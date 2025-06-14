using DevExpress.XtraEditors;
namespace ChessGame2.Forms
{
    partial class frmSelectGame
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
            this.labelX2 = new DevExpress.XtraEditors.LabelControl();
            this.radWhite = new System.Windows.Forms.RadioButton();
            this.radBlack = new System.Windows.Forms.RadioButton();
            this.groupPanel3 = new DevExpress.XtraEditors.GroupControl();
            this.btnBegin = new DevExpress.XtraEditors.SimpleButton();
            this.reflectionLabel1 = new DevExpress.XtraEditors.LabelControl();
            this.groupPanel1 = new DevExpress.XtraEditors.GroupControl();
            this.labelX6 = new DevExpress.XtraEditors.LabelControl();
            this.labelX7 = new DevExpress.XtraEditors.LabelControl();
            this.iTImeBonus = new DevExpress.XtraEditors.SpinEdit();
            this.labelX5 = new DevExpress.XtraEditors.LabelControl();
            this.labelX4 = new DevExpress.XtraEditors.LabelControl();
            this.iTimeLimit = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupPanel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTImeBonus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTimeLimit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX2
            // 
            this.labelX2.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Appearance.Options.UseFont = true;
            this.labelX2.Location = new System.Drawing.Point(6, 10);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(154, 22);
            this.labelX2.TabIndex = 15;
            this.labelX2.Text = "Bạn Chọn Quân:";
            // 
            // radWhite
            // 
            this.radWhite.AutoSize = true;
            this.radWhite.Checked = true;
            this.radWhite.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radWhite.Location = new System.Drawing.Point(125, 9);
            this.radWhite.Name = "radWhite";
            this.radWhite.Size = new System.Drawing.Size(75, 23);
            this.radWhite.TabIndex = 17;
            this.radWhite.TabStop = true;
            this.radWhite.Text = "Trắng";
            this.radWhite.UseVisualStyleBackColor = true;
            // 
            // radBlack
            // 
            this.radBlack.AutoSize = true;
            this.radBlack.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBlack.Location = new System.Drawing.Point(197, 8);
            this.radBlack.Name = "radBlack";
            this.radBlack.Size = new System.Drawing.Size(61, 23);
            this.radBlack.TabIndex = 18;
            this.radBlack.TabStop = true;
            this.radBlack.Text = "Đen";
            this.radBlack.UseVisualStyleBackColor = true;
            // 
            // groupPanel3
            // 
            this.groupPanel3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupPanel3.Controls.Add(this.labelX2);
            this.groupPanel3.Controls.Add(this.radWhite);
            this.groupPanel3.Controls.Add(this.radBlack);
            this.groupPanel3.Location = new System.Drawing.Point(16, 100);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(287, 42);
            this.groupPanel3.TabIndex = 20;
            // 
            // btnBegin
            // 
            this.btnBegin.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBegin.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnBegin.Appearance.Options.UseFont = true;
            this.btnBegin.Appearance.Options.UseForeColor = true;
            this.btnBegin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBegin.Location = new System.Drawing.Point(97, 280);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(109, 36);
            this.btnBegin.TabIndex = 21;
            this.btnBegin.Text = "Bắt Đầu Chơi";
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // reflectionLabel1
            // 
            this.reflectionLabel1.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflectionLabel1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.reflectionLabel1.Appearance.Options.UseFont = true;
            this.reflectionLabel1.Appearance.Options.UseForeColor = true;
            this.reflectionLabel1.Appearance.Options.UseTextOptions = true;
            this.reflectionLabel1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.reflectionLabel1.Location = new System.Drawing.Point(65, 35);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(220, 29);
            this.reflectionLabel1.TabIndex = 22;
            this.reflectionLabel1.Text = "Tùy Chọn Trò Chơi";
            // 
            // groupPanel1
            // 
            this.groupPanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.iTImeBonus);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.iTimeLimit);
            this.groupPanel1.Location = new System.Drawing.Point(16, 170);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(287, 73);
            this.groupPanel1.TabIndex = 23;
            // 
            // labelX6
            // 
            this.labelX6.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Appearance.Options.UseFont = true;
            this.labelX6.Location = new System.Drawing.Point(227, 35);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(42, 22);
            this.labelX6.TabIndex = 21;
            this.labelX6.Text = "Giây";
            // 
            // labelX7
            // 
            this.labelX7.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.Appearance.Options.UseFont = true;
            this.labelX7.Location = new System.Drawing.Point(6, 38);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(212, 22);
            this.labelX7.TabIndex = 20;
            this.labelX7.Text = "Thời Gian Cộng Thêm:";
            // 
            // iTImeBonus
            // 
            this.iTImeBonus.EditValue = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.iTImeBonus.Location = new System.Drawing.Point(164, 36);
            this.iTImeBonus.Name = "iTImeBonus";
            // 
            // 
            // 
            this.iTImeBonus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Up),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)});
            this.iTImeBonus.Properties.MaxValue = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.iTImeBonus.Size = new System.Drawing.Size(56, 24);
            this.iTImeBonus.TabIndex = 19;
            // 
            // labelX5
            // 
            this.labelX5.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Appearance.Options.UseFont = true;
            this.labelX5.Location = new System.Drawing.Point(227, 8);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(44, 22);
            this.labelX5.TabIndex = 18;
            this.labelX5.Text = "Phút";
            // 
            // labelX4
            // 
            this.labelX4.Appearance.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Appearance.Options.UseFont = true;
            this.labelX4.Location = new System.Drawing.Point(6, 8);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(164, 22);
            this.labelX4.TabIndex = 17;
            this.labelX4.Text = "Thời Gian Tối Đa:";
            // 
            // iTimeLimit
            // 
            this.iTimeLimit.EditValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.iTimeLimit.Location = new System.Drawing.Point(165, 5);
            this.iTimeLimit.Name = "iTimeLimit";
            // 
            // 
            // 
            this.iTimeLimit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Up),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)});
            this.iTimeLimit.Properties.MaxValue = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.iTimeLimit.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.iTimeLimit.Size = new System.Drawing.Size(56, 24);
            this.iTimeLimit.TabIndex = 16;
            // 
            // frmSelectGame
            // 
            this.Appearance.Options.UseFont = true;
            this.ClientSize = new System.Drawing.Size(316, 349);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.reflectionLabel1);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.groupPanel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmSelectGame";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tùy Chọn Trò Chơi";
            this.Load += new System.EventHandler(this.frmSelectGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupPanel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTImeBonus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTimeLimit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected DevExpress.XtraEditors.LabelControl labelX2;
        protected System.Windows.Forms.RadioButton radWhite;
        protected System.Windows.Forms.RadioButton radBlack;
       
        protected DevExpress.XtraEditors.LabelControl labelX3;
        
        
        protected DevExpress.XtraEditors.GroupControl groupPanel3;
        
        protected DevExpress.XtraEditors.SimpleButton btnBegin;
        protected DevExpress.XtraEditors.LabelControl reflectionLabel1;
        protected DevExpress.XtraEditors.GroupControl groupPanel1;
        protected DevExpress.XtraEditors.LabelControl labelX4;
        protected DevExpress.XtraEditors.SpinEdit iTimeLimit;
        protected DevExpress.XtraEditors.LabelControl labelX6;
        protected DevExpress.XtraEditors.LabelControl labelX7;
        protected DevExpress.XtraEditors.SpinEdit iTImeBonus;
        protected DevExpress.XtraEditors.LabelControl labelX5;
        private ComboBoxEdit comboBoxEdit1;
      
    }
}