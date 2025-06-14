using DevExpress.DataProcessing;

namespace ChessGame2.UserControls
{
    partial class UcChessPiece
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
            // UcChessPiece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DoubleBuffered = true;
            this.Name = "UcChessPiece";
            this.Size = new System.Drawing.Size(84, 89);
            this.Load += new System.EventHandler(this.UcChessPiece_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UcChessPiece_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UcChessPiece_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UcChessPiece_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UcChessPiece_MouseUp);
            this.ResumeLayout(false);

        }
    }
}