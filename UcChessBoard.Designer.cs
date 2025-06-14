using DevExpress.DataProcessing;

namespace ChessGame2.UserControls
{
    partial class UcChessBoard
    {
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraLayout.LayoutControl layoutControl;

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
            this.components = new System.ComponentModel.Container();
            this.timerComputerMove = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // timerComputerMove
            // 
            this.timerComputerMove.Interval = 750;
            this.timerComputerMove.Tick += new System.EventHandler(this.timerComputerMove_Tick);
            // 
            // backgroundWorker1
            // 
            //this.backgroundWorker1.WorkerSupportsCancellation = true;
            //this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            //this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // UC_ChessBoard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Name = "UC_ChessBoard";
            this.Size = new System.Drawing.Size(154, 170);
            this.Load += new System.EventHandler(this.UC_ChessBoard_Load);
            this.ResumeLayout(false);

        }


        private System.Windows.Forms.Timer timerComputerMove;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}