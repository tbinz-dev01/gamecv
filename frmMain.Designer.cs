using DevExpress.XtraEditors.Repository;

namespace ChessGame2.Forms
{
    partial class frmMain
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnStyle = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenuStyle = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barStyleOffice2007Blue = new DevExpress.XtraBars.BarButtonItem();
            this.barStyleOffice2007Black = new DevExpress.XtraBars.BarButtonItem();
            this.barStyleOffice2007Silver = new DevExpress.XtraBars.BarButtonItem();
            this.barStyleVistaGlass = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnChessRule = new DevExpress.XtraBars.BarButtonItem();
            this.btnContact = new DevExpress.XtraBars.BarButtonItem();
            this.btnAbout = new DevExpress.XtraBars.BarButtonItem();
            this.btnOptions = new DevExpress.XtraBars.BarButtonItem();
            this.buttonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnTrainingDatabase = new DevExpress.XtraBars.BarButtonItem();
            this.btnNewGame = new DevExpress.XtraBars.BarButtonItem();
            this.btnContinueGame = new DevExpress.XtraBars.BarButtonItem();
            this.btnTraining = new DevExpress.XtraBars.BarButtonItem();
            this.btnHelp = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenuHelp = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnTools = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenuTool = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnGame = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenuGame = new DevExpress.XtraBars.PopupMenu(this.components);
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblPage = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuTool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuGame)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMenu.Controls.Add(this.btnExit);
            this.pnlMenu.Controls.Add(this.btnStyle);
            this.pnlMenu.Controls.Add(this.btnHelp);
            this.pnlMenu.Controls.Add(this.btnTools);
            this.pnlMenu.Controls.Add(this.btnGame);
            this.pnlMenu.Controls.Add(this.lblMenu);
            this.pnlMenu.Location = new System.Drawing.Point(300, 150);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(300, 400);
            this.pnlMenu.TabIndex = 10;
            // 
            // btnExit
            // 
            this.btnExit.Appearance.BackColor2 = System.Drawing.Color.Cyan;
            this.btnExit.Appearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnExit.Appearance.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.ForeColor = System.Drawing.Color.Cyan;
            this.btnExit.Appearance.Options.UseBorderColor = true;
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Appearance.Options.UseForeColor = true;
            this.btnExit.Location = new System.Drawing.Point(50, 313);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 40);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStyle
            // 
            this.btnStyle.AllowDrop = true;
            this.btnStyle.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.btnStyle.Appearance.BackColor2 = System.Drawing.Color.Cyan;
            this.btnStyle.Appearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnStyle.Appearance.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStyle.Appearance.ForeColor = System.Drawing.Color.Cyan;
            this.btnStyle.Appearance.Options.UseBorderColor = true;
            this.btnStyle.Appearance.Options.UseFont = true;
            this.btnStyle.Appearance.Options.UseForeColor = true;
            this.btnStyle.AppearanceHovered.BackColor2 = System.Drawing.Color.Cyan;
            this.btnStyle.AppearanceHovered.BorderColor = System.Drawing.Color.Yellow;
            this.btnStyle.AppearanceHovered.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStyle.AppearanceHovered.ForeColor = System.Drawing.Color.Red;
            this.btnStyle.AppearanceHovered.Options.UseBorderColor = true;
            this.btnStyle.AppearanceHovered.Options.UseFont = true;
            this.btnStyle.AppearanceHovered.Options.UseForeColor = true;
            this.btnStyle.AppearancePressed.BackColor2 = System.Drawing.Color.Cyan;
            this.btnStyle.AppearancePressed.BorderColor = System.Drawing.Color.Yellow;
            this.btnStyle.AppearancePressed.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStyle.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.btnStyle.AppearancePressed.Options.UseBorderColor = true;
            this.btnStyle.AppearancePressed.Options.UseFont = true;
            this.btnStyle.AppearancePressed.Options.UseForeColor = true;
            this.btnStyle.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.btnStyle.DropDownControl = this.popupMenuStyle;
            this.btnStyle.Location = new System.Drawing.Point(50, 257);
            this.btnStyle.Name = "btnStyle";
            this.btnStyle.Size = new System.Drawing.Size(200, 40);
            this.btnStyle.TabIndex = 3;
            this.btnStyle.Text = "Giao diện";
            // 
            // popupMenuStyle
            // 
            this.popupMenuStyle.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStyleOffice2007Blue),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStyleOffice2007Black),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStyleOffice2007Silver),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStyleVistaGlass)});
            this.popupMenuStyle.Manager = this.barManager1;
            this.popupMenuStyle.Name = "popupMenuStyle";
            // 
            // barStyleOffice2007Blue
            // 
            this.barStyleOffice2007Blue.Caption = "Office 2007 Blue";
            this.barStyleOffice2007Blue.Id = 19;
            this.barStyleOffice2007Blue.Name = "barStyleOffice2007Blue";
            this.barStyleOffice2007Blue.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonStyleOffice2007Blue_Click);
            // 
            // barStyleOffice2007Black
            // 
            this.barStyleOffice2007Black.Caption = "Office 2007 Black";
            this.barStyleOffice2007Black.Id = 20;
            this.barStyleOffice2007Black.Name = "barStyleOffice2007Black";
            // 
            // barStyleOffice2007Silver
            // 
            this.barStyleOffice2007Silver.Caption = "Office 2007 Silver";
            this.barStyleOffice2007Silver.Id = 21;
            this.barStyleOffice2007Silver.Name = "barStyleOffice2007Silver";
            // 
            // barStyleVistaGlass
            // 
            this.barStyleVistaGlass.Caption = "Vista Glass";
            this.barStyleVistaGlass.Id = 22;
            this.barStyleVistaGlass.Name = "barStyleVistaGlass";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStyleOffice2007Blue,
            this.barStyleOffice2007Black,
            this.barStyleOffice2007Silver,
            this.barStyleVistaGlass,
            this.btnChessRule,
            this.btnContact,
            this.btnAbout,
            this.btnOptions,
            this.buttonItem1,
            this.btnTrainingDatabase,
            this.btnNewGame,
            this.btnContinueGame,
            this.btnTraining});
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 568);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(898, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 568);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(898, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 568);
            // 
            // btnChessRule
            // 
            this.btnChessRule.Caption = "Luật Cờ Vua";
            this.btnChessRule.Id = 15;
            this.btnChessRule.ImageOptions.ImageUri.Uri = "Rules";
            this.btnChessRule.Name = "btnChessRule";
            this.btnChessRule.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChessRule_Click);
            // 
            // btnContact
            // 
            this.btnContact.Caption = "Liên Hệ";
            this.btnContact.Id = 26;
            this.btnContact.ImageOptions.ImageUri.Uri = "Contact";
            this.btnContact.Name = "btnContact";
            // 
            // btnAbout
            // 
            this.btnAbout.Caption = "Tác Giả";
            this.btnAbout.Id = 17;
            this.btnAbout.ImageOptions.ImageUri.Uri = "About";
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAbout_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Caption = "Tùy Chỉnh";
            this.btnOptions.Id = 12;
            this.btnOptions.ImageOptions.ImageUri.Uri = "Settings";
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOptions_Click);
            // 
            // buttonItem1
            // 
            this.buttonItem1.Caption = "Hồ Sơ";
            this.buttonItem1.Id = 13;
            this.buttonItem1.ImageOptions.ImageUri.Uri = "Profile";
            this.buttonItem1.Name = "buttonItem1";
           // this.buttonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buttonItem1_Click);
            // 
            // btnTrainingDatabase
            // 
            this.btnTrainingDatabase.Caption = "Dữ Liệu Luyện Tập";
            this.btnTrainingDatabase.Id = 14;
            this.btnTrainingDatabase.ImageOptions.ImageUri.Uri = "Database";
            this.btnTrainingDatabase.Name = "btnTrainingDatabase";
            this.btnTrainingDatabase.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTrainingDatabase_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Caption = "Chơi Mới";
            this.btnNewGame.Id = 1;
            this.btnNewGame.ImageOptions.ImageUri.Uri = "ChessKing";
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(200, 40);
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
            // btnHelp
            // 
            this.btnHelp.AllowDrop = true;
            this.btnHelp.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.btnHelp.Appearance.BackColor2 = System.Drawing.Color.Cyan;
            this.btnHelp.Appearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnHelp.Appearance.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Appearance.ForeColor = System.Drawing.Color.Cyan;
            this.btnHelp.Appearance.Options.UseBorderColor = true;
            this.btnHelp.Appearance.Options.UseFont = true;
            this.btnHelp.Appearance.Options.UseForeColor = true;
            this.btnHelp.AppearanceHovered.BackColor2 = System.Drawing.Color.Cyan;
            this.btnHelp.AppearanceHovered.BorderColor = System.Drawing.Color.Yellow;
            this.btnHelp.AppearanceHovered.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.AppearanceHovered.ForeColor = System.Drawing.Color.Red;
            this.btnHelp.AppearanceHovered.Options.UseBorderColor = true;
            this.btnHelp.AppearanceHovered.Options.UseFont = true;
            this.btnHelp.AppearanceHovered.Options.UseForeColor = true;
            this.btnHelp.AppearancePressed.BackColor2 = System.Drawing.Color.Cyan;
            this.btnHelp.AppearancePressed.BorderColor = System.Drawing.Color.Yellow;
            this.btnHelp.AppearancePressed.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.btnHelp.AppearancePressed.Options.UseBorderColor = true;
            this.btnHelp.AppearancePressed.Options.UseFont = true;
            this.btnHelp.AppearancePressed.Options.UseForeColor = true;
            this.btnHelp.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.btnHelp.DropDownControl = this.popupMenuHelp;
            this.btnHelp.Location = new System.Drawing.Point(50, 197);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(200, 40);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.Text = "Trợ giúp";
            // 
            // popupMenuHelp
            // 
            this.popupMenuHelp.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnChessRule),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnContact),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAbout)});
            this.popupMenuHelp.Manager = this.barManager1;
            this.popupMenuHelp.Name = "popupMenuHelp";
            // 
            // btnTools
            // 
            this.btnTools.AllowDrop = true;
            this.btnTools.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.btnTools.Appearance.BackColor2 = System.Drawing.Color.Cyan;
            this.btnTools.Appearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnTools.Appearance.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTools.Appearance.ForeColor = System.Drawing.Color.Cyan;
            this.btnTools.Appearance.Options.UseBorderColor = true;
            this.btnTools.Appearance.Options.UseFont = true;
            this.btnTools.Appearance.Options.UseForeColor = true;
            this.btnTools.AppearanceHovered.BackColor2 = System.Drawing.Color.Cyan;
            this.btnTools.AppearanceHovered.BorderColor = System.Drawing.Color.Yellow;
            this.btnTools.AppearanceHovered.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTools.AppearanceHovered.ForeColor = System.Drawing.Color.Red;
            this.btnTools.AppearanceHovered.Options.UseBorderColor = true;
            this.btnTools.AppearanceHovered.Options.UseFont = true;
            this.btnTools.AppearanceHovered.Options.UseForeColor = true;
            this.btnTools.AppearancePressed.BackColor2 = System.Drawing.Color.Cyan;
            this.btnTools.AppearancePressed.BorderColor = System.Drawing.Color.Yellow;
            this.btnTools.AppearancePressed.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTools.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.btnTools.AppearancePressed.Options.UseBorderColor = true;
            this.btnTools.AppearancePressed.Options.UseFont = true;
            this.btnTools.AppearancePressed.Options.UseForeColor = true;
            this.btnTools.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.btnTools.DropDownControl = this.popupMenuTool;
            this.btnTools.Location = new System.Drawing.Point(50, 141);
            this.btnTools.Name = "btnTools";
            this.btnTools.Size = new System.Drawing.Size(200, 40);
            this.btnTools.TabIndex = 1;
            this.btnTools.Text = "Công cụ\r\n";
            // 
            // popupMenuTool
            // 
            this.popupMenuTool.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnOptions),
            new DevExpress.XtraBars.LinkPersistInfo(this.buttonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTrainingDatabase)});
            this.popupMenuTool.Manager = this.barManager1;
            this.popupMenuTool.Name = "popupMenuTool";
            // 
            // btnGame
            // 
            this.btnGame.AllowDrop = true;
            this.btnGame.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.btnGame.Appearance.BackColor2 = System.Drawing.Color.Cyan;
            this.btnGame.Appearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnGame.Appearance.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGame.Appearance.ForeColor = System.Drawing.Color.Cyan;
            this.btnGame.Appearance.Options.UseBorderColor = true;
            this.btnGame.Appearance.Options.UseFont = true;
            this.btnGame.Appearance.Options.UseForeColor = true;
            this.btnGame.AppearanceHovered.BackColor2 = System.Drawing.Color.Cyan;
            this.btnGame.AppearanceHovered.BorderColor = System.Drawing.Color.Yellow;
            this.btnGame.AppearanceHovered.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnGame.AppearanceHovered.ForeColor = System.Drawing.Color.Red;
            this.btnGame.AppearanceHovered.Options.UseBorderColor = true;
            this.btnGame.AppearanceHovered.Options.UseFont = true;
            this.btnGame.AppearanceHovered.Options.UseForeColor = true;
            this.btnGame.AppearancePressed.BorderColor = System.Drawing.Color.Yellow;
            this.btnGame.AppearancePressed.Font = new System.Drawing.Font("Arial", 15.75F);
            this.btnGame.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.btnGame.AppearancePressed.Options.UseBorderColor = true;
            this.btnGame.AppearancePressed.Options.UseFont = true;
            this.btnGame.AppearancePressed.Options.UseForeColor = true;
            this.btnGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGame.DropDownArrowStyle = DevExpress.XtraEditors.DropDownArrowStyle.Hide;
            this.btnGame.DropDownControl = this.popupMenuGame;
            this.btnGame.Location = new System.Drawing.Point(50, 83);
            this.btnGame.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(200, 40);
            this.btnGame.TabIndex = 6;
            this.btnGame.Text = "Chơi";
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
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.Cyan;
            this.lblMenu.Location = new System.Drawing.Point(75, 25);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(198, 44);
            this.lblMenu.TabIndex = 5;
            this.lblMenu.Text = "Trang chủ";
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.BackColor = System.Drawing.Color.Transparent;
            this.lblPage.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.ForeColor = System.Drawing.Color.Cyan;
            this.lblPage.Location = new System.Drawing.Point(15, 25);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(299, 44);
            this.lblPage.TabIndex = 11;
            this.lblPage.Text = "Trò chơi cờ vua";
            // 
            // frmMain
            // 
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::ChessGame2.Properties.Resources.unnamed;
            this.ClientSize = new System.Drawing.Size(898, 568);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMain";
            this.Text = "Trang chủ - Game Cờ vua";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuTool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private DevExpress.XtraEditors.DropDownButton btnStyle;
        private DevExpress.XtraEditors.DropDownButton btnHelp;
        private DevExpress.XtraEditors.DropDownButton btnTools;
        private DevExpress.XtraEditors.DropDownButton btnGame;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblPage;
        private DevExpress.XtraBars.PopupMenu popupMenuGame;
        private DevExpress.XtraBars.BarButtonItem btnNewGame;
        private DevExpress.XtraBars.BarButtonItem btnContinueGame;
            private DevExpress.XtraBars.BarButtonItem btnTraining;
      
        private DevExpress.XtraBars.PopupMenu popupMenuTool;
        private DevExpress.XtraBars.BarButtonItem btnOptions;
        private DevExpress.XtraBars.BarButtonItem buttonItem1;
        private DevExpress.XtraBars.BarButtonItem btnTrainingDatabase;
        
        private DevExpress.XtraBars.PopupMenu popupMenuHelp;
        private DevExpress.XtraBars.BarButtonItem btnChessRule;
        private DevExpress.XtraBars.BarButtonItem btnContact;
        private DevExpress.XtraBars.BarButtonItem btnAbout;

        private DevExpress.XtraBars.PopupMenu popupMenuStyle;
        private DevExpress.XtraBars.BarButtonItem barStyleOffice2007Blue;
        private DevExpress.XtraBars.BarButtonItem barStyleOffice2007Black;
        private DevExpress.XtraBars.BarButtonItem barStyleOffice2007Silver;
        private DevExpress.XtraBars.BarButtonItem barStyleVistaGlass;

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.SimpleButton btnExit;
    }
}