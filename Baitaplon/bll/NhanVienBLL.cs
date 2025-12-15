using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baitaplon.Class;
using Baitaplon.DAL;

namespace Baitaplon.BLL
{
    internal class NhanVienBLL
    {
        public static DataTable LayTatCaNhanVien()
        {
            return NhanVienDAL.GetAll();
        }

        public static string TaoMaMoi(string congviecId)
        {
            if (string.IsNullOrEmpty(congviecId))
                return string.Empty;

            if (congviecId == "Aa1")
            {
                string sql2 = "Select top 1 right(nhanvien_id,1) From NhanVien where congviec_id='Aa1' order by right(nhanvien_id,1) desc";
                float count = Function.FirstRowNumberSafe(sql2) + 1;
                return "A" + count;
            }
            else if (congviecId == "Aa2")
            {
                string sql2 = "Select top 1 right(nhanvien_id,1) From NhanVien where congviec_id='Aa2' order by right(nhanvien_id,1) desc";
                float count = Function.FirstRowNumberSafe(sql2) + 1;
                return "E" + count;
            }

            return string.Empty;
        }

        public static void ThemNhanVien(
            string id,
            string ten,
            string gioitinh,
            string diachi,
            string dienthoai,
            string ngaysinhIso,
            string ngaytuyendungIso,
            string congviecId,
            string email,
            string trangthai)
        {
            NhanVienDAL.Insert(id, ten, gioitinh, diachi, dienthoai, ngaysinhIso, ngaytuyendungIso, congviecId, email, trangthai);
        }

        public static void CapNhatNhanVien(
            string id,
            string ten,
            string gioitinh,
            string diachi,
            string dienthoai,
            string ngaysinhIso,
            string ngaytuyendungIso,
            string congviecId,
            string email,
            string trangthai)
        {
            NhanVienDAL.Update(id, ten, gioitinh, diachi, dienthoai, ngaysinhIso, ngaytuyendungIso, congviecId, email, trangthai);
        }
    }
}
