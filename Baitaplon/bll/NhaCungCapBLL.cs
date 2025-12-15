using System.Data;
using Baitaplon.DAL;
using Baitaplon.Class;

namespace Baitaplon.BLL
{
    internal class NhaCungCapBLL
    {
        public static DataTable LayDanhSachNhaCungCap()
        {
            return NhaCungCapDAL.GetAll();
        }

        public static string TaoMaMoi()
        {
            return NhaCungCapDAL.GetNextId();
        }

        public static void ThemNhaCungCap(
            string id,
            string ten,
            string diachi,
            string dienthoai,
            string email,
            string mota,
            string trangthai)
        {
            NhaCungCapDAL.Insert(id, ten, diachi, dienthoai, email, mota, trangthai);
        }

        public static void CapNhatNhaCungCap(
            string id,
            string ten,
            string diachi,
            string dienthoai,
            string email,
            string mota,
            string trangthai)
        {
            NhaCungCapDAL.Update(id, ten, diachi, dienthoai, email, mota, trangthai);
        }
    }
}
