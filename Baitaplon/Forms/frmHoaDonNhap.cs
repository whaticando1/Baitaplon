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
    public partial class frmHoaDonNhap : Form
    {
        public frmHoaDonNhap()
        {
            InitializeComponent();
        }

        private void chiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmCTHoaDonNhap f = new Forms.frmCTHoaDonNhap();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void frmHoaDonNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
