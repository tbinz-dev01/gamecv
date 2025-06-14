using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.IO;
namespace ChessGame2.UserControls
{
    public static class clsChessEngine
    {
       

        #region "Game Logic"
        public static ArrayList FindAllPossibleMove(int[,] arrState, Point CurPos, ChessPieceType eType)
        {
            ArrayList arrMove = new ArrayList();

            if (eType == ChessPieceType.Pawn)
            {
                arrMove = clsPawn.FindAllPossibleMove(arrState, CurPos);
            }
            if (eType == ChessPieceType.Knight)
            {
                arrMove = clsKnight.FindAllPossibleMove(arrState, CurPos);
            }

            if (eType == ChessPieceType.Bishop)
            {
                arrMove = clsBishop.FindAllPossibleMove(arrState, CurPos);
            }

            if (eType == ChessPieceType.Rook)
            {
                arrMove = clsRook.FindAllPossibleMove(arrState, CurPos);
            }

            if (eType == ChessPieceType.Queen)
            {
                arrMove = clsQueen.FindAllPossibleMove(arrState, CurPos);
            }

            if (eType == ChessPieceType.King)
            {
                arrMove = clsKing.FindAllPossibleMove(arrState, CurPos);
                ChessSide eSide = (ChessSide)(arrState[CurPos.X, CurPos.Y] % 10);
                clsKing.AddCastlingPoint(arrState, eSide, arrMove);

            }
            return arrMove;
        }

        /// <summary>
        /// Trả về độ di động của Side cần kiểm tra
        /// </summary>
        static int Mobility(ChessSide eSide, int[,] BoardState)
        {

            int intSide = 0;
            if (eSide == ChessSide.White)
            {
                intSide = 2;
            }
            else
            {
                intSide = 1;
            }
            int intMobility = 0;
            for (int y = 1; y <= 8; y++)
                for (int x = 1; x <= 8; x++)
                    if (BoardState[x, y] > 0)
                    {
                        int side = BoardState[x, y] % 10;
                        if (side == intSide)
                        {
                            int intType = BoardState[x, y] / 10;
                            intMobility += FindAllLegalMove(BoardState, new Point(x, y), (ChessPieceType)intType).Count;
                        }
                    }
            return intMobility;
        }

       

        public static ArrayList FindAllLegalMove(int[,] arrState, Point CurPos, ChessPieceType eType)
        {
            ArrayList arrPossibleMove = FindAllPossibleMove(arrState, CurPos, eType);

            if (arrPossibleMove.Count == 0)
                return arrPossibleMove;

            ArrayList arrLegalMove = new ArrayList();

            //Những nước đi làm cho quân Vua phe mình bị chiếu được xem là không hợp lệ
            int[,] arrNewState = new int[10, 10];
            Array.Copy(arrState, arrNewState, arrState.Length);
            ChessSide eSide = (ChessSide)(arrState[CurPos.X, CurPos.Y] % 10);
            foreach (Point p in arrPossibleMove)
            {
                int tmp = arrNewState[p.X, p.Y];//Quân cờ tại vị trí mới
                arrNewState[p.X, p.Y] = (int)eType * 10 + (int)eSide;//Thay quân cờ tại vị trí mới
                arrNewState[CurPos.X, CurPos.Y] = 0;//Xóa quân cờ tại vị trí cũ

                if (clsKing.IsChecked(arrNewState, eSide) == false)
                {
                    arrLegalMove.Add(p);
                }
                arrNewState[CurPos.X, CurPos.Y] = arrNewState[p.X, p.Y];//Cho quân cờ quay lại vị trí cũ
                arrNewState[p.X, p.Y] = tmp;//Trả lại quân cờ nằm ở vị trí mới                
            }
            return arrLegalMove;
        }

        public static bool CanMove(ArrayList arrLegalMove, Point NewPos)
        {

            foreach (Point p in arrLegalMove)//Kiểm tra vị trí cần đến có trong danh sách có thể đi hay không
            {
                if (p == NewPos)
                {
                    return true;
                }
            }
            return false;
        }
        /*
         *Hàm kiểm tra 1 phe có còn Nước Đi Hợp Lệ hay không
         * 1. Duyệt tất cả các quân cờ.
	     * 2. Với mỗi quân cờ tìm tất cả các bước đi hợp lệ
         * 3. Nếu tồn tại ít nhất 1 nước đi hợp lệ thì trả vè true còn lại trả về false
         */
        public static bool LegalMoveAvaiable(int[,] arrState, ChessSide eSide)
        {
            int intSide = (int)eSide;
            for (int y = 1; y <= 8; y++)
                for (int x = 1; x <= 8; x++)
                {
                    if (arrState[x, y] > 0 && arrState[x, y] % 10 == intSide)
                    {
                        ChessPieceType eType = (ChessPieceType)(arrState[x, y] / 10);
                        if (FindAllLegalMove(arrState, new Point(x, y), eType).Count > 0)
                            return true;
                    }
                }
            return false;
        }
        //Kiểm tra Chiếu Bí, Hòa Cờ(chưa xét trường hợp bất biến 3 lần) 
        //1. Kiểm tra quân đối phương có còn nước đi hợp lệ hay không nếu không ->2.
        //2. Kiểm tra quân vua đối phương có bị chiếu hay không nếu có-> THUA, nếu không ->HÒA


        public static GameStatus GetGameStatus(int[,] arrState, ArrayList arrFEN, ChessSide eSide)//eSide: phe của quân vừa di chuyển
        {
            ChessSide eOppSide;//Phe đối phương

            if (eSide == ChessSide.White)
                eOppSide = ChessSide.Black;
            else
                eOppSide = ChessSide.White;

            if (CheckThreefoldRepetition(arrFEN))
                return GameStatus.Draw;

            if (CheckInsufficientMaterial(arrState, eSide) == true)
                return GameStatus.Draw;

            if (LegalMoveAvaiable(arrState, eOppSide) == true)//Phe đối phương còn nước đi hợp lệ
            {
                return GameStatus.NowPlaying;
            }
            else
            {
                if (clsKing.IsChecked(arrState, eOppSide) == false)//Quân vua dối phương không bị chiếu
                {
                    return GameStatus.Draw;
                }
                else
                {
                    if (eSide == ChessSide.Black)
                        return GameStatus.BlackWin;
                    else
                        return GameStatus.WhiteWin;
                }
            }
        }
        //Kiểm tra truòng hợp hòa cờ do cả 2 bên không đủ quân để chiếu bí đối phương

        public static bool CheckInsufficientMaterial(int[,] BoardState, ChessSide eSide)
        {
            bool insufficientMaterial = true;
            int intSide = 0;
            if (eSide == ChessSide.White)
            {
                intSide = 2;
            }
            else
            {
                intSide = 1;
            }

            int MyKnightCount = 0;
            int OppKnightCount = 0;

            bool MyBlackBishopAvailable = false;
            bool MyWhiteBishopAvailable = false;
            bool OppBlackBishopAvailable = false;
            bool OppWhiteBishopAvailable = false;

            for (int y = 1; y <= 8; y++)
                for (int x = 1; x <= 8; x++)
                    if (BoardState[x, y] > 0)
                    {
                        int side = BoardState[x, y] % 10;

                        if (side == intSide)
                        {
                            int intType = BoardState[x, y] / 10;

                            switch (intType)
                            {
                                case 1: insufficientMaterial = false; break;
                                case 2: if ((x + y) % 2 == 1) MyWhiteBishopAvailable = true; else MyBlackBishopAvailable = true; break;
                                case 3: MyKnightCount++; break;
                                case 4: insufficientMaterial = false; break;
                                case 5: insufficientMaterial = false; break;
                            }
                        }
                        else
                        {
                            int intType = BoardState[x, y] / 10;
                            switch (intType)
                            {
                                case 1: insufficientMaterial = false; break;
                                case 2: if ((x + y) % 2 == 1) OppWhiteBishopAvailable = true; else OppBlackBishopAvailable = true; break;
                                case 3: OppKnightCount++; break;
                                case 4: insufficientMaterial = false; break;
                                case 5: insufficientMaterial = false; break;
                            }
                        }
                    }
            if (OppKnightCount > 1 || MyKnightCount > 1)
                insufficientMaterial = false;
            if ((MyKnightCount >= 1 && (MyBlackBishopAvailable || MyWhiteBishopAvailable)) || (OppKnightCount >= 1 && (OppBlackBishopAvailable || OppWhiteBishopAvailable)))
                insufficientMaterial = false;
            if (MyBlackBishopAvailable && MyWhiteBishopAvailable)
            {
                insufficientMaterial = false;
            }
            if (OppBlackBishopAvailable && OppWhiteBishopAvailable)
            {
                insufficientMaterial = false;
            }

            if ((OppWhiteBishopAvailable && MyBlackBishopAvailable) || (OppBlackBishopAvailable && MyWhiteBishopAvailable))
                insufficientMaterial = false;

            return insufficientMaterial;
        }


        //Kiểm tra trường hợp hòa cờ do bất biến 3 lần
        //arrFen chứa danh sách các FEN, mỗi khi trạng thái bàn cờ thay đổi thì trạng thái mới sẽ lưu vào ArrFEN
        public static bool CheckThreefoldRepetition(ArrayList arrFEN)
        {
            int n = arrFEN.Count;
            for (int i = 0; i < n - 1; i++)
            {
                int count = 1;
                string s = arrFEN[i].ToString();
                for (int j = i + 1; j < n; j++)
                {
                    if (s == arrFEN[j].ToString())
                    {
                        count++;
                    }

                }
                if (count >= 3)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion

    }

    }
