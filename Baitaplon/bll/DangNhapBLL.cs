using Baitaplon.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace Baitaplon.BLL
{
    public class DangNhapBLL
    {       
       DAL.DangNhapDAL dal = new DAL.DangNhapDAL();
        public bool DangNhap(string ten, string matkhau)
        {
            if (string.IsNullOrWhiteSpace(ten) || string.IsNullOrWhiteSpace(matkhau))
                return false;

            return dal.KiemTraDangNhap(ten, matkhau);
        }
    }
}
