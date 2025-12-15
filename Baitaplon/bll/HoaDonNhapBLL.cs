using Baitaplon.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitaplon.BLL
{
    internal class HoaDonNhapBLL
    {
        public static DataTable LaySanPham()
        {
            return SanPhamDAL.GetAll();
        }

        public static DataTable LayNhaCungCap()
        {
            return NhaCungCapDAL.GetAll();
        }

        public static bool LuuHoaDonNhap(int nccId, DataTable gioNhap, decimal tongTien)
        {
            try
            {
                int hdnId = HoaDonNhapDAL.InsertHoaDonNhap(nccId, tongTien);

                foreach (DataRow r in gioNhap.Rows)
                {
                    int spId = (int)r["sanpham_id"];
                    int sl = (int)r["soluong"];
                    decimal gia = (decimal)r["gianhap"];

                    HoaDonNhapDAL.InsertChiTiet(hdnId, spId, sl, gia);
                    SanPhamDAL.CongTonKho(spId, sl); 
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
