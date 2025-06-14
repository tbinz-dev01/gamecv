﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Collections;
namespace ChessGame2.UserControls
{
    public static class clsRook
    {
        
        static int Side;
        static ArrayList arrMove;


 
       
        public static ArrayList FindAllPossibleMove(int[,] State, Point pos)//, bool EnPassant)
        {
            //Từ vị trí ban đầu quân xe có thể di chuyển về 4 phía theo trục đứng và ngang

            arrMove = new ArrayList();

            Side = State[pos.X, pos.Y] % 10;//Chẵn(0) là quân trắng, lẻ(1) là quân đen

            chessloop(State, pos, 0, 1);
            chessloop(State, pos, 1, 0);
            chessloop(State, pos, 0, -1);
            chessloop(State, pos, -1, 0);

            return arrMove;
        }

        static void chessloop(int[,] State, Point pos, int indexx, int indexy)
        {
            int stop = 0;
            int x = pos.X;
            int y = pos.Y;
            while (stop == 0)
            {
                int state = State[x += indexx, y += indexy];

                if (state == 0)
                {
                    arrMove.Add(new Point(x, y));
                }
                else if (state == -1)
                {
                    stop = 1;
                }
                else
                {
                    if (state % 10 != Side)
                    {
                        arrMove.Add(new Point(x, y));
                    }
                    stop = 1;
                }

            }
        }

    }
}
