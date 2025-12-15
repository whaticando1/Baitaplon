using Baitaplon.BLL;
using Baitaplon.Class;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Baitaplon.Forms
{
    public partial class frmKhachHang : Form
    {
        DataTable tblKH;
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            Resetvalues();
            Load_DataGridViewKH();
            txtMakhach.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnBoqua.Enabled = false;
        }
        private void Resetvalues()
        {
            txtMakhach.Text = "";
            txtTenkhach.Text = "";
            txtDiachi.Text = "";
            txtEmail.Text = "";
            mskDangky.Text = "";
            mskDienthoai.Text = "";
            lblThongbao.Text = "";
        }
        private void Load_DataGridViewKH()
        {
            tblKH = KhachHangBLL.LayDanhSachKhachHang();
            DataGridView.DataSource = tblKH;

            if (DataGridView.Rows.Count > 0)
            {
                DataGridView.Columns[0].HeaderText = "Mã khách hàng";
                DataGridView.Columns[1].HeaderText = "Tên khách hàng";
                DataGridView.Columns[2].HeaderText = "Địa chỉ";
                DataGridView.Columns[3].HeaderText = "Điện thoại";
                DataGridView.Columns[4].HeaderText = "Email";
                DataGridView.Columns[5].HeaderText = "Ngày đăng ký";
                DataGridView.Columns[0].Width = 100;
                DataGridView.Columns[1].Width = 150;
                DataGridView.Columns[2].Width = 150;
                DataGridView.Columns[3].Width = 100;
                DataGridView.Columns[4].Width = 150;
                DataGridView.Columns[5].Width = 100;

                DataGridView.AllowUserToAddRows = false;
                DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtMakhach.Text = DataGridView.CurrentRow.Cells["khachhang_id"].Value.ToString();
            txtTenkhach.Text = DataGridView.CurrentRow.Cells["tenkhachhang"].Value.ToString();
            txtDiachi.Text = DataGridView.CurrentRow.Cells["diachi"].Value.ToString();
            mskDienthoai.Text = DataGridView.CurrentRow.Cells["dienthoai"].Value.ToString();
            txtEmail.Text = DataGridView.CurrentRow.Cells["email"].Value.ToString();
            if (DataGridView.CurrentRow.Cells["ngaydangky"].Value != DBNull.Value)
            {
                DateTime ngaydk = Convert.ToDateTime(DataGridView.CurrentRow.Cells["ngaydangky"].Value);
                mskDangky.Text = ngaydk.ToString("dd/MM/yyyy");
            }
            else
            {
                mskDangky.Text = "";
            }
            btnSua.Enabled = true;
            btnBoqua.Enabled = true;
            btnThem.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string id = "";

            if (txtTenkhach.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải nhập tên khách!";
                lblThongbao.ForeColor = Color.Red;
                txtTenkhach.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải nhập địa chỉ khách hàng!";
                lblThongbao.ForeColor = Color.Red;
                txtDiachi.Focus();
                return;
            }
            if (txtEmail.Text.Trim().Length == 0 || !txtEmail.Text.Contains("@"))
            {
                lblThongbao.Text = "Phải nhập email khách hàng!";
                lblThongbao.ForeColor = Color.Red;
                txtEmail.Focus();
                return;
            }
            if (mskDienthoai.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải nhập điện thoại khách hàng!";
                lblThongbao.ForeColor = Color.Red;
                mskDienthoai.Focus();
                return;
            }
            if (mskDangky.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải nhập ngày đăng ký!";
                lblThongbao.ForeColor = Color.Red;
                mskDangky.Focus();
                return;
            }
            if (!Class.Function.IsDate(mskDangky.Text))
            {
                lblThongbao.Text = "Ngày đăng ký không hợp lệ!";
                lblThongbao.ForeColor = Color.Red;
                mskDangky.Focus();
                return;
            }

            id = KhachHangBLL.TaoMaMoi();

            string ngaydk = Class.Function.ConvertDateTime(mskDangky.Text);
            KhachHangBLL.ThemKhachHang(
                id,
                txtTenkhach.Text.Trim(),
                txtDiachi.Text.Trim(),
                mskDienthoai.Text,
                txtEmail.Text.Trim(),
                ngaydk
            );

            Load_DataGridViewKH();
            Resetvalues();
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenkhach.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải nhập tên khách!";
                lblThongbao.ForeColor = Color.Red;
                txtTenkhach.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải nhập địa chỉ khách hàng!";
                lblThongbao.ForeColor = Color.Red;
                txtDiachi.Focus();
                return;
            }
            if (txtEmail.Text.Trim().Length == 0 || !txtEmail.Text.Contains("@"))
            {
                lblThongbao.Text = "Phải nhập email khách hàng!";
                lblThongbao.ForeColor = Color.Red;
                txtEmail.Focus();
                return;
            }
            if (mskDienthoai.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải nhập điện thoại khách hàng!";
                lblThongbao.ForeColor = Color.Red;
                mskDienthoai.Focus();
                return;
            }
            if (mskDangky.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải nhập ngày đăng ký!";
                lblThongbao.ForeColor = Color.Red;
                mskDangky.Focus();
                return;
            }
            if (!Class.Function.IsDate(mskDangky.Text))
            {
                lblThongbao.Text = "Ngày đăng ký không hợp lệ!";
                lblThongbao.ForeColor = Color.Red;
                mskDangky.Focus();
                return;
            }

            string ngaydk = Class.Function.ConvertDateTime(mskDangky.Text);
            KhachHangBLL.CapNhatKhachHang(
                txtMakhach.Text,
                txtTenkhach.Text.Trim(),
                txtDiachi.Text.Trim(),
                mskDienthoai.Text,
                txtEmail.Text.Trim(),
                ngaydk
            );

            Load_DataGridViewKH();
            Resetvalues();
            btnSua.Enabled = false;
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnBoqua.Enabled = true;
            Resetvalues();
            txtTenkhach.Focus();
        }
        private void btnBoqua_Click(object sender, EventArgs e)
        {
            Resetvalues();
            btnSua.Enabled = false;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenkhach_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtDiachi.Focus();
        }

        private void txtDiachi_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                mskDienthoai.Focus();
        }

        private void mskDienthoai_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                mskDangky.Focus();
        }

        private void mskDangky_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtEmail.Focus();
        }
    }
}
