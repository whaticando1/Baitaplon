using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Baitaplon.Forms
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            Class.Function.Connect();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "")
            {
                lblThongbao.Text = "Bạn chưa nhập tên đăng nhập!";
                lblThongbao.ForeColor = Color.Red;
                txtTen.Focus();
                return;
            }
            if (txtMatkhau.Text == "")
            {
                lblThongbao.Text = "Bạn chưa nhập mật khẩu!";
                lblThongbao.ForeColor = Color.Red;
                txtMatkhau.Focus();
                return;
            }
            string sql = "SELECT * FROM DangNhap WHERE tendangnhap = N'" + txtTen.Text + "' AND matkhau = N'" + txtMatkhau.Text + "'";
            if (Class.Function.CheckKey(sql))
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Optionally, you can set DialogResult to Cancel or leave it unset to allow retry
                // this.DialogResult = DialogResult.Cancel;
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Class.Function.Disconnect();
            Application.Exit();
        }
    }
}

