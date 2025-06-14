using ChessGame2.UserControls;
namespace ChessGame2.Forms
{
    partial class frmLanGame
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblstatus = new DevExpress.XtraEditors.LabelControl();
            this.lstChatBox = new System.Windows.Forms.ListBox();
            this.txtchat = new System.Windows.Forms.TextBox();
            this.btnChat = new System.Windows.Forms.Button();
            this.lblloi = new System.Windows.Forms.Label();
            this.grbPlay = new System.Windows.Forms.GroupBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnLose = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.pnlHistory = new System.Windows.Forms.Panel();
            this.pnlCapturedPiece2 = new System.Windows.Forms.Panel();
            this.pnlCapturedPiece1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSitting = new System.Windows.Forms.Button();
            this.btnkichout = new System.Windows.Forms.Button();
            this.btnSanSang = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.ucOppProfile = new ChessGame2.UcProfile();
            this.ucMyProfile = new ChessGame2.UcProfile();
            this.txtServerIp = new System.Windows.Forms.TextBox();
            this.btnConnectManually = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbPlay.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(168, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 460);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ChessGame2.Properties.Resources.unnamed1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 460);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblstatus
            // 
            this.lblstatus.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Appearance.Options.UseFont = true;
            this.lblstatus.Location = new System.Drawing.Point(172, 497);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(57, 14);
            this.lblstatus.TabIndex = 33;
            this.lblstatus.Text = "lblStatus";
            // 
            // lstChatBox
            // 
            this.lstChatBox.BackColor = System.Drawing.SystemColors.Window;
            this.lstChatBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lstChatBox.ItemHeight = 14;
            this.lstChatBox.Location = new System.Drawing.Point(169, 523);
            this.lstChatBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstChatBox.Name = "lstChatBox";
            this.lstChatBox.Size = new System.Drawing.Size(459, 60);
            this.lstChatBox.TabIndex = 4;
            // 
            // txtchat
            // 
            this.txtchat.Location = new System.Drawing.Point(169, 591);
            this.txtchat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtchat.Name = "txtchat";
            this.txtchat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtchat.Size = new System.Drawing.Size(395, 22);
            this.txtchat.TabIndex = 6;
            // 
            // btnChat
            // 
            this.btnChat.Location = new System.Drawing.Point(570, 589);
            this.btnChat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(58, 24);
            this.btnChat.TabIndex = 7;
            this.btnChat.Text = "Gửi  Tin";
            this.btnChat.UseVisualStyleBackColor = true;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // lblloi
            // 
            this.lblloi.Location = new System.Drawing.Point(0, 0);
            this.lblloi.Name = "lblloi";
            this.lblloi.Size = new System.Drawing.Size(100, 23);
            this.lblloi.TabIndex = 33;
            // 
            // grbPlay
            // 
            this.grbPlay.Controls.Add(this.btnNew);
            this.grbPlay.Controls.Add(this.btnLose);
            this.grbPlay.Controls.Add(this.btnDraw);
            this.grbPlay.Controls.Add(this.btnUndo);
            this.grbPlay.Enabled = false;
            this.grbPlay.Location = new System.Drawing.Point(744, 361);
            this.grbPlay.Name = "grbPlay";
            this.grbPlay.Size = new System.Drawing.Size(188, 117);
            this.grbPlay.TabIndex = 32;
            this.grbPlay.TabStop = false;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(99, 70);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(80, 35);
            this.btnNew.TabIndex = 32;
            this.btnNew.Text = "Chơi Lại";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnLose
            // 
            this.btnLose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLose.Location = new System.Drawing.Point(9, 70);
            this.btnLose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLose.Name = "btnLose";
            this.btnLose.Size = new System.Drawing.Size(80, 35);
            this.btnLose.TabIndex = 31;
            this.btnLose.Text = "Chịu Thua";
            this.btnLose.UseVisualStyleBackColor = true;
            this.btnLose.Click += new System.EventHandler(this.btnLose_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDraw.Location = new System.Drawing.Point(99, 22);
            this.btnDraw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(80, 35);
            this.btnDraw.TabIndex = 30;
            this.btnDraw.Text = "Xin Hòa";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUndo.Location = new System.Drawing.Point(9, 22);
            this.btnUndo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(80, 35);
            this.btnUndo.TabIndex = 29;
            this.btnUndo.Text = "Xin Đi Lại";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // pnlHistory
            // 
            this.pnlHistory.BackColor = System.Drawing.Color.White;
            this.pnlHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHistory.Location = new System.Drawing.Point(744, 84);
            this.pnlHistory.Name = "pnlHistory";
            this.pnlHistory.Size = new System.Drawing.Size(178, 265);
            this.pnlHistory.TabIndex = 36;
            this.pnlHistory.Visible = false;
            // 
            // pnlCapturedPiece2
            // 
            this.pnlCapturedPiece2.BackColor = System.Drawing.Color.White;
            this.pnlCapturedPiece2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCapturedPiece2.Location = new System.Drawing.Point(647, 261);
            this.pnlCapturedPiece2.Name = "pnlCapturedPiece2";
            this.pnlCapturedPiece2.Size = new System.Drawing.Size(48, 231);
            this.pnlCapturedPiece2.TabIndex = 35;
            this.pnlCapturedPiece2.Visible = false;
            // 
            // pnlCapturedPiece1
            // 
            this.pnlCapturedPiece1.BackColor = System.Drawing.Color.White;
            this.pnlCapturedPiece1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCapturedPiece1.Location = new System.Drawing.Point(646, 8);
            this.pnlCapturedPiece1.Name = "pnlCapturedPiece1";
            this.pnlCapturedPiece1.Size = new System.Drawing.Size(48, 238);
            this.pnlCapturedPiece1.TabIndex = 34;
            this.pnlCapturedPiece1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(787, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 14);
            this.label1.TabIndex = 37;
            this.label1.Text = "Danh sách nước đi";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(843, 582);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 35);
            this.btnExit.TabIndex = 34;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSitting
            // 
            this.btnSitting.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSitting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSitting.Location = new System.Drawing.Point(753, 582);
            this.btnSitting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSitting.Name = "btnSitting";
            this.btnSitting.Size = new System.Drawing.Size(80, 35);
            this.btnSitting.TabIndex = 33;
            this.btnSitting.Text = "Cài Đặt";
            this.btnSitting.UseVisualStyleBackColor = true;
            this.btnSitting.Click += new System.EventHandler(this.btnSitting_Click);
            // 
            // btnkichout
            // 
            this.btnkichout.Enabled = false;
            this.btnkichout.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkichout.Location = new System.Drawing.Point(49, 281);
            this.btnkichout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnkichout.Name = "btnkichout";
            this.btnkichout.Size = new System.Drawing.Size(60, 27);
            this.btnkichout.TabIndex = 28;
            this.btnkichout.Text = "Mời ra";
            this.btnkichout.UseVisualStyleBackColor = true;
            this.btnkichout.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnSanSang
            // 
            this.btnSanSang.Enabled = false;
            this.btnSanSang.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanSang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSanSang.Location = new System.Drawing.Point(737, 13);
            this.btnSanSang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSanSang.Name = "btnSanSang";
            this.btnSanSang.Size = new System.Drawing.Size(92, 35);
            this.btnSanSang.TabIndex = 23;
            this.btnSanSang.Text = "Sẵn Sàng";
            this.btnSanSang.UseVisualStyleBackColor = true;
            this.btnSanSang.Click += new System.EventHandler(this.btnSanSang_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Enabled = false;
            this.btnPlay.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.Red;
            this.btnPlay.Location = new System.Drawing.Point(833, 13);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(89, 35);
            this.btnPlay.TabIndex = 31;
            this.btnPlay.Text = "Bắt Đầu";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // ucOppProfile
            // 
            this.ucOppProfile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ucOppProfile.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucOppProfile.Location = new System.Drawing.Point(0, 8);
            this.ucOppProfile.Name = "ucOppProfile";
            this.ucOppProfile.Profile = null;
            this.ucOppProfile.Size = new System.Drawing.Size(161, 266);
            this.ucOppProfile.TabIndex = 25;
            // 
            // ucMyProfile
            // 
            this.ucMyProfile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ucMyProfile.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMyProfile.Location = new System.Drawing.Point(0, 351);
            this.ucMyProfile.Name = "ucMyProfile";
            this.ucMyProfile.Profile = null;
            this.ucMyProfile.Size = new System.Drawing.Size(161, 266);
            this.ucMyProfile.TabIndex = 24;
            // 
            // txtServerIp
            // 
            this.txtServerIp.Location = new System.Drawing.Point(744, 497);
            this.txtServerIp.Multiline = true;
            this.txtServerIp.Name = "txtServerIp";
            this.txtServerIp.Size = new System.Drawing.Size(178, 22);
            this.txtServerIp.TabIndex = 38;
            this.txtServerIp.Text = "Nhập địa chỉ IP của máy chủ";
            // 
            // btnConnectManually
            // 
            this.btnConnectManually.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectManually.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnectManually.Location = new System.Drawing.Point(753, 539);
            this.btnConnectManually.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConnectManually.Name = "btnConnectManually";
            this.btnConnectManually.Size = new System.Drawing.Size(80, 35);
            this.btnConnectManually.TabIndex = 39;
            this.btnConnectManually.Text = "Kết nối ";
            this.btnConnectManually.UseVisualStyleBackColor = true;
            this.btnConnectManually.Click += new System.EventHandler(this.btnConnectManually_Click);
            // 
            // frmLanGame
            // 
            this.AcceptButton = this.btnChat;
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Appearance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 632);
            this.Controls.Add(this.btnConnectManually);
            this.Controls.Add(this.txtServerIp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSitting);
            this.Controls.Add(this.pnlHistory);
            this.Controls.Add(this.pnlCapturedPiece2);
            this.Controls.Add(this.pnlCapturedPiece1);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.grbPlay);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnkichout);
            this.Controls.Add(this.ucOppProfile);
            this.Controls.Add(this.ucMyProfile);
            this.Controls.Add(this.btnSanSang);
            this.Controls.Add(this.lblloi);
            this.Controls.Add(this.btnChat);
            this.Controls.Add(this.txtchat);
            this.Controls.Add(this.lstChatBox);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLanGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chơi Mạng LAN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLanGame_FormClosing);
            this.Load += new System.EventHandler(this.frmLanGame_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbPlay.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstChatBox;
        private System.Windows.Forms.TextBox txtchat;
        private System.Windows.Forms.Button btnChat;
        private System.Windows.Forms.Label lblloi;
        private System.Windows.Forms.Button btnSanSang;
        private System.Windows.Forms.Button btnkichout;
        private System.Windows.Forms.GroupBox grbPlay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl lblstatus;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnLose;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSitting;
        private System.Windows.Forms.Panel pnlHistory;
        private System.Windows.Forms.Panel pnlCapturedPiece2;
        private System.Windows.Forms.Panel pnlCapturedPiece1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlay;
        private ChessGame2.UcProfile ucMyProfile;
        private ChessGame2.UcProfile ucOppProfile;
        private System.Windows.Forms.TextBox txtServerIp;
        private System.Windows.Forms.Button btnConnectManually;
    }
}