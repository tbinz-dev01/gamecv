using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ChessGame2.UserControls;

namespace ChessGame2.Forms
{
    public partial class frmSelectGame : XtraForm
    {
        public ChessSide eOwnSide { get; set; }
        public GameMode eGameMode { get; set; }
        
        public short TimeLimit { get; set; } = 1;
        public short TimeBonus { get; set; } = 0;

        public frmSelectGame()
        {
            InitializeComponent();
            eGameMode = GameMode.VsHuman;
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            //Set game mode
            eGameMode = GameMode.VsHuman;

            // Set side
            eOwnSide = radWhite.Checked ? ChessSide.White : ChessSide.Black;

            
            

            // Set time settings
            TimeLimit = Convert.ToInt16(iTimeLimit.EditValue);
            TimeBonus = Convert.ToInt16(iTImeBonus.EditValue);

            // Ensure the form closes with the correct DialogResult
            DialogResult = DialogResult.OK;
        }

        private void frmSelectGame_Load(object sender, EventArgs e)
        {

        }
    }
}