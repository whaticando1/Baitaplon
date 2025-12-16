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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDonNhap));
            this.dgvNhapHang = new System.Windows.Forms.DataGridView();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.cbbNCC = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picQuanao = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnHuySP = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
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
            this.dgvQuanao = new System.Windows.Forms.DataGridView();
            this.txtMaHDN = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLammoi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtChatLieu = new System.Windows.Forms.TextBox();
            this.txtMaQuanAo = new System.Windows.Forms.TextBox();
            this.txtTenQuanAo = new System.Windows.Forms.TextBox();
            this.txtMau = new System.Windows.Forms.TextBox();
            this.cbbLoaiQA = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chiTiếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQuanao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanao)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNhapHang
            // 
            this.dgvNhapHang.AllowUserToAddRows = false;
            this.dgvNhapHang.AllowUserToDeleteRows = false;
            this.dgvNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvNhapHang.Location = new System.Drawing.Point(12, 11);
            this.dgvNhapHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvNhapHang.Name = "dgvNhapHang";
            this.dgvNhapHang.ReadOnly = true;
            this.dgvNhapHang.RowHeadersVisible = false;
            this.dgvNhapHang.RowHeadersWidth = 51;
            this.dgvNhapHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhapHang.Size = new System.Drawing.Size(734, 317);
            this.dgvNhapHang.TabIndex = 86;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvNhapHang);
            this.groupBox2.Location = new System.Drawing.Point(1083, 89);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(758, 339);
            this.groupBox2.TabIndex = 88;
            this.groupBox2.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(20, 98);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(144, 29);
            this.label17.TabIndex = 85;
            this.label17.Text = "Mã quần áo:";
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhTien.Location = new System.Drawing.Point(592, 327);
            this.lblThanhTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(29, 31);
            this.lblThanhTien.TabIndex = 80;
            this.lblThanhTien.Text = "0";
            // 
            // cbbNCC
            // 
            this.cbbNCC.FormattingEnabled = true;
            this.cbbNCC.Location = new System.Drawing.Point(596, 89);
            this.cbbNCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbNCC.Name = "cbbNCC";
            this.cbbNCC.Size = new System.Drawing.Size(208, 37);
            this.cbbNCC.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 327);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 79;
            this.label1.Text = "Thành tiền:";
            // 
            // picQuanao
            // 
            this.picQuanao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picQuanao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picQuanao.Location = new System.Drawing.Point(842, 36);
            this.picQuanao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picQuanao.Name = "picQuanao";
            this.picQuanao.Size = new System.Drawing.Size(180, 177);
            this.picQuanao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQuanao.TabIndex = 76;
            this.picQuanao.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1114, 577);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 29);
            this.label13.TabIndex = 97;
            this.label13.Text = "Mã hóa đơn:";
            // 
            // btnHuySP
            // 
            this.btnHuySP.BackColor = System.Drawing.Color.Silver;
            this.btnHuySP.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuySP.Location = new System.Drawing.Point(1270, 458);
            this.btnHuySP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuySP.Name = "btnHuySP";
            this.btnHuySP.Size = new System.Drawing.Size(171, 73);
            this.btnHuySP.TabIndex = 91;
            this.btnHuySP.Text = "Hủy nhập sản phẩm";
            this.btnHuySP.UseVisualStyleBackColor = false;
            this.btnHuySP.Click += new System.EventHandler(this.btnHuySP_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(596, 245);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(208, 37);
            this.txtSoLuong.TabIndex = 68;
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(596, 166);
            this.txtGiaTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(208, 37);
            this.txtGiaTien.TabIndex = 67;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(420, 247);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 29);
            this.label7.TabIndex = 62;
            this.label7.Text = "Số lượng:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 41);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 29);
            this.label11.TabIndex = 72;
            this.label11.Text = "Tìm kiếm tên:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(420, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 29);
            this.label6.TabIndex = 61;
            this.label6.Text = "Giá tiền:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 29);
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
            this.lblTongTien.Location = new System.Drawing.Point(1330, 694);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(29, 31);
            this.lblTongTien.TabIndex = 94;
            this.lblTongTien.Text = "0";
            this.lblTongTien.Click += new System.EventHandler(this.lblTongTien_Click);
            // 
            // btnLapHD
            // 
            this.btnLapHD.BackColor = System.Drawing.Color.Silver;
            this.btnLapHD.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapHD.Location = new System.Drawing.Point(1450, 458);
            this.btnLapHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLapHD.Name = "btnLapHD";
            this.btnLapHD.Size = new System.Drawing.Size(164, 73);
            this.btnLapHD.TabIndex = 89;
            this.btnLapHD.Text = "Lưu Hóa Đơn";
            this.btnLapHD.UseVisualStyleBackColor = false;
            this.btnLapHD.Click += new System.EventHandler(this.btnLapHD_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1112, 694);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 31);
            this.label12.TabIndex = 93;
            this.label12.Text = "Tổng tiền:";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTimKiem.Location = new System.Drawing.Point(722, 36);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(84, 39);
            this.btnTimKiem.TabIndex = 73;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 255);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 29);
            this.label3.TabIndex = 58;
            this.label3.Text = "Màu sắc:";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(182, 39);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(529, 37);
            this.txtTim.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 331);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 29);
            this.label4.TabIndex = 59;
            this.label4.Text = "Loại quần áo";
            // 
            // dgvQuanao
            // 
            this.dgvQuanao.AllowUserToAddRows = false;
            this.dgvQuanao.AllowUserToDeleteRows = false;
            this.dgvQuanao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanao.Location = new System.Drawing.Point(9, 445);
            this.dgvQuanao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvQuanao.Name = "dgvQuanao";
            this.dgvQuanao.ReadOnly = true;
            this.dgvQuanao.RowHeadersVisible = false;
            this.dgvQuanao.RowHeadersWidth = 51;
            this.dgvQuanao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuanao.Size = new System.Drawing.Size(1008, 317);
            this.dgvQuanao.TabIndex = 20;
            // 
            // txtMaHDN
            // 
            this.txtMaHDN.Location = new System.Drawing.Point(1287, 572);
            this.txtMaHDN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaHDN.Name = "txtMaHDN";
            this.txtMaHDN.ReadOnly = true;
            this.txtMaHDN.Size = new System.Drawing.Size(200, 31);
            this.txtMaHDN.TabIndex = 95;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1548, 694);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 25);
            this.label10.TabIndex = 96;
            this.label10.Text = "VNĐ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnLammoi);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.lblThanhTien);
            this.groupBox1.Controls.Add(this.cbbNCC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.picQuanao);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtGiaTien);
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
            this.groupBox1.Controls.Add(this.txtMaQuanAo);
            this.groupBox1.Controls.Add(this.txtTenQuanAo);
            this.groupBox1.Controls.Add(this.txtMau);
            this.groupBox1.Controls.Add(this.cbbLoaiQA);
            this.groupBox1.Controls.Add(this.dgvQuanao);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, 89);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1032, 784);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin quần áo";
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(878, 403);
            this.btnLammoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(140, 36);
            this.btnLammoi.TabIndex = 86;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 409);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 29);
            this.label5.TabIndex = 60;
            this.label5.Text = "Chất liệu:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(420, 91);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 29);
            this.label8.TabIndex = 63;
            this.label8.Text = "Nhà cung cấp:";
            // 
            // txtChatLieu
            // 
            this.txtChatLieu.Location = new System.Drawing.Point(182, 402);
            this.txtChatLieu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChatLieu.Name = "txtChatLieu";
            this.txtChatLieu.Size = new System.Drawing.Size(208, 37);
            this.txtChatLieu.TabIndex = 70;
            // 
            // txtMaQuanAo
            // 
            this.txtMaQuanAo.Location = new System.Drawing.Point(182, 97);
            this.txtMaQuanAo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaQuanAo.Name = "txtMaQuanAo";
            this.txtMaQuanAo.Size = new System.Drawing.Size(208, 37);
            this.txtMaQuanAo.TabIndex = 64;
            // 
            // txtTenQuanAo
            // 
            this.txtTenQuanAo.Location = new System.Drawing.Point(182, 173);
            this.txtTenQuanAo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenQuanAo.Name = "txtTenQuanAo";
            this.txtTenQuanAo.Size = new System.Drawing.Size(208, 37);
            this.txtTenQuanAo.TabIndex = 65;
            // 
            // txtMau
            // 
            this.txtMau.Location = new System.Drawing.Point(182, 248);
            this.txtMau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMau.Name = "txtMau";
            this.txtMau.Size = new System.Drawing.Size(208, 37);
            this.txtMau.TabIndex = 66;
            // 
            // cbbLoaiQA
            // 
            this.cbbLoaiQA.FormattingEnabled = true;
            this.cbbLoaiQA.Location = new System.Drawing.Point(182, 325);
            this.cbbLoaiQA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbLoaiQA.Name = "cbbLoaiQA";
            this.cbbLoaiQA.Size = new System.Drawing.Size(208, 37);
            this.cbbLoaiQA.TabIndex = 69;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(695, 24);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(364, 51);
            this.label14.TabIndex = 98;
            this.label14.Text = "HOÁ ĐƠN NHẬP";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Silver;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(1095, 458);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(171, 73);
            this.btnThem.TabIndex = 99;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.Silver;
            this.btnIn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Location = new System.Drawing.Point(1623, 458);
            this.btnIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(164, 73);
            this.btnIn.TabIndex = 100;
            this.btnIn.Text = "In Hóa Đơn";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1548, 425);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(312, 25);
            this.label9.TabIndex = 101;
            this.label9.Text = "Nhấp đúp vào một dòng để xóa";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chiTiếtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 40);
            this.menuStrip1.TabIndex = 102;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chiTiếtToolStripMenuItem
            // 
            this.chiTiếtToolStripMenuItem.Name = "chiTiếtToolStripMenuItem";
            this.chiTiếtToolStripMenuItem.Size = new System.Drawing.Size(111, 36);
            this.chiTiếtToolStripMenuItem.Text = "Chi tiết";
            this.chiTiếtToolStripMenuItem.Click += new System.EventHandler(this.chiTiếtToolStripMenuItem_Click);
            // 
            // frmHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1027);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnHuySP);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.btnLapHD);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtMaHDN);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHoaDonNhap";
            this.Text = "Hoá đơn nhập";
            this.Load += new System.EventHandler(this.frmHoaDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picQuanao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanao)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvNhapHang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.ComboBox cbbNCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picQuanao;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnHuySP;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGiaTien;
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
        private System.Windows.Forms.DataGridView dgvQuanao;
        private System.Windows.Forms.TextBox txtMaHDN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtChatLieu;
        private System.Windows.Forms.TextBox txtMaQuanAo;
        private System.Windows.Forms.TextBox txtTenQuanAo;
        private System.Windows.Forms.TextBox txtMau;
        private System.Windows.Forms.ComboBox cbbLoaiQA;
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
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnLammoi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtToolStripMenuItem;
    }
}