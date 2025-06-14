using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChessGame2.UserControls;

namespace ChessGame2.Forms
{
    public partial class frmLoadGame : Form
    {
        public frmLoadGame()
        {
            InitializeComponent();
        }

        string SavePath = Application.StartupPath + "\\Saved Games";
        public clsSavedGame SavedGame { get; set; } = null;

        private void frmLoadGame_Load(object sender, EventArgs e)
        {
            LoadFiles();
        }

        void LoadFiles()
        {
            try
            {
                listBox1.Items.Clear();
                if (!Directory.Exists(SavePath))
                {
                    Directory.CreateDirectory(SavePath);
                }

                DirectoryInfo dir = new DirectoryInfo(SavePath);
                foreach (FileInfo file in dir.GetFiles("*.sav"))
                {
                    listBox1.Items.Add(Path.GetFileName(file.FullName));
                }

                if (listBox1.Items.Count == 0)
                {
                    MessageBox.Show("Không có ván cờ nào được lưu.", "Thông Báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách tệp: {ex.Message}", "Lỗi Hệ Thống");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedItem == null)
                {
                    return;
                }

                string fname = listBox1.SelectedItem.ToString();
                string fullPath = Path.Combine(SavePath, fname);

                // Đọc dữ liệu từ tệp .sav (text file) thay vì XML
                SavedGame = clsSavedGame.LoadFromFile(fullPath);
                if (SavedGame == null)
                {
                    throw new Exception("Không thể tải dữ liệu ván cờ.");
                }

                label1.Text = fname;
                Fen2Pic(SavedGame.FEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải ván cờ: {ex.Message}", "Lỗi Hệ Thống");
                SavedGame = null;
                pictureBox1.Image = null;
                label1.Text = "Không có dữ liệu";
            }
        }

        void Fen2Pic(string strFEN)
        {
            if (string.IsNullOrEmpty(strFEN))
            {
                pictureBox1.Image = null;
                return;
            }

            int size = pictureBox1.Width / 8;
            clsOptions obj = new clsOptions();
            UcChessBoard board = new UcChessBoard(obj.BoardStyle, obj.PieceStyle, ChessSide.White, GameMode.VsNetWorkPlayer, size, size, false, strFEN);
            Bitmap bmp = board.TakePicture(size * 8, size * 8);
            pictureBox1.Image = bmp;
            board.Dispose();
        }

        private void btnContinueGame_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn tệp ván cờ nào để tiếp tục!", "Thông Báo");
                return;
            }

            if (SavedGame == null)
            {
                MessageBox.Show("Dữ liệu ván cờ không hợp lệ. Vui lòng chọn tệp khác.", "Lỗi");
                return;
            }

            this.DialogResult = DialogResult.OK; // Đặt DialogResult để frmGame biết cần xử lý
            this.Close();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn tệp cần xóa!", "Thông Báo");
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa tệp này không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string fname = Path.Combine(SavePath, listBox1.SelectedItem.ToString());
                    File.SetAttributes(fname, FileAttributes.Normal);
                    File.Delete(fname);
                    LoadFiles();
                    MessageBox.Show("Xóa thành công!", "Thông Báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa tệp: {ex.Message}", "Lỗi Hệ Thống");
                }
            }
        }
    }
}