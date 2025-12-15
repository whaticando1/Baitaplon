using System.Data;
using Baitaplon.DAL;
using Baitaplon.Class;

namespace Baitaplon.BLL
{
    internal class KhachHangBLL
    {
        public static DataTable LayDanhSachKhachHang()
        {
            return KhachHangDAL.GetAll();
        }

        public static string TaoMaMoi()
        {
            return KhachHangDAL.GetNextId();
        }

        public static void ThemKhachHang(
            string id,
            string ten,
            string diachi,
            string dienthoai,
            string email,
            string ngaydangkyIso)
        {
            KhachHangDAL.Insert(id, ten, diachi, dienthoai, email, ngaydangkyIso);
        }

        public static void CapNhatKhachHang(
            string id,
            string ten,
            string diachi,
            string dienthoai,
            string email,
            string ngaydangkyIso)
        {
            KhachHangDAL.Update(id, ten, diachi, dienthoai, email, ngaydangkyIso);
        }
    }
}
