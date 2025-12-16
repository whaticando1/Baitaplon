using Baitaplon.Class;
using Baitaplon.DAL;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Baitaplon.BLL
{
    internal class HoaDonBanBLL
    {
        public static int TaoHoaDon(int nhanvienId, int khachhangId, DataTable gioHang)
        {
            decimal tong = 0;
            foreach (DataRow row in gioHang.Rows)
                tong += (decimal)row["thanhtien"];

            int hoadonId = HoaDonBanDAL.InsertHoaDon(nhanvienId, khachhangId, tong);

            foreach (DataRow row in gioHang.Rows)
            {
                HoaDonBanDAL.InsertChiTiet(
                    hoadonId,
                    (int)row["sanpham_id"],
                    (int)row["soluong"],
                    (decimal)row["giaban"]
                );
            }
            return hoadonId;
        }

        public static DataTable LayDanhSachSanPham()
        {
            return HoaDonBanDAL.GetAll();
        }

        public static bool TaoHoaDon(
           int nhanvienId,
           int khachhangId,
           DataTable tblHDBan,
           decimal tongTien,
           int giamGia)
        {
            // Ensure shared connection is initialized
            Function.Connect();
            SqlConnection conn = Function.Conn;

            SqlTransaction tran = conn.BeginTransaction();
            try
            {
                HoaDonBanDAL.InsertHoaDon(
                    nhanvienId,
                    khachhangId,
                    tongTien,
                    giamGia,
                    tblHDBan,
                    conn,
                    tran);

                tran.Commit();
                return true;
            }
            catch
            {
                try { tran.Rollback(); } catch { /* ignore rollback errors */ }
                return false;
            }
        }
    }
}
