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
    public partial class frmHoaDonBan : Form
    {
        public frmHoaDonBan()
        {
            InitializeComponent();
        }

        private void chiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmCTHoaDonBan f = new Forms.frmCTHoaDonBan();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }
    }
}
