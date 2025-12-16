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
    internal class HoaDonNhapDAL
    {
        
         
            public static int InsertHoaDonNhap(int nccId, decimal tongTien)
            {
                string sql = @"
                INSERT INTO HoaDonNhap(nhacungcap_id, tongtien, ngaynhap)
                OUTPUT INSERTED.hoadonnhap_id
                VALUES (@ncc, @tong)
            ";

                SqlParameter[] pr =
                {
                new SqlParameter("@ncc", nccId),
                new SqlParameter("@tong", tongTien)
            };

                return (int)Function.ExecuteScalar(sql, pr);
            }


            public static void InsertChiTiet(
                int hdnId,
                int sanphamId,
                int soLuong,
                decimal giaNhap)
            {
                string sql = @"
                INSERT INTO ChiTietHoaDonNhap
                (hoadonnhap_id, sanpham_id, soluong, dongia)
                VALUES (@hdn, @sp, @sl, @gia)
            ";

                SqlParameter[] pr =
                {
                new SqlParameter("@hdn", hdnId),
                new SqlParameter("@sp", sanphamId),
                new SqlParameter("@sl", soLuong),
                new SqlParameter("@gia", giaNhap)
            };

                Function.ExecuteNonQuery(sql, pr);
            }
        public static DataTable GetAllHoaDonNhap()
        {
            string sql = @"
        SELECT 
            hdn.hoadonnhap_id,
            hdn.ngaynhap,
            ncc.tennhacungcap,
            nv.tennhanvien,
            hdn.tongtien
        FROM HoaDonNhap hdn
        JOIN NhaCungCap ncc ON hdn.nhacungcap_id = ncc.nhacungcap_id    
        JOIN NhanVien nv ON hdn.nhanvien_id = nv.nhanvien_id
        ORDER BY hdn.hoadonnhap_id DESC
    ";

            return Function.GetDataToTable(sql);
        }
    }
    }

