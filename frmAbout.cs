using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ChessGame2.Forms
{
    public partial class frmAbout : XtraForm
    {
        public frmAbout()
        {
            InitializeComponent();
            // Set the instructor name dynamically if needed
            labelX10.Text = "Thầy Nguyễn Văn A"; // Example instructor name
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelX13_Click(object sender, EventArgs e)
        {
            // Provide additional course information
            MessageBox.Show("Khóa 59 - Học viên Công nghệ Thông tin, Học viện Kỹ thuật Quân sự.", "Thông tin khóa học");
        }

        private void labelX10_Click(object sender, EventArgs e)
        {
            // Provide instructor contact information
            MessageBox.Show("Liên hệ giáo viên hướng dẫn: Nguyễn Văn A\nEmail: nguyen.vana@example.com", "Thông tin giáo viên");
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {

        }
    }
}