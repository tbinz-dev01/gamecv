﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChessGame2.UserControls;
using ChessGame2.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using System.IO;
using System.Collections;
using System.Media;

namespace ChessGame2.Forms
{
    public partial class FrmTraining : XtraForm 
    {
        public FrmTraining()
        {
            InitializeComponent();
        }
        UcChessBoard Board;
        private void btnTrainingOptions_Click(object sender, EventArgs e)
        {
            frmTrainingOptions frm = new frmTrainingOptions();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if ((frmTrainingOptions.Endgame || frmTrainingOptions.Mate1 || frmTrainingOptions.Mate2 || frmTrainingOptions.Mate3) == false)
                {
                    MessageBox.Show("Bạn phải chọn ít nhất 1 loại bài tập !!!");
                    btnNext.Enabled = false;
                    btnPre.Enabled = false;
                }
                else
                {
                    LoadExercises();
                    NextExercise();
                    if (arrLastExercises.Count == 0)
                        btnPre.Enabled = false;
                    else
                        btnPre.Enabled = true;

                    if (arrExercises.Count == 0)
                        btnNext.Enabled = false;
                    else
                        btnNext.Enabled = true;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        int intMoveCount = 0;
        private void frmTraining_Load(object sender, EventArgs e)
        {
            frmTrainingOptions frm = new frmTrainingOptions();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                if ((frmTrainingOptions.Endgame || frmTrainingOptions.Mate1 || frmTrainingOptions.Mate2 || frmTrainingOptions.Mate3) == false)
                {
                    MessageBox.Show("Bạn phải chọn ít nhất 1 loại bài tập !!!");
                }
                else
                {
                    frmMessageBox.ShowMessage = false;
                    LoadExercises();
                    NextExercise();
                    btnPre.Enabled = false;
                }
            }
            else
            {
                this.Close();
            }
        }
        /******************************/
        Label[] lblNotation = new Label[36];
        int intNotationSize;
        private void CreateChessBoard(string strFEN)
        {
            if (Board != null)
            {
                Board.CancelThinking();
                Board.Dispose();
            }
            panel1.Visible = true;
            panel1.Controls.Clear();
            clsOptions obj = new clsOptions();

            string s = strFEN.Split(' ')[1].ToUpper();
            strFEN += " 0 1";
            ChessSide eOwnSide;

            if (s == "W")
            {
                eOwnSide = ChessSide.White;
            }
            else
            {
                eOwnSide = ChessSide.Black;
            }

            int CellSize = 65;
            int PieceSize = 60;
            Board = new UcChessBoard(obj.BoardStyle, obj.PieceStyle, eOwnSide, GameMode.VsHuman, CellSize, PieceSize, obj.PlaySound, strFEN);
            Board.MoveMaked += new UcChessBoard.MoveMakedHandler(MoveMaked);

            Bitmap bmpBackImage = new Bitmap(Board.Width, Board.Height);
            Board.DrawToBitmap(bmpBackImage, Board.Bounds);
            Board.BackgroundImage = bmpBackImage;
            Board.BoardBitMap = bmpBackImage;

            intNotationSize = (int)((CellSize * 38) / 100);
            AddNotation(CellSize, eOwnSide);
            Board.Location = new Point(intNotationSize, intNotationSize);
            this.panel1.Controls.Add(Board);
            this.panel1.ClientSize = new Size(CellSize * 8 + intNotationSize * 2, CellSize * 8 + intNotationSize * 2);

        }
        void MoveMaked(object sender, EventArgs e)
        {
            Board.Enabled = true;
            if ((Board.WhiteToMove == true && Board.OwnSide == ChessSide.White) || (Board.WhiteToMove == false && Board.OwnSide == ChessSide.Black))
            {
                intMoveCount--;
                if (intMoveCount < 0)
                    intMoveCount = 0;
            }
            if (Board.GameStatus == GameStatus.BlackWin && Board.OwnSide == ChessSide.Black || Board.GameStatus == GameStatus.WhiteWin && Board.OwnSide == ChessSide.White)
            {
                frmTrainingResult frm = new frmTrainingResult(true);
                if (frm.ShowDialog() == DialogResult.OK)
                    this.btnNext.PerformClick();
                return;
            }

            if (Board.GameStatus == GameStatus.BlackWin && Board.OwnSide == ChessSide.White || Board.GameStatus == GameStatus.WhiteWin && Board.OwnSide == ChessSide.Black)
            {
                Board.CancelThinking();
                frmTrainingResult frm = new frmTrainingResult(false);
                if (frm.ShowDialog() == DialogResult.OK)
                    this.btnTryAgain.PerformClick();
            }

            if (intMoveCount == 0 || Board.GameStatus == GameStatus.Draw)
            {

                Board.CancelThinking();
                Board.GameStatus = GameStatus.Draw;
                frmTrainingResult frm = new frmTrainingResult(false);
                if (frm.ShowDialog() == DialogResult.OK)
                    this.btnTryAgain.PerformClick();
            }

        }
        void AddNotation(int intCellSize, ChessSide eOwnSide)
        {

            for (int i = 0; i < 36; i++)
            {
                lblNotation[i] = new Label();
                lblNotation[i].Height = intCellSize;
                lblNotation[i].Width = intCellSize;
                lblNotation[i].Image = clsImageProcess.GetChessBoardBitMap(ChessSide.Black, ChessBoardStyle.BoardEdge);

                lblNotation[i].TextAlign = ContentAlignment.MiddleCenter;
                lblNotation[i].Font = new Font(FontFamily.GenericSansSerif, 14.0f);
                lblNotation[i].ImageAlign = ContentAlignment.MiddleCenter;
                lblNotation[i].ForeColor = Color.White;
            }

            lblNotation[0].Height = intNotationSize;
            lblNotation[0].Width = intNotationSize;
            lblNotation[0].Location = new Point();
            lblNotation[0].BackColor = Color.Blue;
            panel1.Controls.Add(lblNotation[0]);

            for (int i = 1; i <= 8; i++)
            {
                lblNotation[i].Height = intNotationSize;
                if (eOwnSide == ChessSide.White)
                {
                    lblNotation[i].Text = Convert.ToChar(64 + i).ToString();
                }
                else
                {
                    lblNotation[i].Text = Convert.ToChar(73 - i).ToString();
                }
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
                if (eOwnSide == ChessSide.White)
                {
                    lblNotation[9 + i].Text = Convert.ToChar(64 + i).ToString();
                }
                else
                {
                    lblNotation[9 + i].Text = Convert.ToChar(73 - i).ToString();
                }
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
                if (eOwnSide == ChessSide.White)
                {
                    lblNotation[18 + i].Text = Convert.ToString(9 - i);
                }
                else
                {
                    lblNotation[18 + i].Text = Convert.ToString(i);
                }
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
                if (eOwnSide == ChessSide.White)
                {
                    lblNotation[27 + i].Text = Convert.ToString(9 - i);
                }
                else
                {
                    lblNotation[27 + i].Text = Convert.ToString(i);
                }
                lblNotation[27 + i].Location = new Point(intNotationSize + intCellSize * 8, intCellSize * (i - 1) + intNotationSize);
                panel1.Controls.Add(lblNotation[27 + i]);
            }

        }
        clsTrainingExercise CurrentExercise = null;
        int intTotalExercises = 0;
        void LoadGame()
        {
            if (CurrentExercise == null)
                return;
            intMoveCount = CurrentExercise.MaxMoves;

            CreateChessBoard(CurrentExercise.FEN);
            LoadInfo();
        }
        void PreviousExercise()
        {
            if (arrLastExercises.Count == 0)
                return;

            int i = arrLastExercises.Count - 1;
            CurrentExercise = (clsTrainingExercise)arrLastExercises[i];

            arrLastExercises.RemoveAt(i);
            LoadGame();
            lblIndex.Text = (arrLastExercises.Count + 1) + "/" + intTotalExercises;
        }
        void NextExercise()
        {
            if (arrExercises.Count == 0)
                MessageBox.Show("Bài tập đã hết !!!");
            else
            {
                int i = arrExercises.Count - 1;
                CurrentExercise = (clsTrainingExercise)arrExercises[i];
                arrExercises.RemoveAt(i);
                LoadGame();
                lblIndex.Text = (arrLastExercises.Count + 1) + "/" + intTotalExercises;
            }
        }

        void LoadInfo()
        {
            if (Board != null)
            {
                if (Board.WhiteToMove == true)
                {
                    lblOwnSide.Text = "Trắng";
                    lblWhoMove.Text = "Trắng";
                }
                else
                {
                    lblOwnSide.Text = "Đen";
                    lblWhoMove.Text = "Đen";
                }
                if (UcChessBoard.KINGsideCastling == true)
                {
                    lblWKCastling.Text = "Có";
                    lblWKCastling.ForeColor = Color.Blue;
                }
                else
                {
                    lblWKCastling.Text = "Không";
                    lblWKCastling.ForeColor = Color.Black;
                }
                if (UcChessBoard.kingsideCastling == true)
                {
                    lblBKCastling.Text = "Có";
                    lblBKCastling.ForeColor = Color.Blue;
                }
                else
                {
                    lblBKCastling.Text = "Không";
                    lblBKCastling.ForeColor = Color.Black;
                }

                if (UcChessBoard.QUEENsideCastling == true)
                {
                    lblWQCastling.Text = "Có";
                    lblWQCastling.ForeColor = Color.Blue;
                }
                else
                {
                    lblWQCastling.Text = "Không";
                    lblWQCastling.ForeColor = Color.Black;
                }

                if (UcChessBoard.queensideCastling == true)
                {
                    lblBQCastling.Text = "Có";
                    lblBQCastling.ForeColor = Color.Blue;
                }
                else
                {
                    lblBQCastling.Text = "Không";
                    lblBQCastling.ForeColor = Color.Black;
                }

                if (UcChessBoard._EnPassantPoint == new Point())
                {
                    lblEnpassant.Text = "Không";
                    lblEnpassant.ForeColor = Color.Black;
                }
                else
                {
                    lblEnpassant.Text = Convert.ToChar(96 + UcChessBoard._EnPassantPoint.X).ToString() + UcChessBoard._EnPassantPoint.Y;
                    lblEnpassant.ForeColor = Color.Red;
                }

                lblType.Text = CurrentExercise.ExerciseName;
            }
        }

        private List<clsTrainingExercise> arrExercises;
        private List<clsTrainingExercise> arrLastExercises;
        void LoadExercises()
        {
            arrExercises = new List<clsTrainingExercise>();
            arrLastExercises = new List<clsTrainingExercise>();
            bool bEndgame = frmTrainingOptions.Endgame;
            bool bMate1 = frmTrainingOptions.Mate1;
            bool bMate2 = frmTrainingOptions.Mate2;
            bool bMate3 = frmTrainingOptions.Mate3;

            DataTable tbl;
            try
            {
                tbl = clsTrainingDatabase.GetDataTable();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading data from database: {ex.Message}");
                return;
            }

            foreach (DataRow r in tbl.Rows)
            {
                string movesValue = Convert.ToString(r["Moves"]);
                if (!int.TryParse(movesValue, out int moves))
                {
                    Console.WriteLine($"Dòng dữ liệu có giá trị Moves không hợp lệ: {movesValue}");
                    continue;
                }

                clsTrainingExercise exe = new clsTrainingExercise(
                    Convert.ToString(clsTrainingExercise.strName) ?? string.Empty, // Ensure string conversion
                    Convert.ToString(r["FEN"]),
                    moves
                );

                if (bEndgame && exe.MaxMoves > 168)
                    arrExercises.Add(exe);
                if (bMate2 && exe.MaxMoves == 2)
                    arrExercises.Add(exe);
                if (bMate3 && exe.MaxMoves == 3)
                    arrExercises.Add(exe);
            }

            if (frmTrainingOptions.Random)
            {
                Random rd = new Random();
                int n = arrExercises.Count;
                while (n > 1)
                {
                    n--;
                    int k = rd.Next(n + 1);
                    var value = arrExercises[k];
                    arrExercises[k] = arrExercises[n];
                    arrExercises[n] = value;
                }
            }

            intTotalExercises = arrExercises.Count;
            if (lblIndex != null)
            {
                lblIndex.Text = $"{arrLastExercises.Count + 1}/{intTotalExercises}";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CurrentExercise == null)
            {
                btnNext.Enabled = false;
                btnPre.Enabled = false;
                return;
            }
            arrLastExercises.Add(CurrentExercise);
            NextExercise();
            if (arrExercises.Count > 0)
                btnNext.Enabled = true;
            else
                btnNext.Enabled = false;

            if (arrLastExercises.Count > 0)
                btnPre.Enabled = true;
            else
                btnPre.Enabled = false;

        }

     

        private void btnTryAgain_Click(object sender, EventArgs e)
        {
            if (Board != null)
                LoadGame();
        }

        private void frmTraining_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Board != null)
            {
                Board.CancelThinking();
                Board.Dispose();
            }
        }

        private void btnSelectGame_Click(object sender, EventArgs e)
        {
            frmTrainingDatabase frm = new frmTrainingDatabase(true);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CurrentExercise = frmTrainingDatabase.exe;
                LoadGame();
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (Board == null)
                return;
            Clipboard.SetText(CurrentExercise.FEN);
            MessageBox.Show(CurrentExercise.FEN, "Đã Lưu Vào ClipBoard");
        }

        private void btnBoard_Click(object sender, EventArgs e)
        {
            if (Board == null)
            {
                return;
            }
            //frmAnalysisBoard frm = new frmAnalysisBoard(clsFEN.GetFENWithoutMoveNumber(Board), Board.OwnSide);
            //frm.ShowDialog();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (Board != null && Board.stkWhiteMoves.Count > 0)
            {
                if (Board.GameMode == GameMode.VsHuman)
                    Board.UnDoMove();
                else
                {
                    if (Board.IsThinking == true)
                        return;

                    Board.UnDoMove();
                    Board.UnDoMove();
                    intMoveCount++;

                }
            }
        }

        private void timerManageControl_Tick(object sender, EventArgs e)
        {
            if (Board == null || CurrentExercise == null)
            {
                btnUndo.Enabled = false;
                
            }
            else
            {

                if (Board.IsThinking && Board.GameStatus == GameStatus.NowPlaying)
                {
                    btnUndo.Enabled = false;
                  
                    btnNext.Enabled = false;
                    btnPre.Enabled = false;
                }
                else
                {
                    if (Board.GameStatus == GameStatus.NowPlaying)
                    {
                        if (Board.stkWhiteMoves.Count > 0)
                            btnUndo.Enabled = true;
                        else
                            btnUndo.Enabled = false;
                       
                    }
                    if (arrExercises.Count > 0)
                        btnNext.Enabled = true;
                    if (arrLastExercises.Count > 0)
                        btnPre.Enabled = true;
                }
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {

            arrExercises.Add(CurrentExercise);
            PreviousExercise();
            if (arrExercises.Count > 0)
                btnNext.Enabled = true;
            else
                btnNext.Enabled = false;
            if (arrLastExercises.Count > 0)
                btnPre.Enabled = true;
            else
                btnPre.Enabled = false;

        }
    }
}