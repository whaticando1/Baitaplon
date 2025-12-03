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


            return exists;
        }
    }
}
