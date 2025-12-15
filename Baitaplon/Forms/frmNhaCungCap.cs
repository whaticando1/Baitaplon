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
    public partial class frmNhaCungCap : Form
    {
        DataTable dtNCC;
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            cboTrangthai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangthai.BeginUpdate();
            cboTrangthai.Items.Add("Đang hợp tác");
            cboTrangthai.Items.Add("Ngừng hợp tác");
            cboTrangthai.EndUpdate();
            cboTrangthai.SelectedIndex = -1;
            resetValues();
            Load_DataGridViewNCC();
            txtIDCungcap.Enabled = false;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnBoqua.Enabled = false;
        }
        
        private void resetValues()
        {
            txtIDCungcap.Text = "";
            txtTennhacungcap.Text = "";
            txtDiachi.Text = "";
            mskDienthoai.Text = "";
            txtEmail.Text = "";
            lblThongbao.Text = "";
            txtMoTa.Text = "";
            cboTrangthai.SelectedValue = -1;

        }
        private void Load_DataGridViewNCC()
        {
            string sql = "Select nhacungcap_id, tennhacungcap, diachi, dienthoai, email, mota, trangthai from NhaCungCap";
            dtNCC = Class.Function.GetDataToTable(sql);
            DataGridView.DataSource = dtNCC;
            if (DataGridView.Rows.Count > 0)
            {
                DataGridView.Columns[0].HeaderText = "Mã nhà cung cấp";
                DataGridView.Columns[1].HeaderText = "Tên nhà cung cấp";
                DataGridView.Columns[2].HeaderText = "Địa chỉ";
                DataGridView.Columns[3].HeaderText = "Điện thoại";
                DataGridView.Columns[4].HeaderText = "Email";
                DataGridView.Columns[5].HeaderText = "Mô tả";
                DataGridView.Columns[6].HeaderText = "Trạng thái";
                DataGridView.Columns[0].Width = 100;
                DataGridView.Columns[1].Width = 150;
                DataGridView.Columns[2].Width = 200;
                DataGridView.Columns[3].Width = 100;
                DataGridView.Columns[4].Width = 150;
                DataGridView.Columns[5].Width = 250;
                DataGridView.Columns[6].Width = 100;
                DataGridView.AllowUserToAddRows = false;
                DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtNCC.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtIDCungcap.Text = DataGridView.CurrentRow.Cells["nhacungcap_id"].Value.ToString();
            txtTennhacungcap.Text = DataGridView.CurrentRow.Cells["tennhacungcap"].Value.ToString();
            txtDiachi.Text = DataGridView.CurrentRow.Cells["diachi"].Value.ToString();
            mskDienthoai.Text = DataGridView.CurrentRow.Cells["dienthoai"].Value.ToString();
            txtEmail.Text = DataGridView.CurrentRow.Cells["email"].Value.ToString();
            txtMoTa.Text = DataGridView.CurrentRow.Cells["mota"].Value.ToString();
            cboTrangthai.Text = DataGridView.CurrentRow.Cells["trangthai"].Value.ToString();
            btnSua.Enabled = true;
            btnBoqua.Enabled = true;
            btnThem.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnBoqua.Enabled = true;
            resetValues();
            txtTennhacungcap.Focus();
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            resetValues();
            btnSua.Enabled = false;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql, id = "";
            if (txtTennhacungcap.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải nhập tên nhà cung cấp";
                txtTennhacungcap.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải nhập địa chỉ";
                txtDiachi.Focus();
                return;
            }
            if (mskDienthoai.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải nhập điện thoại";
                mskDienthoai.Focus();
                return;
            }
            if (cboTrangthai.SelectedIndex == -1)
            {
                lblThongbao.Text = "Phải chọn trạng thái";
                cboTrangthai.Focus();
                return;
            }
            if (txtEmail.Text.Trim().Length != 0 || !txtEmail.Text.Contains("@"))
            {
                lblThongbao.Text = "Email không hợp lệ";
                txtEmail.Focus();
                return;
            }
            string sql1 = "select top 1 right(nhacungcap_id,1) from NhaCungCap order by right(nhacungcap_id,1) desc";
            float count = Function.FirstRowNumberSafe(sql1) + 1;
            id = "NCC" + count;
            sql = "INSERT INTO NhaCungCap(nhacungcap_id, tennhacungcap, diachi, dienthoai, email, mota, trangthai) VALUES('" + id + "',N'" + txtTennhacungcap.Text.Trim() + "',N'" + txtDiachi.Text.Trim() + "','" + mskDienthoai.Text.Trim() + "','" + txtEmail.Text.Trim() + "',N'" + txtMoTa.Text.Trim() + "',N'" + cboTrangthai.Text + "')";
            Function.RunSql(sql);
            Load_DataGridViewNCC();
            resetValues();
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTennhacungcap.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải nhập tên nhà cung cấp";
                txtTennhacungcap.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải nhập địa chỉ";
                txtDiachi.Focus();
                return;
            }
            if (mskDienthoai.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải nhập điện thoại";
                mskDienthoai.Focus();
                return;
            }
            if (cboTrangthai.SelectedIndex == -1)
            {
                lblThongbao.Text = "Phải chọn trạng thái";
                cboTrangthai.Focus();
                return;
            }
            if (txtEmail.Text.Trim().Length != 0 || !txtEmail.Text.Contains("@"))
            {
                lblThongbao.Text = "Email không hợp lệ";
                txtEmail.Focus();
                return;
            }
            string sql = "UPDATE NhaCungCap " +
                         "SET tennhacungcap = N'" + txtTennhacungcap.Text.Trim() + "', " +
                         "diachi = N'" + txtDiachi.Text.Trim() + "', " +
                         "dienthoai = '" + mskDienthoai.Text.Trim() + "', " +
                         "email = '" + txtEmail.Text.Trim() + "', " +
                         "mota = N'" + txtMoTa.Text.Trim() + "', " +
                         "trangthai = N'" + cboTrangthai.Text + "' " +
                         "WHERE nhacungcap_id = N'" + txtIDCungcap.Text + "'";
            Function.RunSql(sql);
            Load_DataGridViewNCC();
            resetValues();
            btnSua.Enabled = false;
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
        }
    }
}
