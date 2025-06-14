using System;
using System.Drawing;
using System.Windows.Forms;
using ChessGame2.UserControls;
using DevExpress.XtraEditors;
using System.Threading;
using System.IO;

namespace ChessGame2.Forms
{
    public partial class frmLanGame : XtraForm
    {
        private UcChessBoard Board;
        private int intNotationSize;
        private Label[] lblNotation = new Label[36];
        private volatile bool ActiveListenerUDP = false;
        private volatile bool ActiveListenerTCP = false;
        private volatile bool ActiveListenerBroadcast = false;
        private volatile bool _isRunning = true;
        private Thread tRec;

        public static int iSide = 0;
        public static int iTotalTimer = 0;
        public static int iMoveTimer = 0;
        public static int iExtraTimer = 0;
        public static int iUndo = 0;

        private bool bMyReady = false;
        private bool bParReady = false;
        private UcMovesHistory UcMovesHistory1;

        public frmLanGame()
        {
            InitializeComponent();
        }

        private void frmLanGame_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            frmGame.localpc.DisconnectUDP();

            string profilePath = Path.Combine(Application.StartupPath, "Profiles", $"{clsEncoding.Encode(frmGame.localpc.Profile)}.xml");
            if (!File.Exists(profilePath))
            {
                clsXMLProcess.CreateNewProfile(profilePath, frmGame.localpc.Profile);
            }

            if (frmGame.localpc.Function == 1)
            {
                frmGameOptions frm = new frmGameOptions();
                frm.ShowDialog();
                lblstatus.Text = "Đang tìm kiếm đối thủ...";
                ActiveListenerBroadcast = true;
                tRec = new Thread(ListenForRequestBroadcast);
                tRec.IsBackground = true;
                tRec.Start();
            }
            else
            {
                btnSanSang.Enabled = true;
                lblstatus.Text = "Đang tiến hành kết nối máy chủ...";
                ActiveListenerUDP = true;
                tRec = new Thread(ListenForRequestUDP);
                tRec.IsBackground = true;
                tRec.Start();
            }
            ucMyProfile.LoadProfile(frmGame.localpc.Profile);
        }

        private void CreateChessBoard(ChessSide eOwnSide, GameMode eGameMode, string strFEN)
        {
            try
            {
                if (Board != null)
                {
                    Board.Dispose();
                    UcMovesHistory1?.Dispose();
                }

                panel1.Visible = true;
                panel1.Controls.Clear();
                clsOptions obj = new clsOptions();
                UcMovesHistory1 = new UcMovesHistory();
                obj.CellSize = 55;
                Board = new UcChessBoard(obj.BoardStyle, obj.PieceStyle, eOwnSide, eGameMode, obj.CellSize, obj.CellSize, obj.PlaySound, strFEN);
                Board.MoveMaked += Board_MoveMaked;
                Bitmap bmpBackImage = new Bitmap(Board.Width, Board.Height);
                Board.DrawToBitmap(bmpBackImage, Board.Bounds);
                Board.BackgroundImage = bmpBackImage;
                Board.BoardBitMap = bmpBackImage;
                pnlHistory.Visible = true;

                intNotationSize = (int)((obj.CellSize * 38) / 100);
                if (InvokeRequired)
                {
                    Invoke(new dlgAddItemN(AddNotation), obj.CellSize, eOwnSide);
                }
                else
                {
                    AddNotation(obj.CellSize, eOwnSide);
                }
                pnlHistory.Controls.Add(UcMovesHistory1);
                UcMovesHistory1.LoadMovesHistory(Board.stkWhiteMoves, Board.stkBlackMoves);

                Board.Location = new Point(intNotationSize, intNotationSize);
                panel1.Controls.Add(Board);
                panel1.ClientSize = new Size(obj.CellSize * 8 + intNotationSize * 2, obj.CellSize * 8 + intNotationSize * 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tạo bàn cờ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private delegate void dlgAddItemN(int intCellSize, ChessSide eOwnSide);

        private void AddNotation(int intCellSize, ChessSide eOwnSide)
        {
            try
            {
                for (int i = 0; i < 36; i++)
                {
                    lblNotation[i] = new Label
                    {
                        Height = intCellSize,
                        Width = intCellSize,
                        Image = clsImageProcess.GetChessBoardBitMap(ChessSide.Black, ChessBoardStyle.BoardEdge),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = new Font(FontFamily.GenericSansSerif, 13.0f),
                        ImageAlign = ContentAlignment.MiddleCenter,
                        ForeColor = Color.White
                    };
                }

                lblNotation[0].Height = intNotationSize;
                lblNotation[0].Width = intNotationSize;
                lblNotation[0].Location = new Point();
                lblNotation[0].BackColor = Color.Blue;
                panel1.Controls.Add(lblNotation[0]);

                for (int i = 1; i <= 8; i++)
                {
                    lblNotation[i].Height = intNotationSize;
                    lblNotation[i].Text = eOwnSide == ChessSide.White ? Convert.ToChar(64 + i).ToString() : Convert.ToChar(73 - i).ToString();
                    lblNotation[i].Location = new Point(intCellSize * (i - 1) + intNotationSize, 0);
                    panel1.Controls.Add(lblNotation[i]);
                }

                lblNotation[9].Height = intNotationSize;
                lblNotation[9].Width = intNotationSize;
                lblNotation[9].BackColor = Color.Blue;
                lblNotation[9].Location = new Point(0, intNotationSize + intCellSize * 8);
                panel1.Controls.Add(lblNotation[9]);

                for (int i = 1; i <= 8; i++)
                {
                    lblNotation[9 + i].Height = intNotationSize;
                    lblNotation[9 + i].Text = eOwnSide == ChessSide.White ? Convert.ToChar(64 + i).ToString() : Convert.ToChar(73 - i).ToString();
                    lblNotation[9 + i].Location = new Point(intCellSize * (i - 1) + intNotationSize, intNotationSize + intCellSize * 8);
                    panel1.Controls.Add(lblNotation[9 + i]);
                }

                lblNotation[18].Height = intNotationSize;
                lblNotation[18].Width = intNotationSize;
                lblNotation[18].BackColor = Color.Blue;
                lblNotation[18].Location = new Point(intNotationSize + intCellSize * 8, 0);
                panel1.Controls.Add(lblNotation[18]);

                for (int i = 1; i <= 8; i++)
                {
                    lblNotation[18 + i].Width = intNotationSize;
                    lblNotation[18 + i].Text = eOwnSide == ChessSide.White ? Convert.ToString(9 - i) : Convert.ToString(i);
                    lblNotation[18 + i].Location = new Point(0, intCellSize * (i - 1) + intNotationSize);
                    panel1.Controls.Add(lblNotation[18 + i]);
                }

                lblNotation[27].Height = intNotationSize;
                lblNotation[27].Width = intNotationSize;
                lblNotation[27].BackColor = Color.Blue;
                lblNotation[27].Location = new Point(intNotationSize + intCellSize * 8, intNotationSize + intCellSize * 8);
                panel1.Controls.Add(lblNotation[27]);

                for (int i = 1; i <= 8; i++)
                {
                    lblNotation[27 + i].Width = intNotationSize;
                    lblNotation[27 + i].Text = eOwnSide == ChessSide.White ? Convert.ToString(9 - i) : Convert.ToString(i);
                    lblNotation[27 + i].Location = new Point(intNotationSize + intCellSize * 8, intCellSize * (i - 1) + intNotationSize);
                    panel1.Controls.Add(lblNotation[27 + i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi thêm ký hiệu bàn cờ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Board_MoveMaked(object sender, EventArgs e)
        {
            try
            {
                if ((Board.WhiteToMove && Board.OwnSide == ChessSide.Black) || (!Board.WhiteToMove && Board.OwnSide == ChessSide.White))
                {
                    string move = Board.LastMove.ToString();
                    frmGame.localpc.SendTCPData("MOVE", move);
                    string response = frmGame.localpc.ReceiveTCPData(5000);
                    if (response != "ACK")
                    {
                        MessageBox.Show("Nước đi không được đồng bộ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                UcMovesHistory1.LoadMovesHistory(Board.stkWhiteMoves, Board.stkBlackMoves);
                UcMovesHistory1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi gửi nước đi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool useManualConnection = false;

        private void btnConnectManually_Click(object sender, EventArgs e)
        {
            string serverIp = txtServerIp.Text.Trim();
            if (string.IsNullOrEmpty(serverIp))
            {
                LogError("Vui lòng nhập địa chỉ IP máy chủ!");
                return;
            }

            if (!frmGame.localpc.IsValidIpAddress(serverIp))
            {
                LogError("Địa chỉ IP không hợp lệ!");
                return;
            }

            frmGame.localpc.ParnerIP = serverIp;
            if (!frmGame.localpc.SendUDPData(serverIp, "JOIN", "0:0:0:1000"))
            {
                LogError("Không thể gửi yêu cầu JOIN đến máy chủ!");
                return;
            }

            lblstatus.Text = "Đang kết nối với máy chủ " + serverIp + "...";
            useManualConnection = true; // Đánh dấu sử dụng kết nối thủ công
            ActiveListenerBroadcast = false;
            ActiveListenerUDP = true;
            tRec = new Thread(ListenForRequestUDP);
            tRec.IsBackground = true;
            tRec.Start();
        }

        private void ListenForRequestBroadcast()
        {
            while (_isRunning && ActiveListenerBroadcast && !useManualConnection)
            {
                string message = frmGame.localpc.ReceiveUDPDataBroadCast(5000);
                if (!string.IsNullOrEmpty(message))
                {
                    string strType, strParnerIp, strParnerName, strItem;
                    frmGame.localpc.AnalysisReceiveUDPString(message, out strType, out strParnerIp, out strParnerName, out strItem);

                    if (strParnerIp != frmGame.localpc.IpAddress.ToString())
                    {
                        switch (strType.ToUpper())
                        {
                            case "FINDHOST":
                                if (frmGame.localpc.ConnectState == 0)
                                {
                                    frmGame.localpc.SendUDPData(strParnerIp, "HOST", "");
                                }
                                break;

                            case "JOIN":
                                if (frmGame.localpc.IsValidIpAddress(strParnerIp))
                                {
                                    string[] arrProfileInfo = strItem.Split(':');
                                    if (arrProfileInfo.Length != 4)
                                    {
                                        LogError($"Dữ liệu hồ sơ của đối thủ không hợp lệ: {strItem}");
                                        break;
                                    }

                                    string totalwin = arrProfileInfo[0];
                                    string totoldraw = arrProfileInfo[1];
                                    string totallose = arrProfileInfo[2];
                                    string rating = arrProfileInfo[3];
                                    ucOppProfile.LoadProfile(strParnerName, totalwin, totoldraw, totallose, rating);

                                    frmGame.localpc.ConnectState = 1;
                                    frmGame.localpc.ParnerIP = strParnerIp;
                                    frmGame.localpc.ParnerName = strParnerName;
                                    frmGame.localpc.Function = 1;

                                    try
                                    {
                                        clsProfile profile = new clsProfile(frmGame.localpc.Profile);
                                        totalwin = profile.TotalWin.ToString();
                                        totoldraw = profile.TotalDraw.ToString();
                                        totallose = profile.TotalLose.ToString();
                                        rating = profile.Rating.ToString();

                                        if (!frmGame.localpc.SendUDPData(frmGame.localpc.ParnerIP, "PROFILE",
                                            $"{totalwin}:{totoldraw}:{totallose}:{rating}"))
                                        {
                                            LogError("Không thể gửi thông tin hồ sơ cho đối thủ!");
                                            break;
                                        }

                                        lblstatus.Text = "Đang tiến hành kết nối với " + strParnerName;
                                        btnkichout.Enabled = true;
                                        btnSanSang.Enabled = true;

                                        ActiveListenerBroadcast = false;
                                        ActiveListenerUDP = true;
                                        tRec = new Thread(ListenForRequestUDP);
                                        tRec.IsBackground = true;
                                        tRec.Start();
                                    }
                                    catch (Exception ex)
                                    {
                                        LogError($"Lỗi khi xử lý yêu cầu JOIN: {ex.Message}");
                                        break;
                                    }
                                }
                                else
                                {
                                    LogError($"Địa chỉ IP đối tác không hợp lệ: {strParnerIp}");
                                }
                                break;

                            case "CHAT":
                                lstChatBox.Items.Add(strParnerName + " :" + strItem);
                                lstChatBox.TopIndex = lstChatBox.Items.Count - 1;
                                break;
                        }
                    }
                }
                Thread.Sleep(100); // Giảm tải CPU
            }
        }
        private void LogError(string message)
        {
            string logPath = Path.Combine(Application.StartupPath, "error.log");
            File.AppendAllText(logPath, $"{DateTime.Now}: {message}\n");
            MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ListenForRequestUDP()
        {
            while (_isRunning && ActiveListenerUDP)
            {
                if (string.IsNullOrEmpty(frmGame.localpc.ParnerIP))
                {        
                    Thread.Sleep(1000); // Chờ 1 giây trước khi kiểm tra lại
                    continue; // Bỏ qua vòng lặp nếu ParnerIP chưa sẵn sàng
                }

                string message = frmGame.localpc.ReceiveUDPData(frmGame.localpc.ParnerIP);
                if (!string.IsNullOrEmpty(message))
                {
                    string strType, strParnerIp, strParnerName, strItem;
                    frmGame.localpc.AnalysisReceiveUDPString(message, out strType, out strParnerIp, out strParnerName, out strItem);
                    if (strParnerIp != frmGame.localpc.IpAddress.ToString())
                    {
                        switch (strType.ToUpper())
                        {
                            case "PROFILE":
                                string[] arrProfileInfo = strItem.Split(':');
                                string totalwin = arrProfileInfo[0];
                                string totoldraw = arrProfileInfo[1];
                                string totallose = arrProfileInfo[2];
                                string rating = arrProfileInfo[3];
                                ucOppProfile.LoadProfile(strParnerName, totalwin, totoldraw, totallose, rating);
                                break;
                            case "CHAT":
                                lstChatBox.Items.Add(strParnerName + " :" + strItem);
                                lstChatBox.TopIndex = lstChatBox.Items.Count - 1;
                                break;
                            case "KICKOUT":
                                MessageBox.Show(strParnerName + " đã từ chối chơi với bạn.");
                                this.Close();
                                break;
                            case "READY":
                                lblstatus.Text = strParnerName + " đã sẵn sàng chơi.";
                                bParReady = true;
                                if (bMyReady && frmGame.localpc.Function == 1)
                                {
                                    frmGame.localpc.InitialTCP();
                                }
                                break;
                            case "SERVERREADY":
                                ActiveListenerUDP = false;
                                ActiveListenerTCP = true;
                                frmGame.localpc.InitialTCP();
                                Thread.Sleep(5000);
                                tRec = new Thread(ListenForRequestTCP);
                                tRec.IsBackground = true;
                                tRec.Start();
                                break;
                            case "CLIENTREADY":
                                ActiveListenerUDP = false;
                                ActiveListenerTCP = true;
                                tRec = new Thread(ListenForRequestTCP);
                                tRec.IsBackground = true;
                                tRec.Start();
                                Thread.Sleep(2000);
                                frmGame.localpc.SendTCPData("OPTION", iSide + ":" + iTotalTimer + ":" + iMoveTimer + ":" + iExtraTimer + ":" + iUndo);
                                break;
                            case "OUT":
                                MessageBox.Show("Máy bạn mất kết nối với " + strParnerName, "Mất kết nối");
                                btnkichout.Enabled = false;
                                frmGame.localpc.DisposeUDP();
                                ActiveListenerUDP = false;
                                ActiveListenerBroadcast = true;
                                tRec = new Thread(ListenForRequestBroadcast);
                                tRec.IsBackground = true;
                                tRec.Start();
                                break;
                        }
                    }
                }
                Thread.Sleep(100); // Giảm tải CPU bằng cách thêm delay nhỏ
            }
        }

        private void ListenForRequestTCP()
        {
            while (_isRunning && ActiveListenerTCP)
            {
                try
                {
                    string message = frmGame.localpc.ReceiveTCPData();
                    if (!string.IsNullOrEmpty(message))
                    {
                        string strType, strItem;
                        frmGame.localpc.AnalysisReceiveTCPString(message, out strType, out strItem);
                        switch (strType.ToUpper())
                        {
                            case "ASKFILE":
                                frmGame.localpc.SendTCPData("FILE", "");
                                Thread tsend = new Thread(frmGame.localpc.SendFileTCP);
                                tsend.IsBackground = true;
                                tsend.Start();
                                break;
                            case "FILE":
                                ActiveListenerTCP = false;
                                Thread treceive = new Thread(frmGame.localpc.ReceiveFileTCP);
                                treceive.IsBackground = true;
                                treceive.Start();
                                ActiveListenerTCP = true;
                                break;
                            case "SENDED":
                                if (frmGame.localpc.Function == 1)
                                {
                                    ucOppProfile.LoadProfile(frmGame.localpc.ParnerName);
                                    frmGame.localpc.SendTCPData("OPTION", iSide + ":" + iTotalTimer + ":" + iMoveTimer + ":" + iExtraTimer + ":" + iUndo);
                                }
                                else
                                {
                                    frmGame.localpc.SendTCPData("ASKFILE", "");
                                }
                                break;
                            case "OPTION":
                                string[] arrOption = strItem.Split(':');
                                iSide = int.Parse(arrOption[0]);
                                iSide = iSide == 0 ? 1 : 0;
                                iTotalTimer = int.Parse(arrOption[1]);
                                iMoveTimer = int.Parse(arrOption[2]);
                                iExtraTimer = int.Parse(arrOption[3]);
                                iUndo = int.Parse(arrOption[4]);
                                frmGameOptions frm = new frmGameOptions();
                                frm.ShowDialog();
                                if (!frmGameOptions.bEditOption)
                                {
                                    btnPlay.Enabled = true;
                                }
                                break;
                            case "ENDOPTION":
                                lblstatus.Text = "Cấu hình đã xong, Xin nhấn Bắt đầu để chơi.";
                                btnPlay.Enabled = true;
                                break;
                            case "MOVE":
                                Board.MakeMove(strItem);
                                frmGame.localpc.SendTCPData("ACK", "");
                                UcMovesHistory1.LoadMovesHistory(Board.stkWhiteMoves, Board.stkBlackMoves);
                                UcMovesHistory1.Refresh();
                                break;
                            case "ACK":
                                break;
                            case "CHAT":
                                lstChatBox.Items.Add(frmGame.localpc.ParnerName + ": " + strItem);
                                lstChatBox.TopIndex = lstChatBox.Items.Count - 1;
                                break;
                            case "LOSE":
                                MessageBox.Show("Chúc mừng bạn đã thắng " + frmGame.localpc.ParnerName);
                                panel1.Enabled = false;
                                break;
                            case "DRAW":
                                DialogResult drdraw = MessageBox.Show(frmGame.localpc.ParnerName + " xin Hòa. Bạn đồng ý không ?", "XIN HÒA", MessageBoxButtons.OKCancel);
                                if (drdraw == DialogResult.OK)
                                {
                                    frmGame.localpc.SendTCPData("DRAWOK", "");
                                    MessageBox.Show("Bạn đã Hòa với " + frmGame.localpc.ParnerName + ". Cố gắng thêm nhé.");
                                    panel1.Enabled = false;
                                }
                                else
                                {
                                    frmGame.localpc.SendTCPData("DRAWCANCEL", "");
                                }
                                break;
                            case "DRAWOK":
                                MessageBox.Show("Bạn đã Hòa với " + frmGame.localpc.ParnerName + ". Cố gắng thêm nhé.");
                                panel1.Enabled = false;
                                break;
                            case "DRAWCANCEL":
                                MessageBox.Show(frmGame.localpc.ParnerName + " không đồng ý HÒA.");
                                break;
                            case "UNDO":
                                DialogResult dr = MessageBox.Show(frmGame.localpc.ParnerName + " xin Đi Lại. Bạn đồng ý không ?", "XIN ĐI LẠI", MessageBoxButtons.OKCancel);
                                if (dr == DialogResult.OK)
                                {
                                    frmGame.localpc.SendTCPData("UNDOOK", "");
                                    Board.UnDoMove();
                                    UcMovesHistory1.LoadMovesHistory(Board.stkWhiteMoves, Board.stkBlackMoves);
                                    UcMovesHistory1.Refresh();
                                }
                                else
                                {
                                    frmGame.localpc.SendTCPData("UNDOCANCEL", "");
                                }
                                break;
                            case "UNDOOK":
                                Board.UnDoMove();
                                UcMovesHistory1.LoadMovesHistory(Board.stkWhiteMoves, Board.stkBlackMoves);
                                UcMovesHistory1.Refresh();
                                break;
                            case "UNDOCANCEL":
                                MessageBox.Show(frmGame.localpc.ParnerName + " không đồng ý cho bạn đi lại.");
                                break;
                            case "NEWGAME":
                                DialogResult drnewgame = MessageBox.Show(frmGame.localpc.ParnerName + " mời bạn chơi lại. Bạn đồng ý không ?", "CHƠI LẠI", MessageBoxButtons.OKCancel);
                                if (drnewgame == DialogResult.OK)
                                {
                                    frmGame.localpc.SendTCPData("NEWGAMEOK", "");
                                }
                                else
                                {
                                    frmGame.localpc.SendTCPData("NEWGAMECANCEL", "");
                                }
                                break;
                            case "NEWGAMEOK":
                                frmGameOptions frmgameoption = new frmGameOptions();
                                frmgameoption.ShowDialog();
                                if (!frmGameOptions.bEditOption)
                                {
                                    btnPlay.Enabled = true;
                                    panel1.Enabled = true;
                                }
                                break;
                            case "NEWGAMECANCEL":
                                MessageBox.Show(frmGame.localpc.ParnerName + " đã từ chối Chơi Lại với bạn.", "Chơi Lại");
                                break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    string errorMsg = frmGame.localpc.ParnerName != null
                        ? $"Máy bạn đã mất kết nối với {frmGame.localpc.ParnerName}"
                        : "Máy bạn đã mất kết nối với máy chủ";
                    MessageBox.Show(errorMsg, "Mất kết nối");
                    ActiveListenerTCP = false;
                    this.Close();
                }
            }
        }

        private void frmLanGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            _isRunning = false;
            if (frmGame.localpc.ConnectState == 1)
            {
                frmGame.localpc.SendUDPData(frmGame.localpc.ParnerIP, "OUT", "");
            }
            tRec?.Join();
            frmGame.localpc.DisconnectUDP();
            frmGame.localpc.DisposeTCPConnection();
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtchat.Text)) return;
            lstChatBox.Items.Add(frmGame.localpc.Profile + ": " + txtchat.Text);
            lstChatBox.TopIndex = lstChatBox.Items.Count - 1;
            switch (frmGame.localpc.ConnectState)
            {
                case 2:
                    frmGame.localpc.SendTCPData("CHAT", txtchat.Text);
                    break;
                case 1:
                    frmGame.localpc.SendUDPData(frmGame.localpc.ParnerIP, "CHAT", txtchat.Text);
                    break;
                default:
                    frmGame.localpc.SendUDPData("255.255.255.255", "CHAT", txtchat.Text);
                    break;
            }
            txtchat.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmGame.localpc.SendUDPData(frmGame.localpc.ParnerIP, "KICKOUT", "");
            btnkichout.Enabled = false;
            frmGame.localpc.DisposeUDP();
            ActiveListenerUDP = false;
            ActiveListenerBroadcast = true;
            tRec = new Thread(ListenForRequestBroadcast);
            tRec.IsBackground = true;
            tRec.Start();
        }

        private void btnSanSang_Click(object sender, EventArgs e)
        {
            btnSanSang.Enabled = false;
            bMyReady = true;
            frmGame.localpc.SendUDPData(frmGame.localpc.ParnerIP, "READY", "");
            if (bParReady && frmGame.localpc.Function == 1)
            {
                frmGame.localpc.InitialTCP();
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (iSide == -1 || iTotalTimer == 0 || iMoveTimer == 0 || iExtraTimer == 0 || iUndo == -1)
            {
                MessageBox.Show("Vui lòng cấu hình tùy chọn trước!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frmGameOptions frm = new frmGameOptions();
                frm.ShowDialog();
                if (frmGameOptions.bEditOption) return;
            }
            if (iSide == 0)
            {
                CreateChessBoard(ChessSide.White, GameMode.VsNetWorkPlayer, clsFEN.DefaultFENstring);
            }
            else
            {
                CreateChessBoard(ChessSide.Black, GameMode.VsNetWorkPlayer, clsFEN.DefaultFENstring);
            }
            btnPlay.Enabled = false;
            btnChat.Enabled = true;
            grbPlay.Enabled = true;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (ActiveListenerTCP)
            {
                frmGame.localpc.SendTCPData("UNDO", "");
            }
            else
            {
                MessageBox.Show("Chưa kết nối TCP!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            if (ActiveListenerTCP)
            {
                frmGame.localpc.SendTCPData("DRAW", "");
            }
            else
            {
                MessageBox.Show("Chưa kết nối TCP!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLose_Click(object sender, EventArgs e)
        {
            if (ActiveListenerTCP)
            {
                frmGame.localpc.SendTCPData("LOSE", "");
                MessageBox.Show("Bạn đã Thua " + frmGame.localpc.ParnerName + ". Cố gắng thêm nhé.");
                panel1.Enabled = false;
            }
            else
            {
                MessageBox.Show("Chưa kết nối TCP!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (ActiveListenerTCP)
            {
                frmGame.localpc.SendTCPData("NEWGAME", "");
            }
            else
            {
                MessageBox.Show("Chưa kết nối TCP!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSitting_Click(object sender, EventArgs e)
        {
            frmGameOptions frm = new frmGameOptions();
            frm.ShowDialog();
        }

       

      
        
    }
}