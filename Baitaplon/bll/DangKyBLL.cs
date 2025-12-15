using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baitaplon.DAL;

namespace Baitaplon.BLL
{
    internal class DangKyBLL
    {
        public static DataTable LayTatCaDangNhap()
        {
            return DangKyDAL.GetAll();
        }

        public static bool NhanVienDaCoTaiKhoan(string nhanvienId)
        {
            return DangKyDAL.ExistsForNhanVien(nhanvienId);
        }

        public static void ThemDangNhap(string tendangnhap, string matkhau, string nhanvienId)
        {
            DangKyDAL.Insert(tendangnhap, matkhau, nhanvienId);
        }

        public static void CapNhatDangNhap(string tendangnhap, string matkhau, string nhanvienId)
        {
            DangKyDAL.Update(tendangnhap, matkhau, nhanvienId);
        }

        public static void XoaDangNhap(string nhanvienId)
        {
            DangKyDAL.DeleteByNhanVien(nhanvienId);
        }

        public static int DemAdmin()
        {
            return DangKyDAL.CountAdminAccounts();
        }

        public static string LayTrangThaiNhanVien(string nhanvienId)
        {
            return DangKyDAL.GetNhanVienTrangThai(nhanvienId);
        }
    }
}
