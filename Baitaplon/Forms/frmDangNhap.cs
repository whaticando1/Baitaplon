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
using Baitaplon.BLL;

namespace Baitaplon.Forms
{
    public partial class frmDangNhap : Form
    {
        DangNhapBLL bll = new DangNhapBLL();
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

            bool ketQua = bll.DangNhap(txtTen.Text, txtMatkhau.Text);
            if (ketQua)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblThongbao.Text = "Kiểm tra lại tên tài khoản và mật khẩu";
                lblThongbao.ForeColor = Color.Red;
                txtTen.Focus();
                return;
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Class.Function.Disconnect();
            Application.Exit();
        }
    }
}

