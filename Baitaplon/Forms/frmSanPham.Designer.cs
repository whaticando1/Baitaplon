namespace Baitaplon.Forms
{
    partial class frmSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thểLoạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMasanpham = new System.Windows.Forms.TextBox();
            this.cboMatheloai = new System.Windows.Forms.ComboBox();
            this.mskNgaynhap = new System.Windows.Forms.MaskedTextBox();
            this.lblAnh = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.txtGiaban = new System.Windows.Forms.TextBox();
            this.txtChatlieu = new System.Windows.Forms.TextBox();
            this.txtDoituong = new System.Windows.Forms.TextBox();
            this.txtTensanpham = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtGianhap = new System.Windows.Forms.TextBox();
            this.txtMausac = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.e = new System.Windows.Forms.Label();
            this.f = new System.Windows.Forms.Label();
            this.g = new System.Windows.Forms.Label();
            this.h = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.i = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.lblDMKH = new System.Windows.Forms.Label();
            this.txtMota = new System.Windows.Forms.TextBox();
            this.lblMota = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.lblThongbao = new System.Windows.Forms.Label();
            this.cboMua = new System.Windows.Forms.ComboBox();
            this.cboTrangthai = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thểLoạiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1583, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thểLoạiToolStripMenuItem
            // 
            this.thểLoạiToolStripMenuItem.Name = "thểLoạiToolStripMenuItem";
            this.thểLoạiToolStripMenuItem.Size = new System.Drawing.Size(119, 36);
            this.thểLoạiToolStripMenuItem.Text = "Thể loại";
            this.thểLoạiToolStripMenuItem.Click += new System.EventHandler(this.thểLoạiToolStripMenuItem_Click);
            // 
            // txtMasanpham
            // 
            this.txtMasanpham.Location = new System.Drawing.Point(247, 141);
            this.txtMasanpham.Name = "txtMasanpham";
            this.txtMasanpham.Size = new System.Drawing.Size(192, 31);
            this.txtMasanpham.TabIndex = 2;
            // 
            // cboMatheloai
            // 
            this.cboMatheloai.FormattingEnabled = true;
            this.cboMatheloai.Location = new System.Drawing.Point(1041, 271);
            this.cboMatheloai.Name = "cboMatheloai";
            this.cboMatheloai.Size = new System.Drawing.Size(192, 33);
            this.cboMatheloai.TabIndex = 4;
            // 
            // mskNgaynhap
            // 
            this.mskNgaynhap.Location = new System.Drawing.Point(1041, 338);
            this.mskNgaynhap.Mask = "00/00/0000";
            this.mskNgaynhap.Name = "mskNgaynhap";
            this.mskNgaynhap.Size = new System.Drawing.Size(192, 31);
            this.mskNgaynhap.TabIndex = 5;
            this.mskNgaynhap.ValidatingType = typeof(System.DateTime);
            // 
            // lblAnh
            // 
            this.lblAnh.AutoSize = true;
            this.lblAnh.Location = new System.Drawing.Point(1241, 434);
            this.lblAnh.Name = "lblAnh";
            this.lblAnh.Size = new System.Drawing.Size(50, 25);
            this.lblAnh.TabIndex = 44;
            this.lblAnh.Text = "Ảnh";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(1339, 481);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(113, 54);
            this.btnOpen.TabIndex = 43;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // picAnh
            // 
            this.picAnh.Location = new System.Drawing.Point(1285, 104);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(236, 296);
            this.picAnh.TabIndex = 42;
            this.picAnh.TabStop = false;
            // 
            // txtAnh
            // 
            this.txtAnh.Location = new System.Drawing.Point(1310, 431);
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(201, 31);
            this.txtAnh.TabIndex = 41;
            // 
            // txtGiaban
            // 
            this.txtGiaban.Location = new System.Drawing.Point(247, 203);
            this.txtGiaban.Name = "txtGiaban";
            this.txtGiaban.Size = new System.Drawing.Size(192, 31);
            this.txtGiaban.TabIndex = 45;
            // 
            // txtChatlieu
            // 
            this.txtChatlieu.Location = new System.Drawing.Point(247, 268);
            this.txtChatlieu.Name = "txtChatlieu";
            this.txtChatlieu.Size = new System.Drawing.Size(192, 31);
            this.txtChatlieu.TabIndex = 46;
            // 
            // txtDoituong
            // 
            this.txtDoituong.Location = new System.Drawing.Point(247, 335);
            this.txtDoituong.Name = "txtDoituong";
            this.txtDoituong.Size = new System.Drawing.Size(192, 31);
            this.txtDoituong.TabIndex = 47;
            // 
            // txtTensanpham
            // 
            this.txtTensanpham.Location = new System.Drawing.Point(649, 200);
            this.txtTensanpham.Name = "txtTensanpham";
            this.txtTensanpham.Size = new System.Drawing.Size(192, 31);
            this.txtTensanpham.TabIndex = 49;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(649, 268);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(192, 31);
            this.txtSoluong.TabIndex = 50;
            // 
            // txtGianhap
            // 
            this.txtGianhap.Location = new System.Drawing.Point(649, 335);
            this.txtGianhap.Name = "txtGianhap";
            this.txtGianhap.Size = new System.Drawing.Size(192, 31);
            this.txtGianhap.TabIndex = 51;
            // 
            // txtMausac
            // 
            this.txtMausac.Location = new System.Drawing.Point(1038, 129);
            this.txtMausac.Name = "txtMausac";
            this.txtMausac.Size = new System.Drawing.Size(192, 31);
            this.txtMausac.TabIndex = 53;
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(93, 203);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(93, 25);
            this.b.TabIndex = 55;
            this.b.Text = "Giá bán:";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(93, 274);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(103, 25);
            this.c.TabIndex = 56;
            this.c.Text = "Chất liệu:";
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Location = new System.Drawing.Point(93, 338);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(110, 25);
            this.d.TabIndex = 57;
            this.d.Text = "Đối tượng:";
            // 
            // e
            // 
            this.e.AutoSize = true;
            this.e.Location = new System.Drawing.Point(495, 147);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(115, 25);
            this.e.TabIndex = 58;
            this.e.Text = "Trạng thái:";
            // 
            // f
            // 
            this.f.AutoSize = true;
            this.f.Location = new System.Drawing.Point(495, 203);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(155, 25);
            this.f.TabIndex = 59;
            this.f.Text = "Tên sản phẩm:";
            // 
            // g
            // 
            this.g.AutoSize = true;
            this.g.Location = new System.Drawing.Point(495, 271);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(103, 25);
            this.g.TabIndex = 60;
            this.g.Text = "Số lượng:";
            // 
            // h
            // 
            this.h.AutoSize = true;
            this.h.Location = new System.Drawing.Point(495, 338);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(105, 25);
            this.h.TabIndex = 61;
            this.h.Text = "Giá nhập:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(913, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 25);
            this.label10.TabIndex = 63;
            this.label10.Text = "Màu sắc:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(913, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 25);
            this.label11.TabIndex = 64;
            this.label11.Text = "Mùa:";
            // 
            // i
            // 
            this.i.AutoSize = true;
            this.i.Location = new System.Drawing.Point(911, 274);
            this.i.Name = "i";
            this.i.Size = new System.Drawing.Size(124, 25);
            this.i.TabIndex = 65;
            this.i.Text = "Mã thể loại:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(913, 335);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 25);
            this.label13.TabIndex = 66;
            this.label13.Text = "Ngày nhập:";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(839, 799);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(107, 49);
            this.btnDong.TabIndex = 73;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(839, 723);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(107, 49);
            this.btnBoqua.TabIndex = 72;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(839, 644);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(107, 49);
            this.btnLuu.TabIndex = 71;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(839, 568);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(107, 49);
            this.btnSua.TabIndex = 70;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(839, 489);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 49);
            this.btnXoa.TabIndex = 69;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(839, 413);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 49);
            this.btnThem.TabIndex = 68;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(59, 413);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 82;
            this.DataGridView.RowTemplate.Height = 33;
            this.DataGridView.Size = new System.Drawing.Size(736, 445);
            this.DataGridView.TabIndex = 67;
            this.DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            // 
            // lblDMKH
            // 
            this.lblDMKH.AutoSize = true;
            this.lblDMKH.BackColor = System.Drawing.Color.Transparent;
            this.lblDMKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDMKH.ForeColor = System.Drawing.Color.Black;
            this.lblDMKH.Location = new System.Drawing.Point(654, 54);
            this.lblDMKH.Name = "lblDMKH";
            this.lblDMKH.Size = new System.Drawing.Size(255, 51);
            this.lblDMKH.TabIndex = 74;
            this.lblDMKH.Text = "SẢN PHẨM";
            // 
            // txtMota
            // 
            this.txtMota.Location = new System.Drawing.Point(1071, 601);
            this.txtMota.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMota.Multiline = true;
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(427, 234);
            this.txtMota.TabIndex = 76;
            // 
            // lblMota
            // 
            this.lblMota.AutoSize = true;
            this.lblMota.Location = new System.Drawing.Point(1066, 555);
            this.lblMota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMota.Name = "lblMota";
            this.lblMota.Size = new System.Drawing.Size(72, 25);
            this.lblMota.TabIndex = 75;
            this.lblMota.Text = "Mô tả:";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(93, 144);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(148, 25);
            this.a.TabIndex = 1;
            this.a.Text = "Mã sản phẩm:";
            // 
            // lblThongbao
            // 
            this.lblThongbao.AutoSize = true;
            this.lblThongbao.Location = new System.Drawing.Point(142, 375);
            this.lblThongbao.Name = "lblThongbao";
            this.lblThongbao.Size = new System.Drawing.Size(24, 25);
            this.lblThongbao.TabIndex = 107;
            this.lblThongbao.Text = "a";
            // 
            // cboMua
            // 
            this.cboMua.FormattingEnabled = true;
            this.cboMua.Location = new System.Drawing.Point(1041, 200);
            this.cboMua.Name = "cboMua";
            this.cboMua.Size = new System.Drawing.Size(192, 33);
            this.cboMua.TabIndex = 110;
            // 
            // cboTrangthai
            // 
            this.cboTrangthai.FormattingEnabled = true;
            this.cboTrangthai.Location = new System.Drawing.Point(649, 141);
            this.cboTrangthai.Name = "cboTrangthai";
            this.cboTrangthai.Size = new System.Drawing.Size(192, 33);
            this.cboTrangthai.TabIndex = 111;
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1583, 979);
            this.Controls.Add(this.cboTrangthai);
            this.Controls.Add(this.cboMua);
            this.Controls.Add(this.lblThongbao);
            this.Controls.Add(this.txtMota);
            this.Controls.Add(this.lblMota);
            this.Controls.Add(this.lblDMKH);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.i);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.h);
            this.Controls.Add(this.g);
            this.Controls.Add(this.f);
            this.Controls.Add(this.e);
            this.Controls.Add(this.d);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.txtMausac);
            this.Controls.Add(this.txtGianhap);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.txtTensanpham);
            this.Controls.Add(this.txtDoituong);
            this.Controls.Add(this.txtChatlieu);
            this.Controls.Add(this.txtGiaban);
            this.Controls.Add(this.lblAnh);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.txtAnh);
            this.Controls.Add(this.mskNgaynhap);
            this.Controls.Add(this.cboMatheloai);
            this.Controls.Add(this.txtMasanpham);
            this.Controls.Add(this.a);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSanPham";
            this.Text = "Sản phẩm";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thểLoạiToolStripMenuItem;
        private System.Windows.Forms.TextBox txtMasanpham;
        private System.Windows.Forms.ComboBox cboMatheloai;
        private System.Windows.Forms.MaskedTextBox mskNgaynhap;
        private System.Windows.Forms.Label lblAnh;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.TextBox txtAnh;
        private System.Windows.Forms.TextBox txtGiaban;
        private System.Windows.Forms.TextBox txtChatlieu;
        private System.Windows.Forms.TextBox txtDoituong;
        private System.Windows.Forms.TextBox txtTensanpham;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.TextBox txtGianhap;
        private System.Windows.Forms.TextBox txtMausac;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Label e;
        private System.Windows.Forms.Label f;
        private System.Windows.Forms.Label g;
        private System.Windows.Forms.Label h;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label i;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Label lblDMKH;
        private System.Windows.Forms.TextBox txtMota;
        private System.Windows.Forms.Label lblMota;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label lblThongbao;
        private System.Windows.Forms.ComboBox cboMua;
        private System.Windows.Forms.ComboBox cboTrangthai;
    }
}