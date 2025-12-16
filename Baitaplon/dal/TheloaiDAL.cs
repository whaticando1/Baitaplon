using System.Data;
using Baitaplon.Class;

namespace Baitaplon.DAL
{
    internal class TheLoaiDAL
    {
        public static DataTable GetAll()
        {
            string sql = "SELECT theloai_id, tentheloai, mota FROM TheLoai";
            return Function.GetDataToTable(sql);
        }

        // Fixed: use the actual table name and alias columns the form expects
        public static DataTable GetAllLoai()
        {
            string sql = @"
                SELECT 
                    theloai_id AS loaiquanao_id,
                    tentheloai AS tenloai
                FROM TheLoai
            ";
            return Function.GetDataToTable(sql);
        }

        public static void Insert(string id, string ten, string mota)
        {
            string sql = $"INSERT INTO TheLoai (theloai_id, tentheloai, mota) VALUES (N'{id}', N'{ten}', N'{mota}')";
            Function.RunSql(sql);
        }

        public static void Update(string id, string ten, string mota)
        {
            string sql = $"UPDATE TheLoai SET tentheloai=N'{ten}', mota=N'{mota}' WHERE theloai_id=N'{id}'";
            Function.RunSql(sql);
        }
    }
}
