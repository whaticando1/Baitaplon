using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Baitaplon.Class;

namespace Baitaplon.DAL
{
    internal class NhaCungCapDAL
    {
        public static DataTable GetAll()
        {
            string sql = "Select nhacungcap_id, tennhacungcap, diachi, dienthoai, email, mota, trangthai from NhaCungCap";
            return Function.GetDataToTable(sql);
        }

        public static string GetNextId()
        {
            string sql = "select top 1 right(nhacungcap_id,1) from NhaCungCap order by right(nhacungcap_id,1) desc";
            float count = Function.FirstRowNumberSafe(sql) + 1;
            return "NCC" + count;
        }

        public static void Insert(
            string id,
            string ten,
            string diachi,
            string dienthoai,
            string email,
            string mota,
            string trangthai)
        {
            string sql = "INSERT INTO NhaCungCap(nhacungcap_id, tennhacungcap, diachi, dienthoai, email, mota, trangthai) VALUES(" +
                         "N'" + id + "', " +
                         "N'" + ten + "', " +
                         "N'" + diachi + "', " +
                         "'" + dienthoai + "', " +
                         "'" + email + "', " +
                         "N'" + mota + "', " +
                         "N'" + trangthai + "')";
            Function.RunSql(sql);
        }

        public static void Update(
            string id,
            string ten,
            string diachi,
            string dienthoai,
            string email,
            string mota,
            string trangthai)
        {
            string sql = "UPDATE NhaCungCap " +
                         "SET tennhacungcap = N'" + ten + "', " +
                         "diachi = N'" + diachi + "', " +
                         "dienthoai = '" + dienthoai + "', " +
                         "email = '" + email + "', " +
                         "mota = N'" + mota + "', " +
                         "trangthai = N'" + trangthai + "' " +
                         "WHERE nhacungcap_id = N'" + id + "'";
            Function.RunSql(sql);
        }
    }
}
