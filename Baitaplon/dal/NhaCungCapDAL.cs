using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Baitaplon.Class;

namespace Baitaplon.DAL
{
    internal class NhaCungCapDAL
    {
        public static DataTable GetAll()
        {
            string sql = @"
                SELECT nhacungcap_id, tennhacungcap
                FROM NhaCungCap
                ORDER BY tennhacungcap";

            return Function.GetDataToTable(sql); 
          
        }
    }
}
