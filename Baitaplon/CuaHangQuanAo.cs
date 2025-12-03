using Baitaplon.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitaplon
{
    public partial class CuaHangQuanAo : Form
    {
        public CuaHangQuanAo()
        {
            InitializeComponent();
        }

        private void CuaHangQuanAo_Load(object sender, EventArgs e)
        {
            Class.Function.Connect();

           

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class.Function.Disconnect();
            Application.Exit();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmSanPham f = new Forms.frmSanPham();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Forms.frmNhanVien f = new Forms.frmNhanVien();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void côngViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmCongViec f = new Forms.frmCongViec();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmKhachHang f = new Forms.frmKhachHang();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmNhaCungCap f = new Forms.frmNhaCungCap();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void hoáĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmHoaDonBan f = new Forms.frmHoaDonBan();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void hoáĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmHoaDonNhap f = new Forms.frmHoaDonNhap();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            using (var loginForm = new Forms.frmDangNhap())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    this.Show(); 
                }
                else
                {
                    Application.Exit(); 
                }
            }
        }
    }
}
