using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace ChessGame2.Forms
{
    public class ClsPC
    {
        private volatile bool _isRunning = true;
        private UdpClient uClient;
        private TcpClient client;
        private TcpListener server;
        private NetworkStream ns;
        private StreamReader sr;
        private StreamWriter sw;
        private IPEndPoint iep;
        private Thread tActiveListenTCP;

        #region Properties
        private string _hostname;
        public string HostName
        {
            get => _hostname;
            set => _hostname = value;
        }

        private IPAddress _ipaddress;
        public IPAddress IpAddress
        {
            get => _ipaddress;
            set => _ipaddress = value;
        }

        private int _port;
        public int Port
        {
            get => _port;
            set => _port = value;
        }

        private int _connectState;
        public int ConnectState
        {
            get => _connectState;
            set => _connectState = value;
        }

        private string _parnerIP;
        public string ParnerIP
        {
            get => _parnerIP;
            set => _parnerIP = value;
        }

        private string _parnerName;
        public string ParnerName
        {
            get => _parnerName;
            set => _parnerName = value;
        }

        private int _function;
        public int Function
        {
            get => _function;
            set => _function = value;
        }

        private string _profile;
        public string Profile
        {
            get => _profile;
            set => _profile = value;
        }
        #endregion

        public ClsPC(int port)
        {
            Port = port;
            HostName = Dns.GetHostName();
            try
            {
                IPHostEntry ipHostEntry = Dns.GetHostEntry(HostName);
                foreach (IPAddress ip in ipHostEntry.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        IpAddress = ip;
                        break;
                    }
                }
            }
            catch (SocketException ex)
            {
                LogError($"Không thể lấy địa chỉ IP: {ex.Message}");
            }
            ConnectState = 0;
            Function = 3;
            ParnerIP = null;
        }

        private void LogError(string message)
        {
            string logPath = Path.Combine(Application.StartupPath, "error.log");
            File.AppendAllText(logPath, $"{DateTime.Now}: {message}\n");
            MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public bool IsValidIpAddress(string ip)
        {
            if (string.IsNullOrEmpty(ip)) return false;
            return Regex.IsMatch(ip, @"^(\d{1,3}\.){3}\d{1,3}$") && ip.Split('.').All(x => int.Parse(x) <= 255);
        }

        public void DisposeUDP()
        {
            ConnectState = 0;
            ParnerIP = null;
            ParnerName = null;
            Function = 3;
            DisconnectUDP();
        }

        #region UDP Methods
        public string ReceiveUDPDataBroadCast(int timeoutMs = 30000)
        {
            try
            {
                uClient = new UdpClient(Port);
                uClient.Client.ReceiveTimeout = timeoutMs;
                IPEndPoint remoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                byte[] data = uClient.Receive(ref remoteIpEndPoint);
                string message = Encoding.UTF8.GetString(data);
                return message;
            }
            catch (SocketException ex) when (ex.SocketErrorCode == SocketError.TimedOut)
            {
                LogError("Hết thời gian chờ nhận dữ liệu UDP Broadcast.");
                return "";
            }
            catch (Exception ex)
            {
                LogError($"Lỗi nhận dữ liệu UDP Broadcast: {ex.Message}");
                return "";
            }
            finally
            {
                DisconnectUDP();
            }
        }

        public string ReceiveUDPData(string ip, int timeoutMs = 30000)
        {
            if (!IsValidIpAddress(ip))
            {
                LogError($"Địa chỉ IP đối tác không hợp lệ: {ip}");
                return "";
            }

            try
            {
                uClient = new UdpClient(Port);
                uClient.Client.ReceiveTimeout = timeoutMs;
                IPEndPoint remoteIpEndPoint = new IPEndPoint(IPAddress.Parse(ip), 0);
                byte[] data = uClient.Receive(ref remoteIpEndPoint);
                string message = Encoding.UTF8.GetString(data);
                return message;
            }
            catch (SocketException ex) when (ex.SocketErrorCode == SocketError.TimedOut)
            {
                LogError($"Hết thời gian chờ nhận dữ liệu UDP từ {ip}.");
                return "";
            }
            catch (Exception ex)
            {
                LogError($"Lỗi nhận dữ liệu UDP từ {ip}: {ex.Message}");
                return "";
            }
            finally
            {
                DisconnectUDP();
            }
        }

        public bool SendUDPData(string ipTo, string type, string item, int retryCount = 3, int timeoutMs = 5000)
        {
            if (!IsValidIpAddress(ipTo))
            {
                LogError($"Địa chỉ IP đích không hợp lệ: {ipTo}");
                return false;
            }

            int attempts = 0;
            bool success = false;
            while (attempts < retryCount && !success)
            {
                try
                {
                    using (UdpClient udp = new UdpClient())
                    {
                        udp.Client.ReceiveTimeout = timeoutMs; // Thêm timeout cho kết nối
                        udp.Connect(ipTo, Port);
                        byte[] data = Encoding.UTF8.GetBytes($"{type}#{IpAddress}#{Profile}#{item}");
                        udp.Send(data, data.Length);
                        success = true;
                    }
                }
                catch (SocketException ex) when (ex.SocketErrorCode == SocketError.HostNotFound)
                {
                    LogError($"Không tìm thấy host {ipTo} (lần thử {attempts + 1}): {ex.Message}");
                    attempts++;
                    Thread.Sleep(500);
                }
                catch (Exception ex)
                {
                    LogError($"Lỗi gửi dữ liệu UDP tới {ipTo} (lần thử {attempts + 1}): {ex.Message}");
                    attempts++;
                    Thread.Sleep(500);
                }
            }

            if (!success)
            {
                LogError($"Không thể gửi dữ liệu UDP tới {ipTo} sau {retryCount} lần thử.");
            }
            return success;
        }

        public void DisconnectUDP()
        {
            try
            {
                uClient?.Close();
                uClient?.Dispose();
            }
            catch (Exception ex)
            {
                LogError($"Lỗi đóng kết nối UDP: {ex.Message}");
            }
            finally
            {
                uClient = null;
            }
        }
        #endregion

        #region TCP Methods
        public void InitialTCP()
        {
            try
            {
                if (Function == 1) // Server
                {
                    if (string.IsNullOrEmpty(ParnerIP) || !IsValidIpAddress(ParnerIP))
                    {
                        throw new InvalidOperationException("Địa chỉ IP đối tác không hợp lệ!");
                    }
                    iep = new IPEndPoint(IPAddress.Any, Port);
                    server = new TcpListener(iep);
                    server.Start();
                    if (!SendUDPData(ParnerIP, "SERVERREADY", ""))
                    {
                        throw new InvalidOperationException("Không thể gửi thông báo SERVERREADY.");
                    }
                }
                else // Client
                {
                    if (string.IsNullOrEmpty(ParnerIP) || !IsValidIpAddress(ParnerIP))
                    {
                        throw new InvalidOperationException("Địa chỉ IP đối tác không hợp lệ!");
                    }
                    iep = new IPEndPoint(IPAddress.Parse(ParnerIP), Port);
                }
                ConnectState = 2;
                client = new TcpClient();
                tActiveListenTCP = new Thread(ActiveListenTCP);
                tActiveListenTCP.IsBackground = true;
                tActiveListenTCP.Start();
            }
            catch (Exception ex)
            {
                LogError($"Lỗi khởi tạo TCP: {ex.Message}");
            }
        }

        private void ActiveListenTCP()
        {
            try
            {
                while (_isRunning)
                {
                    if (client.Connected)
                    {
                        ns = client.GetStream();
                        sr = new StreamReader(ns);
                        sw = new StreamWriter(ns);
                        return;
                    }
                    if (Function == 1)
                    {
                        client = server.AcceptTcpClient();
                    }
                    else
                    {
                        client.Connect(iep);
                        if (!SendUDPData(ParnerIP, "CLIENTREADY", ""))
                        {
                            throw new InvalidOperationException("Không thể gửi thông báo CLIENTREADY.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogError($"Lỗi thiết lập kết nối TCP: {ex.Message}");
            }
        }

        public void SendTCPData(string type, string item)
        {
            try
            {
                if (sw == null || !client.Connected)
                {
                    throw new InvalidOperationException("Kết nối TCP chưa được thiết lập.");
                }
                sw.WriteLine($"{type}#{item}");
                sw.Flush();
            }
            catch (Exception ex)
            {
                LogError($"Lỗi gửi dữ liệu TCP: {ex.Message}");
            }
        }

        public string ReceiveTCPData(int timeoutMs = 30000)
        {
            try
            {
                if (sr == null || !client.Connected)
                {
                    throw new InvalidOperationException("Kết nối TCP chưa được thiết lập.");
                }
                client.ReceiveTimeout = timeoutMs;
                string strdata = sr.ReadLine();
                return strdata ?? "";
            }
            catch (SocketException ex) when (ex.SocketErrorCode == SocketError.TimedOut)
            {
                LogError("Hết thời gian chờ nhận dữ liệu TCP.");
                return "";
            }
            catch (Exception ex)
            {
                LogError($"Lỗi nhận dữ liệu TCP: {ex.Message}");
                return "";
            }
        }

        public void SendFileTCP()
        {
            try
            {
                if (!client.Connected)
                {
                    throw new InvalidOperationException("Kết nối TCP chưa được thiết lập.");
                }
                string filePath = Path.Combine(Application.StartupPath, "Profiles", $"{clsEncoding.Encode(Profile)}.xml");
                if (!File.Exists(filePath))
                {
                    clsXMLProcess.CreateNewProfile(filePath, Profile);
                }
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    int bufferSize = 1024;
                    int noOfPackets = (int)Math.Ceiling((double)fs.Length / bufferSize);
                    int totalLength = (int)fs.Length;
                    for (int i = 0; i < noOfPackets; i++)
                    {
                        int currentPacketLength = totalLength > bufferSize ? bufferSize : totalLength;
                        byte[] sendingBuffer = new byte[currentPacketLength];
                        fs.Read(sendingBuffer, 0, currentPacketLength);
                        ns.Write(sendingBuffer, 0, sendingBuffer.Length);
                        totalLength -= currentPacketLength;
                    }
                }
            }
            catch (Exception ex)
            {
                LogError($"Lỗi gửi file qua TCP: {ex.Message}");
            }
        }

        public void ReceiveFileTCP()
        {
            try
            {
                if (!client.Connected)
                {
                    throw new InvalidOperationException("Kết nối TCP chưa được thiết lập.");
                }
                string filePath = Path.Combine(Application.StartupPath, "Profiles", $"{clsEncoding.Encode(ParnerName)}.xml");
                using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    byte[] recData = new byte[1024];
                    int recBytes;
                    while ((recBytes = ns.Read(recData, 0, recData.Length)) > 0)
                    {
                        fs.Write(recData, 0, recBytes);
                    }
                }
                XmlDocument doc = new XmlDocument();
                doc.Load(filePath);
                SendTCPData("SENDED", "");
            }
            catch (Exception ex)
            {
                LogError($"Lỗi nhận file qua TCP: {ex.Message}");
            }
        }

        public void DisposeTCPConnection()
        {
            try
            {
                _isRunning = false;
                if (ConnectState == 2)
                {
                    tActiveListenTCP?.Join();
                    if (Function == 1)
                    {
                        server?.Stop();
                    }
                    client?.Close();
                    iep = null;
                    ns?.Close();
                    sw?.Close();
                    sr?.Close();
                    ns = null;
                    sw = null;
                    sr = null;
                }
            }
            catch (Exception ex)
            {
                LogError($"Lỗi đóng kết nối TCP: {ex.Message}");
            }
        }
        #endregion

        #region Analysis Methods
        public void AnalysisReceiveUDPString(string message, out string strT, out string strPI, out string strPN, out string strI)
        {
            strT = strPI = strPN = strI = "";
            try
            {
                if (string.IsNullOrEmpty(message))
                    return;
                string[] parts = message.Split('#');
                if (parts.Length >= 4)
                {
                    strT = parts[0];
                    strPI = parts[1];
                    strPN = parts[2];
                    strI = parts[3];
                }
            }
            catch (Exception ex)
            {
                LogError($"Lỗi phân tích chuỗi UDP: {ex.Message}");
            }
        }

        public void AnalysisReceiveTCPString(string message, out string strT, out string strI)
        {
            strT = strI = "";
            try
            {
                if (string.IsNullOrEmpty(message))
                    return;
                int iType = message.IndexOf('#');
                if (iType < 0)
                    return;
                strT = message.Substring(0, iType);
                strI = message.Substring(iType + 1);
            }
            catch (Exception ex)
            {
                LogError($"Lỗi phân tích chuỗi TCP: {ex.Message}");
            }
        }
        #endregion
    }
}