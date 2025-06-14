using System.Drawing; // Added for Point, Color, etc.
using System.Windows.Forms; // Ensure this is present for PictureBoxSizeMode

namespace ChessGame2.Forms
{
    partial class frmGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlPlayer1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlTimer1 = new System.Windows.Forms.Panel();
            this.Pic1 = new System.Windows.Forms.PictureBox();
            this.pnlHistory = new System.Windows.Forms.Panel();
            this.pnlPlayer2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Pic2 = new System.Windows.Forms.PictureBox();
            this.pnlTimer2 = new System.Windows.Forms.Panel();
            this.pnlCapturedPiece2 = new System.Windows.Forms.Panel();
            this.pnlCapturedPiece1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnGame = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenuGame = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnNewGame = new DevExpress.XtraBars.BarButtonItem();
            this.btnContinueGame = new DevExpress.XtraBars.BarButtonItem();
           
            this.btnTraining = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            
            this.btnSaveGame = new DevExpress.XtraBars.BarButtonItem();
            this.btnGetFen = new DevExpress.XtraBars.BarButtonItem();
           
            this.buttonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnOptions = new DevExpress.XtraBars.BarButtonItem();
            this.buttonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnTrainingDatabase = new DevExpress.XtraBars.BarButtonItem();
           
            this.btnMoves = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenuMoves = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnBoard = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenuBoard = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.popupMenuTools = new DevExpress.XtraBars.PopupMenu(this.components);
            this.popupMenuHelp = new DevExpress.XtraBars.PopupMenu(this.components);
            this.popupMenuStyle = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnChessRule = new DevExpress.XtraBars.BarButtonItem();
            this.btnContact = new DevExpress.XtraBars.BarButtonItem();
            this.btnAbout = new DevExpress.XtraBars.BarButtonItem();
            this.pnlPlayer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).BeginInit();
            this.pnlPlayer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMoves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuTools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuStyle)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPlayer1
            // 
            this.pnlPlayer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPlayer1.Controls.Add(this.label2);
            this.pnlPlayer1.Controls.Add(this.pnlTimer1);
            this.pnlPlayer1.Controls.Add(this.Pic1);
            this.pnlPlayer1.Location = new System.Drawing.Point(546, 191);
            this.pnlPlayer1.Name = "pnlPlayer1";
            this.pnlPlayer1.Size = new System.Drawing.Size(163, 247);
            this.pnlPlayer1.TabIndex = 9;
            this.pnlPlayer1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Garamond", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Razor";
            // 
            // pnlTimer1
            // 
            this.pnlTimer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pnlTimer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTimer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTimer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlTimer1.Location = new System.Drawing.Point(11, 11);
            this.pnlTimer1.Name = "pnlTimer1";
            this.pnlTimer1.Size = new System.Drawing.Size(130, 45);
            this.pnlTimer1.TabIndex = 4;
            this.pnlTimer1.Visible = false;
            // 
            // Pic1
            // 
            this.Pic1.BackColor = System.Drawing.Color.Transparent;
            this.Pic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pic1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pic1.Image = global::ChessGame2.Properties.Resources.a1;
            this.Pic1.Location = new System.Drawing.Point(27, 77);
            this.Pic1.Name = "Pic1";
            this.Pic1.Size = new System.Drawing.Size(108, 120);
            this.Pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic1.TabIndex = 6;
            this.Pic1.TabStop = false;
            // 
            // pnlHistory
            // 
            this.pnlHistory.BackColor = System.Drawing.Color.White;
            this.pnlHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHistory.ForeColor = System.Drawing.Color.Blue;
            this.pnlHistory.Location = new System.Drawing.Point(721, 246);
            this.pnlHistory.Name = "pnlHistory";
            this.pnlHistory.Size = new System.Drawing.Size(173, 294);
            this.pnlHistory.TabIndex = 3;
            this.pnlHistory.Visible = false;
            // 
            // pnlPlayer2
            // 
            this.pnlPlayer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPlayer2.Controls.Add(this.label1);
            this.pnlPlayer2.Controls.Add(this.Pic2);
            this.pnlPlayer2.Controls.Add(this.pnlTimer2);
            this.pnlPlayer2.Location = new System.Drawing.Point(552, 466);
            this.pnlPlayer2.Name = "pnlPlayer2";
            this.pnlPlayer2.Size = new System.Drawing.Size(163, 247);
            this.pnlPlayer2.TabIndex = 8;
            this.pnlPlayer2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Garamond", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Storm Spirit";
            // 
            // Pic2
            // 
            this.Pic2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Pic2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pic2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pic2.Image = global::ChessGame2.Properties.Resources.a2;
            this.Pic2.Location = new System.Drawing.Point(27, 77);
            this.Pic2.Name = "Pic2";
            this.Pic2.Size = new System.Drawing.Size(108, 120);
            this.Pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic2.TabIndex = 7;
            this.Pic2.TabStop = false;
            // 
            // pnlTimer2
            // 
            this.pnlTimer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pnlTimer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTimer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTimer2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlTimer2.Location = new System.Drawing.Point(18, 11);
            this.pnlTimer2.Name = "pnlTimer2";
            this.pnlTimer2.Size = new System.Drawing.Size(130, 50);
            this.pnlTimer2.TabIndex = 5;
            this.pnlTimer2.Visible = false;
            // 
            // pnlCapturedPiece2
            // 
            this.pnlCapturedPiece2.BackColor = System.Drawing.Color.White;
            this.pnlCapturedPiece2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCapturedPiece2.Location = new System.Drawing.Point(476, 547);
            this.pnlCapturedPiece2.Name = "pnlCapturedPiece2";
            this.pnlCapturedPiece2.Size = new System.Drawing.Size(46, 190);
            this.pnlCapturedPiece2.TabIndex = 2;
            this.pnlCapturedPiece2.Visible = false;
            // 
            // pnlCapturedPiece1
            // 
            this.pnlCapturedPiece1.BackColor = System.Drawing.Color.White;
            this.pnlCapturedPiece1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCapturedPiece1.Location = new System.Drawing.Point(476, 300);
            this.pnlCapturedPiece1.Name = "pnlCapturedPiece1";
            this.pnlCapturedPiece1.Size = new System.Drawing.Size(46, 190);
            this.pnlCapturedPiece1.TabIndex = 1;
            this.pnlCapturedPiece1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(22, 203);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 400);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            this.panel1.PaddingChanged += new System.EventHandler(this.Board_PieceCaptured);
            // 
            // pnlMenu
            // 
            this.pnlMenu.AllowDrop = true;
            this.pnlMenu.AutoSize = true;
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMenu.Controls.Add(this.btnGame);
            this.pnlMenu.Controls.Add(this.btnMoves);
            this.pnlMenu.Controls.Add(this.btnBoard);
            this.pnlMenu.Controls.Add(this.btnExit);
            this.pnlMenu.Location = new System.Drawing.Point(300, 150);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(300, 239);
            this.pnlMenu.TabIndex = 10;
            // 
            // btnGame
            // 
            this.btnGame.AllowDrop = true;
            this.btnGame.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.btnGame.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.btnGame.Appearance.BackColor2 = System.Drawing.Color.Cyan;
            this.btnGame.Appearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnGame.Appearance.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGame.Appearance.ForeColor = System.Drawing.Color.Cyan;
            this.btnGame.Appearance.Options.UseBorderColor = true;
            this.btnGame.Appearance.Options.UseFont = true;
            this.btnGame.Appearance.Options.UseForeColor = true;
            this.btnGame.AppearanceHovered.BackColor = System.Drawing.Color.Yellow;
            this.btnGame.AppearanceHovered.BorderColor = System.Drawing.Color.Red;
            this.btnGame.AppearanceHovered.Font = new System.Drawing.Font("Garamond", 16F, System.Drawing.FontStyle.Bold);
            this.btnGame.AppearanceHovered.ForeColor = System.Drawing.Color.Red;
            this.btnGame.AppearanceHovered.Options.UseBackColor = true;
            this.btnGame.AppearanceHovered.Options.UseBorderColor = true;
            this.btnGame.AppearanceHovered.Options.UseFont = true;
            this.btnGame.AppearanceHovered.Options.UseForeColor = true;
            this.btnGame.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.btnGame.AppearancePressed.Font = new System.Drawing.Font("Garamond", 16F, System.Drawing.FontStyle.Bold);
            this.btnGame.AppearancePressed.ForeColor = System.Drawing.Color.Black;
            this.btnGame.AppearancePressed.Options.UseBackColor = true;
            this.btnGame.AppearancePressed.Options.UseFont = true;
            this.btnGame.AppearancePressed.Options.UseForeColor = true;
            this.btnGame.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.btnGame.DropDownControl = this.popupMenuGame;
            this.btnGame.ImageOptions.ImageUri.Uri = "ChessKing";
            this.btnGame.Location = new System.Drawing.Point(50, 20);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(200, 40);
            this.btnGame.TabIndex = 0;
            this.btnGame.Text = "Trò Chơi";
            // 
            // popupMenuGame
            // 
            this.popupMenuGame.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNewGame),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnContinueGame),
            
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTraining)});
            this.popupMenuGame.Manager = this.barManager1;
            this.popupMenuGame.Name = "popupMenuGame";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Caption = "Chơi Đơn";
            this.btnNewGame.Id = 1;
            this.btnNewGame.ImageOptions.ImageUri.Uri = "ChessKing";
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewGame_Click);
            // 
            // btnContinueGame
            // 
            this.btnContinueGame.Caption = "Chơi Tiếp";
            this.btnContinueGame.Id = 2;
            this.btnContinueGame.ImageOptions.ImageUri.Uri = "ChessRook";
            this.btnContinueGame.Name = "btnContinueGame";
            this.btnContinueGame.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnContinueGame_Click);
         
            // 
            // btnTraining
            // 
            this.btnTraining.Caption = "Luyện Tập";
            this.btnTraining.Id = 3;
            this.btnTraining.ImageOptions.ImageUri.Uri = "ChessPawn";
            this.btnTraining.Name = "btnTraining";
            this.btnTraining.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTraining_Click);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnNewGame,
            this.btnContinueGame,
           
            this.btnTraining,
            this.btnUndo,
            
            this.btnSaveGame,
            this.btnGetFen,
          
            this.buttonItem2,
            this.btnOptions,
            this.buttonItem1,
            this.btnTrainingDatabase
         });
            this.barManager1.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(898, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 618);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(898, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 618);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(898, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 618);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Quay Lại";
            this.btnUndo.Enabled = false;
            this.btnUndo.Id = 7;
            this.btnUndo.ImageOptions.ImageUri.Uri = "Undo";
            this.btnUndo.ItemAppearance.Disabled.ForeColor = System.Drawing.Color.Gray;
            this.btnUndo.ItemAppearance.Disabled.Options.UseForeColor = true;
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_Click);
            // 
            // btnSaveGame
            // 
            this.btnSaveGame.Caption = "Lưu Game";
            this.btnSaveGame.Id = 11;
            this.btnSaveGame.ImageOptions.ImageUri.Uri = "SaveGame";
            this.btnSaveGame.Name = "btnSaveGame";
            this.btnSaveGame.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveGame_Click);
            // 
            // btnGetFen
            // 
            this.btnGetFen.Caption = "Sao Chép FEN";
            this.btnGetFen.Id = 9;
            this.btnGetFen.ImageOptions.ImageUri.Uri = "Copy";
            this.btnGetFen.Name = "btnGetFen";
            this.btnGetFen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGetFen_Click);
            // 
            // buttonItem2
            // 
            this.buttonItem2.Caption = "Lưu Các Nước Đi";
            this.buttonItem2.Id = 11;
            this.buttonItem2.ImageOptions.ImageUri.Uri = "SaveMoves";
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonItem2_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Id = 0;
            this.btnOptions.Name = "btnOptions";
            // 
            // buttonItem1
            // 
            this.buttonItem1.Id = 1;
            this.buttonItem1.Name = "buttonItem1";
            // 
            // btnTrainingDatabase
            // 
            this.btnTrainingDatabase.Id = 2;
            this.btnTrainingDatabase.Name = "btnTrainingDatabase";
            // 
            // btnMoves
            // 
            this.btnMoves.Appearance.BackColor2 = System.Drawing.Color.Cyan;
            this.btnMoves.Appearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnMoves.Appearance.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoves.Appearance.ForeColor = System.Drawing.Color.Cyan;
            this.btnMoves.Appearance.Options.UseBorderColor = true;
            this.btnMoves.Appearance.Options.UseFont = true;
            this.btnMoves.Appearance.Options.UseForeColor = true;
            this.btnMoves.AppearanceHovered.BackColor = System.Drawing.Color.Yellow;
            this.btnMoves.AppearanceHovered.BorderColor = System.Drawing.Color.Red;
            this.btnMoves.AppearanceHovered.Font = new System.Drawing.Font("Garamond", 16F, System.Drawing.FontStyle.Bold);
            this.btnMoves.AppearanceHovered.ForeColor = System.Drawing.Color.Red;
            this.btnMoves.AppearanceHovered.Options.UseBackColor = true;
            this.btnMoves.AppearanceHovered.Options.UseBorderColor = true;
            this.btnMoves.AppearanceHovered.Options.UseFont = true;
            this.btnMoves.AppearanceHovered.Options.UseForeColor = true;
            this.btnMoves.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.btnMoves.AppearancePressed.Font = new System.Drawing.Font("Garamond", 16F, System.Drawing.FontStyle.Bold);
            this.btnMoves.AppearancePressed.ForeColor = System.Drawing.Color.Black;
            this.btnMoves.AppearancePressed.Options.UseBackColor = true;
            this.btnMoves.AppearancePressed.Options.UseFont = true;
            this.btnMoves.AppearancePressed.Options.UseForeColor = true;
            this.btnMoves.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.btnMoves.DropDownControl = this.popupMenuMoves;
            this.btnMoves.ImageOptions.ImageUri.Uri = "Undo";
            this.btnMoves.Location = new System.Drawing.Point(50, 70);
            this.btnMoves.Name = "btnMoves";
            this.btnMoves.Size = new System.Drawing.Size(200, 40);
            this.btnMoves.TabIndex = 1;
            this.btnMoves.Text = "Nước Đi";
            // 
            // popupMenuMoves
            // 
            this.popupMenuMoves.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUndo)});
            this.popupMenuMoves.Manager = this.barManager1;
            this.popupMenuMoves.Name = "popupMenuMoves";
            // 
            // btnBoard
            // 
            this.btnBoard.AllowDrop = true;
            this.btnBoard.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.btnBoard.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.btnBoard.Appearance.BackColor2 = System.Drawing.Color.Cyan;
            this.btnBoard.Appearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnBoard.Appearance.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoard.Appearance.ForeColor = System.Drawing.Color.Cyan;
            this.btnBoard.Appearance.Options.UseBorderColor = true;
            this.btnBoard.Appearance.Options.UseFont = true;
            this.btnBoard.Appearance.Options.UseForeColor = true;
            this.btnBoard.AppearanceHovered.BackColor = System.Drawing.Color.Yellow;
            this.btnBoard.AppearanceHovered.BorderColor = System.Drawing.Color.Red;
            this.btnBoard.AppearanceHovered.Font = new System.Drawing.Font("Garamond", 16F, System.Drawing.FontStyle.Bold);
            this.btnBoard.AppearanceHovered.ForeColor = System.Drawing.Color.Red;
            this.btnBoard.AppearanceHovered.Options.UseBackColor = true;
            this.btnBoard.AppearanceHovered.Options.UseBorderColor = true;
            this.btnBoard.AppearanceHovered.Options.UseFont = true;
            this.btnBoard.AppearanceHovered.Options.UseForeColor = true;
            this.btnBoard.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.btnBoard.AppearancePressed.Font = new System.Drawing.Font("Garamond", 16F, System.Drawing.FontStyle.Bold);
            this.btnBoard.AppearancePressed.ForeColor = System.Drawing.Color.Black;
            this.btnBoard.AppearancePressed.Options.UseBackColor = true;
            this.btnBoard.AppearancePressed.Options.UseFont = true;
            this.btnBoard.AppearancePressed.Options.UseForeColor = true;
            this.btnBoard.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.btnBoard.DropDownControl = this.popupMenuBoard;
            this.btnBoard.ImageOptions.ImageUri.Uri = "Copy";
            this.btnBoard.Location = new System.Drawing.Point(50, 120);
            this.btnBoard.Name = "btnBoard";
            this.btnBoard.Size = new System.Drawing.Size(200, 40);
            this.btnBoard.TabIndex = 2;
            this.btnBoard.Text = "Bàn Cờ";
            // 
            // popupMenuBoard
            // 
            this.popupMenuBoard.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGetFen),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSaveGame),
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonItem2)});
            this.popupMenuBoard.Manager = this.barManager1;
            this.popupMenuBoard.Name = "popupMenuBoard";
            // 
            // btnExit
            // 
            this.btnExit.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExit.Appearance.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExit.Appearance.Options.UseBorderColor = true;
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Appearance.Options.UseForeColor = true;
            this.btnExit.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExit.AppearanceHovered.BorderColor = System.Drawing.Color.Red;
            this.btnExit.AppearanceHovered.Font = new System.Drawing.Font("Garamond", 16F, System.Drawing.FontStyle.Bold);
            this.btnExit.AppearanceHovered.ForeColor = System.Drawing.Color.Red;
            this.btnExit.AppearanceHovered.Options.UseBackColor = true;
            this.btnExit.AppearanceHovered.Options.UseBorderColor = true;
            this.btnExit.AppearanceHovered.Options.UseFont = true;
            this.btnExit.AppearanceHovered.Options.UseForeColor = true;
            this.btnExit.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
            this.btnExit.AppearancePressed.Font = new System.Drawing.Font("Garamond", 16F, System.Drawing.FontStyle.Bold);
            this.btnExit.AppearancePressed.ForeColor = System.Drawing.Color.Black;
            this.btnExit.AppearancePressed.Options.UseBackColor = true;
            this.btnExit.AppearancePressed.Options.UseFont = true;
            this.btnExit.AppearancePressed.Options.UseForeColor = true;
            this.btnExit.ImageOptions.ImageUri.Uri = "Exit";
            this.btnExit.Location = new System.Drawing.Point(50, 178);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 40);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // popupMenuTools
            // 
            this.popupMenuTools.Name = "popupMenuTools";
            // 
            // popupMenuHelp
            // 
            this.popupMenuHelp.Name = "popupMenuHelp";
         
            // 
            // btnChessRule
            // 
            this.btnChessRule.Name = "btnChessRule";
            // 
            // btnContact
            // 
            this.btnContact.Name = "btnContact";
            // 
            // btnAbout
            // 
            this.btnAbout.Name = "btnAbout";
            // 
            // frmGame
            // 
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::ChessGame2.Properties.Resources.unnamed1;
            this.ClientSize = new System.Drawing.Size(898, 618);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlCapturedPiece1);
            this.Controls.Add(this.pnlCapturedPiece2);
            this.Controls.Add(this.pnlPlayer2);
            this.Controls.Add(this.pnlHistory);
            this.Controls.Add(this.pnlPlayer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Garamond", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmGame";
            this.Text = "Game Cờ Vua";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.pnlPlayer1.ResumeLayout(false);
            this.pnlPlayer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).EndInit();
            this.pnlPlayer2.ResumeLayout(false);
            this.pnlPlayer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuMoves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuTools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuStyle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPlayer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlTimer1;
        private System.Windows.Forms.PictureBox Pic1;
        private System.Windows.Forms.Panel pnlPlayer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Pic2;
        private System.Windows.Forms.Panel pnlTimer2;
        private System.Windows.Forms.Panel pnlHistory;
        private System.Windows.Forms.Panel pnlCapturedPiece2;
        private System.Windows.Forms.Panel pnlCapturedPiece1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMenu;
        private DevExpress.XtraEditors.DropDownButton btnGame;
        private DevExpress.XtraBars.PopupMenu popupMenuGame;
        private DevExpress.XtraBars.BarButtonItem btnNewGame;
        private DevExpress.XtraBars.BarButtonItem btnContinueGame;
        
        private DevExpress.XtraBars.BarButtonItem btnTraining;
        private DevExpress.XtraEditors.DropDownButton btnMoves;
        private DevExpress.XtraBars.PopupMenu popupMenuMoves;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraEditors.DropDownButton btnBoard;
        private DevExpress.XtraBars.PopupMenu popupMenuBoard;
        private DevExpress.XtraBars.BarButtonItem btnSaveGame;
        private DevExpress.XtraBars.BarButtonItem btnGetFen;
        private DevExpress.XtraBars.BarButtonItem buttonItem2;
        private DevExpress.XtraBars.PopupMenu popupMenuTools;
        private DevExpress.XtraBars.BarButtonItem btnOptions;
        private DevExpress.XtraBars.BarButtonItem buttonItem1;
        private DevExpress.XtraBars.BarButtonItem btnTrainingDatabase;
        private DevExpress.XtraBars.PopupMenu popupMenuHelp;
        private DevExpress.XtraBars.BarButtonItem btnChessRule;
        private DevExpress.XtraBars.BarButtonItem btnContact;
        private DevExpress.XtraBars.BarButtonItem btnAbout;
        private DevExpress.XtraBars.PopupMenu popupMenuStyle;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraBars.BarManager barManager1; // Added BarManager
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}