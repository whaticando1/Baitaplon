using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baitaplon.Class;

namespace Baitaplon.DAL
{
    internal class CongViecDAL
    {
        public static DataTable GetAll()
        {
            string sql = "SELECT congviec_id, tencongviec, mota, luongcoban FROM CongViec";
            return Function.GetDataToTable(sql);
        }

        public static void Update(string id, string ten, string mota, decimal luongcoban)
        {
            // convert decimal to DB-friendly format (dot decimal separator)
            string luongStr = luongcoban.ToString().Replace(",", ".");
            string sql = "UPDATE CongViec SET tencongviec=N'" + ten + "', mota=N'" + mota + "', luongcoban=" + luongStr + " WHERE congviec_id=N'" + id + "'";
            Function.RunSql(sql);
        }
    }
}
