using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

using System.Windows.Forms;
using System.Collections;
using System.Media;



namespace ChessGame2.Forms
{
    public partial class frmMain : XtraForm
    {
        private string m_BaseSkinName = "Windows 11 Light";
        private bool m_SkinSelected = false;
        public frmMain()
        {
            InitializeComponent();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(m_BaseSkinName);

        }

        private void ApplySkin(string skinName)
        {
            m_SkinSelected = true;
            m_BaseSkinName = skinName;
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(skinName);
            this.Invalidate();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            this.pnlMenu.Location = new Point((this.ClientSize.Width - this.pnlMenu.Width) / 2, (this.ClientSize.Height - this.pnlMenu.Height) / 2);
        }

        //Sự kiện khi nhấn chơi 
        private void btnNewGame_Click(object sender,ItemClickEventArgs e)
        {
            frmGame main = new frmGame();
            main.ShowDialog();
        }
        //sự kiện khi nhấn chơi tiếp
        private void btnContinueGame_Click(object sendeer,ItemClickEventArgs e)
        {

            frmLoadGame frm = new frmLoadGame();
            frm.ShowDialog();
            this.Show();
        }
        //sự kiện khi nhấn luyện tập 
        private void btnTraining_Click(object sender,ItemClickEventArgs e)
        {

            this.Hide();
            FrmTraining frm = new FrmTraining();
            frm.ShowDialog();
            this.Show();
        }
        //sự kiện khi nhấn dữ liệu luyện tập 
        private void btnTrainingDatabase_Click(object sender,ItemClickEventArgs e)
        {
            frmTrainingDatabase frm = new frmTrainingDatabase();
            frm.ShowDialog();
        }

        //sự kiện khi nhấn tùy chọn 
        private void btnOptions_Click(object sender , ItemClickEventArgs e)
        {
            frmOptions frm = new frmOptions();
            frm.ShowDialog();
        }
        //sự kiện khi nhấn luật cờ vua 
        private void btnChessRule_Click (object sneder ,ItemClickEventArgs e)
        {
            Help.ShowHelp(this, Application.StartupPath + "\\LuatCoVua.chm", HelpNavigator.TableOfContents);
        }


        private void buttonItem1_Click(object sender , ItemClickEventArgs e)
        {
            //frmAnalysisBoard frm = new frmAnalysisBoard();
            //frm.ShowDialog();
        }
        //sự kiện khi nhấn tác giả 
        private void btnAbout_Click(object sender, ItemClickEventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }
        //sự kiện khi nhấn office
        private void buttonStyleOffice2007Blue_Click(object sender ,ItemClickEventArgs e)
        {
            ApplySkin("Windows 11 Light ");
        }
        //sự kiện khi nhấn thoát 
      

        private void btnExit_Click(object sender, EventArgs e)
        {
         Application.Exit();
        }
    }

}
