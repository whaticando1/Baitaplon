namespace Baitaplon.Forms
{
    partial class frmHoaDonNhap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSPThem = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblDuongDan = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.cbbNCC = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picBoxTraiCay = new System.Windows.Forms.PictureBox();
            this.chkTrangThai = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnXoaGioHang = new System.Windows.Forms.Button();
            this.btnHuySP = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ofdHinh = new System.Windows.Forms.OpenFileDialog();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnLapHD = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvTraiCay = new System.Windows.Forms.DataGridView();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtChatLieu = new System.Windows.Forms.TextBox();
            this.txtMaTraiCay = new System.Windows.Forms.TextBox();
            this.txtTenTraiCay = new System.Windows.Forms.TextBox();
            this.txtMau = new System.Windows.Forms.TextBox();
            this.cbbLoaiTC = new System.Windows.Forms.ComboBox();
            this.colquanao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltenquanao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmausac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colloaiquanao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colchatlieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colgiatien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colhinh = new System.Windows.Forms.DataGridViewImageColumn();
            this.colsoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnhacungcap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltrangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaQA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenQA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMauTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiQA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaTienTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHinhTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThaiTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPThem)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTraiCay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraiCay)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSPThem
            // 
            this.dgvSPThem.AllowUserToAddRows = false;
            this.dgvSPThem.AllowUserToDeleteRows = false;
            this.dgvSPThem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSPThem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaQA,
            this.colTenQA,
            this.colMauTC,
            this.colLoaiQA,
            this.colCL,
            this.colGiaTienTC,
            this.colThanhTien,
            this.colHinhTC,
            this.colSoLuongTC,
            this.colNCC,
            this.colTrangThaiTC});
            this.dgvSPThem.Location = new System.Drawing.Point(8, 7);
            this.dgvSPThem.Name = "dgvSPThem";
            this.dgvSPThem.ReadOnly = true;
            this.dgvSPThem.RowHeadersVisible = false;
            this.dgvSPThem.RowHeadersWidth = 51;
            this.dgvSPThem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSPThem.Size = new System.Drawing.Size(489, 203);
            this.dgvSPThem.TabIndex = 86;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSPThem);
            this.groupBox2.Location = new System.Drawing.Point(722, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 217);
            this.groupBox2.TabIndex = 88;
            this.groupBox2.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(13, 63);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 19);
            this.label17.TabIndex = 85;
            this.label17.Text = "Mã quần áo:";
            // 
            // lblDuongDan
            // 
            this.lblDuongDan.AutoSize = true;
            this.lblDuongDan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuongDan.Location = new System.Drawing.Point(664, 263);
            this.lblDuongDan.Name = "lblDuongDan";
            this.lblDuongDan.Size = new System.Drawing.Size(18, 20);
            this.lblDuongDan.TabIndex = 84;
            this.lblDuongDan.Text = "0";
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhTien.Location = new System.Drawing.Point(395, 209);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(18, 20);
            this.lblThanhTien.TabIndex = 80;
            this.lblThanhTien.Text = "0";
            // 
            // cbbNCC
            // 
            this.cbbNCC.FormattingEnabled = true;
            this.cbbNCC.Location = new System.Drawing.Point(397, 57);
            this.cbbNCC.Name = "cbbNCC";
            this.cbbNCC.Size = new System.Drawing.Size(140, 27);
            this.cbbNCC.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 79;
            this.label1.Text = "Thành tiền:";
            // 
            // picBoxTraiCay
            // 
            this.picBoxTraiCay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxTraiCay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxTraiCay.Location = new System.Drawing.Point(561, 23);
            this.picBoxTraiCay.Name = "picBoxTraiCay";
            this.picBoxTraiCay.Size = new System.Drawing.Size(121, 115);
            this.picBoxTraiCay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxTraiCay.TabIndex = 76;
            this.picBoxTraiCay.TabStop = false;
            // 
            // chkTrangThai
            // 
            this.chkTrangThai.AutoSize = true;
            this.chkTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTrangThai.Location = new System.Drawing.Point(397, 262);
            this.chkTrangThai.Name = "chkTrangThai";
            this.chkTrangThai.Size = new System.Drawing.Size(18, 17);
            this.chkTrangThai.TabIndex = 75;
            this.chkTrangThai.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(743, 369);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 19);
            this.label13.TabIndex = 97;
            this.label13.Text = "Mã hóa đơn:";
            // 
            // btnXoaGioHang
            // 
            this.btnXoaGioHang.BackColor = System.Drawing.Color.Silver;
            this.btnXoaGioHang.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaGioHang.Location = new System.Drawing.Point(967, 293);
            this.btnXoaGioHang.Name = "btnXoaGioHang";
            this.btnXoaGioHang.Size = new System.Drawing.Size(114, 47);
            this.btnXoaGioHang.TabIndex = 92;
            this.btnXoaGioHang.Text = "Xóa giỏ hàng";
            this.btnXoaGioHang.UseVisualStyleBackColor = false;
            // 
            // btnHuySP
            // 
            this.btnHuySP.BackColor = System.Drawing.Color.Silver;
            this.btnHuySP.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuySP.Location = new System.Drawing.Point(847, 293);
            this.btnHuySP.Name = "btnHuySP";
            this.btnHuySP.Size = new System.Drawing.Size(114, 47);
            this.btnHuySP.TabIndex = 91;
            this.btnHuySP.Text = "Hủy thông tin sản phẩm";
            this.btnHuySP.UseVisualStyleBackColor = false;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(397, 157);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(140, 26);
            this.txtSoLuong.TabIndex = 68;
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(397, 106);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(140, 26);
            this.txtGiaTien.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(280, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 19);
            this.label9.TabIndex = 74;
            this.label9.Text = "Trạng thái";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(280, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 19);
            this.label7.TabIndex = 62;
            this.label7.Text = "Số lượng:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 19);
            this.label11.TabIndex = 72;
            this.label11.Text = "Tìm kiếm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(280, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 61;
            this.label6.Text = "Giá tiền:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 57;
            this.label2.Text = "Tên quần áo:";
            // 
            // ofdHinh
            // 
            this.ofdHinh.FileName = "openFileDialog1";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(887, 444);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(18, 20);
            this.lblTongTien.TabIndex = 94;
            this.lblTongTien.Text = "0";
            // 
            // btnLapHD
            // 
            this.btnLapHD.BackColor = System.Drawing.Color.Silver;
            this.btnLapHD.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapHD.Location = new System.Drawing.Point(1087, 293);
            this.btnLapHD.Name = "btnLapHD";
            this.btnLapHD.Size = new System.Drawing.Size(109, 47);
            this.btnLapHD.TabIndex = 89;
            this.btnLapHD.Text = "Lập Hóa Đơn";
            this.btnLapHD.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(741, 444);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 20);
            this.label12.TabIndex = 93;
            this.label12.Text = "Tổng tiền:";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTimKiem.Location = new System.Drawing.Point(454, 21);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(56, 25);
            this.btnTimKiem.TabIndex = 73;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 58;
            this.label3.Text = "Màu sắc:";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(92, 23);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(354, 26);
            this.txtTim.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 19);
            this.label4.TabIndex = 59;
            this.label4.Text = "Loại quần áo";
            // 
            // dgvTraiCay
            // 
            this.dgvTraiCay.AllowUserToAddRows = false;
            this.dgvTraiCay.AllowUserToDeleteRows = false;
            this.dgvTraiCay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraiCay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colquanao,
            this.coltenquanao,
            this.colmausac,
            this.colloaiquanao,
            this.colchatlieu,
            this.colgiatien,
            this.colhinh,
            this.colsoluong,
            this.colnhacungcap,
            this.coltrangthai});
            this.dgvTraiCay.Location = new System.Drawing.Point(6, 285);
            this.dgvTraiCay.Name = "dgvTraiCay";
            this.dgvTraiCay.ReadOnly = true;
            this.dgvTraiCay.RowHeadersVisible = false;
            this.dgvTraiCay.RowHeadersWidth = 51;
            this.dgvTraiCay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTraiCay.Size = new System.Drawing.Size(672, 203);
            this.dgvTraiCay.TabIndex = 20;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(858, 366);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.ReadOnly = true;
            this.txtMaHD.Size = new System.Drawing.Size(135, 22);
            this.txtMaHD.TabIndex = 95;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1032, 444);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 16);
            this.label10.TabIndex = 96;
            this.label10.Text = "VNĐ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.lblDuongDan);
            this.groupBox1.Controls.Add(this.lblThanhTien);
            this.groupBox1.Controls.Add(this.cbbNCC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.picBoxTraiCay);
            this.groupBox1.Controls.Add(this.chkTrangThai);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtGiaTien);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTim);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtChatLieu);
            this.groupBox1.Controls.Add(this.txtMaTraiCay);
            this.groupBox1.Controls.Add(this.txtTenTraiCay);
            this.groupBox1.Controls.Add(this.txtMau);
            this.groupBox1.Controls.Add(this.cbbLoaiTC);
            this.groupBox1.Controls.Add(this.dgvTraiCay);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 502);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin quần áo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 60;
            this.label5.Text = "Chất liệu:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(280, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 19);
            this.label8.TabIndex = 63;
            this.label8.Text = "Nhà cung cấp:";
            // 
            // txtChatLieu
            // 
            this.txtChatLieu.Location = new System.Drawing.Point(121, 257);
            this.txtChatLieu.Name = "txtChatLieu";
            this.txtChatLieu.Size = new System.Drawing.Size(140, 26);
            this.txtChatLieu.TabIndex = 70;
            // 
            // txtMaTraiCay
            // 
            this.txtMaTraiCay.Location = new System.Drawing.Point(121, 62);
            this.txtMaTraiCay.Name = "txtMaTraiCay";
            this.txtMaTraiCay.Size = new System.Drawing.Size(140, 26);
            this.txtMaTraiCay.TabIndex = 64;
            // 
            // txtTenTraiCay
            // 
            this.txtTenTraiCay.Location = new System.Drawing.Point(121, 111);
            this.txtTenTraiCay.Name = "txtTenTraiCay";
            this.txtTenTraiCay.Size = new System.Drawing.Size(140, 26);
            this.txtTenTraiCay.TabIndex = 65;
            // 
            // txtMau
            // 
            this.txtMau.Location = new System.Drawing.Point(121, 159);
            this.txtMau.Name = "txtMau";
            this.txtMau.Size = new System.Drawing.Size(140, 26);
            this.txtMau.TabIndex = 66;
            // 
            // cbbLoaiTC
            // 
            this.cbbLoaiTC.FormattingEnabled = true;
            this.cbbLoaiTC.Location = new System.Drawing.Point(121, 208);
            this.cbbLoaiTC.Name = "cbbLoaiTC";
            this.cbbLoaiTC.Size = new System.Drawing.Size(140, 27);
            this.cbbLoaiTC.TabIndex = 69;
            // 
            // colquanao
            // 
            this.colquanao.DataPropertyName = "MaQuanAo";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.colquanao.DefaultCellStyle = dataGridViewCellStyle3;
            this.colquanao.HeaderText = "Mã quần áo";
            this.colquanao.MinimumWidth = 6;
            this.colquanao.Name = "colquanao";
            this.colquanao.ReadOnly = true;
            this.colquanao.Width = 125;
            // 
            // coltenquanao
            // 
            this.coltenquanao.DataPropertyName = "TenQuanAo";
            this.coltenquanao.HeaderText = "Tên quần áo";
            this.coltenquanao.MinimumWidth = 6;
            this.coltenquanao.Name = "coltenquanao";
            this.coltenquanao.ReadOnly = true;
            this.coltenquanao.Width = 125;
            // 
            // colmausac
            // 
            this.colmausac.DataPropertyName = "Mau";
            this.colmausac.HeaderText = "Màu sắc";
            this.colmausac.MinimumWidth = 6;
            this.colmausac.Name = "colmausac";
            this.colmausac.ReadOnly = true;
            this.colmausac.Width = 125;
            // 
            // colloaiquanao
            // 
            this.colloaiquanao.DataPropertyName = "MaLoaiQuanAo";
            this.colloaiquanao.HeaderText = "Loại quần áo";
            this.colloaiquanao.MinimumWidth = 6;
            this.colloaiquanao.Name = "colloaiquanao";
            this.colloaiquanao.ReadOnly = true;
            this.colloaiquanao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colloaiquanao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colloaiquanao.Width = 125;
            // 
            // colchatlieu
            // 
            this.colchatlieu.DataPropertyName = "Chatlieu";
            this.colchatlieu.HeaderText = "Chất liệu";
            this.colchatlieu.MinimumWidth = 6;
            this.colchatlieu.Name = "colchatlieu";
            this.colchatlieu.ReadOnly = true;
            this.colchatlieu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colchatlieu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colchatlieu.Width = 125;
            // 
            // colgiatien
            // 
            this.colgiatien.DataPropertyName = "GiaTien";
            dataGridViewCellStyle4.Format = "#,## VNĐ";
            this.colgiatien.DefaultCellStyle = dataGridViewCellStyle4;
            this.colgiatien.HeaderText = "Giá tiền";
            this.colgiatien.MinimumWidth = 6;
            this.colgiatien.Name = "colgiatien";
            this.colgiatien.ReadOnly = true;
            this.colgiatien.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colgiatien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colgiatien.Width = 125;
            // 
            // colhinh
            // 
            this.colhinh.DataPropertyName = "HinhAnh";
            this.colhinh.HeaderText = "Hình";
            this.colhinh.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colhinh.MinimumWidth = 6;
            this.colhinh.Name = "colhinh";
            this.colhinh.ReadOnly = true;
            this.colhinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colhinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colhinh.Width = 125;
            // 
            // colsoluong
            // 
            this.colsoluong.DataPropertyName = "SoLuong";
            this.colsoluong.HeaderText = "Số lượng";
            this.colsoluong.MinimumWidth = 6;
            this.colsoluong.Name = "colsoluong";
            this.colsoluong.ReadOnly = true;
            this.colsoluong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colsoluong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colsoluong.Width = 125;
            // 
            // colnhacungcap
            // 
            this.colnhacungcap.DataPropertyName = "MaNhaCungCap";
            this.colnhacungcap.HeaderText = "Nhà cung cấp";
            this.colnhacungcap.MinimumWidth = 6;
            this.colnhacungcap.Name = "colnhacungcap";
            this.colnhacungcap.ReadOnly = true;
            this.colnhacungcap.Width = 125;
            // 
            // coltrangthai
            // 
            this.coltrangthai.DataPropertyName = "TrangThai";
            this.coltrangthai.HeaderText = "Trạng thái";
            this.coltrangthai.MinimumWidth = 6;
            this.coltrangthai.Name = "coltrangthai";
            this.coltrangthai.ReadOnly = true;
            this.coltrangthai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.coltrangthai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.coltrangthai.Width = 125;
            // 
            // colMaQA
            // 
            this.colMaQA.DataPropertyName = "MaQA";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.colMaQA.DefaultCellStyle = dataGridViewCellStyle1;
            this.colMaQA.HeaderText = "Mã quần áo";
            this.colMaQA.MinimumWidth = 6;
            this.colMaQA.Name = "colMaQA";
            this.colMaQA.ReadOnly = true;
            this.colMaQA.Width = 125;
            // 
            // colTenQA
            // 
            this.colTenQA.DataPropertyName = "TenQuanAo";
            this.colTenQA.HeaderText = "Tên quần áo";
            this.colTenQA.MinimumWidth = 6;
            this.colTenQA.Name = "colTenQA";
            this.colTenQA.ReadOnly = true;
            this.colTenQA.Width = 125;
            // 
            // colMauTC
            // 
            this.colMauTC.DataPropertyName = "Mau";
            this.colMauTC.HeaderText = "Màu sắc";
            this.colMauTC.MinimumWidth = 6;
            this.colMauTC.Name = "colMauTC";
            this.colMauTC.ReadOnly = true;
            this.colMauTC.Width = 125;
            // 
            // colLoaiQA
            // 
            this.colLoaiQA.DataPropertyName = "MaLoaiQuanAo";
            this.colLoaiQA.HeaderText = "Loại quần áo";
            this.colLoaiQA.MinimumWidth = 6;
            this.colLoaiQA.Name = "colLoaiQA";
            this.colLoaiQA.ReadOnly = true;
            this.colLoaiQA.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLoaiQA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colLoaiQA.Width = 125;
            // 
            // colCL
            // 
            this.colCL.DataPropertyName = "ChatLieu";
            this.colCL.HeaderText = "Chất liệu";
            this.colCL.MinimumWidth = 6;
            this.colCL.Name = "colCL";
            this.colCL.ReadOnly = true;
            this.colCL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCL.Width = 125;
            // 
            // colGiaTienTC
            // 
            this.colGiaTienTC.DataPropertyName = "GiaTien";
            dataGridViewCellStyle2.Format = "#,## VNĐ";
            this.colGiaTienTC.DefaultCellStyle = dataGridViewCellStyle2;
            this.colGiaTienTC.HeaderText = "Giá tiền";
            this.colGiaTienTC.MinimumWidth = 6;
            this.colGiaTienTC.Name = "colGiaTienTC";
            this.colGiaTienTC.ReadOnly = true;
            this.colGiaTienTC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colGiaTienTC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colGiaTienTC.Width = 125;
            // 
            // colThanhTien
            // 
            this.colThanhTien.DataPropertyName = "ThanhTien";
            this.colThanhTien.HeaderText = "Thành tiền";
            this.colThanhTien.MinimumWidth = 6;
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true;
            this.colThanhTien.Width = 125;
            // 
            // colHinhTC
            // 
            this.colHinhTC.DataPropertyName = "HinhAnh";
            this.colHinhTC.HeaderText = "Hình";
            this.colHinhTC.MinimumWidth = 6;
            this.colHinhTC.Name = "colHinhTC";
            this.colHinhTC.ReadOnly = true;
            this.colHinhTC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colHinhTC.Width = 125;
            // 
            // colSoLuongTC
            // 
            this.colSoLuongTC.DataPropertyName = "SoLuong";
            this.colSoLuongTC.HeaderText = "Số lượng";
            this.colSoLuongTC.MinimumWidth = 6;
            this.colSoLuongTC.Name = "colSoLuongTC";
            this.colSoLuongTC.ReadOnly = true;
            this.colSoLuongTC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSoLuongTC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSoLuongTC.Width = 125;
            // 
            // colNCC
            // 
            this.colNCC.DataPropertyName = "MaNhaCungCap";
            this.colNCC.HeaderText = "Nhà cung cấp";
            this.colNCC.MinimumWidth = 6;
            this.colNCC.Name = "colNCC";
            this.colNCC.ReadOnly = true;
            this.colNCC.Width = 125;
            // 
            // colTrangThaiTC
            // 
            this.colTrangThaiTC.DataPropertyName = "TrangThai";
            this.colTrangThaiTC.HeaderText = "Trạng thái";
            this.colTrangThaiTC.MinimumWidth = 6;
            this.colTrangThaiTC.Name = "colTrangThaiTC";
            this.colTrangThaiTC.ReadOnly = true;
            this.colTrangThaiTC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTrangThaiTC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTrangThaiTC.Width = 125;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(479, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 16);
            this.label14.TabIndex = 98;
            this.label14.Text = "Hóa Đơn Nhập";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Silver;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(730, 293);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(114, 47);
            this.btnThem.TabIndex = 99;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1356, 623);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnXoaGioHang);
            this.Controls.Add(this.btnHuySP);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.btnLapHD);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHoaDonNhap";
            this.Text = "HoaDonNhap";
            this.Load += new System.EventHandler(this.frmHoaDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPThem)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTraiCay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraiCay)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSPThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblDuongDan;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.ComboBox cbbNCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBoxTraiCay;
        private System.Windows.Forms.CheckBox chkTrangThai;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnXoaGioHang;
        private System.Windows.Forms.Button btnHuySP;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog ofdHinh;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnLapHD;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvTraiCay;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtChatLieu;
        private System.Windows.Forms.TextBox txtMaTraiCay;
        private System.Windows.Forms.TextBox txtTenTraiCay;
        private System.Windows.Forms.TextBox txtMau;
        private System.Windows.Forms.ComboBox cbbLoaiTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colquanao;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltenquanao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmausac;
        private System.Windows.Forms.DataGridViewTextBoxColumn colloaiquanao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colchatlieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colgiatien;
        private System.Windows.Forms.DataGridViewImageColumn colhinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnhacungcap;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltrangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaQA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenQA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMauTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiQA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaTienTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHinhTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThaiTC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnThem;
    }
}