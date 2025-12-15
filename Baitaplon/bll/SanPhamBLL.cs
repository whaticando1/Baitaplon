using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baitaplon.DAL;

namespace Baitaplon.BLL
{
    internal class SanPhamBLL
    {
        public static DataTable LayDanhSachSanPham()
        {
            return SanPhamDAL.GetAll();
        }

        public static void ThemSanPham(
            string id,
            string tensp,
            decimal gianhap,
            decimal giaban,
            int soluong,
            string chatlieu,
            string mausac,
            string doituong,
            string trangthai,
            string theloaiId,
            string ngaynhapIso,
            string mua,
            string mota,
            string urlAnh)
        {
            SanPhamDAL.Insert(id, tensp, gianhap, giaban, soluong, chatlieu, mausac, doituong, trangthai, theloaiId, ngaynhapIso, mua, mota, urlAnh);
        }

        public static void CapNhatSanPham(
            string id,
            string tensp,
            decimal gianhap,
            decimal giaban,
            int soluong,
            string chatlieu,
            string mausac,
            string doituong,
            string trangthai,
            string theloaiId,
            string ngaynhapIso,
            string mua,
            string mota,
            string urlAnh)
        {
            SanPhamDAL.Update(id, tensp, gianhap, giaban, soluong, chatlieu, mausac, doituong, trangthai, theloaiId, ngaynhapIso, mua, mota, urlAnh);
        }

        public static void XoaSanPham(string id)
        {
            SanPhamDAL.Delete(id);
        }
    }
}
