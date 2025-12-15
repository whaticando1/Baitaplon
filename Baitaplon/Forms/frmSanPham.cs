using Baitaplon.BLL;
using Baitaplon.Class;
using Baitaplon.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitaplon.Forms
{
    public partial class frmSanPham : Form
    {
        DataTable dtSanPham;
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmTheLoai f = new Forms.frmTheLoai();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            picAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            cboTrangthai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMua.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMatheloai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMua.BeginUpdate();
            cboMua.Items.Add("Xuân");
            cboMua.Items.Add("Hạ");
            cboMua.Items.Add("Thu");
            cboMua.Items.Add("Đông");
            cboMua.EndUpdate();
            cboTrangthai.BeginUpdate();
            cboTrangthai.Items.Add("Còn hàng");
            cboTrangthai.Items.Add("Hết hàng");
            cboTrangthai.EndUpdate();
            Function.FillCombo("Select theloai_id, tentheloai from TheLoai", cboMatheloai, "theloai_id", "tentheloai");
            cboMatheloai.SelectedValue = -1;
            Load_DataGridViewSP();
            resetValues();
            txtMasanpham.Enabled = false;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnBoqua.Enabled = false;
        }
        private void resetValues()
        {
            txtMasanpham.Text = "";
            txtGiaban.Text = "";
            txtChatlieu.Text = "";
            txtDoituong.Text = "";
            cboTrangthai.SelectedIndex = -1;
            txtTensanpham.Text = "";
            txtSoluong.Text = "";
            txtGianhap.Text = "";
            txtMausac.Text = "";
            cboMua.SelectedIndex = -1;
            cboMatheloai.SelectedValue = -1;
            mskNgaynhap.Text = "";
            txtAnh.Text = "";
            txtMota.Text = "";
            picAnh.Image = null;
            lblThongbao.Text = "";
        }
        private void Load_DataGridViewSP()
        {
            string sql = "Select sanpham_id, tensanpham, gianhap, giaban, soluong, chatlieu, mausac, doituong, trangthai, theloai_id, ngaynhap, mua, mota, url_anh from SanPham";
            dtSanPham = Class.Function.GetDataToTable(sql);
            DataGridView.DataSource = dtSanPham;
            if (DataGridView.Rows.Count > 0)
            {
                DataGridView.Columns[0].HeaderText = "Mã sản phẩm";
                DataGridView.Columns[1].HeaderText = "Tên sản phẩm";
                DataGridView.Columns[2].HeaderText = "Giá nhập";
                DataGridView.Columns[3].HeaderText = "Giá bán";
                DataGridView.Columns[4].HeaderText = "Số lượng";
                DataGridView.Columns[5].HeaderText = "Chất liệu";
                DataGridView.Columns[6].HeaderText = "Màu sắc";
                DataGridView.Columns[7].HeaderText = "Đối tượng";
                DataGridView.Columns[8].HeaderText = "Trạng thái";
                DataGridView.Columns[9].HeaderText = "Mã thể loại";
                DataGridView.Columns[10].HeaderText = "Ngày nhập";
                DataGridView.Columns[11].HeaderText = "Mùa";
                DataGridView.Columns[12].HeaderText = "Mô tả";
                DataGridView.Columns[13].HeaderText = "URL Ảnh";
                DataGridView.Columns[0].Width = 100;
                DataGridView.Columns[1].Width = 150;
                DataGridView.Columns[2].Width = 100;
                DataGridView.Columns[3].Width = 100;
                DataGridView.Columns[4].Width = 80;
                DataGridView.Columns[5].Width = 100;
                DataGridView.Columns[6].Width = 100;
                DataGridView.Columns[7].Width = 100;
                DataGridView.Columns[8].Width = 100;
                DataGridView.Columns[9].Width = 100;
                DataGridView.Columns[10].Width = 100;
                DataGridView.Columns[11].Width = 80;
                DataGridView.Columns[12].Width = 200;
                DataGridView.Columns[13].Width = 200;

                DataGridView.AllowUserToAddRows = false;
                DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
        }
        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtSanPham.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (File.Exists(txtAnh.Text))
            {
                using (var img = Image.FromFile(txtAnh.Text))
                {
                    picAnh.Image = new Bitmap(img);
                }
            }
            else
            {
                picAnh.Image = null;
            }


            txtMasanpham.Text = DataGridView.CurrentRow.Cells["sanpham_id"].Value.ToString();
            txtTensanpham.Text = DataGridView.CurrentRow.Cells["tensanpham"].Value.ToString();
            txtGianhap.Text = DataGridView.CurrentRow.Cells["gianhap"].Value.ToString();
            txtGiaban.Text = DataGridView.CurrentRow.Cells["giaban"].Value.ToString();
            txtSoluong.Text = DataGridView.CurrentRow.Cells["soluong"].Value.ToString();
            txtChatlieu.Text = DataGridView.CurrentRow.Cells["chatlieu"].Value.ToString();
            txtMausac.Text = DataGridView.CurrentRow.Cells["mausac"].Value.ToString();
            txtDoituong.Text = DataGridView.CurrentRow.Cells["doituong"].Value.ToString();
            cboTrangthai.Text = DataGridView.CurrentRow.Cells["trangthai"].Value.ToString();
            cboMua.Text = DataGridView.CurrentRow.Cells["mua"].Value.ToString();
            cboMatheloai.SelectedValue = DataGridView.CurrentRow.Cells["theloai_id"].Value.ToString();
            txtAnh.Text = DataGridView.CurrentRow.Cells["url_anh"].Value.ToString();
            picAnh.Image = Image.FromFile(txtAnh.Text);
            txtMota.Text = DataGridView.CurrentRow.Cells["mota"].Value.ToString();
            if (DataGridView.CurrentRow.Cells["ngaynhap"].Value != DBNull.Value)
            {
                DateTime ngaynhap = Convert.ToDateTime(DataGridView.CurrentRow.Cells["ngaynhap"].Value);
                mskNgaynhap.Text = ngaynhap.ToString("dd/MM/yyyy");
            }
            else
            {
                mskNgaynhap.Text = "";
            }
            btnBoqua.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = true;
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            resetValues();
            btnBoqua.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            resetValues();
            txtTensanpham.Focus();
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Image files (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            dlgOpen.Title = "Chọn hình ảnh";
            dlgOpen.FilterIndex = 1;

            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                // Avoid file locking
                using (var img = Image.FromFile(dlgOpen.FileName))
                {
                    picAnh.Image = new Bitmap(img);
                }

                txtAnh.Text = dlgOpen.FileName; // temporary original path
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql, id = "";
            if (txtTensanpham.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải nhập tên sản phẩm!";
                lblThongbao.ForeColor = Color.Red;
                return;
            }
            if (txtGianhap.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải nhập giá nhập!";
                lblThongbao.ForeColor = Color.Red;
                return;
            }
            if (txtGiaban.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải nhập giá bán!";
                lblThongbao.ForeColor = Color.Red;
                return;
            }
            if (txtGianhap.Text.Trim().Length <= 0 || txtGiaban.Text.Trim().Length <= 0)
            {
                lblThongbao.Text = "Giá nhập / bán không hợp lệ!";
                lblThongbao.ForeColor = Color.Red;
                return;
            }
            if (txtSoluong.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải nhập số lượng!";
                lblThongbao.ForeColor = Color.Red;
                return;
            }
            if (cboMatheloai.SelectedIndex == -1)
            {
                lblThongbao.Text = "Phải chọn thể loại!";
                lblThongbao.ForeColor = Color.Red;
                return;
            }
            if (txtMausac.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải nhập màu sắc!";
                lblThongbao.ForeColor = Color.Red;
                return;
            }
            if (cboTrangthai.SelectedIndex == -1)
            {
                lblThongbao.Text = "Phải chọn trạng thái!";
                lblThongbao.ForeColor = Color.Red;
                return;
            }
            if (cboMua.SelectedIndex == -1)
            {
                lblThongbao.Text = "Phải chọn mùa!";
                lblThongbao.ForeColor = Color.Red;
                return;
            }
            if (mskNgaynhap.Text == "  /  /" || !Function.IsDate(mskNgaynhap.Text))
            {
                lblThongbao.Text = "Ngày nhập không hợp lệ!";
                lblThongbao.ForeColor = Color.Red;
                return;
            }
            if (txtAnh.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải chọn ảnh!";
                lblThongbao.ForeColor = Color.Red;
                return;
            }
            if (txtDoituong.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải nhập đối tượng!";
                lblThongbao.ForeColor = Color.Red;
                return;
            }
            if (txtChatlieu.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải nhập chất liệu!";
                lblThongbao.ForeColor = Color.Red;
                return;
            }
            if (Function.IsNumber(txtGianhap.Text) == false)
            {
                lblThongbao.Text = "Giá nhập phải là số!";
                lblThongbao.ForeColor = Color.Red;
                return;
            }
            if (Function.IsNumber(txtGiaban.Text) == false)
            {
                lblThongbao.Text = "Giá bán phải là số!";
                lblThongbao.ForeColor = Color.Red;
                return;
            }
            if (Function.IsNumber(txtSoluong.Text) == false)
            {
                lblThongbao.Text = "Số lượng phải là số!";
                lblThongbao.ForeColor = Color.Red;
                return;
            }
            // ===== CREATE PRODUCT ID =====
            string sql1 = "SELECT TOP 1 RIGHT(sanpham_id, 2) FROM SanPham ORDER BY RIGHT(sanpham_id, 2) DESC";
            int count = (int)Function.FirstRowNumberSafe(sql1) + 1;
            id = "SP" + count.ToString("00");   // SP01, SP02...

            // ===== SAVE IMAGE TO PROJECT FOLDER =====
            string sourcePath = txtAnh.Text;
            string targetFolder = Function.GetImageRootPath();

            if (!Directory.Exists(targetFolder))
                Directory.CreateDirectory(targetFolder);

            string extension = Path.GetExtension(sourcePath);
            string fileName = id + extension;          // image name = product ID
            string targetPath = Path.Combine(targetFolder, fileName);

            File.Copy(sourcePath, targetPath, true);

            // update image path to NEW path
            txtAnh.Text = targetPath;

            // ===== INSERT PRODUCT =====
            string idate = Function.ConvertDateTime(mskNgaynhap.Text);

            sql = "INSERT INTO SanPham " +
                  "(sanpham_id, tensanpham, gianhap, giaban, soluong, chatlieu, mausac, doituong, trangthai, theloai_id, ngaynhap, mua, mota, url_anh) " +
                  "VALUES (N'" + id + "', N'" + txtTensanpham.Text.Trim() + "', " +
                  txtGianhap.Text.Trim() + ", " +
                  txtGiaban.Text.Trim() + ", " +
                  txtSoluong.Text.Trim() + ", N'" +
                  txtChatlieu.Text.Trim() + "', N'" +
                  txtMausac.Text.Trim() + "', N'" +
                  txtDoituong.Text.Trim() + "', N'" +
                  cboTrangthai.Text + "', N'" +
                  cboMatheloai.SelectedValue + "', '" +
                  idate + "', N'" +
                  cboMua.Text + "', N'" +
                  txtMota.Text.Trim() + "', N'" +
                  targetPath + "')";

            Function.RunSql(sql);

            // ===== FINISH =====
            Load_DataGridViewSP();
            resetValues();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTensanpham.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải nhập tên sản phẩm!";
                lblThongbao.ForeColor = Color.Red;
                return;
            }
            if (txtGianhap.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải nhập giá nhập!";
                lblThongbao.ForeColor = Color.Red;
                return;
            }
            if (txtGiaban.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải nhập giá bán!";
                lblThongbao.ForeColor = Color.Red;
                return;
            }
            if (txtSoluong.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải nhập số lượng!";
                lblThongbao.ForeColor = Color.Red;
                return;
            }
            if (cboMatheloai.SelectedIndex == -1)
            {
                lblThongbao.Text = "Phải chọn thể loại!";
                lblThongbao.ForeColor = Color.Red;
                return;
            }
            if (txtMausac.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải nhập màu sắc!";
                lblThongbao.ForeColor = Color.Red;
                return;
            }
            if (cboTrangthai.SelectedIndex == -1)
            {
                lblThongbao.Text = "Phải chọn trạng thái!";
                lblThongbao.ForeColor = Color.Red;
                return;
            }
            if (cboMua.SelectedIndex == -1)
            {
                lblThongbao.Text = "Phải chọn mùa!";
                lblThongbao.ForeColor = Color.Red;
                return;
            }
            if (mskNgaynhap.Text == "  /  /" || !Function.IsDate(mskNgaynhap.Text))
            {
                lblThongbao.Text = "Ngày nhập không hợp lệ!";
                lblThongbao.ForeColor = Color.Red;
                return;
            }
            if (txtAnh.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải chọn ảnh!";
                lblThongbao.ForeColor = Color.Red;
                return;
            }
            if (txtDoituong.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải nhập đối tượng!";
                lblThongbao.ForeColor = Color.Red;
                return;
            }
            if (txtChatlieu.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải nhập chất liệu!";
                lblThongbao.ForeColor = Color.Red;
                return;
            }
            if (txtGianhap.Text.Trim().Length <= 0 || txtGiaban.Text.Trim().Length <= 0)
            {
                lblThongbao.Text = "Giá nhập / bán không hợp lệ!";
                lblThongbao.ForeColor = Color.Red;
                return;
            }
            if (Function.IsNumber(txtGianhap.Text) == false)
            {
                lblThongbao.Text = "Giá nhập phải là số!";
                lblThongbao.ForeColor = Color.Red;
                return;
            }
            if (Function.IsNumber(txtGiaban.Text) == false)
            {
                lblThongbao.Text = "Giá bán phải là số!";
                lblThongbao.ForeColor = Color.Red;
                return;
            }
            if (Function.IsNumber(txtSoluong.Text) == false)
            {
                lblThongbao.Text = "Số lượng phải là số!";
                lblThongbao.ForeColor = Color.Red;
                return;
            }
            string imagePath = txtAnh.Text;

            // ===== IMAGE HANDLING (ONLY if changed) =====
            if (File.Exists(txtAnh.Text) && !txtAnh.Text.Contains(@"\Images\Products\"))
            {
                string targetFolder = Function.GetImageRootPath();
                if (!Directory.Exists(targetFolder))
                    Directory.CreateDirectory(targetFolder);

                string extension = Path.GetExtension(txtAnh.Text);
                string fileName = txtMasanpham.Text + extension;
                imagePath = Path.Combine(targetFolder, fileName);

                File.Copy(txtAnh.Text, imagePath, true);
            }

            txtAnh.Text = imagePath;

            // ===== UPDATE PRODUCT =====
            string idate = Function.ConvertDateTime(mskNgaynhap.Text);

            string sql = "UPDATE SanPham SET " +
                         "tensanpham = N'" + txtTensanpham.Text.Trim() + "', " +
                         "gianhap = " + txtGianhap.Text.Trim() + ", " +
                         "giaban = " + txtGiaban.Text.Trim() + ", " +
                         "soluong = " + txtSoluong.Text.Trim() + ", " +
                         "chatlieu = N'" + txtChatlieu.Text.Trim() + "', " +
                         "mausac = N'" + txtMausac.Text.Trim() + "', " +
                         "doituong = N'" + txtDoituong.Text.Trim() + "', " +
                         "trangthai = N'" + cboTrangthai.Text + "', " +
                         "theloai_id = N'" + cboMatheloai.SelectedValue + "', " +
                         "ngaynhap = '" + idate + "', " +
                         "mua = N'" + cboMua.Text + "', " +
                         "mota = N'" + txtMota.Text.Trim() + "', " +
                         "url_anh = N'" + imagePath + "' " +
                         "WHERE sanpham_id = N'" + txtMasanpham.Text + "'";

            Function.RunSql(sql);

            Load_DataGridViewSP();
            resetValues();
            btnBoqua.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtSanPham.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult result = MessageBox.Show( "Bạn có chắc chắn muốn xóa sản phẩm này?","Xác nhận",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            // ===== GET IMAGE PATH BEFORE DELETE =====
            string imagePath = Function.FirstRow(
                "SELECT url_anh FROM SanPham WHERE sanpham_id = N'" + txtMasanpham.Text + "'"
            );

            // ===== DELETE FROM DATABASE =====
            string sql = "DELETE FROM SanPham WHERE sanpham_id = N'" + txtMasanpham.Text + "'";
            Function.RunSqlDel(sql);

            // ===== DELETE IMAGE FILE (if exists) =====
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                try
                {
                    File.Delete(imagePath);
                }
                catch
                {
                    MessageBox.Show("Không thể xóa file ảnh trên máy!", "Cảnh báo");
                }
            }

            Load_DataGridViewSP();
            resetValues();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
        }

        
    }
}
