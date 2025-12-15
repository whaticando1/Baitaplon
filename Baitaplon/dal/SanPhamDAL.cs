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
    internal class SanPhamDAL
    {
        public static DataTable GetAll()
        {
            string sql = @"
                SELECT sanpham_id, tensanpham, mausac, loaiquanao,
                       chatlieu, gianhap, soluong, hinhanh
                FROM SanPham";

            return Function.GetDataToTable(sql);
        }

        public static void CongTonKho(int sanphamId, int soLuong)
        {
            string sql = @"
                UPDATE SanPham
                SET soluong = soluong + @sl
                WHERE sanpham_id = @id";

            SqlParameter[] pr =
            {
                new SqlParameter("@sl", soLuong),
                new SqlParameter("@id", sanphamId)
            };

            Function.ExecuteNonQuery(sql, pr);
        }
    }
}

