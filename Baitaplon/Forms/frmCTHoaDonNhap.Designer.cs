namespace Baitaplon.Forms
{
    partial class frmCTHoaDonNhap
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
            System.Windows.Forms.Button btnIn;
            this.label12 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMahoadon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateNgaynhap = new System.Windows.Forms.DateTimePicker();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.cboKhachhang = new System.Windows.Forms.ComboBox();
            this.txtSanpham = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvChitiet = new System.Windows.Forms.DataGridView();
            this.dgvHoaDonNhap = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.cboNhaCungCap = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picSanPham = new System.Windows.Forms.PictureBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            btnIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhap)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIn
            // 
            btnIn.Location = new System.Drawing.Point(761, 568);
            btnIn.Name = "btnIn";
            btnIn.Size = new System.Drawing.Size(75, 23);
            btnIn.TabIndex = 38;
            btnIn.Text = "In";
            btnIn.UseVisualStyleBackColor = true;
            btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Tổng tiền: ";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(518, 568);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 27;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(599, 568);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(680, 568);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 33;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(842, 568);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 31;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Thành tiền";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Đơn giá";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Số lượng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Tên quần áo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mã hóa đơn";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(90, 141);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(176, 22);
            this.txtThanhTien.TabIndex = 4;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(90, 114);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(176, 22);
            this.txtDonGia.TabIndex = 3;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(90, 87);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(176, 22);
            this.txtSoLuong.TabIndex = 2;
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(90, 59);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(176, 22);
            this.txtTenSanPham.TabIndex = 1;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(90, 31);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(176, 22);
            this.txtMaHD.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Mã hóa đơn";
            // 
            // txtMahoadon
            // 
            this.txtMahoadon.Location = new System.Drawing.Point(177, 121);
            this.txtMahoadon.Name = "txtMahoadon";
            this.txtMahoadon.Size = new System.Drawing.Size(200, 22);
            this.txtMahoadon.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ngày nhập";
            // 
            // dateNgaynhap
            // 
            this.dateNgaynhap.Location = new System.Drawing.Point(177, 149);
            this.dateNgaynhap.Name = "dateNgaynhap";
            this.dateNgaynhap.Size = new System.Drawing.Size(200, 22);
            this.dateNgaynhap.TabIndex = 23;
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(177, 177);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(200, 24);
            this.cboNhanVien.TabIndex = 22;
            // 
            // cboKhachhang
            // 
            this.cboKhachhang.FormattingEnabled = true;
            this.cboKhachhang.Location = new System.Drawing.Point(177, 207);
            this.cboKhachhang.Name = "cboKhachhang";
            this.cboKhachhang.Size = new System.Drawing.Size(200, 24);
            this.cboKhachhang.TabIndex = 21;
            // 
            // txtSanpham
            // 
            this.txtSanpham.Location = new System.Drawing.Point(177, 237);
            this.txtSanpham.Name = "txtSanpham";
            this.txtSanpham.Size = new System.Drawing.Size(200, 22);
            this.txtSanpham.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvChitiet
            // 
            this.dgvChitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChitiet.Location = new System.Drawing.Point(518, 350);
            this.dgvChitiet.Name = "dgvChitiet";
            this.dgvChitiet.RowHeadersWidth = 51;
            this.dgvChitiet.RowTemplate.Height = 24;
            this.dgvChitiet.Size = new System.Drawing.Size(476, 195);
            this.dgvChitiet.TabIndex = 18;
            this.dgvChitiet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChitiet_CellClick);
            this.dgvChitiet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChitiet_CellContentClick);
            this.dgvChitiet.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChitiet_CellEndEdit);
            // 
            // dgvHoaDonNhap
            // 
            this.dgvHoaDonNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDonNhap.Location = new System.Drawing.Point(51, 350);
            this.dgvHoaDonNhap.Name = "dgvHoaDonNhap";
            this.dgvHoaDonNhap.RowHeadersWidth = 51;
            this.dgvHoaDonNhap.RowTemplate.Height = 24;
            this.dgvHoaDonNhap.Size = new System.Drawing.Size(434, 195);
            this.dgvHoaDonNhap.TabIndex = 17;
            this.dgvHoaDonNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDonNhap_CellClick);
            this.dgvHoaDonNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDonNhap_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLammoi);
            this.groupBox1.Controls.Add(this.cboNhaCungCap);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(34, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 466);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm hóa đơn";
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(376, 225);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(75, 23);
            this.btnLammoi.TabIndex = 40;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // cboNhaCungCap
            // 
            this.cboNhaCungCap.FormattingEnabled = true;
            this.cboNhaCungCap.Location = new System.Drawing.Point(143, 171);
            this.cboNhaCungCap.Name = "cboNhaCungCap";
            this.cboNhaCungCap.Size = new System.Drawing.Size(200, 24);
            this.cboNhaCungCap.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(40, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 16);
            this.label13.TabIndex = 36;
            this.label13.Text = "Nhà cung cấp";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTongTien);
            this.groupBox2.Controls.Add(this.picSanPham);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtThanhTien);
            this.groupBox2.Controls.Add(this.txtDonGia);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.txtTenSanPham);
            this.groupBox2.Controls.Add(this.txtMaHD);
            this.groupBox2.Location = new System.Drawing.Point(512, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 466);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết hóa đơn nhập";
            // 
            // picSanPham
            // 
            this.picSanPham.Location = new System.Drawing.Point(287, 81);
            this.picSanPham.Name = "picSanPham";
            this.picSanPham.Size = new System.Drawing.Size(195, 110);
            this.picSanPham.TabIndex = 39;
            this.picSanPham.TabStop = false;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(83, 197);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(183, 22);
            this.txtTongTien.TabIndex = 39;
            // 
            // frmCTHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1268, 744);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(btnIn);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMahoadon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateNgaynhap);
            this.Controls.Add(this.cboNhanVien);
            this.Controls.Add(this.cboKhachhang);
            this.Controls.Add(this.txtSanpham);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvChitiet);
            this.Controls.Add(this.dgvHoaDonNhap);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCTHoaDonNhap";
            this.Text = "CTHoaDonNhap";
            this.Load += new System.EventHandler(this.frmCTHoaDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChitiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMahoadon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateNgaynhap;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.ComboBox cboKhachhang;
        private System.Windows.Forms.TextBox txtSanpham;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvChitiet;
        private System.Windows.Forms.DataGridView dgvHoaDonNhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picSanPham;
        private System.Windows.Forms.ComboBox cboNhaCungCap;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.TextBox txtTongTien;
    }
}