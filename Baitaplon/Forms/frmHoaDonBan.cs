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
    public partial class frmHoaDonBan : Form
    {
        DataTable tblHDBan;
        DataTable tblSanPham;
        DataTable tblKhachHang;
        public static string id_hdb;
        public frmHoaDonBan()
        {
            InitializeComponent();
        }


        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            tblSanPham = HoaDonBanBLL.LayDanhSachSanPham(); 
            dgvQuanao.DataSource = tblSanPham;
            TaoBangGioHang();
            LoadKhachHang();
            LoadGiamGia();
        }
            void TaoBangGioHang()
            {
                tblHDBan = new DataTable();

                tblHDBan.Columns.Add("sanpham_id", typeof(int));
                tblHDBan.Columns.Add("tensanpham", typeof(string));
                tblHDBan.Columns.Add("giaban", typeof(decimal));
                tblHDBan.Columns.Add("soluong", typeof(int));
                tblHDBan.Columns.Add("thanhtien", typeof(decimal));

                dgvGioHang.AutoGenerateColumns = false;
                dgvGioHang.DataSource = tblHDBan;
            }


        

        private void btnThemhoadon_Click(object sender, EventArgs e)
        {
            int nhanvienId = 1;   // lấy từ đăng nhập
            int khachhangId = 1;  // lấy từ combobox

            HoaDonBanBLL.TaoHoaDon(nhanvienId, khachhangId, tblHDBan);
            MessageBox.Show("Tạo hóa đơn thành công!");
        }

        private void LoadDGV1()
        {
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dgvQuanao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvGioHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThemSoLuong_Click(object sender, EventArgs e)
        {
            if (dgvQuanao.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!");
                return;
            }

            if (!KiemTraSoLuong(out int soLuongNhap))
                return;

            DataGridViewRow spRow = dgvQuanao.CurrentRow;

            int sanphamId = Convert.ToInt32(spRow.Cells["sanpham_id"].Value);
            string ten = spRow.Cells["tensanpham"].Value.ToString();
            decimal gia = Convert.ToDecimal(spRow.Cells["giaban"].Value);
            int tonKho = Convert.ToInt32(spRow.Cells["soluong"].Value);

            // ❌ vượt tồn kho
            if (soLuongNhap > tonKho)
            {
                MessageBox.Show("Số lượng nhập vượt tồn kho!");
                return;
            }

            // kiểm tra trong giỏ
            foreach (DataRow row in tblHDBan.Rows)
            {
                if ((int)row["sanpham_id"] == sanphamId)
                {
                    int tongSoLuong = (int)row["soluong"] + soLuongNhap;

                    if (tongSoLuong > tonKho)
                    {
                        MessageBox.Show("Tổng số lượng vượt tồn kho!");
                        return;
                    }

                    row["soluong"] = tongSoLuong;
                    row["thanhtien"] = tongSoLuong * (decimal)row["giaban"];

                    // trừ tồn kho bên trái
                    spRow.Cells["soluong"].Value = tonKho - soLuongNhap;

                    CapNhatTongTien();
                    txtSoLuongNhap.Clear();
                    return;
                }
            }

            // thêm mới
            DataRow newRow = tblHDBan.NewRow();
            newRow["sanpham_id"] = sanphamId;
            newRow["tensanpham"] = ten;
            newRow["giaban"] = gia;
            newRow["soluong"] = soLuongNhap;
            newRow["thanhtien"] = gia * soLuongNhap;

            tblHDBan.Rows.Add(newRow);

            // trừ tồn kho
            spRow.Cells["soluong"].Value = tonKho - soLuongNhap;

            CapNhatTongTien();
            txtSoLuongNhap.Clear();
        }
        bool KiemTraSoLuong(out int soLuongNhap)
        {
            soLuongNhap = 0;

            if (!int.TryParse(txtSoLuongNhap.Text.Trim(), out soLuongNhap) || soLuongNhap <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ!");
                txtSoLuongNhap.Focus();
                return false;
            }
            return true;
        }
        private void txtSoLuongNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        void CapNhatTongTien()
        {
            decimal tong = 0;

            foreach (DataRow row in tblHDBan.Rows)
                tong += Convert.ToDecimal(row["thanhtien"]);

            decimal tongSauGiam = tong * (100 - phanTramGiamGia) / 100;

            txtTongTien.Text = tongSauGiam.ToString("N0");
        }

        private void dgvGioHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DialogResult rs = MessageBox.Show(
                "Bạn có muốn xóa sản phẩm này khỏi giỏ hàng?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rs == DialogResult.No) return;

            // Lấy thông tin dòng bị xóa
            DataRow rowGioHang =
                ((DataRowView)dgvGioHang.Rows[e.RowIndex].DataBoundItem).Row;

            int sanphamId = (int)rowGioHang["sanpham_id"];
            int soLuongXoa = (int)rowGioHang["soluong"];

            // HOÀN TỒN KHO 
            foreach (DataGridViewRow rowSP in dgvQuanao.Rows)
            {
                if (Convert.ToInt32(rowSP.Cells["sanpham_id"].Value) == sanphamId)
                {
                    rowSP.Cells["soluong"].Value =
                        Convert.ToInt32(rowSP.Cells["soluong"].Value) + soLuongXoa;
                    break;
                }
            }

            // Xóa khỏi giỏ hàng
            tblHDBan.Rows.Remove(rowGioHang);

            // Cập nhật tổng tiền
            CapNhatTongTien();
        }

        private void LoadGiamGia()
        {
            cbbGiamgia.Items.Clear();
            cbbGiamgia.Items.AddRange(new object[] { 0, 5, 10, 15, 20, 30, 50 });
            cbbGiamgia.SelectedIndex = 0; // mặc định 0%
        }
        int phanTramGiamGia = 0;

        private void cbbGiamgia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbGiamgia.SelectedItem != null)
            {
                phanTramGiamGia = Convert.ToInt32(cbbGiamgia.SelectedItem);
                CapNhatTongTien();
            }
        }
      
        private void LoadKhachHang()
{
            tblKhachHang = KhachHangBLL.LayDanhSachKhachHang();

            // thêm khách lẻ
            DataRow r = tblKhachHang.NewRow();
            r["khachhang_id"] = 0;
            r["tenkhachhang"] = "-- Khách lẻ --";
            tblKhachHang.Rows.InsertAt(r, 0);

            cbbKhachHang.DataSource = tblKhachHang;
            cbbKhachHang.DisplayMember = "tenkhachhang";
            cbbKhachHang.ValueMember = "khachhang_id";
            cbbKhachHang.SelectedIndex = 0;
        }



        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnThemhoadon_Click_1(object sender, EventArgs e)
        {
            if (tblHDBan.Rows.Count == 0)
            {
                MessageBox.Show("Giỏ hàng trống!");
                return;
            }

            int nhanvienId = 1; // từ đăng nhập
            int khachhangId = Convert.ToInt32(cbbKhachHang.SelectedValue);

            decimal tongTien = decimal.Parse(txtTongTien.Text.Replace(",", ""));
            int giamGia = phanTramGiamGia;

            bool ok = HoaDonBanBLL.TaoHoaDon(
                nhanvienId,
                khachhangId,
                tblHDBan,
                tongTien,
                giamGia);

            if (ok)
            {
                MessageBox.Show("Lưu hóa đơn thành công!");
                tblHDBan.Clear();
                CapNhatTongTien();
            }
            else
            {
                MessageBox.Show("Lỗi khi lưu hóa đơn!");
            }
        }

        private void btnHuyhoadon_Click(object sender, EventArgs e)
        {
            if (tblHDBan.Rows.Count == 0)
            {
                MessageBox.Show("Không có hóa đơn để hủy!");
                return;
            }

            DialogResult rs = MessageBox.Show(
                "Bạn có chắc chắn muốn hủy hóa đơn này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (rs == DialogResult.No) return;

            foreach (DataRow row in tblHDBan.Rows)
            {
                int sanphamId = (int)row["sanpham_id"];
                int soLuong = (int)row["soluong"];

                foreach (DataGridViewRow spRow in dgvQuanao.Rows)
                {
                    if (Convert.ToInt32(spRow.Cells["sanpham_id"].Value) == sanphamId)
                    {
                        spRow.Cells["soluong"].Value =
                            Convert.ToInt32(spRow.Cells["soluong"].Value) + soLuong;
                        break;
                    }
                }
            }


            tblHDBan.Clear();

            phanTramGiamGia = 0;
            cbbGiamgia.SelectedIndex = 0;
            cbbKhachHang.SelectedIndex = 0;
            txtSoLuongNhap.Clear();
            txtTongTien.Text = "0";

            MessageBox.Show("Đã hủy hóa đơn!");
        }

        private void btnTimTraiCay_Click(object sender, EventArgs e)
        {
            string keyword = txtTimTen.Text.Trim();

            DataView dv = tblSanPham.DefaultView;

            if (string.IsNullOrEmpty(keyword))
            {
                dv.RowFilter = "";
            }
            else
            {
                dv.RowFilter = $"Tensanpham LIKE '%{keyword}%'";
            }

            dgvQuanao.DataSource = dv;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTimTen.Clear();
            dgvQuanao.DataSource = tblSanPham;
        }
    }
}
