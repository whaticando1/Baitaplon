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
    internal class KhachHangDAL
    {
        public static DataTable GetAll()
        {
            string sql = "SELECT khachhang_id, tenkhachhang FROM KhachHang";

            SqlDataAdapter da = new SqlDataAdapter(sql, Function.Conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}

