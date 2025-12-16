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
using Excel=Microsoft.Office.Interop.Excel;
namespace Baitaplon.Forms
{
    public partial class frmCTHoaDonBan : Form
    {
        public static string id;
        public frmCTHoaDonBan()
        {
            InitializeComponent();

            frmCTHoaDonBan.id = frmHoaDonBan.id_hdb;
        }

        private void frmCTHoaDonBan_Load(object sender, EventArgs e)
        {
            dgvHoaDonBan.DataSource = CTHoaDonBanDAL.GetAllHoaDonBan();

            // Load combobox
            cboNhanVien.DataSource = NhanVienDAL.GetAll();
            cboNhanVien.DisplayMember = "tennhanvien";
            cboNhanVien.ValueMember = "nhanvien_id";

            cboKhachHang.DataSource = KhachHangDAL.GetAll();
            cboKhachHang.DisplayMember = "tenkhachhang";
            cboKhachHang.ValueMember = "khachhang_id";

            cboGiamGia.Items.AddRange(new object[] { "0", "5", "10", "20","30","50" });
        }

        private void LoadDGV1()
        {
        
        }

        private void LoadDGV2()
        {
       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvChiTiet.ReadOnly = false;
            dgvChiTiet.Columns["tensanpham"].ReadOnly = true;
            dgvChiTiet.Columns["sanpham_id"].ReadOnly = true;
            dgvChiTiet.Columns["thanhtien"].ReadOnly = true;

            btnLuu.Enabled = true;
            btnSua.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvHoaDonBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvHoaDonBan.Rows[e.RowIndex];
            int hdbId = Convert.ToInt32(row.Cells["hoadonban_id"].Value);

            txtMaHoaDon.Text = hdbId.ToString();
            txtMaHD.Text = hdbId.ToString();
            dateNgayban.Value = Convert.ToDateTime(row.Cells["ngayban"].Value);
            cboNhanVien.Text = row.Cells["tennhanvien"].Value.ToString();
            cboKhachHang.Text = row.Cells["tenkhachhang"].Value.ToString();
            txtTongTien.Text = row.Cells["tongtien"].Value.ToString();

            dgvChiTiet.DataSource = CTHoaDonBanDAL.GetChiTietHoaDonBan(hdbId);
        }

        private void dgvChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvChiTiet.Rows[e.RowIndex];

            txtTenSanPham.Text = row.Cells["tensanpham"].Value.ToString();
            txtSoLuong.Text = row.Cells["soluong"].Value.ToString();
            txtDonGia.Text = row.Cells["giaban"].Value.ToString();
            cboGiamGia.Text = row.Cells["giamgia"].Value.ToString();
            txtThanhTien.Text = row.Cells["thanhtien"].Value.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int hdbId = int.Parse(txtMaHoaDon.Text);

            foreach (DataGridViewRow r in dgvChiTiet.Rows)
            {
                CTHoaDonBanDAL.UpdateChiTietHoaDonBan(
                    hdbId,
                    Convert.ToInt32(r.Cells["sanpham_id"].Value),
                    Convert.ToInt32(r.Cells["soluong"].Value),
                    Convert.ToDecimal(r.Cells["giaban"].Value),
                    Convert.ToDecimal(r.Cells["giamgia"].Value)
                );
            }

            CTHoaDonBanDAL.UpdateTongTien(hdbId,
                decimal.Parse(txtTongTien.Text));

            MessageBox.Show("Lưu hóa đơn bán thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvChiTiet.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
                return;
            }

            DialogResult dr = MessageBox.Show(
                "Bạn có chắc muốn xóa sản phẩm này khỏi hóa đơn?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dr != DialogResult.Yes) return;

            int hdnId = int.Parse(txtMaHD.Text);
            int sanPhamId = Convert.ToInt32(
                dgvChiTiet.CurrentRow.Cells["sanpham_id"].Value);

            // Xóa DB
            CTHoaDonBanDAL.DeleteChiTietHoaDonBan(hdnId, sanPhamId);

            // Xóa trên grid
            dgvChiTiet.Rows.Remove(dgvChiTiet.CurrentRow);

            // Tính lại tổng tiền
            TinhTongTien();

            btnLuu.Enabled = true;
        }
        private void TinhTongTien()
        {
            decimal tong = 0;

            foreach (DataGridViewRow r in dgvChiTiet.Rows)
            {
                tong += Convert.ToDecimal(r.Cells["thanhtien"].Value);
            }

            txtTongTien.Text = tong.ToString("N0");
        }
        private void ApDungGiamGia()
        {
            decimal tongThanhTien = decimal.Parse(txtThanhTien.Text);
            decimal giamGia = decimal.Parse(cboGiamGia.Text); // %

            decimal tongTien =
                tongThanhTien * (100 - giamGia) / 100;

            txtTongTien.Text = tongTien.ToString("N0");
        }
        private void TinhTongThanhTien()
        {
            decimal tong = 0;

            foreach (DataGridViewRow r in dgvChiTiet.Rows)
            {
                if (r.Cells["thanhtien"].Value != null)
                    tong += Convert.ToDecimal(r.Cells["thanhtien"].Value);
            }

            txtThanhTien.Text = tong.ToString("N0");

            ApDungGiamGia();
        }

        private void dgvChiTiet_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvChiTiet.Rows[e.RowIndex];

            int soLuong = Convert.ToInt32(row.Cells["soluong"].Value);
            decimal donGia = Convert.ToDecimal(row.Cells["giaban"].Value);

            row.Cells["thanhtien"].Value = soLuong * donGia;

            TinhTongThanhTien();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook wb = xlApp.Workbooks.Add();
            Excel.Worksheet ws = wb.Worksheets[1];

            xlApp.Visible = true;

            // ===== TIÊU ĐỀ =====
            ws.Range["A1", "G1"].Merge();
            ws.Range["A1"].Value = "HÓA ĐƠN BÁN";
            ws.Range["A1"].Font.Size = 18;
            ws.Range["A1"].Font.Bold = true;
            ws.Range["A1"].HorizontalAlignment =
                Excel.XlHAlign.xlHAlignCenter;

            // ===== THÔNG TIN CHUNG =====
            ws.Range["A3"].Value = "Mã HĐ:";
            ws.Range["B3"].Value = txtMaHoaDon.Text;

            ws.Range["D3"].Value = "Ngày bán:";
            ws.Range["E3"].Value = dateNgayban.Value.ToString("dd/MM/yyyy");

            ws.Range["A4"].Value = "Nhân viên:";
            ws.Range["B4"].Value = cboNhanVien.Text;

            ws.Range["D4"].Value = "Khách hàng:";
            ws.Range["E4"].Value = cboKhachHang.Text;

            // ===== HEADER CHI TIẾT =====
            int row = 6;

            ws.Cells[row, 1] = "STT";
            ws.Cells[row, 2] = "Tên sản phẩm";
            ws.Cells[row, 3] = "Số lượng";
            ws.Cells[row, 4] = "Đơn giá";
            ws.Cells[row, 5] = "Thành tiền";

            ws.Range["A6", "E6"].Font.Bold = true;
            ws.Range["A6", "E6"].Borders.LineStyle =
                Excel.XlLineStyle.xlContinuous;

            // ===== DỮ LIỆU =====
            int stt = 1;
            row++;

            foreach (DataGridViewRow r in dgvChiTiet.Rows)
            {
                if (r.IsNewRow) continue;

                ws.Cells[row, 1] = stt++;
                ws.Cells[row, 2] = r.Cells["tensanpham"].Value.ToString();
                ws.Cells[row, 3] = r.Cells["soluong"].Value;
                ws.Cells[row, 4] = r.Cells["giaban"].Value;
                ws.Cells[row, 5] = r.Cells["thanhtien"].Value;

                ws.Range[$"A{row}", $"E{row}"].Borders.LineStyle =
                    Excel.XlLineStyle.xlContinuous;

                row++;
            }

            // ===== TỔNG TIỀN =====
            row += 1;
            ws.Cells[row, 4] = "Giảm giá (%)";
            ws.Cells[row, 5] = cboGiamGia.Text;

            row++;
            ws.Cells[row, 4] = "TỔNG TIỀN";
            ws.Cells[row, 5] = txtTongTien.Text;

            ws.Range[$"D{row}", $"E{row}"].Font.Bold = true;

            // ===== FORMAT =====
            ws.Columns.AutoFit();
        }
    }
}
