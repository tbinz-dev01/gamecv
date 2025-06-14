using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace ChessGame2.Forms
{
    public class clsXMLProcess
    {
        public static DataTable GetTable(string path)
        {
            if (string.IsNullOrEmpty(path) || !File.Exists(path))
            {
                MessageBox.Show("???ng d?n t?p không h?p l? ho?c t?p không t?n t?i!", "L?i", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            DataSet ds = new DataSet();
            try
            {
                ds.ReadXml(path);
                if (ds.Tables.Count == 0)
                {
                    MessageBox.Show("T?p XML không ch?a d? li?u b?ng h?p l?!", "L?i", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"L?i khi ??c t?p XML: {ex.Message}", "L?i", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static void CreateNewOptions(string path, int cellSize = 55, int pieceSize = 50, string boardStyle = "Classic",
            string pieceStyle = "Standard", bool playSound = true)
        {
            if (string.IsNullOrEmpty(path) || Path.GetInvalidPathChars().Any(c => path.Contains(c)))
            {
                MessageBox.Show("???ng d?n t?p không h?p l?!", "L?i", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            XmlDocument doc = new XmlDocument();
            try
            {
                // Khai báo tiêu ?? file XML
                XmlDeclaration xmlDec = doc.CreateXmlDeclaration("1.0", "utf-8", "");
                // Khai báo node g?c
                XmlNode root = doc.CreateElement("config");
                // Khai báo node con
                XmlNode cellSizeNode = doc.CreateElement("CELLSIZE");
                XmlNode pieceSizeNode = doc.CreateElement("PIECESIZE");
                XmlNode boardStyleNode = doc.CreateElement("BOARDSTYLE");
                XmlNode pieceStyleNode = doc.CreateElement("PIECESTYLE");
                XmlNode playSoundNode = doc.CreateElement("PLAYSOUND");

                // Gán giá tr? m?c ??nh
                cellSizeNode.InnerText = cellSize.ToString();
                pieceSizeNode.InnerText = pieceSize.ToString();
                boardStyleNode.InnerText = boardStyle;
                pieceStyleNode.InnerText = pieceStyle;
                playSoundNode.InnerText = playSound.ToString().ToLower();

                // Thêm node con vào node g?c
                root.AppendChild(cellSizeNode);
                root.AppendChild(pieceSizeNode);
                root.AppendChild(boardStyleNode);
                root.AppendChild(pieceStyleNode);
                root.AppendChild(playSoundNode);

                // Thêm declaration và root vào document
                doc.AppendChild(xmlDec);
                doc.AppendChild(root);

                // L?u file
                doc.Save(path);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"Không có quy?n truy c?p ?? t?o t?p: {ex.Message}", "L?i", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"L?i khi t?o t?p c?u hình: {ex.Message}", "L?i", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void CreateNewTrainingDatabase(string path, string name = "DefaultTraining", string fen = "rnbqkbnr/pppp1ppp/5n2/5p2/5P2/5N2/PPPP1PPP/RNBQKB1R w KQkq - 1 2", string moves = "")
        {
            if (string.IsNullOrEmpty(path) || Path.GetInvalidPathChars().Any(c => path.Contains(c)))
            {
                MessageBox.Show("???ng d?n t?p không h?p l?!", "L?i", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            XmlDocument doc = new XmlDocument();
            try
            {
                // Khai báo tiêu ?? file XML
                XmlDeclaration xmlDec = doc.CreateXmlDeclaration("1.0", "utf-8", "");
                // Khai báo node g?c
                XmlNode root = doc.CreateElement("TrainingData");
                // Khai báo node con
                XmlNode nameNode = doc.CreateElement("Name");
                XmlNode fenNode = doc.CreateElement("FEN");
                XmlNode movesNode = doc.CreateElement("Moves");

                // Gán giá tr? m?c ??nh
                nameNode.InnerText = name;
                fenNode.InnerText = fen;
                movesNode.InnerText = moves;

                // Thêm node con vào node g?c
                root.AppendChild(nameNode);
                root.AppendChild(fenNode);
                root.AppendChild(movesNode);

                // Thêm declaration và root vào document
                doc.AppendChild(xmlDec);
                doc.AppendChild(root);

                // L?u file
                doc.Save(path);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"Không có quy?n truy c?p ?? t?o t?p: {ex.Message}", "L?i", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"L?i khi t?o t?p c? s? d? li?u hu?n luy?n: {ex.Message}", "L?i", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void CreateNewProfile(string path, string playerName = "NewPlayer", string avatar = "default.png",
            int totalGames = 0, int totalWin = 0, int totalLose = 0, int totalDraw = 0, int rating = 1000)
        {
            if (string.IsNullOrEmpty(path) || Path.GetInvalidPathChars().Any(c => path.Contains(c)))
            {
                MessageBox.Show("???ng d?n t?p không h?p l?!", "L?i", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            XmlDocument doc = new XmlDocument();
            try
            {
                // Khai báo tiêu ?? file XML
                XmlDeclaration xmlDec = doc.CreateXmlDeclaration("1.0", "utf-8", "");
                // Khai báo node g?c
                XmlNode root = doc.CreateElement("profile");
                // Khai báo node con
                XmlNode playerNameNode = doc.CreateElement("PlayerName");
                XmlNode avatarNode = doc.CreateElement("Avatar");
                XmlNode totalGamesNode = doc.CreateElement("TotalGames");
                XmlNode totalWinNode = doc.CreateElement("TotalWin");
                XmlNode totalLoseNode = doc.CreateElement("TotalLose");
                XmlNode totalDrawNode = doc.CreateElement("TotalDraw");
                XmlNode ratingNode = doc.CreateElement("Rating");

                // Gán giá tr? m?c ??nh
                playerNameNode.InnerText = playerName;
                avatarNode.InnerText = avatar;
                totalGamesNode.InnerText = totalGames.ToString();
                totalWinNode.InnerText = totalWin.ToString();
                totalLoseNode.InnerText = totalLose.ToString();
                totalDrawNode.InnerText = totalDraw.ToString();
                ratingNode.InnerText = rating.ToString();

                // Thêm node con vào node g?c
                root.AppendChild(playerNameNode);
                root.AppendChild(avatarNode);
                root.AppendChild(totalGamesNode);
                root.AppendChild(totalWinNode);
                root.AppendChild(totalLoseNode);
                root.AppendChild(totalDrawNode);
                root.AppendChild(ratingNode);

                // Thêm declaration và root vào document
                doc.AppendChild(xmlDec);
                doc.AppendChild(root);

                // L?u file
                doc.Save(path);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"Không có quy?n truy c?p ?? t?o t?p: {ex.Message}", "L?i", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"L?i khi t?o t?p h? s?: {ex.Message}", "L?i", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}