using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;

namespace ChessGame2.UserControls
{
    public static class clsPawn
    {
  

        public static ArrayList FindAllPossibleMove(int[,] State, Point pos)//, bool EnPassant)
        {
            //Từ vị trí ban đầu quân tốt có thể di chuyển về phía trước 1 hoặc 2 ô các vị trí còn lại : 1 ô
            //Nước di chuyển 2 ô có thể kích hoạt trạng thái "Bắt Tốt Qua Đường(Enpassant)"
            //Trạng thái Enpassant cỉ có hiệu lực trong 1 Nước cờ
            //(nếu đối phương ko ăn quân trong lượt đó thì trạng thái Enpassant sẽ mất hiệu lực)
            ArrayList arrMove = new ArrayList();
            /*
             * Nếu ô phía trước không bị cản thì có thể di chuyển
             */
            int Side = State[pos.X, pos.Y] % 10;//Chẵn(2) là quân trắng, lẻ(1) là quân đen

            if (Side == 2)//Quân Trắng
            {
                if (State[pos.X, pos.Y + 1] == 0)
                {
                    arrMove.Add(new Point(pos.X, pos.Y + 1));

                    if (pos.Y == 2 && State[pos.X, pos.Y + 2] == 0)//Vi tri ban dau
                        arrMove.Add(new Point(pos.X, pos.Y + 2));
                    //Phong Cấp
                    if (pos.Y == 7)
                    {
                        arrMove.Add(new Point(pos.X, pos.Y + 1));
                        arrMove.Add(new Point(pos.X, pos.Y + 1));
                        arrMove.Add(new Point(pos.X, pos.Y + 1));
                    }
                }
                //Ăn quân
                //Nếu đường chéo ở 2 ô trước mặt là quân đen
                if (State[pos.X - 1, pos.Y + 1] % 10 == 1)
                {
                    arrMove.Add(new Point(pos.X - 1, pos.Y + 1));
                    if (pos.Y == 7)
                    {
                        arrMove.Add(new Point(pos.X - 1, pos.Y + 1));
                        arrMove.Add(new Point(pos.X - 1, pos.Y + 1));
                        arrMove.Add(new Point(pos.X - 1, pos.Y + 1));
                    }
                }
                if (State[pos.X + 1, pos.Y + 1] % 10 == 1)
                {
                    arrMove.Add(new Point(pos.X + 1, pos.Y + 1));
                    if (pos.Y == 7)
                    {
                        arrMove.Add(new Point(pos.X + 1, pos.Y + 1));
                        arrMove.Add(new Point(pos.X + 1, pos.Y + 1));
                        arrMove.Add(new Point(pos.X + 1, pos.Y + 1));
                    }
                }


            }
            else if (Side == 1)
            {
                if (State[pos.X, pos.Y - 1] == 0)
                {
                    arrMove.Add(new Point(pos.X, pos.Y - 1));

                    if (pos.Y == 7 && State[pos.X, pos.Y - 2] == 0)//Vi tri ban dau
                        arrMove.Add(new Point(pos.X, pos.Y - 2));

                    if (pos.Y == 2)
                    {
                        arrMove.Add(new Point(pos.X, pos.Y - 1));
                        arrMove.Add(new Point(pos.X, pos.Y - 1));
                        arrMove.Add(new Point(pos.X, pos.Y - 1));
                    }

                }
                //Ăn quân
                //Nếu đường chéo ở 2 ô trước mặt là quân Trắng
                if (State[pos.X - 1, pos.Y - 1] % 10 == 2)
                {
                    arrMove.Add(new Point(pos.X - 1, pos.Y - 1));
                    if (pos.Y == 2)
                    {
                        arrMove.Add(new Point(pos.X - 1, pos.Y - 1));
                        arrMove.Add(new Point(pos.X - 1, pos.Y - 1));
                        arrMove.Add(new Point(pos.X - 1, pos.Y - 1));
                    }
                }

                if (State[pos.X + 1, pos.Y - 1] % 10 == 2)
                {
                    arrMove.Add(new Point(pos.X + 1, pos.Y - 1));
                    if (pos.Y == 2)
                    {
                        arrMove.Add(new Point(pos.X + 1, pos.Y - 1));
                        arrMove.Add(new Point(pos.X + 1, pos.Y - 1));
                        arrMove.Add(new Point(pos.X + 1, pos.Y - 1));
                    }
                }


            }

            Point pt = UcChessBoard._EnPassantPoint;
            if (pt != new Point())//Nếu có tọa đọ bắt tốt
            {
                if (pos.Y == 4 && Side == 1)//Nếu là quân tốt đen
                {
                    if (new Point(pos.X - 1, 3) == pt)//Đường chéo phải
                    {
                        arrMove.Add(UcChessBoard._EnPassantPoint);
                    }

                    if (new Point(pos.X + 1, 3) == pt)//Đường chéo trái
                    {
                        arrMove.Add(UcChessBoard._EnPassantPoint);
                    }
                }

                if (pos.Y == 5 && Side == 2)
                {
                    if (new Point(pos.X - 1, 6) == pt)
                    {
                        arrMove.Add(UcChessBoard._EnPassantPoint);
                    }

                    if (new Point(pos.X + 1, 6) == pt)
                    {
                        arrMove.Add(UcChessBoard._EnPassantPoint);
                    }
                }
            }
            return arrMove;

        }
        public static Point GetEnPassantPoint(int[,] State, Point pos)
        {
            if (pos.Y == 4)
                return new Point(pos.X, pos.Y - 1);
            if (pos.Y == 5)
                return new Point(pos.X, pos.Y + 1);
            return new Point();
        }

        //Nếu chơi với máy hì máy sẽ chon quân Hậu và không hieern thị form chọn
        //Nếu đóng Form thì mặc định sẽ chọn quân hậu
        public static bool Promotion(UcChessPiece UcPawn, ChessPieceType PromoteTo)
        {

            if ((UcPawn.PositionY == 8) || (UcPawn.PositionY == 1))
            {

                Bitmap queen = clsImageProcess.GetChessPieceBitMap(UcPawn.Side, ChessPieceType.Queen, UcPawn.Style);
                Bitmap root = clsImageProcess.GetChessPieceBitMap(UcPawn.Side, ChessPieceType.Rook, UcPawn.Style);
                Bitmap knight = clsImageProcess.GetChessPieceBitMap(UcPawn.Side, ChessPieceType.Knight, UcPawn.Style);
                Bitmap bishop = clsImageProcess.GetChessPieceBitMap(UcPawn.Side, ChessPieceType.Bishop, UcPawn.Style);

                if (PromoteTo == ChessPieceType.Null)
                {
                    Form f = new frmPromotion(queen, root, knight, bishop);
                    f.ShowDialog();
                    UcPawn.Type = frmPromotion.Type;
                }
                else
                {
                    UcPawn.Type = PromoteTo;
                }
                Bitmap image = clsImageProcess.GetChessPieceBitMap(UcPawn.Side, UcPawn.Type, UcPawn.Style);
                UcPawn.Image = image;
                return true;
            }
            return false;
        }

    }
}
