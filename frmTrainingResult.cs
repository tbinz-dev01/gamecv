using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChessGame2.UserControls;
using DevExpress.XtraEditors;

namespace ChessGame2.Forms
{
    public partial class frmTrainingResult : XtraForm
    {
        public frmTrainingResult()
        {
            InitializeComponent();
        }

        public frmTrainingResult(bool IsSuccess)
        {
            InitializeComponent();
            if (IsSuccess == true)
            {
                labelControl1.Text = "Bạn Đã Hoàn Thành Bài Tập";
                labelControl1.ForeColor = Color.Red;

                btnNext.Text = "Tiếp Tục";
                this.Text = "Thành Công !!!";

            }
            else
            {
                labelControl1.Text = "Xin Hãy Thử Lại !!!";
                labelControl1.ForeColor = Color.Blue;

                btnNext.Text = "Thử Lại";
                this.Text = "Thất Bại !!!";
            }
        }

        private void frmTrainingResult_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}