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
    public partial class frmHoaDonBan : Form
    {
        public static string id_hdb;
        public frmHoaDonBan()
        {
            InitializeComponent();
        }


        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {


            LoadDGV1();
        }

        private void LoadDGV1()
        {
            string sql = "SELECT * FROM HoaDonBan";

            DataTable dt = Class.Function.GetDataToTable(sql);

            //DataGridView.DataSource = dt;
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            var f = new frmCTHoaDonBan();

            f.Show();

        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //id_hdb = DataGridView.CurrentRow.Cells["hoadonban_id"].Value.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
