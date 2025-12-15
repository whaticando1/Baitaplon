using System.Data;
using Baitaplon.DAL;

namespace Baitaplon.BLL
{
    internal class TheLoaiBLL
    {
        public static DataTable LayDanhSachTheLoai()
        {
            return TheLoaiDAL.GetAll();
        }

        public static DataTable LayDanhSachLoai()
        {
            return TheLoaiDAL.GetAllLoai();
        }

        public static void ThemTheLoai(string id, string ten, string mota)
        {
            TheLoaiDAL.Insert(id, ten, mota);
        }

        public static void CapNhatTheLoai(string id, string ten, string mota)
        {
            TheLoaiDAL.Update(id, ten, mota);
        }
    }
}
