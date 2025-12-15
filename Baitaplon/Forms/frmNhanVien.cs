using Baitaplon.BLL;
using Baitaplon.Class;
using Baitaplon.DAL;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Baitaplon.Forms
{
    public partial class frmNhanVien : Form
    {
        DataTable tblNhanvien;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            cboCongviec.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangthai.DropDownStyle = ComboBoxStyle.DropDownList;
            Function.FillCombo("SELECT congviec_id, tencongviec FROM CongViec", cboCongviec, "congviec_id", "tencongviec");
            cboCongviec.SelectedIndex = -1;
            cboTrangthai.BeginUpdate();
            cboTrangthai.Items.Add("Đang làm việc");
            cboTrangthai.Items.Add("Đã nghỉ");
            cboTrangthai.EndUpdate();
            txtManhanvien.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            btnSua.Enabled = false;
            cboCongviec.Enabled = false;
            Resetvalues();
            Load_DataGridView();
        }

        private void Resetvalues()
        {
            lblwarning.Text = "";
            txtManhanvien.Text = "";
            txtTennhanvien.Text = "";
            txtDiachi.Text = "";
            mskDienthoai.Text = "";
            mskNgaysinh.Text = "";
            mskNgaytuyendung.Text = "";
            chkNam.Checked = false;
            chkNu.Checked = false;
            txtEmail.Text = "";
            cboTrangthai.SelectedIndex = -1;
            cboCongviec.SelectedIndex = -1;
            lblThongbao.Text = "";
        }

        private void Load_DataGridView()
        {
            tblNhanvien = NhanVienBLL.LayTatCaNhanVien();
            DataGridView.DataSource = tblNhanvien;

            if (DataGridView.Rows.Count > 0)
            {
                DataGridView.Columns[0].HeaderText = "Mã nhân viên";
                DataGridView.Columns[1].HeaderText = "Tên nhân viên";
                DataGridView.Columns[2].HeaderText = "Giới tính";
                DataGridView.Columns[3].HeaderText = "Địa chỉ";
                DataGridView.Columns[4].HeaderText = "Điện thoại";
                DataGridView.Columns[5].HeaderText = "Ngày sinh";
                DataGridView.Columns[6].HeaderText = "Ngày tuyển dụng";
                DataGridView.Columns[7].HeaderText = "Mã công việc";
                DataGridView.Columns[8].HeaderText = "Email";
                DataGridView.Columns[9].HeaderText = "Trạng thái";
                DataGridView.Columns[0].Width = 100;
                DataGridView.Columns[1].Width = 150;
                DataGridView.Columns[2].Width = 100;
                DataGridView.Columns[3].Width = 200;
                DataGridView.Columns[4].Width = 100;
                DataGridView.Columns[5].Width = 100;
                DataGridView.Columns[6].Width = 100;
                DataGridView.Columns[7].Width = 100;
                DataGridView.Columns[8].Width = 150;
                DataGridView.Columns[9].Width = 100;
            }
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblNhanvien.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            txtManhanvien.Text = DataGridView.CurrentRow.Cells["nhanvien_id"].Value.ToString();
            txtTennhanvien.Text = DataGridView.CurrentRow.Cells["tennhanvien"].Value.ToString();
            string gioitinh = DataGridView.CurrentRow.Cells["Gioitinh"].Value.ToString();
            if (gioitinh == "Nam")
            {
                chkNam.Checked = true;
                chkNu.Checked = false;
            }
            else if (gioitinh == "Nữ")
            {
                chkNam.Checked = false;
                chkNu.Checked = true;
            }
            else
            {
                chkNam.Checked = false;
                chkNu.Checked = false;
            }
            txtDiachi.Text = DataGridView.CurrentRow.Cells["Diachi"].Value.ToString();
            mskDienthoai.Text = DataGridView.CurrentRow.Cells["Dienthoai"].Value.ToString();

            if (DataGridView.CurrentRow.Cells["ngaysinh"].Value != DBNull.Value)
            {
                DateTime ngaysinh = Convert.ToDateTime(DataGridView.CurrentRow.Cells["ngaysinh"].Value);
                mskNgaysinh.Text = ngaysinh.ToString("dd/MM/yyyy");
            }
            else
            {
                mskNgaysinh.Text = "";
            }

            if (DataGridView.CurrentRow.Cells["ngaytuyendung"].Value != DBNull.Value)
            {
                DateTime ngaytuyendung = Convert.ToDateTime(DataGridView.CurrentRow.Cells["ngaytuyendung"].Value);
                mskNgaytuyendung.Text = ngaytuyendung.ToString("dd/MM/yyyy");
            }
            else
            {
                mskNgaytuyendung.Text = "";
            }
            cboCongviec.SelectedValue = DataGridView.CurrentRow.Cells["congviec_id"].Value.ToString();
            txtEmail.Text = DataGridView.CurrentRow.Cells["Email"].Value.ToString();
            cboTrangthai.Text = DataGridView.CurrentRow.Cells["trangthai"].Value.ToString();
            btnSua.Enabled = true;
            btnBoqua.Enabled = true;
            btnThem.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql, gt, id = "";
            if (txtTennhanvien.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải nhập tên nhân viên!";
                lblThongbao.ForeColor = Color.Red;
                txtTennhanvien.Focus();
                return;
            }
            if (txtEmail.Text.Trim().Length == 0 || !txtEmail.Text.Contains("@"))
            {
                lblThongbao.Text = "Phải nhập Email!";
                lblThongbao.ForeColor = Color.Red;
                txtEmail.Focus();
                return;
            }
            if (chkNam.Checked == false && chkNu.Checked == false)
            {
                lblThongbao.Text = "Phải chọn giới tính!";
                lblThongbao.ForeColor = Color.Red;
                return;
            }
            if (mskNgaysinh.Text == "  /  /")
            {
                lblThongbao.Text = "Phải nhập ngày sinh!";
                lblThongbao.ForeColor = Color.Red;
                mskNgaysinh.Focus();
                return;
            }
            if (!Function.IsDate(mskNgaysinh.Text))
            {
                lblThongbao.Text = "Hãy ghi chính xác ngày sinh";
                lblThongbao.ForeColor = Color.Red;
                mskNgaysinh.Text = "";
                mskNgaysinh.Focus();
                return;
            }
            if (mskNgaytuyendung.Text == "  /  /")
            {
                lblThongbao.Text = "Phải nhập ngày tuyển dụng!";
                lblThongbao.ForeColor = Color.Red;
                mskNgaytuyendung.Focus();
                return;
            }
            if (!Function.IsDate(mskNgaytuyendung.Text))
            {
                lblThongbao.Text = "Hãy ghi chính xác ngày tuyển dụng";
                lblThongbao.ForeColor = Color.Red;
                mskNgaytuyendung.Text = "";
                mskNgaytuyendung.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải nhập địa chỉ!";
                lblThongbao.ForeColor = Color.Red;
                txtDiachi.Focus();
                return;
            }

            if (mskDienthoai.Text == "(   )     -")
            {
                lblThongbao.Text = "Phải nhập điện thoại!";
                lblThongbao.ForeColor = Color.Red;
                mskDienthoai.Focus();
                return;
            }
            if (cboCongviec.SelectedIndex == -1)
            {
                lblThongbao.Text = "Phải chọn công việc!";
                lblThongbao.ForeColor = Color.Red;
                cboCongviec.Focus();
                return;
            }
            if (cboTrangthai.SelectedIndex == -1)
            {
                lblThongbao.Text = "Phải chọn trạng thái!";
                lblThongbao.ForeColor = Color.Red;
                cboTrangthai.Focus();
                return;
            }
            if (chkNam.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";

            var selectedJob = cboCongviec.SelectedValue?.ToString();
            id = NhanVienBLL.TaoMaMoi(selectedJob);

            string bdate = Class.Function.ConvertDateTime(mskNgaysinh.Text.Trim());
            string edate = Class.Function.ConvertDateTime(mskNgaytuyendung.Text.Trim());

            NhanVienBLL.ThemNhanVien(
                id,
                txtTennhanvien.Text.Trim(),
                gt,
                txtDiachi.Text.Trim(),
                mskDienthoai.Text.Trim(),
                bdate,
                edate,
                selectedJob ?? string.Empty,
                txtEmail.Text.Trim(),
                cboTrangthai.Text
            );

            Load_DataGridView();
            Resetvalues();
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            cboCongviec.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (tblNhanvien.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTennhanvien.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải nhập tên nhân viên!";
                lblThongbao.ForeColor = Color.Red;
                txtTennhanvien.Focus();
                return;
            }
            if (txtEmail.Text.Trim().Length == 0 || !txtEmail.Text.Contains("@"))
            {
                lblThongbao.Text = "Phải nhập Email!";
                lblThongbao.ForeColor = Color.Red;
                txtEmail.Focus();
                return;
            }
            if (chkNam.Checked == false && chkNu.Checked == false)
            {
                lblThongbao.Text = "Phải chọn giới tính!";
                lblThongbao.ForeColor = Color.Red;
                return;
            }
            if (mskNgaysinh.Text == "  /  /")
            {
                lblThongbao.Text = "Phải nhập ngày sinh!";
                lblThongbao.ForeColor = Color.Red;
                mskNgaysinh.Focus();
                return;
            }
            if (!Function.IsDate(mskNgaysinh.Text))
            {
                lblThongbao.Text = "Hãy ghi chính xác ngày sinh";
                lblThongbao.ForeColor = Color.Red;
                mskNgaysinh.Text = "";
                mskNgaysinh.Focus();
                return;
            }
            if (mskNgaytuyendung.Text == "  /  /")
            {
                lblThongbao.Text = "Phải nhập ngày tuyển dụng!";
                lblThongbao.ForeColor = Color.Red;
                mskNgaytuyendung.Focus();
                return;
            }
            if (!Function.IsDate(mskNgaytuyendung.Text))
            {
                lblThongbao.Text = "Hãy ghi chính xác ngày tuyển dụng";
                lblThongbao.ForeColor = Color.Red;
                mskNgaytuyendung.Text = "";
                mskNgaytuyendung.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải nhập địa chỉ!";
                lblThongbao.ForeColor = Color.Red;
                txtDiachi.Focus();
                return;
            }
            if (mskDienthoai.Text == "(   )     -")
            {
                lblThongbao.Text = "Phải nhập điện thoại!";
                lblThongbao.ForeColor = Color.Red;
                mskDienthoai.Focus();
                return;
            }
            if (cboCongviec.SelectedIndex == -1)
            {
                lblThongbao.Text = "Phải chọn công việc!";
                lblThongbao.ForeColor = Color.Red;
                cboCongviec.Focus();
                return;
            }
            if (cboTrangthai.SelectedIndex == -1)
            {
                lblThongbao.Text = "Phải chọn trạng thái!";
                lblThongbao.ForeColor = Color.Red;
                cboTrangthai.Focus();
                return;
            }
            if (chkNam.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";

            string bdate1 = Class.Function.ConvertDateTime(mskNgaysinh.Text.Trim());
            string edate1 = Class.Function.ConvertDateTime(mskNgaytuyendung.Text.Trim());
            var jobValue = cboCongviec.SelectedValue?.ToString() ?? string.Empty;

            NhanVienBLL.CapNhatNhanVien(
                txtManhanvien.Text.Trim(),
                txtTennhanvien.Text.Trim(),
                gt,
                txtDiachi.Text.Trim(),
                mskDienthoai.Text.Trim(),
                bdate1,
                edate1,
                jobValue,
                txtEmail.Text.Trim(),
                cboTrangthai.Text
            );

            Load_DataGridView();
            Resetvalues();
            btnSua.Enabled = false;
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            cboCongviec.Enabled = true;
            Resetvalues();
            txtTennhanvien.Focus();
            lblwarning.Text = "Chú ý! Công việc sẽ \n chỉ được chọn khi \n đang tạo tài khoản mới!";
            lblwarning.ForeColor = Color.Red;
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            Resetvalues();
            btnSua.Enabled = false;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTennhanvien_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            txtEmail.Focus();
        }

        private void txtEmail_KeyUp(object sender, KeyEventArgs e)
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
                mskNgaysinh.Focus();
        }

        private void mskNgaysinh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                mskNgaytuyendung.Focus();
        }
    }
}
