using Baitaplon.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Baitaplon.BLL
{
    internal class NhaCungCapBLL
    {


        public static DataTable LayDanhSachNhaCungCap()
        {
            return NhaCungCapDAL.GetAll();
        }
}
}
