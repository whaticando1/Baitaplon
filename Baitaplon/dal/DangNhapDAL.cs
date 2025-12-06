using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitaplon.DAL
{
    public class DangNhapDAL
    {
        public bool KiemTraDangNhap(string ten, string matkhau)
        {
            string sql = "SELECT * FROM DangNhap WHERE tendangnhap = @ten AND matkhau = @matkhau";

            SqlCommand cmd = new SqlCommand(sql, Class.Function.Conn);
            cmd.Parameters.AddWithValue("@ten", ten);
            cmd.Parameters.AddWithValue("@matkhau", matkhau);

            
            SqlDataReader dr = cmd.ExecuteReader();
            bool exists = dr.HasRows;
            dr.Close();

            return exists;
        }

        public static string GetUserRole(string ten)
        {
            string sql = "select abc.tencongviec from\r\n(select a.nhanvien_id, b.tencongviec from NhanVien a join CongViec b on a.congviec_id = b.congviec_id) abc join DangNhap on DangNhap.nhanvien_id = abc.nhanvien_id \r\nwhere DangNhap.tendangnhap = @ten";
            SqlCommand cmd = new SqlCommand(sql, Class.Function.Conn);
            cmd.Parameters.AddWithValue("@ten", ten);
            SqlDataReader dr = cmd.ExecuteReader();
            string role = null;
            if (dr.Read())
            {
                role = dr["tencongviec"].ToString();
            }
            dr.Close();
            return role;
        }
    }
}
