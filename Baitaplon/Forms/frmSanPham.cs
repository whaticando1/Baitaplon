using Baitaplon.BLL;
using Baitaplon.Class;
using Baitaplon.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
            cboTrangthai.Text = "";
            txtTensanpham.Text = "";
            txtSoluong.Text = "";
            txtGianhap.Text = "";
            txtMausac.Text = "";
            cboMua.Text = "";
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
                DateTime ngaytuyendung = Convert.ToDateTime(DataGridView.CurrentRow.Cells["ngaytuyendung"].Value);
                mskNgaynhap.Text = ngaytuyendung.ToString("dd/MM/yyyy");
            }
            else
            {
                mskNgaynhap.Text = "";
            }
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

        }
    }
}
