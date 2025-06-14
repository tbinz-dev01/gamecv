using DevExpress.DataProcessing;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;


namespace ChessGame2.Forms
{
    partial class frmGameOptions : XtraForm
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
            this.grOptionGame = new DevExpress.XtraEditors.GroupControl();
            this.cboUndo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelX7 = new DevExpress.XtraEditors.LabelControl();
            this.labelX8 = new DevExpress.XtraEditors.LabelControl();
            this.cboExtraTimer = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelX6 = new DevExpress.XtraEditors.LabelControl();
            this.cboMoveTimer = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelX5 = new DevExpress.XtraEditors.LabelControl();
            this.labelX3 = new DevExpress.XtraEditors.LabelControl();
            this.cboTotalTimer = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelX2 = new DevExpress.XtraEditors.LabelControl();
            this.labelX4 = new DevExpress.XtraEditors.LabelControl();
            this.labelX1 = new DevExpress.XtraEditors.LabelControl();
            this.radWhite = new System.Windows.Forms.RadioButton();
            this.radBlack = new System.Windows.Forms.RadioButton();
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.button1 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureBox1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grOptionGame)).BeginInit();
            this.grOptionGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboUndo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboExtraTimer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMoveTimer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTotalTimer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grOptionGame
            // 
            this.grOptionGame.Controls.Add(this.cboUndo);
            this.grOptionGame.Controls.Add(this.labelX7);
            this.grOptionGame.Controls.Add(this.labelX8);
            this.grOptionGame.Controls.Add(this.cboExtraTimer);
            this.grOptionGame.Controls.Add(this.labelX6);
            this.grOptionGame.Controls.Add(this.cboMoveTimer);
            this.grOptionGame.Controls.Add(this.labelX5);
            this.grOptionGame.Controls.Add(this.labelX3);
            this.grOptionGame.Controls.Add(this.cboTotalTimer);
            this.grOptionGame.Controls.Add(this.labelX2);
            this.grOptionGame.Controls.Add(this.labelX4);
            this.grOptionGame.Controls.Add(this.labelX1);
            this.grOptionGame.Controls.Add(this.pictureBox2);
            this.grOptionGame.Controls.Add(this.pictureBox1);
            this.grOptionGame.Controls.Add(this.radWhite);
            this.grOptionGame.Controls.Add(this.radBlack);
            this.grOptionGame.Enabled = false;
            this.grOptionGame.Location = new System.Drawing.Point(14, 22);
            this.grOptionGame.Name = "grOptionGame";
            this.grOptionGame.Size = new System.Drawing.Size(315, 294);
            this.grOptionGame.TabIndex = 12;
            this.grOptionGame.Text = "Tùy Chọn Trò Chơi";
            // 
            // cboUndo
            // 
            this.cboUndo.Location = new System.Drawing.Point(160, 246);
            this.cboUndo.Name = "cboUndo";
            this.cboUndo.Properties.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboUndo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor; // Equivalent to DropDownList
            this.cboUndo.Size = new System.Drawing.Size(92, 22);
            this.cboUndo.TabIndex = 18;
            // 
            // labelX7
            // 
            this.labelX7.Location = new System.Drawing.Point(270, 246);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(35, 15);
            this.labelX7.TabIndex = 19;
            this.labelX7.Text = "lần";
            // 
            // labelX8
            // 
            this.labelX8.AutoSize = true;
            this.labelX8.Location = new System.Drawing.Point(8, 248);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(102, 15);
            this.labelX8.TabIndex = 17;
            this.labelX8.Text = "Số lần được đi lại";
            // 
            // cboExtraTimer
            // 
            this.cboExtraTimer.Location = new System.Drawing.Point(160, 217);
            this.cboExtraTimer.Name = "cboExtraTimer";
            this.cboExtraTimer.Properties.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboExtraTimer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboExtraTimer.Size = new System.Drawing.Size(92, 22);
            this.cboExtraTimer.TabIndex = 15;
            // 
            // labelX6
            // 
            this.labelX6.Location = new System.Drawing.Point(270, 217);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(35, 15);
            this.labelX6.TabIndex = 16;
            this.labelX6.Text = "giây";
            // 
            // cboMoveTimer
            // 
            this.cboMoveTimer.Location = new System.Drawing.Point(160, 188);
            this.cboMoveTimer.Name = "cboMoveTimer";
            this.cboMoveTimer.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboMoveTimer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboMoveTimer.Size = new System.Drawing.Size(92, 22);
            this.cboMoveTimer.TabIndex = 13;
            // 
            // labelX5
            // 
            this.labelX5.Location = new System.Drawing.Point(270, 189);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(35, 15);
            this.labelX5.TabIndex = 14;
            this.labelX5.Text = "phút";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.Location = new System.Drawing.Point(8, 219);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(141, 15);
            this.labelX3.TabIndex = 12;
            this.labelX3.Text = "Thời gian thêm mỗi lượt";
            // 
            // cboTotalTimer
            // 
            this.cboTotalTimer.Location = new System.Drawing.Point(160, 159);
            this.cboTotalTimer.Name = "cboTotalTimer";
            this.cboTotalTimer.Properties.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "30",
            "40",
            "50",
            "60"});
            this.cboTotalTimer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboTotalTimer.Size = new System.Drawing.Size(92, 22);
            this.cboTotalTimer.TabIndex = 8;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(8, 191);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(108, 15);
            this.labelX2.TabIndex = 11;
            this.labelX2.Text = "Thời gian mỗi lượt";
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(270, 158);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(35, 15);
            this.labelX4.TabIndex = 10;
            this.labelX4.Text = "phút";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(8, 161);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(106, 15);
            this.labelX1.TabIndex = 10;
            this.labelX1.Text = "Thời gian ván đấu";
            // 
            // radWhite
            // 
            this.radWhite.Location = new System.Drawing.Point(25, 116);
            this.radWhite.Name = "radWhite";
            this.radWhite.Size = new System.Drawing.Size(93, 20);
            this.radWhite.TabIndex = 0;
            this.radWhite.Text = "Quân Trắng";
            // 
            // radBlack
            // 
            this.radBlack.Location = new System.Drawing.Point(178, 116);
            this.radBlack.Name = "radBlack";
            this.radBlack.Size = new System.Drawing.Size(82, 20);
            this.radBlack.TabIndex = 0;
            this.radBlack.Text = "Quân Đen";
            // 
            // btnStart
            // 
            //this.btnStart.Image = global::ChessGameGama.Properties.Resources.Apply;
            //this.btnStart.ImagePosition = DevExpress.XtraEditors.ImagePosition.Left;
            this.btnStart.Location = new System.Drawing.Point(215, 326);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(113, 36);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "&Đồng ý";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // button1
            // 
            //this.button1.Image = global::ChessGameGama.Properties.Resources.Pinion;
            //this.button1.ImagePosition = DevExpress.XtraEditors.ImagePosition.Left;
            this.button1.Location = new System.Drawing.Point(92, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "&Chỉnh sửa";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.EditValue = global::ChessGame2.Properties.Resources.Black_N;
            this.pictureBox2.Location = new System.Drawing.Point(188, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.EditValue = global::ChessGame2.Properties.Resources.White_N;
            this.pictureBox1.Location = new System.Drawing.Point(39, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 3;
            // 
            // frmGameOptions
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 376);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grOptionGame);
            this.Controls.Add(this.btnStart);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmGameOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tùy Chọn Trò Chơi";
            this.Load += new System.EventHandler(this.FrmOptionGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grOptionGame)).EndInit();
            this.grOptionGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboUndo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboExtraTimer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboMoveTimer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTotalTimer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1.Properties)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grOptionGame;
        private System.Windows.Forms.RadioButton radWhite;
        private System.Windows.Forms.RadioButton radBlack;
        private DevExpress.XtraEditors.SimpleButton btnStart;
        private DevExpress.XtraEditors.PictureEdit pictureBox1;
        private DevExpress.XtraEditors.PictureEdit pictureBox2;
        private DevExpress.XtraEditors.SimpleButton button1;
        private DevExpress.XtraEditors.LabelControl labelX3;
        private DevExpress.XtraEditors.LabelControl labelX2;
        private DevExpress.XtraEditors.LabelControl labelX1;
        private DevExpress.XtraEditors.LabelControl labelX4;
        private DevExpress.XtraEditors.ComboBoxEdit cboExtraTimer;
        private DevExpress.XtraEditors.LabelControl labelX6;
        private DevExpress.XtraEditors.ComboBoxEdit cboMoveTimer;
        private DevExpress.XtraEditors.LabelControl labelX5;
        private DevExpress.XtraEditors.ComboBoxEdit cboUndo;
        private DevExpress.XtraEditors.LabelControl labelX7;
        private DevExpress.XtraEditors.LabelControl labelX8;
        private DevExpress.XtraEditors.ComboBoxEdit cboTotalTimer;
    }
}