using System.Data;
using Baitaplon.Class;

namespace Baitaplon.DAL
{
    internal class KhachHangDAL
    {
        public static DataTable GetAll()
        {
            string sql = "SELECT khachhang_id, tenkhachhang, diachi, dienthoai, email, ngaydangky FROM KhachHang";
            return Function.GetDataToTable(sql);
        }

        public static string GetNextId()
        {
            string sql = "Select top 1 right(khachhang_id,1) From KhachHang order by right(khachhang_id,1) desc";
            float count = Function.FirstRowNumberSafe(sql) + 1;
            return "G" + count;
        }

        public static void Insert(
            string id,
            string ten,
            string diachi,
            string dienthoai,
            string email,
            string ngaydangkyIso)
        {
            string sql = "INSERT INTO KhachHang(khachhang_id, tenkhachhang, diachi, dienthoai, email, ngaydangky) VALUES (" +
                         "N'" + id + "', " +
                         "N'" + ten + "', " +
                         "N'" + diachi + "', " +
                         "N'" + dienthoai + "', " +
                         "N'" + email + "', " +
                         "'" + ngaydangkyIso + "')";
            Function.RunSql(sql);
        }

        public static void Update(
            string id,
            string ten,
            string diachi,
            string dienthoai,
            string email,
            string ngaydangkyIso)
        {
            string sql = "UPDATE KhachHang SET " +
                         "tenkhachhang = N'" + ten + "', " +
                         "diachi = N'" + diachi + "', " +
                         "dienthoai = N'" + dienthoai + "', " +
                         "email = N'" + email + "', " +
                         "ngaydangky = '" + ngaydangkyIso + "' " +
                         "WHERE khachhang_id = N'" + id + "'";
            Function.RunSql(sql);
        }
    }
}

