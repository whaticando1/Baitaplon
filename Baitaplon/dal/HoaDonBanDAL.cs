using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Baitaplon.Class;
using System.Data;  

namespace Baitaplon.DAL
{
    internal class HoaDonBanDAL
    {
        public static int InsertHoaDon(int nhanvienId, int khachhangId, decimal tongtien)
        {
            string sql = @"INSERT INTO HoaDonBan(nhanvien_id, khachhang_id, ngayban, tongtien)
                           VALUES(@nv, @kh, GETDATE(), @tong);
                           SELECT SCOPE_IDENTITY();";

            SqlParameter[] param =
            {
                new SqlParameter("@nv", nhanvienId),
                new SqlParameter("@kh", khachhangId),
                new SqlParameter("@tong", tongtien)
            };

            return int.Parse(Function.ExecuteScalar(sql).ToString());
        }

        public static void InsertChiTiet(int hoadonId, int sanphamId, int soluong, decimal giaban)
        {
            string sql = @"INSERT INTO ChiTietHoaDonBan
                           VALUES(@hd, @sp, @sl, @gia, 0, @tt)";

            SqlParameter[] param =
            {
                new SqlParameter("@hd", hoadonId),
                new SqlParameter("@sp", sanphamId),
                new SqlParameter("@sl", soluong),
                new SqlParameter("@gia", giaban),
                new SqlParameter("@tt", soluong * giaban)
            };

            Function.ExecuteNonQuery(sql, param);
        }

        public static DataTable GetAll()
        {
            string sql = @"SELECT sp.sanpham_id, sp.tensanpham, sp.mausac,
                                  tl.tentheloai, sp.chatlieu,
                                  sp.giaban, sp.soluong
                           FROM SanPham sp
                           JOIN TheLoai tl ON sp.theloai_id = tl.theloai_id";

            return Function.GetDataToTable(sql);
        }

    }
}

