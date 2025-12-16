using Baitaplon.Class;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Baitaplon.DAL
{
    internal class CTHoaDonBanDAL
    {
        public static DataTable GetAllHoaDonBan()
        {
            string sql = @"
        SELECT 
            hdb.hoadonban_id,
            hdb.ngayban,
            nv.tennhanvien,
            kh.tenkhachhang,
            hdb.tongtien
        FROM HoaDonBan hdb
        JOIN NhanVien nv ON hdb.nhanvien_id = nv.nhanvien_id
        JOIN KhachHang kh ON hdb.khachhang_id = kh.khachhang_id
        ORDER BY hdb.hoadonban_id DESC
    ";
            return Function.GetDataToTable(sql);
        }
        public static DataTable GetChiTietHoaDonBan(int hdbId)
        {
            string sql = @"
        SELECT 
            sp.sanpham_id,
            sp.tensanpham,
            ct.soluong,
            ct.giaban,
            ct.giamgia,
            ct.thanhtien
        FROM ChiTietHoaDonBan ct
        JOIN SanPham sp ON ct.sanpham_id = sp.sanpham_id
        WHERE ct.hoadonban_id = @id
    ";

            SqlParameter[] pr =
            {
        new SqlParameter("@id", hdbId)
    };

            return Function.GetDataToTable(sql);
        }
        public static void UpdateChiTietHoaDonBan(
    int hdbId, int spId, int sl, decimal gia, decimal gg)
        {
            decimal tt = sl * gia - gg;

            string sql = @"
        UPDATE ChiTietHoaDonBan
        SET soluong=@sl, giaban=@gia, giamgia=@gg, thanhtien=@tt
        WHERE hoadonban_id=@hd AND sanpham_id=@sp
    ";

            SqlParameter[] pr =
            {
        new SqlParameter("@sl", sl),
        new SqlParameter("@gia", gia),
        new SqlParameter("@gg", gg),
        new SqlParameter("@tt", tt),
        new SqlParameter("@hd", hdbId),
        new SqlParameter("@sp", spId)
    };

            Function.ExecuteNonQuery(sql, pr);
        }
        public static void DeleteChiTietHoaDonBan(int hdbId, int spId)
        {
            string sql = @"
        DELETE FROM ChiTietHoaDonBan
        WHERE hoadonban_id=@hd AND sanpham_id=@sp
    ";
            SqlParameter[] pr =
     {
    new SqlParameter("@hd", hdbId),
    new SqlParameter("@sp", spId)
};

            Function.ExecuteNonQuery(sql, pr);

        }
        public static void UpdateTongTien(int hdnId, decimal tongTien)
        {
            string sql = @"
        UPDATE HoaDonNhap
        SET tongtien = @tong
        WHERE hoadonnhap_id = @id
    ";

            SqlParameter[] pr =
            {
                new SqlParameter("@tong", tongTien),
                new SqlParameter("@id", hdnId)
            };
        }
    }
}
