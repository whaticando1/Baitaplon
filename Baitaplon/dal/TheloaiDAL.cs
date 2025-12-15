using Baitaplon.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Baitaplon.DAL
{
    internal class TheLoaiDAL
    {
        public static DataTable GetAll()
        {
            string sql = "SELECT loaiquanao_id, tenloai FROM LoaiQuanAo";
            return Function.GetDataToTable(sql);
        }
    }
}
