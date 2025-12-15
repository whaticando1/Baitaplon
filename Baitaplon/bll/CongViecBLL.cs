using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baitaplon.DAL;

namespace Baitaplon.BLL
{
    internal class CongViecBLL
    {
        public static DataTable LayTatCaCongViec()
        {
            return CongViecDAL.GetAll();
        }

        public static void CapNhatCongViec(string id, string ten, string mota, decimal luongcoban)
        {
            CongViecDAL.Update(id, ten, mota, luongcoban);
        }
    }
}
