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
    internal class CTHoaDonNhapDAL
    {
        public static DataTable GetChiTietHoaDonNhap(int hdnId)
        {
            string sql = @"
        SELECT 
            sp.tensanpham,
            cthdn.soluong,
            cthdn.dongia,
            cthdn.giamgia,
            cthdn.thanhtien
        FROM ChiTietHoaDonNhap cthdn
        JOIN SanPham sp ON cthdn.sanpham_id = sp.sanpham_id
        WHERE cthdn.hoadonnhap_id = @id
    ";

            SqlParameter[] pr =
            {
        new SqlParameter("@id", hdnId)
    };

            return Function.GetDataToTable(sql);
        }
        public static DataRow GetHoaDonNhapById(int hdnId)
        {
            string sql = @"
        SELECT 
            hoadonnhap_id,
            nhanvien_id,
            nhacungcap_id,
            ngaynhap,
            tongtien
        FROM HoaDonNhap
        WHERE hoadonnhap_id = @id
    ";

            SqlParameter[] pr =
            {
        new SqlParameter("@id", hdnId)
    };

            return Function.GetDataToTable(sql).Rows[0];

        }
        public static DataTable TimKiemHoaDonNhap(
    string maHoaDon,
    DateTime? ngayNhap,
    int? nhanVienId,
    int? nhaCungCapId,
    string tenSanPham)
        {
            string sql = @"
        SELECT DISTINCT
            hdn.hoadonnhap_id,
            hdn.ngaynhap,
            nv.tennhanvien,
            ncc.tennhacungcap,
            hdn.tongtien
        FROM HoaDonNhap hdn
        JOIN NhanVien nv ON hdn.nhanvien_id = nv.nhanvien_id
        JOIN NhaCungCap ncc ON hdn.nhacungcap_id = ncc.nhacungcap_id
        LEFT JOIN ChiTietHoaDonNhap ct ON hdn.hoadonnhap_id = ct.hoadonnhap_id
        LEFT JOIN SanPham sp ON ct.sanpham_id = sp.sanpham_id
        WHERE 1 = 1
    ";

            List<SqlParameter> pr = new List<SqlParameter>();

            if (!string.IsNullOrWhiteSpace(maHoaDon))
            {
                sql += " AND hdn.hoadonnhap_id = @mahd";
                pr.Add(new SqlParameter("@mahd", maHoaDon));
            }

            if (ngayNhap.HasValue)
            {
                sql += " AND CAST(hdn.ngaynhap AS DATE) = @ngay";
                pr.Add(new SqlParameter("@ngay", ngayNhap.Value.Date));
            }

            if (nhanVienId.HasValue)
            {
                sql += " AND hdn.nhanvien_id = @nv";
                pr.Add(new SqlParameter("@nv", nhanVienId));
            }

            if (nhaCungCapId.HasValue)
            {
                sql += " AND hdn.nhacungcap_id = @ncc";
                pr.Add(new SqlParameter("@ncc", nhaCungCapId));
            }

            if (!string.IsNullOrWhiteSpace(tenSanPham))
            {
                sql += " AND sp.tensanpham LIKE @sp";
                pr.Add(new SqlParameter("@sp", "%" + tenSanPham + "%"));
            }

            return Function.GetDataToTable(sql);
        }
        public static string GetAnhSanPhamByHoaDonNhap(int hdnId)
        {
            string sql = @"
        SELECT TOP 1 sp.url_anh
        FROM ChiTietHoaDonNhap ct
        JOIN SanPham sp ON ct.sanpham_id = sp.sanpham_id
        WHERE ct.hoadonnhap_id = @id
    ";

            SqlParameter[] pr =
            {
        new SqlParameter("@id", hdnId)
    };

            object result = Function.ExecuteScalar(sql, pr);
            return result == null ? "" : result.ToString();
        }

        public static void UpdateChiTietHoaDonNhap(
    int hdnId,
    int sanPhamId,
    int soLuong,
    decimal donGia,
    decimal giamGia)
        {
            decimal thanhTien = soLuong * donGia - giamGia;

            string sql = @"
        UPDATE ChiTietHoaDonNhap
        SET soluong = @sl,
            dongia = @dg,
            giamgia = @gg,
            thanhtien = @tt
        WHERE hoadonnhap_id = @hdn
          AND sanpham_id = @sp
    ";

            SqlParameter[] pr =
            {
        new SqlParameter("@sl", soLuong),
        new SqlParameter("@dg", donGia),
        new SqlParameter("@gg", giamGia),
        new SqlParameter("@tt", thanhTien),
        new SqlParameter("@hdn", hdnId),
        new SqlParameter("@sp", sanPhamId)
    };

            Function.ExecuteNonQuery(sql, pr);
        }
        public static void UpdateTongTien(int hdnId, decimal tongTien)
        {
            string sql = @"
        UPDATE HoaDonNhap
        SET tongtien = @tong
        WHERE hoadonnhap_id = @id
    ";

            SqlParameter[] pr =
            {
        new SqlParameter("@tong", tongTien),
        new SqlParameter("@id", hdnId)
    };

            Function.ExecuteNonQuery(sql, pr);
        }
        public static void DeleteChiTietHoaDonNhap(int hdnId, int sanPhamId)
        {
            string sql = @"
        DELETE FROM ChiTietHoaDonNhap
        WHERE hoadonnhap_id = @hdn
          AND sanpham_id = @sp
    ";

            SqlParameter[] pr =
            {
        new SqlParameter("@hdn", hdnId),
        new SqlParameter("@sp", sanPhamId)
    };

            Function.ExecuteNonQuery(sql, pr);
        }
    }
}
