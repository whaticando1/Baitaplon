using Baitaplon.BLL;
using Baitaplon.Class;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Baitaplon.Forms
{
    public partial class frmDangKy : Form
    {
        DataTable tblDangky;
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            cboNhanvien.DropDownStyle = ComboBoxStyle.DropDownList;
            Function.FillCombo("SELECT nhanvien_id, tennhanvien FROM NhanVien", cboNhanvien, "nhanvien_id", "tennhanvien");
            cboNhanvien.SelectedIndex = -1;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnLamlai.Enabled = false;
            btnXoa.Enabled = false;
            cboNhanvien.Enabled = false;
            Load_DataGridView();
            Resetvalues();
        }
        private void Resetvalues()
        {
            txtMatkhau.Text = "";
            txtTen.Text = "";
            cboNhanvien.SelectedIndex = -1;
            lblThongbao.Text = "";
        }
        private void Load_DataGridView()
        {
            tblDangky = DangKyBLL.LayTatCaDangNhap();
            dataGridView1.DataSource = tblDangky;

            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Columns[0].HeaderText = "Tên đăng nhập";
                dataGridView1.Columns[1].HeaderText = "Mật khẩu";
                dataGridView1.Columns[2].HeaderText = "Mã nhân viên";
                dataGridView1.Columns[0].Width = 150;
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[2].Width = 150;
            }
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void btnLamlai_Click(object sender, EventArgs e)
        {
            Resetvalues();
            btnLamlai.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            cboNhanvien.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải nhập tên đăng nhập";
                lblThongbao.ForeColor = Color.Red;
                txtTen.Focus();
                return;
            }
            if (txtMatkhau.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải nhập mật khẩu";
                lblThongbao.ForeColor = Color.Red;
                txtMatkhau.Focus();
                return;
            }
            if (cboNhanvien.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải chọn nhân viên";
                lblThongbao.ForeColor = Color.Red;
                cboNhanvien.Focus();
                return;
            }
            string nhanvienId = cboNhanvien.SelectedValue.ToString();
            if (DangKyBLL.NhanVienDaCoTaiKhoan(nhanvienId))
            {
                lblThongbao.Text = "Nhân viên này đã có tài khoản đăng nhập";
                lblThongbao.ForeColor = Color.Red;
                cboNhanvien.Focus();
                return;
            }

            if (MessageBox.Show("Bạn có muốn đăng ký tài khoản này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DangKyBLL.ThemDangNhap(txtTen.Text.Trim(), txtMatkhau.Text.Trim(), cboNhanvien.SelectedValue.ToString());
                MessageBox.Show("Đăng ký tài khoản mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Load_DataGridView();
                Resetvalues();
                btnLamlai.Enabled = false;
                btnThem.Enabled = true;
                btnLuu.Enabled = false;
                cboNhanvien.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnLamlai.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            Resetvalues();
            txtTen.Focus();
            cboNhanvien.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tblDangky.Rows.Count == 0)
            {
                lblThongbao.Text = "Không có dữ liệu!";
                lblThongbao.ForeColor = Color.Red;
                return;
            }
            if (txtTen.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải nhập tên đăng nhập";
                lblThongbao.ForeColor = Color.Red;
                txtTen.Focus();
                return;
            }
            if (txtMatkhau.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải nhập mật khẩu";
                lblThongbao.ForeColor = Color.Red;
                txtMatkhau.Focus();
                return;
            }
            if (cboNhanvien.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải chọn nhân viên";
                lblThongbao.ForeColor = Color.Red;
                cboNhanvien.Focus();
                return;
            }

            DangKyBLL.CapNhatDangNhap(txtTen.Text.Trim(), txtMatkhau.Text.Trim(), cboNhanvien.SelectedValue.ToString());

            MessageBox.Show("Cập nhật tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Resetvalues();
            Load_DataGridView();
            btnLamlai.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblDangky.Rows.Count == 0)
            {
                lblThongbao.Text = "Không có dữ liệu!";
                lblThongbao.ForeColor = Color.Red;
                return;
            }

            txtMatkhau.Text = dataGridView1.CurrentRow.Cells["matkhau"].Value.ToString();
            txtTen.Text = dataGridView1.CurrentRow.Cells["tendangnhap"].Value.ToString();
            cboNhanvien.SelectedValue = dataGridView1.CurrentRow.Cells["nhanvien_id"].Value.ToString();
            btnLamlai.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = true;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tt = DangKyBLL.LayTrangThaiNhanVien(cboNhanvien.SelectedValue.ToString());
            int fad = DangKyBLL.DemAdmin();
            if (fad <= 1)
            {
                MessageBox.Show("Nhân viên này là admin cuối cùng, không thể xóa tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (tt == "Đang làm việc")
            {
                MessageBox.Show("Nhân viên này vẫn còn đang làm việc, không thể xóa tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DangKyBLL.XoaDangNhap(cboNhanvien.SelectedValue.ToString());
                    Load_DataGridView();
                    Resetvalues();
                    btnXoa.Enabled = false;
                    btnSua.Enabled = false;
                    btnLamlai.Enabled = false;
                    btnThem.Enabled = true;
                }
            }
        }

        private void txtTen_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtMatkhau.Focus();
        }
    }
}
