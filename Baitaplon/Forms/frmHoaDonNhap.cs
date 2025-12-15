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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

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

            txtMaHDN.Text = GenerateInvoiceCode();
        }

        string GenerateInvoiceCode()
        {
            return "MDH" + DateTime.Now.ToString("yyyyMMddHHmmss");
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

            dgvNhapHang.AutoGenerateColumns = false;
            dgvNhapHang.DataSource = tblHoaDonNhap;
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
                txtMaHDN.Text = GenerateInvoiceCode();
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

            txtGiaTien.Clear();
            txtSoLuong.Clear();
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



            private void btnInHoaDonNhap_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu
            if (dgvNhapHang == null || dgvNhapHang.Rows.Count <= 1)
            {
                MessageBox.Show("Không có dữ liệu để in hóa đơn nhập!", "Thông báo",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Excel.Application excel = null;
            Excel.Workbook wb = null;
            Excel.Worksheet ws = null;

            try
            {
                // Khởi tạo Excel
                excel = new Excel.Application();
                excel.Visible = true;
                wb = excel.Workbooks.Add();
                ws = wb.ActiveSheet as Excel.Worksheet;

                // ===== TIÊU ĐỀ HÓA ĐƠN =====
                ws.Cells[1, 1] = "HÓA ĐƠN NHẬP HÀNG";
                Excel.Range title = ws.Range["A1", "H1"];
                title.Merge();
                title.Font.Bold = true;
                title.Font.Size = 16;
                title.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                title.Interior.Color = Color.LightBlue;

                // ===== THÔNG TIN CHUNG =====
                ws.Cells[3, 1] = "Mã hóa đơn:";
                ws.Cells[3, 2] = txtMaHDN.Text; 

                ws.Cells[3, 5] = "Ngày nhập:";
                ws.Cells[3, 6] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                ws.Cells[4, 1] = "Nhà cung cấp:";
                ws.Cells[4, 2] = cbbNCC.Text ?? "Chưa chọn";
                ws.Range["B4", "H4"].Merge();

                ws.Cells[5, 1] = "Người nhập:";
                ws.Cells[5, 2] = Environment.UserName;

                ws.Cells[5, 5] = "Trạng thái:";
                ws.Cells[5, 6] = "Đã nhập";

                // ===== TIÊU ĐỀ BẢNG CHI TIẾT =====
                int startRow = 7;
                string[] headers = {
            "STT",
            "Mã quần áo",
            "Tên quần áo",
            "Màu sắc",
            "Loại quần áo",
            "Chất liệu",
            "Số lượng",
            "Giá nhập",
            "Thành tiền"
        };

                // Ghi tiêu đề
                for (int i = 0; i < headers.Length; i++)
                {
                    ws.Cells[startRow, i + 1] = headers[i];

                    // Định dạng tiêu đề cột
                    Excel.Range headerCell = ws.Cells[startRow, i + 1];
                    headerCell.Font.Bold = true;
                    headerCell.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    headerCell.Interior.Color = Color.LightGray;
                    headerCell.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                }

                // ===== DỮ LIỆU CHI TIẾT =====
                int rowExcel = startRow + 1;
                int stt = 1;
                decimal tongTien = 0;
                int tongSoLuong = 0;

                foreach (DataGridViewRow row in dgvNhapHang.Rows)
                {
                    if (row.IsNewRow) continue;

                    // Lấy giá trị từ DataGridView (giả sử tên cột như sau)
                    string maQuanAo = row.Cells["MaQuanAo"]?.Value?.ToString() ?? "";
                    string tenQuanAo = row.Cells["TenQuanAo"]?.Value?.ToString() ?? "";
                    string mauSac = row.Cells["MauSac"]?.Value?.ToString() ?? "";
                    string loaiQuanAo = row.Cells["LoaiQuanAo"]?.Value?.ToString() ?? "";
                    string chatLieu = row.Cells["ChatLieu"]?.Value?.ToString() ?? "";

                    // Số lượng và giá
                    int soLuong = 0;
                    decimal giaNhap = 0;
                    decimal thanhTien = 0;

                    if (row.Cells["SoLuong"].Value != null)
                        int.TryParse(row.Cells["SoLuong"].Value.ToString(), out soLuong);

                    if (row.Cells["GiaNhap"].Value != null)
                        decimal.TryParse(row.Cells["GiaNhap"].Value.ToString(), out giaNhap);

                    thanhTien = soLuong * giaNhap;
                    tongTien += thanhTien;
                    tongSoLuong += soLuong;

                    // Ghi dữ liệu vào Excel
                    ws.Cells[rowExcel, 1] = stt++; // STT
                    ws.Cells[rowExcel, 2] = maQuanAo;
                    ws.Cells[rowExcel, 3] = tenQuanAo;
                    ws.Cells[rowExcel, 4] = mauSac;
                    ws.Cells[rowExcel, 5] = loaiQuanAo;
                    ws.Cells[rowExcel, 6] = chatLieu;
                    ws.Cells[rowExcel, 7] = soLuong;
                    ws.Cells[rowExcel, 8] = giaNhap;
                    ws.Cells[rowExcel, 9] = thanhTien;

                    // Định dạng số
                    ws.Cells[rowExcel, 7].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    ws.Cells[rowExcel, 8].NumberFormat = "#,##0";
                    ws.Cells[rowExcel, 9].NumberFormat = "#,##0";

                    // Đường viền cho dòng
                    Excel.Range dataRow = ws.Range[$"A{rowExcel}", $"I{rowExcel}"];
                    dataRow.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

                    // Màu nền xen kẽ cho dễ đọc
                    if (rowExcel % 2 == 0)
                        dataRow.Interior.Color = Color.FromArgb(240, 240, 240);

                    rowExcel++;
                }

                // ===== TỔNG KẾT =====
                int summaryRow = rowExcel + 1;

                // Tổng số lượng
                ws.Cells[summaryRow, 6] = "Tổng số lượng:";
                ws.Cells[summaryRow, 7] = tongSoLuong;
                ws.Cells[summaryRow, 7].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                // Tổng tiền
                ws.Cells[summaryRow + 1, 6] = "Tổng tiền:";
                ws.Cells[summaryRow + 1, 7] = tongTien;
                ws.Cells[summaryRow + 1, 7].NumberFormat = "#,##0";
                ws.Cells[summaryRow + 1, 7].Font.Bold = true;

                // Thuế VAT (nếu có)
                decimal thueVAT = tongTien * 0.1m; // Giả sử 10%
                ws.Cells[summaryRow + 2, 6] = "Thuế VAT (10%):";
                ws.Cells[summaryRow + 2, 7] = thueVAT;
                ws.Cells[summaryRow + 2, 7].NumberFormat = "#,##0";

                // Tổng thanh toán
                decimal tongThanhToan = tongTien + thueVAT;
                ws.Cells[summaryRow + 3, 6] = "Tổng thanh toán:";
                ws.Cells[summaryRow + 3, 7] = tongThanhToan;
                ws.Cells[summaryRow + 3, 7].NumberFormat = "#,##0";
                ws.Cells[summaryRow + 3, 7].Font.Bold = true;
                ws.Cells[summaryRow + 3, 7].Font.Color = Color.Red;

                // Định dạng vùng tổng kết
                Excel.Range summaryRange = ws.Range[$"F{summaryRow}", $"G{summaryRow + 3}"];
                summaryRange.Font.Bold = true;
                summaryRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

                // ===== THÔNG TIN BẰNG CHỮ =====
                ws.Cells[summaryRow + 5, 1] = "Tổng tiền bằng chữ:";
                ws.Cells[summaryRow + 5, 2] = DocSoThanhChu(tongThanhToan);
                Excel.Range bangChuRange = ws.Range[$"A{summaryRow + 5}", $"I{summaryRow + 5}"];
                bangChuRange.Merge();
                bangChuRange.Font.Italic = true;
                bangChuRange.Font.Size = 11;


                // ===== CHỮ KÝ =====
                int signatureRow = summaryRow + 10;

                ws.Cells[signatureRow, 1] = "Người nhập";
                ws.Cells[signatureRow, 1].Font.Bold = true;
                ws.Cells[signatureRow, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                ws.Range[$"A{signatureRow}", $"C{signatureRow}"].Merge();

                ws.Cells[signatureRow, 5] = "Người giao";
                ws.Cells[signatureRow, 5].Font.Bold = true;
                ws.Cells[signatureRow, 5].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                ws.Range[$"E{signatureRow}", $"G{signatureRow}"].Merge();

                // Dòng ký
                ws.Cells[signatureRow + 3, 1] = ".........................................";
                ws.Range[$"A{signatureRow + 3}", $"C{signatureRow + 3}"].Merge();
                ws.Cells[signatureRow + 3, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                ws.Cells[signatureRow + 3, 5] = ".........................................";
                ws.Range[$"E{signatureRow + 3}", $"G{signatureRow + 3}"].Merge();
                ws.Cells[signatureRow + 3, 5].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                // ===== ĐỊNH DẠNG CỘT =====
                ws.Columns["A"].ColumnWidth = 6;  // STT
                ws.Columns["B"].ColumnWidth = 12; // Mã quần áo
                ws.Columns["C"].ColumnWidth = 25; // Tên quần áo
                ws.Columns["D"].ColumnWidth = 12; // Màu sắc
                ws.Columns["E"].ColumnWidth = 15; // Loại quần áo
                ws.Columns["F"].ColumnWidth = 15; // Chất liệu
                ws.Columns["G"].ColumnWidth = 12; // Số lượng
                ws.Columns["H"].ColumnWidth = 12; // Giá nhập
                ws.Columns["I"].ColumnWidth = 15; // Thành tiền

                // AutoFit các dòng
                ws.Rows.AutoFit();

                // ===== LƯU FILE =====
                string fileName = $"HoaDonNhap_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string folderPath = Path.Combine(desktopPath, "HoaDonNhap");

                // Tạo thư mục nếu chưa tồn tại
                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);

                string fullPath = Path.Combine(folderPath, fileName);
                wb.SaveAs(fullPath);

                MessageBox.Show($"In hóa đơn nhập thành công!\nFile đã lưu tại: {fullPath}",
                               "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi in hóa đơn nhập: {ex.Message}\n{ex.StackTrace}",
                               "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Giải phóng tài nguyên
                if (ws != null) Marshal.ReleaseComObject(ws);
                if (wb != null) Marshal.ReleaseComObject(wb);
                if (excel != null)
                {
                    excel.Quit();
                    Marshal.ReleaseComObject(excel);
                }

                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        // Hàm đọc số thành chữ (giữ nguyên từ code trước)
        private string DocSoThanhChu(decimal soTien)
        {
            // Giữ nguyên hàm này từ code cũ của bạn
            // Hoặc thay bằng hàm của bạn
            return $"({soTien.ToString("#,##0")} đồng)";
        }

        private void btnIn_Click_1(object sender, EventArgs e)
        {

            // Kiểm tra dữ liệu
            if (dgvNhapHang == null || dgvNhapHang.Rows.Count <= 1)
            {
                MessageBox.Show("Không có dữ liệu để in hóa đơn nhập!", "Thông báo",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Excel.Application excel = null;
            Excel.Workbook wb = null;
            Excel.Worksheet ws = null;

            try
            {
                // Khởi tạo Excel
                excel = new Excel.Application();
                excel.Visible = true;
                wb = excel.Workbooks.Add();
                ws = wb.ActiveSheet as Excel.Worksheet;

                // ===== TIÊU ĐỀ HÓA ĐƠN =====
                ws.Cells[1, 1] = "HÓA ĐƠN NHẬP HÀNG";
                Excel.Range title = ws.Range["A1", "H1"];
                title.Merge();
                title.Font.Bold = true;
                title.Font.Size = 16;
                title.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                title.Interior.Color = Color.LightBlue;

                // ===== THÔNG TIN CHUNG =====
                ws.Cells[3, 1] = "Mã hóa đơn:";
                ws.Cells[3, 2] = txtMaHDN.Text; // Giả sử có TextBox nhập mã hóa đơn

                ws.Cells[3, 5] = "Ngày nhập:";
                ws.Cells[3, 6] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                ws.Cells[4, 1] = "Nhà cung cấp:";
                ws.Cells[4, 2] = cbbNCC.Text ?? "Chưa chọn";
                ws.Range["B4", "H4"].Merge();

                ws.Cells[5, 1] = "Người nhập:";
                ws.Cells[5, 2] = Environment.UserName;

                ws.Cells[5, 5] = "Trạng thái:";
                ws.Cells[5, 6] = "Đã nhập";

                // ===== TIÊU ĐỀ BẢNG CHI TIẾT =====
                int startRow = 7;
                string[] headers = {
            "STT",
            "Mã quần áo",
            "Tên quần áo",
            "Màu sắc",
            "Loại quần áo",
            "Chất liệu",
            "Số lượng",
            "Giá nhập",
            "Thành tiền"
        };

                // Ghi tiêu đề
                for (int i = 0; i < headers.Length; i++)
                {
                    ws.Cells[startRow, i + 1] = headers[i];

                    // Định dạng tiêu đề cột
                    Excel.Range headerCell = ws.Cells[startRow, i + 1];
                    headerCell.Font.Bold = true;
                    headerCell.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    headerCell.Interior.Color = Color.LightGray;
                    headerCell.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                }

                // ===== DỮ LIỆU CHI TIẾT =====
                int rowExcel = startRow + 1;
                int stt = 1;
                decimal tongTien = 0;
                int tongSoLuong = 0;

                foreach (DataGridViewRow row in dgvNhapHang.Rows)
                {
                    if (row.IsNewRow) continue;

                    // Lấy giá trị từ DataGridView (giả sử tên cột như sau)
                    string maQuanAo = row.Cells["MaQuanAo"]?.Value?.ToString() ?? "";
                    string tenQuanAo = row.Cells["TenQuanAo"]?.Value?.ToString() ?? "";
                    string mauSac = row.Cells["MauSac"]?.Value?.ToString() ?? "";
                    string loaiQuanAo = row.Cells["LoaiQuanAo"]?.Value?.ToString() ?? "";
                    string chatLieu = row.Cells["ChatLieu"]?.Value?.ToString() ?? "";

                    // Số lượng và giá
                    int soLuong = 0;
                    decimal giaNhap = 0;
                    decimal thanhTien = 0;

                    if (row.Cells["SoLuong"].Value != null)
                        int.TryParse(row.Cells["SoLuong"].Value.ToString(), out soLuong);

                    if (row.Cells["GiaNhap"].Value != null)
                        decimal.TryParse(row.Cells["GiaNhap"].Value.ToString(), out giaNhap);

                    thanhTien = soLuong * giaNhap;
                    tongTien += thanhTien;
                    tongSoLuong += soLuong;

                    // Ghi dữ liệu vào Excel
                    ws.Cells[rowExcel, 1] = stt++; // STT
                    ws.Cells[rowExcel, 2] = maQuanAo;
                    ws.Cells[rowExcel, 3] = tenQuanAo;
                    ws.Cells[rowExcel, 4] = mauSac;
                    ws.Cells[rowExcel, 5] = loaiQuanAo;
                    ws.Cells[rowExcel, 6] = chatLieu;
                    ws.Cells[rowExcel, 7] = soLuong;
                    ws.Cells[rowExcel, 8] = giaNhap;
                    ws.Cells[rowExcel, 9] = thanhTien;

                    // Định dạng số
                    ws.Cells[rowExcel, 7].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    ws.Cells[rowExcel, 8].NumberFormat = "#,##0";
                    ws.Cells[rowExcel, 9].NumberFormat = "#,##0";

                    // Đường viền cho dòng
                    Excel.Range dataRow = ws.Range[$"A{rowExcel}", $"I{rowExcel}"];
                    dataRow.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

                    // Màu nền xen kẽ cho dễ đọc
                    if (rowExcel % 2 == 0)
                        dataRow.Interior.Color = Color.FromArgb(240, 240, 240);

                    rowExcel++;
                }

                // ===== TỔNG KẾT =====
                int summaryRow = rowExcel + 1;

                // Tổng số lượng
                ws.Cells[summaryRow, 6] = "Tổng số lượng:";
                ws.Cells[summaryRow, 7] = tongSoLuong;
                ws.Cells[summaryRow, 7].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                // Tổng tiền
                ws.Cells[summaryRow + 1, 6] = "Tổng tiền:";
                ws.Cells[summaryRow + 1, 7] = tongTien;
                ws.Cells[summaryRow + 1, 7].NumberFormat = "#,##0";
                ws.Cells[summaryRow + 1, 7].Font.Bold = true;

                // Thuế VAT (nếu có)
                decimal thueVAT = tongTien * 0.1m; // Giả sử 10%
                ws.Cells[summaryRow + 2, 6] = "Thuế VAT (10%):";
                ws.Cells[summaryRow + 2, 7] = thueVAT;
                ws.Cells[summaryRow + 2, 7].NumberFormat = "#,##0";

                // Tổng thanh toán
                decimal tongThanhToan = tongTien + thueVAT;
                ws.Cells[summaryRow + 3, 6] = "Tổng thanh toán:";
                ws.Cells[summaryRow + 3, 7] = tongThanhToan;
                ws.Cells[summaryRow + 3, 7].NumberFormat = "#,##0";
                ws.Cells[summaryRow + 3, 7].Font.Bold = true;
                ws.Cells[summaryRow + 3, 7].Font.Color = Color.Red;

                // Định dạng vùng tổng kết
                Excel.Range summaryRange = ws.Range[$"F{summaryRow}", $"G{summaryRow + 3}"];
                summaryRange.Font.Bold = true;
                summaryRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

                // ===== THÔNG TIN BẰNG CHỮ =====
                ws.Cells[summaryRow + 5, 1] = "Tổng tiền bằng chữ:";
                ws.Cells[summaryRow + 5, 2] = DocSoThanhChu(tongThanhToan);
                Excel.Range bangChuRange = ws.Range[$"A{summaryRow + 5}", $"I{summaryRow + 5}"];
                bangChuRange.Merge();
                bangChuRange.Font.Italic = true;
                bangChuRange.Font.Size = 11;


                // ===== CHỮ KÝ =====
                int signatureRow = summaryRow + 10;

                ws.Cells[signatureRow, 1] = "Người nhập";
                ws.Cells[signatureRow, 1].Font.Bold = true;
                ws.Cells[signatureRow, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                ws.Range[$"A{signatureRow}", $"C{signatureRow}"].Merge();

                ws.Cells[signatureRow, 5] = "Người giao";
                ws.Cells[signatureRow, 5].Font.Bold = true;
                ws.Cells[signatureRow, 5].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                ws.Range[$"E{signatureRow}", $"G{signatureRow}"].Merge();

                // Dòng ký
                ws.Cells[signatureRow + 3, 1] = ".........................................";
                ws.Range[$"A{signatureRow + 3}", $"C{signatureRow + 3}"].Merge();
                ws.Cells[signatureRow + 3, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                ws.Cells[signatureRow + 3, 5] = ".........................................";
                ws.Range[$"E{signatureRow + 3}", $"G{signatureRow + 3}"].Merge();
                ws.Cells[signatureRow + 3, 5].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                // ===== ĐỊNH DẠNG CỘT =====
                ws.Columns["A"].ColumnWidth = 6;  // STT
                ws.Columns["B"].ColumnWidth = 12; // Mã quần áo
                ws.Columns["C"].ColumnWidth = 25; // Tên quần áo
                ws.Columns["D"].ColumnWidth = 12; // Màu sắc
                ws.Columns["E"].ColumnWidth = 15; // Loại quần áo
                ws.Columns["F"].ColumnWidth = 15; // Chất liệu
                ws.Columns["G"].ColumnWidth = 12; // Số lượng
                ws.Columns["H"].ColumnWidth = 12; // Giá nhập
                ws.Columns["I"].ColumnWidth = 15; // Thành tiền

                // AutoFit các dòng
                ws.Rows.AutoFit();

                // ===== LƯU FILE =====
                string fileName = $"HoaDonNhap_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string folderPath = Path.Combine(desktopPath, "HoaDonNhap");

                // Tạo thư mục nếu chưa tồn tại
                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);

                string fullPath = Path.Combine(folderPath, fileName);
                wb.SaveAs(fullPath);

                MessageBox.Show($"In hóa đơn nhập thành công!\nFile đã lưu tại: {fullPath}",
                               "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi in hóa đơn nhập: {ex.Message}\n{ex.StackTrace}",
                               "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Giải phóng tài nguyên
                if (ws != null) Marshal.ReleaseComObject(ws);
                if (wb != null) Marshal.ReleaseComObject(wb);
                if (excel != null)
                {
                    excel.Quit();
                    Marshal.ReleaseComObject(excel);
                }

                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        private void lblTongTien_Click(object sender, EventArgs e)
        {

        }
    } 
}
    

