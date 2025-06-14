using System;
using System.Xml;
using ChessGame2.UserControls;

namespace ChessGame2.Forms
{
    public class clsSavedGame
    {
        private GameMode _GameMode;
        public GameMode GameMode
        {
            get { return _GameMode; }
            set { _GameMode = value; }
        }

        private ChessSide _OwnSide;
        public ChessSide OwnSide
        {
            get { return _OwnSide; }
            set { _OwnSide = value; }
        }

        private string _FEN;
        public string FEN
        {
            get { return _FEN; }
            set { _FEN = value; }
        }

        private string _MoveList;
        public string MoveList
        {
            get { return _MoveList; }
            set { _MoveList = value; }
        }

        private short _Limit;
        public short TimeLimit
        {
            get { return _Limit; }
            set { _Limit = value; }
        }

        private short _Bonus;
        public short TimeBonus
        {
            get { return _Bonus; }
            set { _Bonus = value; }
        }

        private short _mRemain1;
        public short MinutesRemaining1
        {
            get { return _mRemain1; }
            set { _mRemain1 = value; }
        }

        private short _mRemain2;
        public short MinutesRemaining2
        {
            get { return _mRemain2; }
            set { _mRemain2 = value; }
        }

        private short _sRemain1;
        public short SecondsRemaining1
        {
            get { return _sRemain1; }
            set { _sRemain1 = value; }
        }

        private short _sRemain2;
        public short SecondsRemaining2
        {
            get { return _sRemain2; }
            set { _sRemain2 = value; }
        }

        public clsSavedGame()
        {
        }

        public clsSavedGame(GameMode eGameMode, ChessSide eOwnSide, string strFEN, string strMoveList)
        {
            this._GameMode = eGameMode;
            this._OwnSide = eOwnSide;
            this._FEN = strFEN;
            this._MoveList = strMoveList;
        }

        public void SaveToFile(string path)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                XmlDeclaration xmlDec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
                doc.AppendChild(xmlDec);

                XmlNode root = doc.CreateElement("SavedGame");
                doc.AppendChild(root);

                // Thêm các phần tử con
                XmlNode xGameMode = doc.CreateElement("GameMode");
                xGameMode.InnerText = ((int)_GameMode).ToString();
                root.AppendChild(xGameMode);

                XmlNode xOwnSide = doc.CreateElement("OwnSide");
                xOwnSide.InnerText = ((int)_OwnSide).ToString();
                root.AppendChild(xOwnSide);

                XmlNode xFEN = doc.CreateElement("FEN");
                xFEN.InnerText = _FEN;
                root.AppendChild(xFEN);

                XmlNode xMoveList = doc.CreateElement("MoveList");
                xMoveList.InnerText = _MoveList?.Trim() ?? "";
                root.AppendChild(xMoveList);

                XmlNode xTimeLimit = doc.CreateElement("TimeLimit");
                xTimeLimit.InnerText = _Limit.ToString();
                root.AppendChild(xTimeLimit);

                XmlNode xTimeBonus = doc.CreateElement("TimeBonus");
                xTimeBonus.InnerText = _Bonus.ToString();
                root.AppendChild(xTimeBonus);

                XmlNode xMinutesRemaining1 = doc.CreateElement("MinutesRemaining1");
                xMinutesRemaining1.InnerText = _mRemain1.ToString();
                root.AppendChild(xMinutesRemaining1);

                XmlNode xSecondsRemaining1 = doc.CreateElement("SecondsRemaining1");
                xSecondsRemaining1.InnerText = _sRemain1.ToString();
                root.AppendChild(xSecondsRemaining1);

                XmlNode xMinutesRemaining2 = doc.CreateElement("MinutesRemaining2");
                xMinutesRemaining2.InnerText = _mRemain2.ToString();
                root.AppendChild(xMinutesRemaining2);

                XmlNode xSecondsRemaining2 = doc.CreateElement("SecondsRemaining2");
                xSecondsRemaining2.InnerText = _sRemain2.ToString();
                root.AppendChild(xSecondsRemaining2);

                // Lưu tệp XML
                doc.Save(path);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lưu tệp: {ex.Message}");
            }
        }

        public static clsSavedGame LoadFromFile(string path)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(path);

                XmlNode root = doc.SelectSingleNode("SavedGame");
                if (root == null)
                    throw new Exception("Tệp không chứa dữ liệu hợp lệ.");

                clsSavedGame savedGame = new clsSavedGame(
                    (GameMode)Convert.ToInt32(root.SelectSingleNode("GameMode")?.InnerText ?? "0"),
                    (ChessSide)Convert.ToInt32(root.SelectSingleNode("OwnSide")?.InnerText ?? "0"),
                    root.SelectSingleNode("FEN")?.InnerText ?? "",
                    root.SelectSingleNode("MoveList")?.InnerText ?? ""
                )
                {
                    TimeLimit = Convert.ToInt16(root.SelectSingleNode("TimeLimit")?.InnerText ?? "0"),
                    TimeBonus = Convert.ToInt16(root.SelectSingleNode("TimeBonus")?.InnerText ?? "0"),
                    MinutesRemaining1 = Convert.ToInt16(root.SelectSingleNode("MinutesRemaining1")?.InnerText ?? "0"),
                    SecondsRemaining1 = Convert.ToInt16(root.SelectSingleNode("SecondsRemaining1")?.InnerText ?? "0"),
                    MinutesRemaining2 = Convert.ToInt16(root.SelectSingleNode("MinutesRemaining2")?.InnerText ?? "0"),
                    SecondsRemaining2 = Convert.ToInt16(root.SelectSingleNode("SecondsRemaining2")?.InnerText ?? "0")
                };

                return savedGame;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi tải tệp: {ex.Message}");
            }
        }
    }
}