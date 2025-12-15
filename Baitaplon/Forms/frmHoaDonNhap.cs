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
    public partial class frmHoaDonNhap : Form
    {
        DataTable tblSanPham;
        DataTable tblHoaDonNhap;
        DataTable tblNhaCungCap;
        public frmHoaDonNhap()
        {
            InitializeComponent();
        }


        private void frmHoaDonNhap_Load(object sender, EventArgs e)
        {
            tblSanPham = HoaDonNhapBLL.LaySanPham();
            dgvQuanao.DataSource = tblSanPham;
            

            LoadNhaCungCap();
            TaoBangGioNhap();
            LoadLoaiQuanAo();
        }
        void LoadNhaCungCap()
        {
            tblNhaCungCap = NhaCungCapBLL.LayDanhSachNhaCungCap();

            DataRow r = tblNhaCungCap.NewRow();
            r["nhacungcap_id"] = 0;
            r["tennhacungcap"] = "-- Chọn nhà cung cấp --";
            tblNhaCungCap.Rows.InsertAt(r, 0);

            cbbNCC.DataSource = tblNhaCungCap;
            cbbNCC.DisplayMember = "tennhacungcap";
            cbbNCC.ValueMember = "nhacungcap_id";
            cbbNCC.SelectedIndex = 0;
        }

        void TaoBangGioNhap()
            {
                tblHoaDonNhap = new DataTable();

                tblHoaDonNhap.Columns.Add("maquanao", typeof(int));
                tblHoaDonNhap.Columns.Add("tenquanao", typeof(string));
                tblHoaDonNhap.Columns.Add("mausac", typeof(string));
                tblHoaDonNhap.Columns.Add("loaiquanao", typeof(string));
                tblHoaDonNhap.Columns.Add("chatlieu", typeof(string));
                tblHoaDonNhap.Columns.Add("giatien", typeof(decimal));
                tblHoaDonNhap.Columns.Add("soluong", typeof(int));
                tblHoaDonNhap.Columns.Add("thanhtien", typeof(decimal));
                tblHoaDonNhap.Columns.Add("nhacungcap", typeof(string));
                tblHoaDonNhap.Columns.Add("hinh", typeof(string));

                dgvSPThem.AutoGenerateColumns = false;
                dgvSPThem.DataSource = tblHoaDonNhap;
            }

        



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }


            private void btnThem_Click(object sender, EventArgs e)
        {
            
        }
        void CapNhatTongTien()
        {
           
                decimal tong = 0;
                foreach (DataRow r in tblHoaDonNhap.Rows)
                    tong += Convert.ToDecimal(r["thanhtien"]);

                lblTongTien.Text = tong.ToString("N0") + " VNĐ";
            

        }

        private void btnLapHD_Click(object sender, EventArgs e)
        {

            if (tblHoaDonNhap.Rows.Count == 0)
            {
                MessageBox.Show("Giỏ nhập trống!");
                return;
            }

            int nccId = Convert.ToInt32(cbbNCC.SelectedValue);
            decimal tongTien = decimal.Parse(lblTongTien.Text.Replace(",", ""));

            bool ok = HoaDonNhapBLL.LuuHoaDonNhap(
                nccId,        
                tblHoaDonNhap,   
                tongTien     
            );

            if (ok)
            {
                MessageBox.Show("Lập hóa đơn nhập thành công!");
                tblHoaDonNhap.Clear();
                lblTongTien.Text = "0";
            }
            else
            {
                MessageBox.Show("Lỗi khi lưu hóa đơn!");
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (dgvQuanao.CurrentRow == null)
            {
                MessageBox.Show("Chọn sản phẩm!");
                return;
            }

            if (!int.TryParse(txtSoLuong.Text, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ!");
                return;
            }

            decimal giaNhap = decimal.Parse(txtGiaTien.Text);

            DataGridViewRow r = dgvQuanao.CurrentRow;

            DataRow newRow = tblHoaDonNhap.NewRow();
            newRow["maquanao"] = r.Cells["colquanao"].Value;
            newRow["tenquanao"] = r.Cells["coltenquanao"].Value;
            newRow["mausac"] = r.Cells["colmausac"].Value;
            newRow["loaiquanao"] = r.Cells["colloaiquanao"].Value;
            newRow["chatlieu"] = r.Cells["colchatlieu"].Value;
            newRow["giatien"] = giaNhap;
            newRow["soluong"] = soLuong;
            newRow["thanhtien"] = giaNhap * soLuong;
            newRow["nhacungcap"] = cbbNCC.Text;
            newRow["hinh"] = r.Cells["colhinh"].Value;

            tblHoaDonNhap.Rows.Add(newRow);

            CapNhatTongTien();
        }
        private void LoadLoaiQuanAo()
        {
            DataTable tblLoai = TheLoaiBLL.LayDanhSachLoai();

            // Thêm dòng "-- Chọn thể loại --"
            DataRow r = tblLoai.NewRow();
            r["loaiquanao_id"] = 0;
            r["tenloai"] = "-- Chọn thể loại --";
            tblLoai.Rows.InsertAt(r, 0);

            cbbLoaiQA.DataSource = tblLoai;
            cbbLoaiQA.DisplayMember = "tenloai";
            cbbLoaiQA.ValueMember = "loaiquanao_id";
            cbbLoaiQA.SelectedIndex = 0;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (tblSanPham == null) return;

            string keyword = txtTim.Text.Trim();

            DataView dv = tblSanPham.DefaultView;

            if (string.IsNullOrEmpty(keyword))
            {
                dv.RowFilter = "";
            }
            else
            {
                
                dv.RowFilter = $"tensanpham LIKE '%{keyword}%'";
            }

            dgvQuanao.DataSource = dv;
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtTim.Clear();
            tblSanPham.DefaultView.RowFilter = "";
            dgvQuanao.DataSource = tblSanPham;
        }

        private void btnHuySP_Click(object sender, EventArgs e)
        {
            if (tblHoaDonNhap == null || tblHoaDonNhap.Rows.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm để hủy!");
                return;
            }

            DialogResult rs = MessageBox.Show(
                "Bạn có chắc chắn muốn hủy nhập sản phẩm không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (rs == DialogResult.No)
                return;

           tblHoaDonNhap.Clear();


            lblTongTien.Text = "0";

          
            txtSoLuong.Clear();
            txtGiaTien.Clear();

            
            cbbNCC.SelectedIndex = 0;

            
            picQuanao.Image = null;
            

            MessageBox.Show("Đã hủy nhập sản phẩm!");
        }

        private void btnIn_Click(object sender, EventArgs e)
        {

        }
    }
}

