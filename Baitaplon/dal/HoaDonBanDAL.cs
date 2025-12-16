using System;
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

            object result = Function.ExecuteScalar(sql, param);
            if (result == null || result == DBNull.Value)
                throw new InvalidOperationException("Failed to insert HoaDon and obtain identity.");

            return Convert.ToInt32(result);
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

        public static int InsertHoaDon(
            int nhanvienId,
            int khachhangId,
            decimal tongTien,
            int giamGia,
            DataTable chiTiet,
            SqlConnection conn,
            SqlTransaction tran)
        {
            string sqlHD = @"
                INSERT INTO HoaDonBan(ngayban, nhanvien_id, khachhang_id, tongtien, giamgia)
                OUTPUT INSERTED.hdb_id
                VALUES(GETDATE(), @nv, @kh, @tong, @gg)";

            using (SqlCommand cmdHD = new SqlCommand(sqlHD, conn, tran))
            {
                cmdHD.Parameters.AddWithValue("@nv", nhanvienId);
                cmdHD.Parameters.AddWithValue("@kh", khachhangId == 0 ? (object)DBNull.Value : khachhangId);
                cmdHD.Parameters.AddWithValue("@tong", tongTien);
                cmdHD.Parameters.AddWithValue("@gg", giamGia);

                int hdbId = Convert.ToInt32(cmdHD.ExecuteScalar());

                foreach (DataRow row in chiTiet.Rows)
                {
                    string sqlCT = @"
                        INSERT INTO ChiTietHoaDonBan
                        (hdb_id, sanpham_id, soluong, giaban, thanhtien)
                        VALUES (@hdb, @sp, @sl, @gia, @tt)";

                    using (SqlCommand cmdCT = new SqlCommand(sqlCT, conn, tran))
                    {
                        cmdCT.Parameters.AddWithValue("@hdb", hdbId);
                        cmdCT.Parameters.AddWithValue("@sp", row["sanpham_id"]);
                        cmdCT.Parameters.AddWithValue("@sl", row["soluong"]);
                        cmdCT.Parameters.AddWithValue("@gia", row["giaban"]);
                        cmdCT.Parameters.AddWithValue("@tt", row["thanhtien"]);

                        cmdCT.ExecuteNonQuery();
                    }
                }

                return hdbId;
            }
        }
    }
}

