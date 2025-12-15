using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baitaplon.Class;

namespace Baitaplon.DAL
{
    internal class NhanVienDAL
    {
        public static DataTable GetAll()
        {
            string sql = "SELECT nhanvien_id, tennhanvien, gioitinh, diachi, dienthoai, ngaysinh, ngaytuyendung, congviec_id, email, trangthai FROM NhanVien";
            return Function.GetDataToTable(sql);
        }

        public static void Insert(
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
            string sql = "INSERT INTO NhanVien(nhanvien_id, tennhanvien, gioitinh, diachi, dienthoai, ngaysinh, ngaytuyendung, congviec_id, email, trangthai) VALUES(" +
                         "N'" + id + "', " +
                         "N'" + ten + "', " +
                         "N'" + gioitinh + "', " +
                         "N'" + diachi + "', " +
                         "N'" + dienthoai + "', " +
                         "N'" + ngaysinhIso + "', " +
                         "N'" + ngaytuyendungIso + "', " +
                         "N'" + congviecId + "', " +
                         "N'" + email + "', " +
                         "N'" + trangthai + "')";
            Function.RunSql(sql);
        }

        public static void Update(
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
            string sql = "UPDATE NhanVien SET " +
                         "tennhanvien=N'" + ten + "', " +
                         "gioitinh=N'" + gioitinh + "', " +
                         "diachi=N'" + diachi + "', " +
                         "dienthoai=N'" + dienthoai + "', " +
                         "ngaysinh=N'" + ngaysinhIso + "', " +
                         "ngaytuyendung=N'" + ngaytuyendungIso + "', " +
                         "congviec_id=N'" + congviecId + "', " +
                         "email=N'" + email + "', " +
                         "trangthai=N'" + trangthai + "' " +
                         "WHERE nhanvien_id=N'" + id + "'";
            Function.RunSql(sql);
        }
    }
}
