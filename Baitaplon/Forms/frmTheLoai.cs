using Baitaplon.Class;
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
    public partial class frmTheLoai : Form
    {
        DataTable tblTL;
        public frmTheLoai()
        {
            InitializeComponent();
        }

        private void frmTheLoai_Load(object sender, EventArgs e)
        {
            resetValues();
            Load_DataGridViewTL();
            txtIDTheloai.Enabled = false;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnBoqua.Enabled = false;
        }

        private void resetValues()
        {
            txtIDTheloai.Text = "";
            txtTentheloai.Text = "";
            txtMota.Text = "";
            lblThongbao.Text = "";
        }

        private void Load_DataGridViewTL()
        {
            string sql = "Select theloai_id, tentheloai, mota from TheLoai";
            tblTL = Class.Function.GetDataToTable(sql);
            DataGridView.DataSource = tblTL;

            if (DataGridView.Rows.Count > 0)
            {
                DataGridView.Columns[0].HeaderText = "Mã thể loại";
                DataGridView.Columns[1].HeaderText = "Tên thể loại";
                DataGridView.Columns[2].HeaderText = "Mô tả";
                DataGridView.Columns[0].Width = 100;
                DataGridView.Columns[1].Width = 150;
                DataGridView.Columns[2].Width = 250;
                DataGridView.AllowUserToAddRows = false;
                DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;

            }
            
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tblTL.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIDTheloai.Focus();
                return;
            }
            txtIDTheloai.Text = DataGridView.CurrentRow.Cells["theloai_id"].Value.ToString();
            txtTentheloai.Text = DataGridView.CurrentRow.Cells["tentheloai"].Value.ToString();
            txtMota.Text = DataGridView.CurrentRow.Cells["mota"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
            btnThem.Enabled = false;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql, id="";

            if (txtTentheloai.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải nhập tên thể loại!";
                lblThongbao.ForeColor = Color.Red;
                txtTentheloai.Focus();
                return;
            }

            string sql2 = "Select top 1 right(theloai_id,1) From TheLoai order by right(theloai_id,1) desc";

            float count = Function.FirstRowNumberSafe(sql2) + 1;

            id = "TL" + count;

            sql = "INSERT INTO TheLoai (theloai_id, tentheloai, mota) VALUES (N'" + id + "', N'" + txtTentheloai.Text.Trim() + "', N'" + txtMota.Text.Trim() + "')";
            Function.RunSql(sql);
            Load_DataGridViewTL();
            resetValues();
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTentheloai.Text.Trim().Length == 0)
            {
                lblThongbao.Text = "Phải nhập tên thể loại!";
                lblThongbao.ForeColor = Color.Red;
                txtTentheloai.Focus();
                return;
            }
            string Sql = "UPDATE TheLoai SET tentheloai=N'" + txtTentheloai.Text.Trim().ToString() + "', mota=N'" + txtMota.Text.Trim().ToString() + "' WHERE theloai_id=N'" + txtIDTheloai.Text + "'";
            Function.RunSql(Sql);
            Load_DataGridViewTL();
            resetValues();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tblTL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string sql = "DELETE TheLoai WHERE theloai_id=N'" + txtIDTheloai.Text + "'";
            Function.RunSqlDel(sql);
            Load_DataGridViewTL();
            resetValues();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnBoqua.Enabled = true;
            resetValues();
            txtTentheloai.Focus();
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            resetValues();
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
