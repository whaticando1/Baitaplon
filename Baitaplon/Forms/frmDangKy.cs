using Baitaplon.BLL;
using Baitaplon.Class;
using Baitaplon.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string sql;
            sql = "SELECT tendangnhap, matkhau, nhanvien_id FROM DangNhap";
            tblDangky = Class.Function.GetDataToTable(sql);
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
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
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
            sql = "SELECT tendangnhap FROM DangNhap WHERE nhanvien_id = N'" + nhanvienId + "'";
            if (Function.CheckKey(sql))
            {
                lblThongbao.Text = "Nhân viên này đã có tài khoản đăng nhập";
                lblThongbao.ForeColor = Color.Red;
                cboNhanvien.Focus();
                return;
            }

            if (MessageBox.Show("Bạn có muốn đăng ký tài khoản này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "INSERT INTO DangNhap (tendangnhap, matkhau, nhanvien_id ) VALUES (N'" + txtTen.Text.Trim() + "', N'" + txtMatkhau.Text.Trim() + "', N'" + cboNhanvien.SelectedValue.ToString() + "')";
                Function.RunSql(sql);
                MessageBox.Show("Đăng ký tài khoản mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Load_DataGridView();
                Resetvalues();
                btnLamlai.Enabled = false;
                btnThem.Enabled = true;
                btnLuu.Enabled = false;
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
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
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
            sql = "UPDATE DangNhap SET matkhau = N'" + txtMatkhau.Text.Trim().ToString() + "', nhanvien_id = N'" + cboNhanvien.SelectedValue.ToString() + "' WHERE tendangnhap = N'" + txtTen.Text.Trim() + "'";
            Function.RunSql(sql);
            MessageBox.Show("Cập nhật tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Resetvalues(); 
            btnLamlai.Enabled = false;
            btnSua.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblDangky.Rows.Count == 0)
            {
                lblThongbao.Text = "Không có dữ liệu!";
                lblThongbao.ForeColor = Color.Red;
                return;
            }
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTen.Focus();
                return;
            }
            txtMatkhau.Text = dataGridView1.CurrentRow.Cells["matkhau"].Value.ToString();
            txtTen.Text = dataGridView1.CurrentRow.Cells["tendangnhap"].Value.ToString();
            cboNhanvien.SelectedValue = dataGridView1.CurrentRow.Cells["nhanvien_id"].Value.ToString();
            btnLamlai.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = false;
        }
    }
}
