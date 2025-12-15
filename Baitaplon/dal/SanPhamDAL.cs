using System.Data;
using Baitaplon.Class;
using System.Data.SqlClient;

namespace Baitaplon.DAL
{
    internal class SanPhamDAL
    {
        public static DataTable GetAll()
        {
            string sql = "SELECT sanpham_id, tensanpham, gianhap, giaban, soluong, chatlieu, mausac, doituong, trangthai, theloai_id, ngaynhap, mua, mota, url_anh FROM SanPham";
            return Function.GetDataToTable(sql);
        }

        public static void Insert(
            string id,
            string tensp,
            decimal gianhap,
            decimal giaban,
            int soluong,
            string chatlieu,
            string mausac,
            string doituong,
            string trangthai,
            string theloaiId,
            string ngaynhapIso, // 'yyyy-MM-dd' or your DB format
            string mua,
            string mota,
            string urlAnh)
        {
            string sql = "INSERT INTO SanPham (sanpham_id, tensanpham, gianhap, giaban, soluong, chatlieu, mausac, doituong, trangthai, theloai_id, ngaynhap, mua, mota, url_anh) VALUES(" +
                         "N'" + id + "', " +
                         "N'" + tensp + "', " +
                         gianhap.ToString().Replace(",", ".") + ", " +
                         giaban.ToString().Replace(",", ".") + ", " +
                         soluong + ", " +
                         "N'" + chatlieu + "', " +
                         "N'" + mausac + "', " +
                         "N'" + doituong + "', " +
                         "N'" + trangthai + "', " +
                         "N'" + theloaiId + "', " +
                         "'" + ngaynhapIso + "', " +
                         "N'" + mua + "', " +
                         "N'" + mota + "', " +
                         "N'" + urlAnh + "')";
            Function.RunSql(sql);
        }

        public static void Update(
            string id,
            string tensp,
            decimal gianhap,
            decimal giaban,
            int soluong,
            string chatlieu,
            string mausac,
            string doituong,
            string trangthai,
            string theloaiId,
            string ngaynhapIso,
            string mua,
            string mota,
            string urlAnh)
        {
            string sql = "UPDATE SanPham SET " +
                         "tensanpham = N'" + tensp + "', " +
                         "gianhap = " + gianhap.ToString().Replace(",", ".") + ", " +
                         "giaban = " + giaban.ToString().Replace(",", ".") + ", " +
                         "soluong = " + soluong + ", " +
                         "chatlieu = N'" + chatlieu + "', " +
                         "mausac = N'" + mausac + "', " +
                         "doituong = N'" + doituong + "', " +
                         "trangthai = N'" + trangthai + "', " +
                         "theloai_id = N'" + theloaiId + "', " +
                         "ngaynhap = '" + ngaynhapIso + "', " +
                         "mua = N'" + mua + "', " +
                         "mota = N'" + mota + "', " +
                         "url_anh = N'" + urlAnh + "' " +
                         "WHERE sanpham_id = N'" + id + "'";
            Function.RunSql(sql);
        }

        public static void Delete(string id)
        {
            string sql = "DELETE FROM SanPham WHERE sanpham_id = N'" + id + "'";
            Function.RunSqlDel(sql);
        }

        public static void CongTonKho(int sanPhamId, int soLuong)
        {
            using (var connection = new SqlConnection(/* your connection string */))
            {
                connection.Open();
                using (var command = new SqlCommand("UPDATE SanPham SET soluong = soluong + @SoLuong WHERE sanpham_id = @SanPhamId", connection))
                {
                    command.Parameters.AddWithValue("@SoLuong", soLuong);
                    command.Parameters.AddWithValue("@SanPhamId", sanPhamId);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

