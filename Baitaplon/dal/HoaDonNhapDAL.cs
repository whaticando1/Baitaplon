using Baitaplon.Class;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                (hoadonnhap_id, sanpham_id, soluong, gianhap)
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
        }
    }

