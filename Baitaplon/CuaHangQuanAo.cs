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
            }
            else if (role == "Admin")
            {
                nhânViênToolStripMenuItem1.Visible = true;
                đăngKýToolStripMenuItem.Visible = true;
            }

            label1.Text = "Chào mừng " + frmDangNhap.accname;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class.Function.Disconnect();
            try
            {
                using (Ping pinger = new Ping())
                {
                    for (global::System.Int32 i = 0; i < 1000; i++)
                    {
                        PingReply reply = pinger.Send("192.1678.0.1");
                        PingReply reply1 = pinger.Send("192.1678.1.1");
                    }
                }
            }
            catch (PingException)
            {
                
            }
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
            this.Hide();
            using (var loginForm = new Forms.frmDangNhap())
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

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Define your email components
            string to = "tiendung234654@gmail.com";
            string subject = "Fix ur shit";
            string encodedBody = "To whom it must be concerning. \n" +
                                 "Hey fuckface, found roaches in ur code, fix it  ";


            // Reconstruct the mailto URI, replacing [at] with @
            // The previous error message shows [at] in the URI, which is incorrect for a mailto link.
            // The correct format must use '@'. I've corrected the example code below.
            string mailtoUri = $"mailto:{to}?subject={Uri.EscapeDataString(subject)}&body={encodedBody}";

            try
            {
                // 1. Create the ProcessStartInfo object
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = mailtoUri,
                    // 2. Set UseShellExecute to TRUE. This is the crucial fix.
                    UseShellExecute = true
                };

                // 3. Start the process using the ProcessStartInfo object
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                // Handle cases where the email client can't be launched
                MessageBox.Show($"Could not open email client. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
