using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChessGame2.UserControls;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace ChessGame2.Forms
{
    public partial class frmTrainingOptions :XtraForm
    {
        public frmTrainingOptions()
        {
            InitializeComponent();
        }

        public static bool Endgame = true;
        public static bool Mate1 = true;
        public static bool Mate2 = true;
        public static bool Mate3 = true;
        public static bool Random = true;

        private void frmTrainingOptions_Load(object sender, EventArgs e)
        {
            Endgame = true;
            Mate1 = true;
            Mate2 = true;
            Mate3 = true;
            Random = true;
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            Endgame = chkEndGame.Checked;
            Mate1 = chkMate1.Checked;
            Mate2 = chkMate2.Checked;
            Mate3 = chkMate3.Checked;
            Random = chkRandom.Checked;


            this.Close();
        }

        private void radioGroupSide_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}