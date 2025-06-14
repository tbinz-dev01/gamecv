using System.Windows.Forms;

namespace ChessGame2.Forms
{
    partial class frmTrainingDatabase
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.cboType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textBoxEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chụpẢnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuẢnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnCopy = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.lblWhoMove = new DevExpress.XtraEditors.LabelControl();
            this.btnSelect = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxEdit1.Properties)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupControl1.AppearanceCaption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.ForeColor = System.Drawing.Color.Black;
            this.groupControl1.AppearanceCaption.Options.UseBackColor = true;
            this.groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.btnClear);
            this.groupControl1.Controls.Add(this.btnAdd);
            this.groupControl1.Controls.Add(this.btnPreview);
            this.groupControl1.Controls.Add(this.cboType);
            this.groupControl1.Controls.Add(this.textBoxEdit1);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(36, 258);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(309, 178);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Nhập Dữ Liệu";
            // 
            // btnClear
            // 
            this.btnClear.Appearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnClear.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Appearance.ForeColor = System.Drawing.Color.Cyan;
            this.btnClear.Appearance.Options.UseBorderColor = true;
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.Appearance.Options.UseForeColor = true;
            this.btnClear.AppearancePressed.BackColor2 = System.Drawing.Color.Cyan;
            this.btnClear.AppearancePressed.BorderColor = System.Drawing.Color.Cyan;
            this.btnClear.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.btnClear.AppearancePressed.Options.UseBorderColor = true;
            this.btnClear.AppearancePressed.Options.UseForeColor = true;
            this.btnClear.Location = new System.Drawing.Point(140, 99);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 32);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Làm Mới";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.ForeColor = System.Drawing.Color.Cyan;
            this.btnAdd.Appearance.Options.UseBorderColor = true;
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Appearance.Options.UseForeColor = true;
            this.btnAdd.AppearancePressed.BackColor2 = System.Drawing.Color.Cyan;
            this.btnAdd.AppearancePressed.BorderColor = System.Drawing.Color.Cyan;
            this.btnAdd.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.btnAdd.AppearancePressed.Options.UseBorderColor = true;
            this.btnAdd.AppearancePressed.Options.UseForeColor = true;
            this.btnAdd.Location = new System.Drawing.Point(5, 99);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 32);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Appearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnPreview.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Appearance.ForeColor = System.Drawing.Color.Cyan;
            this.btnPreview.Appearance.Options.UseBorderColor = true;
            this.btnPreview.Appearance.Options.UseFont = true;
            this.btnPreview.Appearance.Options.UseForeColor = true;
            this.btnPreview.AppearancePressed.BackColor2 = System.Drawing.Color.Cyan;
            this.btnPreview.AppearancePressed.BorderColor = System.Drawing.Color.Cyan;
            this.btnPreview.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.btnPreview.AppearancePressed.Options.UseBorderColor = true;
            this.btnPreview.AppearancePressed.Options.UseForeColor = true;
            this.btnPreview.Location = new System.Drawing.Point(5, 137);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(95, 32);
            this.btnPreview.TabIndex = 7;
            this.btnPreview.Text = "Xem Thử";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            this.btnPreview.MouseHover += new System.EventHandler(this.btnPreview_MouseHover);
            // 
            // cboType
            // 
            this.cboType.Location = new System.Drawing.Point(54, 65);
            this.cboType.Name = "cboType";
            // 
            // 
            // 
            this.cboType.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboType.Properties.Appearance.Options.UseFont = true;
            this.cboType.Properties.Items.AddRange(new object[] {
            "Tàn Cuộc Luyện Tập",
            "Chiếu Bí Trong 1 Nước",
            "Chiếu Bí Trong 2 Nước",
            "Chiếu Bí Trong 3 Nước"});
            this.cboType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboType.Size = new System.Drawing.Size(200, 34);
            this.cboType.TabIndex = 5;
            // 
            // textBoxEdit1
            // 
            this.textBoxEdit1.Location = new System.Drawing.Point(54, 26);
            this.textBoxEdit1.Name = "textBoxEdit1";
            // 
            // 
            // 
            this.textBoxEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxEdit1.Properties.Appearance.Options.UseFont = true;
            this.textBoxEdit1.Size = new System.Drawing.Size(200, 34);
            this.textBoxEdit1.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Cyan;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.labelControl3.Location = new System.Drawing.Point(5, 65);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 28);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Loại:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Cyan;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.labelControl1.Location = new System.Drawing.Point(5, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 28);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "FEN:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chụpẢnhToolStripMenuItem,
            this.lưuẢnhToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(148, 56);
            this.contextMenuStrip1.Text = "Chụp Ảnh";
            // 
            // chụpẢnhToolStripMenuItem
            // 
            this.chụpẢnhToolStripMenuItem.Name = "chụpẢnhToolStripMenuItem";
            this.chụpẢnhToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.chụpẢnhToolStripMenuItem.Text = "Chụp ảnh";
            // 
            // lưuẢnhToolStripMenuItem
            // 
            this.lưuẢnhToolStripMenuItem.Name = "lưuẢnhToolStripMenuItem";
            this.lưuẢnhToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.lưuẢnhToolStripMenuItem.Text = "Lưu ảnh";
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.BackColor2 = System.Drawing.Color.Cyan;
            this.btnDelete.Appearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.ForeColor = System.Drawing.Color.Cyan;
            this.btnDelete.Appearance.Options.UseBorderColor = true;
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Appearance.Options.UseForeColor = true;
            this.btnDelete.AppearancePressed.BackColor2 = System.Drawing.Color.Red;
            this.btnDelete.AppearancePressed.BorderColor = System.Drawing.Color.Cyan;
            this.btnDelete.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.AppearancePressed.Options.UseBorderColor = true;
            this.btnDelete.AppearancePressed.Options.UseForeColor = true;
            this.btnDelete.Location = new System.Drawing.Point(34, 460);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 32);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Appearance.BackColor2 = System.Drawing.Color.Cyan;
            this.btnCopy.Appearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnCopy.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Appearance.ForeColor = System.Drawing.Color.Cyan;
            this.btnCopy.Appearance.Options.UseBorderColor = true;
            this.btnCopy.Appearance.Options.UseFont = true;
            this.btnCopy.Appearance.Options.UseForeColor = true;
            this.btnCopy.AppearancePressed.BackColor2 = System.Drawing.Color.Red;
            this.btnCopy.AppearancePressed.BorderColor = System.Drawing.Color.Cyan;
            this.btnCopy.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.btnCopy.AppearancePressed.Options.UseBorderColor = true;
            this.btnCopy.AppearancePressed.Options.UseForeColor = true;
            this.btnCopy.Location = new System.Drawing.Point(236, 460);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(109, 32);
            this.btnCopy.TabIndex = 8;
            this.btnCopy.Text = "Sao Chép FEN";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnExit
            // 
            this.btnExit.Appearance.BackColor2 = System.Drawing.Color.Cyan;
            this.btnExit.Appearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnExit.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.ForeColor = System.Drawing.Color.Cyan;
            this.btnExit.Appearance.Options.UseBorderColor = true;
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Appearance.Options.UseForeColor = true;
            this.btnExit.AppearancePressed.BackColor2 = System.Drawing.Color.Red;
            this.btnExit.AppearancePressed.BorderColor = System.Drawing.Color.Cyan;
            this.btnExit.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.btnExit.AppearancePressed.Options.UseBorderColor = true;
            this.btnExit.AppearancePressed.Options.UseForeColor = true;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(646, 460);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 32);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor2 = System.Drawing.Color.Cyan;
            this.simpleButton1.Appearance.BorderColor = System.Drawing.Color.Cyan;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Cyan;
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.AppearancePressed.BackColor2 = System.Drawing.Color.Red;
            this.simpleButton1.AppearancePressed.BorderColor = System.Drawing.Color.Cyan;
            this.simpleButton1.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.simpleButton1.AppearancePressed.Options.UseBorderColor = true;
            this.simpleButton1.AppearancePressed.Options.UseForeColor = true;
            this.simpleButton1.Location = new System.Drawing.Point(135, 460);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(95, 32);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Text = "Cập Nhật";
            this.simpleButton1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // label1
            // 
            this.label1.Appearance.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Appearance.Options.UseFont = true;
            this.label1.Appearance.Options.UseForeColor = true;
            this.label1.Location = new System.Drawing.Point(230, -7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 50);
            this.label1.TabIndex = 11;
            this.label1.Text = "Quản Lý Dữ Liệu";
            // 
            // lblWhoMove
            // 
            this.lblWhoMove.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblWhoMove.Appearance.ForeColor = System.Drawing.Color.Crimson;
            this.lblWhoMove.Appearance.Options.UseFont = true;
            this.lblWhoMove.Appearance.Options.UseForeColor = true;
            this.lblWhoMove.Location = new System.Drawing.Point(527, 433);
            this.lblWhoMove.Name = "lblWhoMove";
            this.lblWhoMove.Size = new System.Drawing.Size(177, 28);
            this.lblWhoMove.TabIndex = 12;
            this.lblWhoMove.Text = "Quân Trắng Đi Trước";
            // 
            // btnSelect
            // 
            this.btnSelect.Appearance.BackColor2 = System.Drawing.Color.Cyan;
            this.btnSelect.Appearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnSelect.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Appearance.ForeColor = System.Drawing.Color.Cyan;
            this.btnSelect.Appearance.Options.UseBorderColor = true;
            this.btnSelect.Appearance.Options.UseFont = true;
            this.btnSelect.Appearance.Options.UseForeColor = true;
            this.btnSelect.AppearancePressed.BackColor2 = System.Drawing.Color.Red;
            this.btnSelect.AppearancePressed.BorderColor = System.Drawing.Color.Cyan;
            this.btnSelect.AppearancePressed.ForeColor = System.Drawing.Color.Red;
            this.btnSelect.AppearancePressed.Options.UseBorderColor = true;
            this.btnSelect.AppearancePressed.Options.UseForeColor = true;
            this.btnSelect.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSelect.Location = new System.Drawing.Point(451, 460);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(95, 32);
            this.btnSelect.TabIndex = 13;
            this.btnSelect.Text = "Chọn";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Location = new System.Drawing.Point(653, 351);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(465, 446);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(418, 469);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // frmTrainingDatabase
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 525);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lblWhoMove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmTrainingDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Dữ Liệu - Cờ Vua";
            this.Load += new System.EventHandler(this.frmTrainingDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxEdit1.Properties)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit textBoxEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cboType;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton btnPreview;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnCopy;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.LabelControl lblWhoMove;
        private DevExpress.XtraEditors.SimpleButton btnSelect;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chụpẢnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuẢnhToolStripMenuItem;
    }
}