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
    public partial class frmCTHoaDonBan : Form
    {
        public static string id;
        public frmCTHoaDonBan()
        {
            InitializeComponent();

            frmCTHoaDonBan.id = frmHoaDonBan.id_hdb;
        }

        private void frmCTHoaDonBan_Load(object sender, EventArgs e)
        {
            LoadDGV1();

            LoadDGV2();
        }

        private void LoadDGV1()
        {
            string sql = "SELECT * FROM ChiTietHoaDonBan WHERE hoadonban_id = N'" +   id + "'";
            DataTable dt = Class.Function.GetDataToTable(sql);
            DataGridView.DataSource = dt;
        }

        private void LoadDGV2()
        {
            string sql = "SELECT * FROM SanPham ";
            DataTable dt = Class.Function.GetDataToTable(sql);
            dataGridView1.DataSource = dt;
        }
    }
}
