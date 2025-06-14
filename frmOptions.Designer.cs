namespace ChessGame2.Forms
{
    partial class frmOptions
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
            if (disposing)
            {
                components?.Dispose();
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cboPieceStyle = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboBoardStyle = new DevExpress.XtraEditors.ComboBoxEdit();
            this.chkPlaySound = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.numCellSize = new DevExpress.XtraEditors.SpinEdit();
            this.numPieceSize = new DevExpress.XtraEditors.SpinEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPieceStyle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBoardStyle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPlaySound.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCellSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPieceSize.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.pictureEdit1);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.cboPieceStyle);
            this.groupControl1.Controls.Add(this.cboBoardStyle);
            this.groupControl1.Location = new System.Drawing.Point(13, 164);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(321, 227);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Bàn Cờ";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(12, 126);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(288, 96);
            this.pictureEdit1.TabIndex = 21;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 95);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(99, 21);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Kiểu Quân Cờ:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(12, 54);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(87, 21);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Kiểu Bàn Cờ:";
            // 
            // cboPieceStyle
            // 
            this.cboPieceStyle.Location = new System.Drawing.Point(128, 92);
            this.cboPieceStyle.Name = "cboPieceStyle";
            this.cboPieceStyle.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboPieceStyle.Properties.Appearance.Options.UseFont = true;
            this.cboPieceStyle.Properties.DropDownRows = 5;
            this.cboPieceStyle.Properties.Items.AddRange(new object[] {
            "Classic 1",
            "Classic 2",
            "Wooden",
            "Plastic",
            "DotA"});
            this.cboPieceStyle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboPieceStyle.Size = new System.Drawing.Size(175, 28);
            this.cboPieceStyle.TabIndex = 0;
            this.cboPieceStyle.SelectedIndexChanged += new System.EventHandler(this.cboBoardStyle_SelectedIndexChanged);
            // 
            // cboBoardStyle
            // 
            this.cboBoardStyle.Location = new System.Drawing.Point(128, 47);
            this.cboBoardStyle.Name = "cboBoardStyle";
            this.cboBoardStyle.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboBoardStyle.Properties.Appearance.Options.UseFont = true;
            this.cboBoardStyle.Properties.Items.AddRange(new object[] {
            "Wooden",
            "Metal",
            "Blue Marble",
            "Tan Marble",
            "Green Marble",
            "Granit",
            "Brick"});
            this.cboBoardStyle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboBoardStyle.Size = new System.Drawing.Size(175, 28);
            this.cboBoardStyle.TabIndex = 0;
            this.cboBoardStyle.SelectedIndexChanged += new System.EventHandler(this.cboBoardStyle_SelectedIndexChanged);
            // 
            // chkPlaySound
            // 
            this.chkPlaySound.Location = new System.Drawing.Point(13, 397);
            this.chkPlaySound.Name = "chkPlaySound";
            this.chkPlaySound.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.chkPlaySound.Properties.Appearance.Options.UseFont = true;
            this.chkPlaySound.Properties.Caption = "Âm Thanh";
            this.chkPlaySound.Size = new System.Drawing.Size(92, 25);
            this.chkPlaySound.TabIndex = 12;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(13, 59);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(119, 21);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Kích Thước Ô Cờ:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(13, 101);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(145, 21);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Kích Thước Quân Cờ:";
            // 
            // numCellSize
            // 
            this.numCellSize.EditValue = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numCellSize.Location = new System.Drawing.Point(204, 54);
            this.numCellSize.Name = "numCellSize";
            this.numCellSize.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.numCellSize.Properties.Appearance.Options.UseFont = true;
            this.numCellSize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.numCellSize.Properties.MaxValue = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.numCellSize.Properties.MinValue = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numCellSize.Size = new System.Drawing.Size(112, 28);
            this.numCellSize.TabIndex = 15;
            this.numCellSize.EditValueChanged += new System.EventHandler(this.numCellSize_ValueChanged);
            // 
            // numPieceSize
            // 
            this.numPieceSize.EditValue = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numPieceSize.Location = new System.Drawing.Point(204, 96);
            this.numPieceSize.Name = "numPieceSize";
            this.numPieceSize.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.numPieceSize.Properties.Appearance.Options.UseFont = true;
            this.numPieceSize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.numPieceSize.Properties.MaxValue = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.numPieceSize.Properties.MinValue = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numPieceSize.Size = new System.Drawing.Size(112, 28);
            this.numPieceSize.TabIndex = 16;
            this.numPieceSize.EditValueChanged += new System.EventHandler(this.numPieceSize_ValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSave.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSave.Appearance.Options.UseBackColor = true;
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Appearance.Options.UseForeColor = true;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(154, 399);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 28);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Lưu Lại";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(202)))), ((int)(((byte)(249)))));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancel.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Appearance.Options.UseBackColor = true;
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Appearance.Options.UseForeColor = true;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(254, 399);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 28);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Hủy Bỏ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(85, 1);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(168, 30);
            this.labelControl5.TabIndex = 19;
            this.labelControl5.Text = "Tùy Chọn Bàn Cờ";
            // 
            // frmOptions
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 440);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numPieceSize);
            this.Controls.Add(this.numCellSize);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.chkPlaySound);
            this.Controls.Add(this.groupControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmOptions";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tùy Chọn Bàn Cờ";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPieceStyle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBoardStyle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPlaySound.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCellSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPieceSize.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit chkPlaySound;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SpinEdit numCellSize;
        private DevExpress.XtraEditors.SpinEdit numPieceSize;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cboBoardStyle;
        private DevExpress.XtraEditors.ComboBoxEdit cboPieceStyle;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}