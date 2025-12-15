using Baitaplon.Class;
using Baitaplon.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Baitaplon
{
    public partial class CuaHangQuanAo : Form
    {
        public string role;

        public CuaHangQuanAo()
        {
            this.role = Forms.frmDangNhap.role;
            InitializeComponent();

           
        }

        private void CuaHangQuanAo_Load(object sender, EventArgs e)
        {
            Class.Function.Connect();

            if (role == "Employee")
            {
                nhânViênToolStripMenuItem1.Visible = false;
                đăngKýToolStripMenuItem.Visible = false;
                côngViệcToolStripMenuItem.Visible = false;
            }
            else if (role == "Admin")
            {
                nhânViênToolStripMenuItem1.Visible = true;
                đăngKýToolStripMenuItem.Visible = true;
                côngViệcToolStripMenuItem.Visible = true;
            }

            label1.Text = "Chào mừng " + frmDangNhap.accname;
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
            Forms.frmDangKy f = new Forms.frmDangKy();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                this.Hide();
                using (var loginForm = new Forms.frmDangNhap())
                {
                    if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {

                        if (loginForm.ShowDialog() == DialogResult.OK)
                        {
                            this.role = Forms.frmDangNhap.role;
                            this.Show();
                            CuaHangQuanAo_Load(this, EventArgs.Empty);
                        }
                        else
                        {
                            Application.Exit();
                        }
                    }
                }
            }
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            string to = "VerysadboiA@gmail.com";
            string subject = "need help";
            string encodedBody = "please";


            string mailtoUri = $"mailto:{to}?subject={Uri.EscapeDataString(subject)}&body={encodedBody}";

            try
            {
                
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = mailtoUri,
                    
                    UseShellExecute = true
                };

               
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Could not open email client. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
