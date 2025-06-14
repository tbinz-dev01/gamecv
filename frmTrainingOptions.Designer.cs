using ChessGame2.UserControls;

namespace ChessGame2.Forms
{
    partial class frmTrainingOptions
    {
        private void InitializeComponent()
        {
            this.chkEndGame = new DevExpress.XtraEditors.CheckEdit();
            this.chkMate3 = new DevExpress.XtraEditors.CheckEdit();
            this.chkMate1 = new DevExpress.XtraEditors.CheckEdit();
            this.chkMate2 = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.chkRandom = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnBegin = new DevExpress.XtraEditors.SimpleButton();
            this.radioGroupSide = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.chkEndGame.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMate3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMate2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkRandom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupSide.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // chkEndGame
            // 
            this.chkEndGame.EditValue = "Y";
            this.chkEndGame.Location = new System.Drawing.Point(7, 45);
            this.chkEndGame.Name = "chkEndGame";
            this.chkEndGame.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.chkEndGame.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEndGame.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.chkEndGame.Properties.Appearance.Options.UseBackColor = true;
            this.chkEndGame.Properties.Appearance.Options.UseFont = true;
            this.chkEndGame.Properties.Appearance.Options.UseForeColor = true;
            this.chkEndGame.Properties.Caption = "Tàn Cuộc Luyện Tập";
            this.chkEndGame.Properties.ValueChecked = "Y";
            this.chkEndGame.Properties.ValueUnchecked = "N";
            this.chkEndGame.Size = new System.Drawing.Size(172, 23);
            this.chkEndGame.TabIndex = 0;
            // 
            // chkMate3
            // 
            this.chkMate3.EditValue = "Y";
            this.chkMate3.Location = new System.Drawing.Point(187, 76);
            this.chkMate3.Name = "chkMate3";
            this.chkMate3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.chkMate3.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMate3.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.chkMate3.Properties.Appearance.Options.UseBackColor = true;
            this.chkMate3.Properties.Appearance.Options.UseFont = true;
            this.chkMate3.Properties.Appearance.Options.UseForeColor = true;
            this.chkMate3.Properties.Caption = "Chiếu Bí Trong 3 Nước";
            this.chkMate3.Properties.ValueChecked = "Y";
            this.chkMate3.Properties.ValueUnchecked = "N";
            this.chkMate3.Size = new System.Drawing.Size(187, 23);
            this.chkMate3.TabIndex = 1;
            // 
            // chkMate1
            // 
            this.chkMate1.EditValue = "Y";
            this.chkMate1.Location = new System.Drawing.Point(187, 45);
            this.chkMate1.Name = "chkMate1";
            this.chkMate1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.chkMate1.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMate1.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.chkMate1.Properties.Appearance.Options.UseBackColor = true;
            this.chkMate1.Properties.Appearance.Options.UseFont = true;
            this.chkMate1.Properties.Appearance.Options.UseForeColor = true;
            this.chkMate1.Properties.Caption = "Chiếu Bí Trong 1 Nước";
            this.chkMate1.Properties.ValueChecked = "Y";
            this.chkMate1.Properties.ValueUnchecked = "N";
            this.chkMate1.Size = new System.Drawing.Size(187, 23);
            this.chkMate1.TabIndex = 2;
            // 
            // chkMate2
            // 
            this.chkMate2.EditValue = "Y";
            this.chkMate2.Location = new System.Drawing.Point(5, 76);
            this.chkMate2.Name = "chkMate2";
            this.chkMate2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.chkMate2.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMate2.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.chkMate2.Properties.Appearance.Options.UseBackColor = true;
            this.chkMate2.Properties.Appearance.Options.UseFont = true;
            this.chkMate2.Properties.Appearance.Options.UseForeColor = true;
            this.chkMate2.Properties.Caption = "Chiếu Bí Trong 2 Nước";
            this.chkMate2.Properties.ValueChecked = "Y";
            this.chkMate2.Properties.ValueUnchecked = "N";
            this.chkMate2.Size = new System.Drawing.Size(182, 23);
            this.chkMate2.TabIndex = 3;
            // 
            // groupControl1
            // 
            this.groupControl1.AllowHtmlText = true;
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupControl1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupControl1.Appearance.ForeColor = System.Drawing.Color.Aqua;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Appearance.Options.UseBorderColor = true;
            this.groupControl1.Appearance.Options.UseForeColor = true;
            this.groupControl1.AppearanceCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Aqua;
            this.groupControl1.AppearanceCaption.Options.UseBackColor = true;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.groupControl1.Controls.Add(this.chkMate1);
            this.groupControl1.Controls.Add(this.chkMate2);
            this.groupControl1.Controls.Add(this.chkEndGame);
            this.groupControl1.Controls.Add(this.chkMate3);
            this.groupControl1.Location = new System.Drawing.Point(12, 73);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(374, 106);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Loại Bài Tập";
            // 
            // chkRandom
            // 
            this.chkRandom.EditValue = "Y";
            this.chkRandom.Location = new System.Drawing.Point(107, 185);
            this.chkRandom.Name = "chkRandom";
            this.chkRandom.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRandom.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.chkRandom.Properties.Appearance.Options.UseFont = true;
            this.chkRandom.Properties.Appearance.Options.UseForeColor = true;
            this.chkRandom.Properties.Caption = "Xáo Trộn Bài Tập";
            this.chkRandom.Properties.ValueChecked = "Y";
            this.chkRandom.Properties.ValueUnchecked = "N";
            this.chkRandom.Size = new System.Drawing.Size(160, 23);
            this.chkRandom.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(96, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(197, 32);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Tùy Chọn Bài Tập";
            // 
            // btnBegin
            // 
            this.btnBegin.Appearance.BackColor2 = System.Drawing.Color.Aqua;
            this.btnBegin.Appearance.BorderColor = System.Drawing.Color.Red;
            this.btnBegin.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBegin.Appearance.ForeColor = System.Drawing.Color.Cyan;
            this.btnBegin.Appearance.Options.UseBorderColor = true;
            this.btnBegin.Appearance.Options.UseFont = true;
            this.btnBegin.Appearance.Options.UseForeColor = true;
            this.btnBegin.AppearancePressed.BackColor = System.Drawing.Color.Aqua;
            this.btnBegin.AppearancePressed.BorderColor = System.Drawing.Color.Aqua;
            this.btnBegin.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.btnBegin.AppearancePressed.Options.UseBackColor = true;
            this.btnBegin.AppearancePressed.Options.UseBorderColor = true;
            this.btnBegin.AppearancePressed.Options.UseForeColor = true;
            this.btnBegin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBegin.Location = new System.Drawing.Point(150, 266);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(75, 32);
            this.btnBegin.TabIndex = 8;
            this.btnBegin.Text = "Bắt Đầu";
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // radioGroupSide
            // 
            this.radioGroupSide.EditValue = ChessGame2.UserControls.ChessSide.White;
            this.radioGroupSide.Location = new System.Drawing.Point(96, 216);
            this.radioGroupSide.Name = "radioGroupSide";
            this.radioGroupSide.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroupSide.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGroupSide.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.radioGroupSide.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroupSide.Properties.Appearance.Options.UseFont = true;
            this.radioGroupSide.Properties.Appearance.Options.UseForeColor = true;
            this.radioGroupSide.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(ChessGame2.UserControls.ChessSide.White, "Trắng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(ChessGame2.UserControls.ChessSide.Black, "Đen")});
            this.radioGroupSide.Size = new System.Drawing.Size(189, 38);
            this.radioGroupSide.TabIndex = 6;
            this.radioGroupSide.SelectedIndexChanged += new System.EventHandler(this.radioGroupSide_SelectedIndexChanged);
            // 
            // frmTrainingOptions
            // 
            this.AcceptButton = this.btnBegin;
            this.ClientSize = new System.Drawing.Size(405, 310);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.radioGroupSide);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.chkRandom);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmTrainingOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tùy Chọn Bài Tập ";
            this.Load += new System.EventHandler(this.frmTrainingOptions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chkEndGame.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMate3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkMate2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkRandom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupSide.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private DevExpress.XtraEditors.CheckEdit chkEndGame;
        private DevExpress.XtraEditors.CheckEdit chkMate3;
        private DevExpress.XtraEditors.CheckEdit chkMate1;
        private DevExpress.XtraEditors.CheckEdit chkMate2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit chkRandom;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnBegin;
        private DevExpress.XtraEditors.RadioGroup radioGroupSide; // New field for RadioGroup
    }
}