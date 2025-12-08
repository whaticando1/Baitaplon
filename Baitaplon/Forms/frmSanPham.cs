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
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmTheLoai f = new Forms.frmTheLoai();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {

        }
    }
}
