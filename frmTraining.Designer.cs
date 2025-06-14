namespace ChessGame2.Forms
{
    partial class FrmTraining
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblIndex = new DevExpress.XtraEditors.LabelControl();
            this.lblEnpassant = new DevExpress.XtraEditors.LabelControl();
            this.lblBKCastling = new DevExpress.XtraEditors.LabelControl();
            this.lblBQCastling = new DevExpress.XtraEditors.LabelControl();
            this.lblWKCastling = new DevExpress.XtraEditors.LabelControl();
            this.lblWQCastling = new DevExpress.XtraEditors.LabelControl();
            this.lblType = new DevExpress.XtraEditors.LabelControl();
            this.lblWhoMove = new DevExpress.XtraEditors.LabelControl();
            this.lblOwnSide = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.buttonX1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnBoard = new DevExpress.XtraEditors.SimpleButton();
            this.btnSelectGame = new DevExpress.XtraEditors.SimpleButton();
            this.btnTrainingOptions = new DevExpress.XtraEditors.SimpleButton();
            this.btnTryAgain = new DevExpress.XtraEditors.SimpleButton();
            this.btnUndo = new DevExpress.XtraEditors.SimpleButton();
            this.btnPre = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.timerManageControl = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 560);
            this.panel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupControl1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Appearance.Options.UseBorderColor = true;
            this.groupControl1.AppearanceCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Cyan;
            this.groupControl1.AppearanceCaption.Options.UseBackColor = true;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.lblIndex);
            this.groupControl1.Controls.Add(this.lblEnpassant);
            this.groupControl1.Controls.Add(this.lblBKCastling);
            this.groupControl1.Controls.Add(this.lblBQCastling);
            this.groupControl1.Controls.Add(this.lblWKCastling);
            this.groupControl1.Controls.Add(this.lblWQCastling);
            this.groupControl1.Controls.Add(this.lblType);
            this.groupControl1.Controls.Add(this.lblWhoMove);
            this.groupControl1.Controls.Add(this.lblOwnSide);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Location = new System.Drawing.Point(578, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(300, 250);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thông Tin Bài Tập";
            // 
            // lblIndex
            // 
            this.lblIndex.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndex.Appearance.Options.UseFont = true;
            this.lblIndex.Location = new System.Drawing.Point(150, 210);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(39, 24);
            this.lblIndex.TabIndex = 8;
            this.lblIndex.Text = "1/10";
            // 
            // lblEnpassant
            // 
            this.lblEnpassant.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnpassant.Appearance.Options.UseFont = true;
            this.lblEnpassant.Location = new System.Drawing.Point(220, 180);
            this.lblEnpassant.Name = "lblEnpassant";
            this.lblEnpassant.Size = new System.Drawing.Size(62, 24);
            this.lblEnpassant.TabIndex = 7;
            this.lblEnpassant.Text = "Không";
            // 
            // lblBKCastling
            // 
            this.lblBKCastling.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBKCastling.Appearance.Options.UseFont = true;
            this.lblBKCastling.Location = new System.Drawing.Point(220, 150);
            this.lblBKCastling.Name = "lblBKCastling";
            this.lblBKCastling.Size = new System.Drawing.Size(62, 24);
            this.lblBKCastling.TabIndex = 6;
            this.lblBKCastling.Text = "Không";
            // 
            // lblBQCastling
            // 
            this.lblBQCastling.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBQCastling.Appearance.Options.UseFont = true;
            this.lblBQCastling.Location = new System.Drawing.Point(228, 120);
            this.lblBQCastling.Name = "lblBQCastling";
            this.lblBQCastling.Size = new System.Drawing.Size(26, 24);
            this.lblBQCastling.TabIndex = 5;
            this.lblBQCastling.Text = "Có";
            // 
            // lblWKCastling
            // 
            this.lblWKCastling.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWKCastling.Appearance.Options.UseFont = true;
            this.lblWKCastling.Location = new System.Drawing.Point(253, 90);
            this.lblWKCastling.Name = "lblWKCastling";
            this.lblWKCastling.Size = new System.Drawing.Size(62, 24);
            this.lblWKCastling.TabIndex = 4;
            this.lblWKCastling.Text = "Không";
            // 
            // lblWQCastling
            // 
            this.lblWQCastling.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWQCastling.Appearance.Options.UseFont = true;
            this.lblWQCastling.Location = new System.Drawing.Point(253, 60);
            this.lblWQCastling.Name = "lblWQCastling";
            this.lblWQCastling.Size = new System.Drawing.Size(26, 24);
            this.lblWQCastling.TabIndex = 3;
            this.lblWQCastling.Text = "Có";
            // 
            // lblType
            // 
            this.lblType.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Appearance.Options.UseFont = true;
            this.lblType.Location = new System.Drawing.Point(150, 30);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(154, 24);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Mate in 2 Moves";
            // 
            // lblWhoMove
            // 
            this.lblWhoMove.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhoMove.Appearance.Options.UseFont = true;
            this.lblWhoMove.Location = new System.Drawing.Point(207, 90);
            this.lblWhoMove.Name = "lblWhoMove";
            this.lblWhoMove.Size = new System.Drawing.Size(55, 24);
            this.lblWhoMove.TabIndex = 1;
            this.lblWhoMove.Text = "Trắng";
            // 
            // lblOwnSide
            // 
            this.lblOwnSide.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnSide.Appearance.Options.UseFont = true;
            this.lblOwnSide.Location = new System.Drawing.Point(208, 60);
            this.lblOwnSide.Name = "lblOwnSide";
            this.lblOwnSide.Size = new System.Drawing.Size(55, 24);
            this.lblOwnSide.TabIndex = 0;
            this.lblOwnSide.Text = "Trắng";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Cyan;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(10, 210);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 24);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Chỉ Số:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Cyan;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(10, 180);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(194, 24);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Bắt Tốt Qua Đường:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Cyan;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(10, 150);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(220, 24);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Nhập Thành Đen (Vua):";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Cyan;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(10, 120);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(222, 24);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Nhập Thành Đen (Hậu):";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Cyan;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(10, 90);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(238, 24);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "Nhập Thành Trắng (Vua):";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Cyan;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(10, 60);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(240, 24);
            this.labelControl6.TabIndex = 14;
            this.labelControl6.Text = "Nhập Thành Trắng (Hậu):";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Cyan;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(10, 30);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(125, 24);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "Loại Bài Tập:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Cyan;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(10, 60);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(130, 24);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "Bên Của Bạn:";
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupControl2.Appearance.Options.UseBorderColor = true;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl2.Controls.Add(this.btnExit);
            this.groupControl2.Controls.Add(this.buttonX1);
            this.groupControl2.Controls.Add(this.btnBoard);
            this.groupControl2.Controls.Add(this.btnSelectGame);
            this.groupControl2.Controls.Add(this.btnTrainingOptions);
            this.groupControl2.Controls.Add(this.btnTryAgain);
            this.groupControl2.Controls.Add(this.btnUndo);
            this.groupControl2.Controls.Add(this.btnPre);
            this.groupControl2.Controls.Add(this.btnNext);
            this.groupControl2.Location = new System.Drawing.Point(578, 268);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(300, 304);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Chức Năng";
            // 
            // btnExit
            // 
            this.btnExit.Appearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnExit.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.ForeColor = System.Drawing.Color.Cyan;
            this.btnExit.Appearance.Options.UseBorderColor = true;
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Appearance.Options.UseForeColor = true;
            this.btnExit.AppearancePressed.BorderColor = System.Drawing.Color.Cyan;
            this.btnExit.AppearancePressed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.btnExit.AppearancePressed.Options.UseBorderColor = true;
            this.btnExit.AppearancePressed.Options.UseFont = true;
            this.btnExit.AppearancePressed.Options.UseForeColor = true;
            this.btnExit.Location = new System.Drawing.Point(107, 249);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 32);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.Appearance.BorderColor = System.Drawing.Color.Cyan;
            this.buttonX1.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Appearance.ForeColor = System.Drawing.Color.Cyan;
            this.buttonX1.Appearance.Options.UseBorderColor = true;
            this.buttonX1.Appearance.Options.UseFont = true;
            this.buttonX1.Appearance.Options.UseForeColor = true;
            this.buttonX1.AppearancePressed.BorderColor = System.Drawing.Color.Cyan;
            this.buttonX1.AppearancePressed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.buttonX1.AppearancePressed.Options.UseBorderColor = true;
            this.buttonX1.AppearancePressed.Options.UseFont = true;
            this.buttonX1.AppearancePressed.Options.UseForeColor = true;
            this.buttonX1.Location = new System.Drawing.Point(170, 193);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(95, 32);
            this.buttonX1.TabIndex = 8;
            this.buttonX1.Text = "Sao Chép FEN";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btnBoard
            // 
            this.btnBoard.Appearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnBoard.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoard.Appearance.ForeColor = System.Drawing.Color.Cyan;
            this.btnBoard.Appearance.Options.UseBorderColor = true;
            this.btnBoard.Appearance.Options.UseFont = true;
            this.btnBoard.Appearance.Options.UseForeColor = true;
            this.btnBoard.AppearancePressed.BorderColor = System.Drawing.Color.Cyan;
            this.btnBoard.AppearancePressed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoard.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.btnBoard.AppearancePressed.Options.UseBorderColor = true;
            this.btnBoard.AppearancePressed.Options.UseFont = true;
            this.btnBoard.AppearancePressed.Options.UseForeColor = true;
            this.btnBoard.Location = new System.Drawing.Point(47, 193);
            this.btnBoard.Name = "btnBoard";
            this.btnBoard.Size = new System.Drawing.Size(95, 32);
            this.btnBoard.TabIndex = 7;
            this.btnBoard.Text = "Bàn Cờ Tạm";
            this.btnBoard.DoubleClick += new System.EventHandler(this.btnBoard_Click);
            // 
            // btnSelectGame
            // 
            this.btnSelectGame.Appearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnSelectGame.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectGame.Appearance.ForeColor = System.Drawing.Color.Cyan;
            this.btnSelectGame.Appearance.Options.UseBorderColor = true;
            this.btnSelectGame.Appearance.Options.UseFont = true;
            this.btnSelectGame.Appearance.Options.UseForeColor = true;
            this.btnSelectGame.AppearancePressed.BorderColor = System.Drawing.Color.Cyan;
            this.btnSelectGame.AppearancePressed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectGame.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.btnSelectGame.AppearancePressed.Options.UseBorderColor = true;
            this.btnSelectGame.AppearancePressed.Options.UseFont = true;
            this.btnSelectGame.AppearancePressed.Options.UseForeColor = true;
            this.btnSelectGame.Location = new System.Drawing.Point(170, 143);
            this.btnSelectGame.Name = "btnSelectGame";
            this.btnSelectGame.Size = new System.Drawing.Size(95, 32);
            this.btnSelectGame.TabIndex = 6;
            this.btnSelectGame.Text = "Chọn Bài Tập";
            this.btnSelectGame.Click += new System.EventHandler(this.btnSelectGame_Click);
            // 
            // btnTrainingOptions
            // 
            this.btnTrainingOptions.Appearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnTrainingOptions.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainingOptions.Appearance.ForeColor = System.Drawing.Color.Cyan;
            this.btnTrainingOptions.Appearance.Options.UseBorderColor = true;
            this.btnTrainingOptions.Appearance.Options.UseFont = true;
            this.btnTrainingOptions.Appearance.Options.UseForeColor = true;
            this.btnTrainingOptions.AppearancePressed.BorderColor = System.Drawing.Color.Cyan;
            this.btnTrainingOptions.AppearancePressed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrainingOptions.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.btnTrainingOptions.AppearancePressed.Options.UseBorderColor = true;
            this.btnTrainingOptions.AppearancePressed.Options.UseFont = true;
            this.btnTrainingOptions.AppearancePressed.Options.UseForeColor = true;
            this.btnTrainingOptions.Location = new System.Drawing.Point(47, 143);
            this.btnTrainingOptions.Name = "btnTrainingOptions";
            this.btnTrainingOptions.Size = new System.Drawing.Size(95, 32);
            this.btnTrainingOptions.TabIndex = 5;
            this.btnTrainingOptions.Text = "Tùy Chọn";
            this.btnTrainingOptions.Click += new System.EventHandler(this.btnTrainingOptions_Click);
            // 
            // btnTryAgain
            // 
            this.btnTryAgain.Appearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnTryAgain.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTryAgain.Appearance.ForeColor = System.Drawing.Color.Cyan;
            this.btnTryAgain.Appearance.Options.UseBorderColor = true;
            this.btnTryAgain.Appearance.Options.UseFont = true;
            this.btnTryAgain.Appearance.Options.UseForeColor = true;
            this.btnTryAgain.AppearancePressed.BorderColor = System.Drawing.Color.Cyan;
            this.btnTryAgain.AppearancePressed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTryAgain.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.btnTryAgain.AppearancePressed.Options.UseBorderColor = true;
            this.btnTryAgain.AppearancePressed.Options.UseFont = true;
            this.btnTryAgain.AppearancePressed.Options.UseForeColor = true;
            this.btnTryAgain.Location = new System.Drawing.Point(0, 90);
            this.btnTryAgain.Name = "btnTryAgain";
            this.btnTryAgain.Size = new System.Drawing.Size(95, 32);
            this.btnTryAgain.TabIndex = 4;
            this.btnTryAgain.Text = "Thử Lại";
            this.btnTryAgain.Click += new System.EventHandler(this.btnTryAgain_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Appearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnUndo.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.Appearance.ForeColor = System.Drawing.Color.Cyan;
            this.btnUndo.Appearance.Options.UseBorderColor = true;
            this.btnUndo.Appearance.Options.UseFont = true;
            this.btnUndo.Appearance.Options.UseForeColor = true;
            this.btnUndo.AppearancePressed.BorderColor = System.Drawing.Color.Cyan;
            this.btnUndo.AppearancePressed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.btnUndo.AppearancePressed.Options.UseBorderColor = true;
            this.btnUndo.AppearancePressed.Options.UseFont = true;
            this.btnUndo.AppearancePressed.Options.UseForeColor = true;
            this.btnUndo.Location = new System.Drawing.Point(200, 90);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(95, 32);
            this.btnUndo.TabIndex = 3;
            this.btnUndo.Text = "Hoàn Tác";
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnPre
            // 
            this.btnPre.Appearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnPre.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPre.Appearance.ForeColor = System.Drawing.Color.Cyan;
            this.btnPre.Appearance.Options.UseBorderColor = true;
            this.btnPre.Appearance.Options.UseFont = true;
            this.btnPre.Appearance.Options.UseForeColor = true;
            this.btnPre.AppearancePressed.BorderColor = System.Drawing.Color.Cyan;
            this.btnPre.AppearancePressed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPre.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.btnPre.AppearancePressed.Options.UseBorderColor = true;
            this.btnPre.AppearancePressed.Options.UseFont = true;
            this.btnPre.AppearancePressed.Options.UseForeColor = true;
            this.btnPre.Location = new System.Drawing.Point(151, 38);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(95, 32);
            this.btnPre.TabIndex = 1;
            this.btnPre.Text = "Trước";
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnNext
            // 
            this.btnNext.Appearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnNext.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Appearance.ForeColor = System.Drawing.Color.Cyan;
            this.btnNext.Appearance.Options.UseBorderColor = true;
            this.btnNext.Appearance.Options.UseFont = true;
            this.btnNext.Appearance.Options.UseForeColor = true;
            this.btnNext.AppearancePressed.BorderColor = System.Drawing.Color.Cyan;
            this.btnNext.AppearancePressed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.btnNext.AppearancePressed.Options.UseBorderColor = true;
            this.btnNext.AppearancePressed.Options.UseFont = true;
            this.btnNext.AppearancePressed.Options.UseForeColor = true;
            this.btnNext.Location = new System.Drawing.Point(47, 38);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(95, 32);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Tiếp";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // FrmTraining
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmTraining";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Luyện Tập - Cờ vua";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTraining_FormClosing);
            this.Load += new System.EventHandler(this.frmTraining_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.ResumeLayout(false);

        }

        private DevExpress.XtraEditors.PanelControl panel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lblOwnSide;
        private DevExpress.XtraEditors.LabelControl lblWhoMove;
        private DevExpress.XtraEditors.LabelControl lblType;
        private DevExpress.XtraEditors.LabelControl lblWQCastling;
        private DevExpress.XtraEditors.LabelControl lblWKCastling;
        private DevExpress.XtraEditors.LabelControl lblBQCastling;
        private DevExpress.XtraEditors.LabelControl lblBKCastling;
        private DevExpress.XtraEditors.LabelControl lblEnpassant;
        private DevExpress.XtraEditors.LabelControl lblIndex;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnPre;
        private DevExpress.XtraEditors.SimpleButton btnUndo;
        private DevExpress.XtraEditors.SimpleButton btnTryAgain;
        private DevExpress.XtraEditors.SimpleButton btnTrainingOptions;
        private DevExpress.XtraEditors.SimpleButton btnSelectGame;
        private DevExpress.XtraEditors.SimpleButton btnBoard;
        private DevExpress.XtraEditors.SimpleButton buttonX1;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private System.Windows.Forms.Timer timerManageControl;
    }
}