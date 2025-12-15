using System;
using Baitaplon.DAL;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Baitaplon.Class;

namespace Baitaplon.BLL
{
    internal class KhachHangBLL
    {

            public static DataTable LayDanhSachKhachHang()
            {
                return KhachHangDAL.GetAll();
            }
        
    }
}
