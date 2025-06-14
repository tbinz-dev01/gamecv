using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ChessGame2.UserControls;
using DevExpress.XtraEditors;

namespace ChessGame2.Forms
{
    public partial class frmTrainingDatabase : XtraForm
    {
        public frmTrainingDatabase()
        {
            InitializeComponent();
            this.btnSelect.Visible = false;
        }

        public static clsTrainingExercise exe = null;

        public frmTrainingDatabase(bool EnableSelect)
        {
            InitializeComponent();
            this.btnSelect.Visible = true;
        }

        private void frmTrainingDatabase_Load(object sender, EventArgs e)
        {
            // Apply the "Office 2019 Colorful" skin
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2019 Colorful");

            cboType.SelectedIndex = 0;
            lblWhoMove.Text = "";
            try
            {
                // Bind DataTable to DataGridView
                dataGridView1.DataSource = clsTrainingDatabase.GetDataTable();
                // Configure DataGridView columns
                ConfigureDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ConfigureDataGridView()
        {
            // Configure DataGridView appearance
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToAddRows = false; // Prevent adding rows directly in the grid
            dataGridView1.ReadOnly = true; // Make grid read-only

            // Ensure columns are correctly named (assuming DataTable has columns: FEN, Name, Moves)
            if (dataGridView1.Columns["FEN"] != null)
                dataGridView1.Columns["FEN"].HeaderText = "FEN";
            if (dataGridView1.Columns["Name"] != null)
                dataGridView1.Columns["Name"].HeaderText = "Loại";
            if (dataGridView1.Columns["Moves"] != null)
                dataGridView1.Columns["Moves"].HeaderText = "Số Nước Tối Đa";
        }

        private clsOptions obj = new clsOptions();

        private void btnPreview_Click(object sender, EventArgs e)
        {
            PreviewFEN(textBoxEdit1.Text);
        }

        private void btnPreview_MouseHover(object sender, EventArgs e)
        {
            // Add hover logic if needed
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxEdit1.Text = "";
            cboType.SelectedIndex = -1;
            lblWhoMove.Text = "";
            pictureBox1.Image = null;
            textBoxEdit1.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboType.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn Chưa Chọn Loại !!!");
                return;
            }

            if (PreviewFEN(textBoxEdit1.Text))
            {
                clsTrainingExercise data = new clsTrainingExercise
                {
                    ExerciseName = cboType.SelectedItem.ToString(),
                    FEN = textBoxEdit1.Text,
                    MaxMoves = cboType.SelectedIndex == 0 ? 10000 : cboType.SelectedIndex
                };

                DataTable tbl = clsTrainingDatabase.AddData(data);

                if (tbl != null)
                {
                    dataGridView1.DataSource = tbl;
                    MessageBox.Show("Thêm Thành Công !!!");
                    btnClear_Click(sender, e); // Clear inputs after adding
                }
                else
                {
                    MessageBox.Show("Không Thể Thêm Dữ Liệu !!!");
                }
            }
        }

        private bool PreviewFEN(string strFEN)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(strFEN))
                {
                    MessageBox.Show("Vui lòng nhập FEN!");
                    return false;
                }

                int size = 45;
                string s = strFEN.Split(' ')[1];
                lblWhoMove.Text = s.ToUpper() == "W" ? "Quân Trắng Đi Trước" : "Quân Đen Đi Trước";

                UcChessBoard board = new UcChessBoard(obj.BoardStyle, obj.PieceStyle, ChessSide.White, GameMode.VsNetWorkPlayer, size, size, false, strFEN);
                Bitmap bmp = board.TakePicture(size * 8, size * 8);
                pictureBox1.Image = bmp;
                board.Dispose();
                return true;
            }
            catch
            {
                MessageBox.Show("Dữ Liệu Không Phù Hợp !!!");
                return false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Bạn Chưa Chọn Dòng Cần Xóa !!!");
                return;
            }

            if (dataGridView1.Rows.Count <= 1)
            {
                MessageBox.Show("Bạn Không Được Xóa Khi Chỉ Còn 1 Dòng !!!");
                return;
            }

            DataRowView row = dataGridView1.CurrentRow.DataBoundItem as DataRowView;
            if (row != null)
            {
                clsTrainingExercise data = new clsTrainingExercise
                {
                    FEN = row["FEN"].ToString()
                };

                DataTable tbl = clsTrainingDatabase.DeleteData(data);

                if (tbl == null)
                {
                    MessageBox.Show("Không Thể Xóa Dữ Liệu");
                }
                else
                {
                    dataGridView1.DataSource = tbl;
                    MessageBox.Show("Xóa Thành Công !!!");
                }
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Bạn chưa chọn dòng cần copy !!!");
                return;
            }

            DataRowView row = dataGridView1.CurrentRow.DataBoundItem as DataRowView;
            if (row != null)
            {
                string FEN = row["FEN"].ToString();
                Clipboard.SetText(FEN);
                MessageBox.Show(FEN, "Đã lưu vào ClipBoard !!!");
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (cboType.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn Chưa Chọn Loại !!!");
                return;
            }

            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Bạn Chưa Chọn Dòng Cần Cập Nhật !!!");
                return;
            }

            if (PreviewFEN(textBoxEdit1.Text))
            {
                clsTrainingExercise data = new clsTrainingExercise
                {
                    ExerciseName = cboType.SelectedItem.ToString(),
                    FEN = textBoxEdit1.Text,
                    MaxMoves = cboType.SelectedIndex == 0 ? 10000 : cboType.SelectedIndex
                };

                int rowIndex = dataGridView1.CurrentRow.Index;
                DataTable tbl = clsTrainingDatabase.UpdateData(rowIndex, data);
                if (tbl != null)
                {
                    dataGridView1.DataSource = tbl;
                    MessageBox.Show("Cập Nhật Thành Công !!!");
                    btnClear_Click(sender, e); // Clear inputs after updating
                }
                else
                {
                    MessageBox.Show("Không Thể Cập Nhật !!!");
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            DataRowView row = dataGridView1.CurrentRow.DataBoundItem as DataRowView;
            if (row != null)
            {
                string FEN = row["FEN"].ToString();
                textBoxEdit1.Text = FEN;
                cboType.Text = row["Name"].ToString();
                PreviewFEN(FEN);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Bạn Chưa Chọn Dòng Nào Cả !!!");
                return;
            }

            DataRowView row = dataGridView1.CurrentRow.DataBoundItem as DataRowView;
            if (row != null)
            {
                exe = new clsTrainingExercise
                {
                    FEN = row["FEN"].ToString(),
                    ExerciseName = row["Name"].ToString(),
                    MaxMoves = Convert.ToInt32(row["Moves"])
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}