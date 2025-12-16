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
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace Baitaplon.Forms
{
    public partial class frmCTHoaDonNhap : Form
    {
        public frmCTHoaDonNhap()
        {
            InitializeComponent();
        }

        private void frmCTHoaDonNhap_Load(object sender, EventArgs e)
        {

            cboNhanVien.DataSource = NhanVienDAL.GetAll();
            cboNhanVien.DisplayMember = "tennhanvien";
            cboNhanVien.ValueMember = "nhanvien_id";

                
            cboNhaCungCap.DataSource = NhaCungCapDAL.GetAll();
            cboNhaCungCap.DisplayMember = "tennhacungcap";
            cboNhaCungCap.ValueMember = "nhacungcap_id";

            cboKhachhang.DataSource = KhachHangDAL.GetAll();
            cboKhachhang.DisplayMember = "tenkhachhang";
            cboKhachhang.ValueMember = "khachhang_id";
            
        
            dgvHoaDonNhap.DataSource = HoaDonNhapDAL.GetAllHoaDonNhap();
            
            LockGridChiTiet();


        }

        private void dgvHoaDonNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvHoaDonNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int hdnId = Convert.ToInt32(
                dgvHoaDonNhap.Rows[e.RowIndex].Cells["hoadonnhap_id"].Value);

            
            DataRow hdn = CTHoaDonNhapDAL.GetHoaDonNhapById(hdnId);

           
            txtMahoadon.Text = hdn["hoadonnhap_id"].ToString();
            dateNgaynhap.Value = Convert.ToDateTime(hdn["ngaynhap"]);

            cboNhanVien.SelectedValue = hdn["nhanvien_id"];
            cboNhaCungCap.SelectedValue = hdn["nhacungcap_id"];
            txtSanpham.Text = hdn["tensanpham"].ToString();

            
            dgvHoaDonNhap.DataSource = CTHoaDonNhapDAL.GetChiTietHoaDonNhap(hdnId);
        }

        private void dgvChitiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvChitiet.Rows[e.RowIndex];

            txtMaHD.Text = row.Cells["hoadonnhap_id"].Value.ToString();
            txtTenSanPham.Text = row.Cells["tensanpham"].Value.ToString();
            txtSoLuong.Text = row.Cells["soluong"].Value.ToString();
            txtDonGia.Text = row.Cells["dongia"].Value.ToString();
            txtThanhTien.Text = row.Cells["thanhtien"].Value.ToString();
            picSanPham.Image = row.Cells["hinhanh"].Value as Image;

                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHD.Text.Trim();

            DateTime? ngayNhap = null;
                ngayNhap = dateNgaynhap.Value;

            int? nhanVienId = null;
            if (cboNhanVien.SelectedIndex != -1)
                nhanVienId = (int)cboNhanVien.SelectedValue;

            int? nhaCungCapId = null;
            if (cboNhaCungCap.SelectedIndex != -1)
                nhaCungCapId = (int)cboNhaCungCap.SelectedValue;

            string tenSanPham = txtSanpham.Text.Trim();

            dgvHoaDonNhap.DataSource = CTHoaDonNhapDAL.TimKiemHoaDonNhap(
                maHD,
                ngayNhap,
                nhanVienId,
                nhaCungCapId,
                tenSanPham
            );
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            txtMaHD.Clear();
            txtSanpham.Clear();
            cboNhaCungCap.SelectedIndex = -1;
            cboKhachhang.SelectedIndex = -1;
            dateNgaynhap.Checked = false;

            dgvHoaDonNhap.DataSource = HoaDonNhapDAL.GetAllHoaDonNhap();
        }

        private void dgvChitiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LockGridChiTiet()
        {
            dgvChitiet.ReadOnly = true;
            dgvChitiet.AllowUserToAddRows = false;
            dgvChitiet.AllowUserToDeleteRows = false;
        }

        private void UnlockGridChiTiet()
        {
            dgvChitiet.ReadOnly = false;

            dgvChitiet.Columns["tensanpham"].ReadOnly = true;
            dgvChitiet.Columns["sanpham_id"].ReadOnly = true;
            dgvChitiet.Columns["thanhtien"].ReadOnly = true;

            dgvChitiet  .AllowUserToAddRows = false;
            dgvChitiet.AllowUserToDeleteRows = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            UnlockGridChiTiet();
            btnLuu.Enabled = true;
            btnSua.Enabled = false;

            int hdnId = int.Parse(txtMaHD.Text);

            foreach (DataGridViewRow row in dgvChitiet.Rows)
            {
                int sanPhamId = Convert.ToInt32(row.Cells["sanpham_id"].Value);
                int sl = Convert.ToInt32(row.Cells["soluong"].Value);
                decimal dg = Convert.ToDecimal(row.Cells["dongia"].Value);
                decimal gg = Convert.ToDecimal(row.Cells["giamgia"].Value);

                CTHoaDonNhapDAL.UpdateChiTietHoaDonNhap(
                    hdnId, sanPhamId, sl, dg, gg);
            }

            // Cập nhật tổng tiền hóa đơn
            CTHoaDonNhapDAL.UpdateTongTien(hdnId, decimal.Parse(txtTongTien.Text));

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            int hdnId = int.Parse(txtMaHD.Text);
            dgvChitiet.DataSource = CTHoaDonNhapDAL.GetChiTietHoaDonNhap(hdnId);

            LockGridChiTiet();
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvChitiet.CurrentRow == null)
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
                dgvChitiet.CurrentRow.Cells["sanpham_id"].Value);

            // Xóa DB
            CTHoaDonNhapDAL.DeleteChiTietHoaDonNhap(hdnId, sanPhamId);

            // Xóa trên grid
            dgvChitiet.Rows.Remove(dgvChitiet.CurrentRow);

            // Tính lại tổng tiền
            TinhTongTien();

            btnLuu.Enabled = true;
        }
        private void TinhTongTien()
        {
            decimal tong = 0;

            foreach (DataGridViewRow r in dgvChitiet.Rows)
            {
                tong += Convert.ToDecimal(r.Cells["thanhtien"].Value);
            }

            txtTongTien.Text = tong.ToString("N0");
        }

        private void dgvChitiet_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvChitiet.Rows[e.RowIndex];

            int sl = Convert.ToInt32(row.Cells["soluong"].Value);
            decimal dg = Convert.ToDecimal(row.Cells["dongia"].Value);
            decimal gg = Convert.ToDecimal(row.Cells["giamgia"].Value);

            row.Cells["thanhtien"].Value = sl * dg - gg;

            // Cập nhật tổng tiền
            TinhTongTien();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook wb = xlApp.Workbooks.Add();
            Excel.Worksheet ws = wb.Worksheets[1];

            ws.Name = "HoaDonNhap";

            // ===== TIÊU ĐỀ =====
            ws.Range["A1:G1"].Merge();
            ws.Range["A1"].Value = "HÓA ĐƠN NHẬP";
            ws.Range["A1"].Font.Size = 16;
            ws.Range["A1"].Font.Bold = true;
            ws.Range["A1"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            // ===== THÔNG TIN HÓA ĐƠN =====
            ws.Range["A3"].Value = "Mã HĐ:";
            ws.Range["B3"].Value = txtMaHD.Text;

            ws.Range["D3"].Value = "Ngày nhập:";
            ws.Range["E3"].Value = dateNgaynhap.Value.ToString("dd/MM/yyyy");

            ws.Range["A4"].Value = "Nhà cung cấp:";
            ws.Range["B4"].Value = cboNhaCungCap.Text;

            ws.Range["D4"].Value = "Nhân viên:";
            ws.Range["E4"].Value = cboNhanVien.Text;

            // ===== HEADER BẢNG =====
            int startRow = 6;

            ws.Cells[startRow, 1] = "STT";
            ws.Cells[startRow, 2] = "Tên sản phẩm";
            ws.Cells[startRow, 3] = "Số lượng";
            ws.Cells[startRow, 4] = "Đơn giá";
            ws.Cells[startRow, 5] = "Giảm giá";
            ws.Cells[startRow, 6] = "Thành tiền";

            Excel.Range header = ws.Range["A6:F6"];
            header.Font.Bold = true;
            header.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            header.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            // ===== CHI TIẾT =====
            int row = startRow + 1;
            int stt = 1;

            foreach (DataGridViewRow r in dgvChitiet.Rows)
            {
                ws.Cells[row, 1] = stt;
                ws.Cells[row, 2] = r.Cells["tensanpham"].Value.ToString();
                ws.Cells[row, 3] = r.Cells["soluong"].Value;
                ws.Cells[row, 4] = r.Cells["dongia"].Value;
                ws.Cells[row, 5] = r.Cells["giamgia"].Value;
                ws.Cells[row, 6] = r.Cells["thanhtien"].Value;

                row++;
                stt++;
            }

            // ===== FORMAT BẢNG =====
            Excel.Range table = ws.Range[
                $"A6:F{row - 1}"
            ];
            table.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

            ws.Columns.AutoFit();

            // ===== TỔNG TIỀN =====
            ws.Cells[row + 1, 5] = "TỔNG TIỀN:";
            ws.Cells[row + 1, 6] = txtTongTien.Text;
            ws.Cells[row + 1, 6].Font.Bold = true;

            // ===== HIỆN EXCEL =====
            xlApp.Visible = true;

            // Giải phóng
            releaseObject(ws);
            releaseObject(wb);
            releaseObject(xlApp);
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }

    }
}


