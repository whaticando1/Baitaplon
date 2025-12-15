using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baitaplon.DAL;
using System.Data;

namespace Baitaplon.BLL
{
    internal class TheLoaiBLL
    {
        public static DataTable LayDanhSachLoai()
        {
            return TheLoaiDAL.GetAll();
        }
    }
}
