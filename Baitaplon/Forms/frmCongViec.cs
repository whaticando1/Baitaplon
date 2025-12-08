using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitaplon.Forms
{
    public partial class frmCongViec : Form
    {
        DataTable tblCongviec;
        public frmCongViec()
        {
            InitializeComponent();
        }

        private void frmCongViec_Load(object sender, EventArgs e)
        { 
            
            btnBoqua.Enabled = false;
            txtIDCongViec.Enabled = false;
            txtTenCongViec.Enabled = false;
            btnSua.Enabled = false;
            Resetvalues();
            Load_DataGridViewCV();
        }
        private void Resetvalues()
        {
            txtIDCongViec.Enabled = false;
            txtIDCongViec.Text = "";
            txtTenCongViec.Text = "";
            txtMoTa.Text = "";
            txtLuongCoBan.Text = "";
            lblThongbaoCV.Text = "";
        }
        private void Load_DataGridViewCV()
        {
            String sql;
            sql = "SELECT congviec_id, tencongviec, mota, luongcoban FROM CongViec";
            tblCongviec = Class.Function.GetDataToTable(sql);
            dataGridViewCV.DataSource = tblCongviec;

            if (dataGridViewCV.Rows.Count > 0)
            {
                dataGridViewCV.Columns[0].HeaderText = "Mã công việc";
                dataGridViewCV.Columns[1].HeaderText = "Tên công việc";
                dataGridViewCV.Columns[2].HeaderText = "Mô tả";
                dataGridViewCV.Columns[3].HeaderText = "Lương cơ bản";
                dataGridViewCV.Columns[0].Width = 100;
                dataGridViewCV.Columns[1].Width = 150;
                dataGridViewCV.Columns[2].Width = 250;
                dataGridViewCV.Columns[3].Width = 150;
            }
            dataGridViewCV.AllowUserToAddRows = false;
            dataGridViewCV.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewCV_Click(object sender, EventArgs e)
        {
            
            if (tblCongviec.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtIDCongViec.Text = dataGridViewCV.CurrentRow.Cells["congviec_id"].Value.ToString();
            txtTenCongViec.Text = dataGridViewCV.CurrentRow.Cells["tencongviec"].Value.ToString();
            txtMoTa.Text = dataGridViewCV.CurrentRow.Cells["mota"].Value.ToString();
            txtLuongCoBan.Text = dataGridViewCV.CurrentRow.Cells["luongcoban"].Value.ToString();

            btnSua.Enabled = true;
            btnBoqua.Enabled = true;
        }


        private void btnBoqua_Click(object sender, EventArgs e)
        {
            Resetvalues();
            btnBoqua.Enabled = false;
            btnSua.Enabled = false;
            txtIDCongViec.Enabled = false;
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCongviec.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtIDCongViec.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn công việc nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtIDCongViec.Text.Trim().Length == 0)
            {
                lblThongbaoCV.Text = "Bạn chưa nhập ID công việc!";
                lblThongbaoCV.ForeColor = Color.Red;
                txtIDCongViec.Focus();
                return;
            }
            if (txtTenCongViec.Text.Trim().Length == 0)
            {
                lblThongbaoCV.Text = "Bạn chưa nhập tên công việc!";
                lblThongbaoCV.ForeColor = Color.Red;
                txtTenCongViec.Focus();
                return;
            }
            if (txtLuongCoBan.Text.Trim().Length == 0)
            {
                lblThongbaoCV.Text = "Bạn chưa nhập lương cơ bản!";
                lblThongbaoCV.ForeColor = Color.Red;
                txtLuongCoBan.Focus();
                return;
            }
            if (!Class.Function.IsNumber(txtLuongCoBan.Text))
            {
                lblThongbaoCV.Text = "Lương cơ bản phải là số!";
                lblThongbaoCV.ForeColor = Color.Red;
                txtLuongCoBan.Focus();
                return;
            }
            sql = "UPDATE CongViec SET tencongviec=N'" + txtTenCongViec.Text.Trim() + "', mota=N'" + txtMoTa.Text.Trim() + "', luongcoban=" + txtLuongCoBan.Text.Trim() + " WHERE congviec_id=N'" + txtIDCongViec.Text + "'";
            Class.Function.RunSql(sql);
            Load_DataGridViewCV();
            Resetvalues();
            btnBoqua.Enabled = false;
            btnSua.Enabled = false;
        }
    }
}
