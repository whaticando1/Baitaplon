using System.Data;
using Baitaplon.Class;

namespace Baitaplon.DAL
{
    internal class DangKyDAL
    {
        public static DataTable GetAll()
        {
            string sql = "SELECT tendangnhap, matkhau, nhanvien_id FROM DangNhap";
            return Function.GetDataToTable(sql);
        }

        public static bool ExistsForNhanVien(string nhanvienId)
        {
            string sql = "SELECT tendangnhap FROM DangNhap WHERE nhanvien_id = N'" + nhanvienId + "'";
            return Function.CheckKey(sql);
        }

        public static void Insert(string tendangnhap, string matkhau, string nhanvienId)
        {
            string sql = "INSERT INTO DangNhap (tendangnhap, matkhau, nhanvien_id) VALUES (N'" +
                         tendangnhap + "', N'" + matkhau + "', N'" + nhanvienId + "')";
            Function.RunSql(sql);
        }

        public static void Update(string tendangnhap, string matkhau, string nhanvienId)
        {
            string sql = "UPDATE DangNhap SET matkhau = N'" + matkhau + "', tendangnhap = N'" +
                         tendangnhap + "' WHERE nhanvien_id = N'" + nhanvienId + "'";
            Function.RunSql(sql);
        }

        public static void DeleteByNhanVien(string nhanvienId)
        {
            string sql = "DELETE FROM DangNhap WHERE nhanvien_id = N'" + nhanvienId + "'";
            Function.RunSqlDel(sql);
        }

        public static int CountAdminAccounts()
        {
            string sql = "SELECT COUNT(*) FROM DangNhap dn JOIN NhanVien nv ON dn.nhanvien_id = nv.nhanvien_id WHERE nv.congviec_id = 'Aa1'";
            string s = Function.GetFieldValues(sql);
            int v;
            return int.TryParse(s, out v) ? v : 0;
        }

        public static string GetNhanVienTrangThai(string nhanvienId)
        {
            return Function.GetFieldValues("Select trangthai from NhanVien where nhanvien_id = N'" + nhanvienId + "'");
        }
    }
}
