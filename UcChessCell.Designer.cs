using DevExpress.DataProcessing;

namespace ChessGame2.UserControls
{
    partial class UcChessCell
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // UcChessCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UC_ChessCell";
            this.Size = new System.Drawing.Size(102, 100);
            this.Load += new System.EventHandler(this.UcChessCell_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UcChessCell_Paint);
            this.Click += new System.EventHandler(this.UcChessCell_Click);
        }
    }
}