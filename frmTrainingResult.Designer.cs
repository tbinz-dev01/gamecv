namespace ChessGame2.Forms
{
    partial class frmTrainingResult
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Location = new System.Drawing.Point(16, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(261, 22);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Bạn Đã Hoàn Thành Bài Tập";
            // 
            // btnNext
            // 
            this.btnNext.Appearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnNext.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Appearance.ForeColor = System.Drawing.Color.Cyan;
            this.btnNext.Appearance.Options.UseBorderColor = true;
            this.btnNext.Appearance.Options.UseFont = true;
            this.btnNext.Appearance.Options.UseForeColor = true;
            this.btnNext.AppearancePressed.BackColor = System.Drawing.Color.Cyan;
            this.btnNext.AppearancePressed.BackColor2 = System.Drawing.Color.Red;
            this.btnNext.AppearancePressed.BorderColor = System.Drawing.Color.Red;
            this.btnNext.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.btnNext.AppearancePressed.Options.UseBackColor = true;
            this.btnNext.AppearancePressed.Options.UseBorderColor = true;
            this.btnNext.AppearancePressed.Options.UseForeColor = true;
            this.btnNext.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnNext.Location = new System.Drawing.Point(50, 69);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(68, 30);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Tiếp Tục";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BorderColor = System.Drawing.Color.Cyan;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Cyan;
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.AppearancePressed.BackColor = System.Drawing.Color.Cyan;
            this.simpleButton1.AppearancePressed.BackColor2 = System.Drawing.Color.Red;
            this.simpleButton1.AppearancePressed.BorderColor = System.Drawing.Color.Red;
            this.simpleButton1.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.simpleButton1.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton1.AppearancePressed.Options.UseBorderColor = true;
            this.simpleButton1.AppearancePressed.Options.UseForeColor = true;
            this.simpleButton1.Location = new System.Drawing.Point(170, 69);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(68, 30);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Xem Lại";
            this.simpleButton1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // frmTrainingResult
            // 
            this.ClientSize = new System.Drawing.Size(289, 111);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTrainingResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết Quả Luyện Tập ";
            this.Load += new System.EventHandler(this.frmTrainingResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}