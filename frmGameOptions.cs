using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using ChessGame2.UserControls;


namespace ChessGame2.Forms
{
    public partial class frmGameOptions : XtraForm
    {
        public static bool bEditOption;
        public ChessSide SelectedSide { get; private set; }

        public frmGameOptions()
        {
            InitializeComponent();
        }

        private void FrmOptionGame_Load(object sender, EventArgs e)
        {
            cboTotalTimer.SelectedIndex = 0;
            cboMoveTimer.SelectedIndex = 0;
            cboExtraTimer.SelectedIndex = 0;
            cboUndo.SelectedIndex = 0;
            bEditOption = false;

            if (frmLanGame.iSide == 0)
            {
                radWhite.Checked = true;
                radBlack.Checked = false;
            }
            else
            {
                radWhite.Checked = false;
                radBlack.Checked = true;
            }
            cboTotalTimer.SelectedItem = frmLanGame.iTotalTimer.ToString();
            cboMoveTimer.SelectedItem = frmLanGame.iMoveTimer.ToString();
            cboExtraTimer.SelectedItem = frmLanGame.iExtraTimer.ToString();
            cboUndo.SelectedItem = frmLanGame.iUndo.ToString();
        }



        private void btnStart_Click(object sender, EventArgs e)
        {
            if (radWhite.Checked)
            {
                frmLanGame.iSide = 0;
            }
            else
            {
                frmLanGame.iSide = 1;
            }
            frmLanGame.iTotalTimer = int.Parse(cboTotalTimer.SelectedItem.ToString());
            frmLanGame.iMoveTimer = int.Parse(cboMoveTimer.SelectedItem.ToString());
            frmLanGame.iExtraTimer = int.Parse(cboExtraTimer.SelectedItem.ToString());
            frmLanGame.iUndo = int.Parse(cboUndo.SelectedItem.ToString());

            if (frmGame.localpc.ConnectState == 2)
            {
                if (bEditOption)
                {
                    frmGame.localpc.SendTCPData("OPTION", frmLanGame.iSide + ":" + frmLanGame.iTotalTimer + ":" + frmLanGame.iMoveTimer + ":" + frmLanGame.iExtraTimer + ":" + frmLanGame.iUndo);
                }
                else
                {
                    frmGame.localpc.SendTCPData("ENDOPTION", "");
                }
            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bEditOption = true;
            grOptionGame.Enabled = true;
        }


    }
}