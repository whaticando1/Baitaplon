namespace Baitaplon.Forms
{
    partial class frmHoaDonBan
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
            this.lblDMKH = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboMakhachhang = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboManhanvien = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mskNgayban = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblThongbao = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTrangthai = new System.Windows.Forms.TextBox();
            this.txtIDHoadonban = new System.Windows.Forms.TextBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.rdo5 = new System.Windows.Forms.RadioButton();
            this.rdo10 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPhuongthucthanhtoan = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDMKH
            // 
            this.lblDMKH.AutoSize = true;
            this.lblDMKH.BackColor = System.Drawing.Color.Transparent;
            this.lblDMKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDMKH.ForeColor = System.Drawing.Color.Black;
            this.lblDMKH.Location = new System.Drawing.Point(292, 17);
            this.lblDMKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDMKH.Name = "lblDMKH";
            this.lblDMKH.Size = new System.Drawing.Size(215, 31);
            this.lblDMKH.TabIndex = 136;
            this.lblDMKH.Text = "HOÁ ĐƠN BÁN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(441, 125);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 158;
            this.label7.Text = "Mã khách hàng:";
            // 
            // cboMakhachhang
            // 
            this.cboMakhachhang.FormattingEnabled = true;
            this.cboMakhachhang.Location = new System.Drawing.Point(563, 122);
            this.cboMakhachhang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMakhachhang.Name = "cboMakhachhang";
            this.cboMakhachhang.Size = new System.Drawing.Size(228, 24);
            this.cboMakhachhang.TabIndex = 157;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(441, 81);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 16);
            this.label10.TabIndex = 156;
            this.label10.Text = "Mã nhân viên:";
            // 
            // cboManhanvien
            // 
            this.cboManhanvien.FormattingEnabled = true;
            this.cboManhanvien.Location = new System.Drawing.Point(563, 79);
            this.cboManhanvien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboManhanvien.Name = "cboManhanvien";
            this.cboManhanvien.Size = new System.Drawing.Size(228, 24);
            this.cboManhanvien.TabIndex = 155;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 127);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 154;
            this.label6.Text = "Ngày bán:";
            // 
            // mskNgayban
            // 
            this.mskNgayban.Location = new System.Drawing.Point(170, 125);
            this.mskNgayban.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mskNgayban.Mask = "00/00/0000";
            this.mskNgayban.Name = "mskNgayban";
            this.mskNgayban.Size = new System.Drawing.Size(228, 22);
            this.mskNgayban.TabIndex = 153;
            this.mskNgayban.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 224);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 152;
            this.label5.Text = "Tổng tiền:";
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(170, 222);
            this.txtTongtien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(228, 22);
            this.txtTongtien.TabIndex = 151;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(665, 415);
            this.btnDong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(71, 31);
            this.btnDong.TabIndex = 150;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(665, 362);
            this.btnBoqua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(71, 31);
            this.btnBoqua.TabIndex = 149;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(549, 415);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(71, 31);
            this.btnLuu.TabIndex = 148;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(549, 362);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(71, 31);
            this.btnSua.TabIndex = 147;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(665, 308);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(71, 31);
            this.btnXoa.TabIndex = 146;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(549, 308);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(71, 31);
            this.btnThem.TabIndex = 145;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // lblThongbao
            // 
            this.lblThongbao.AutoSize = true;
            this.lblThongbao.Location = new System.Drawing.Point(117, 259);
            this.lblThongbao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThongbao.Name = "lblThongbao";
            this.lblThongbao.Size = new System.Drawing.Size(15, 16);
            this.lblThongbao.TabIndex = 144;
            this.lblThongbao.Text = "a";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 143;
            this.label4.Text = "Giảm giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 142;
            this.label2.Text = "Trạng thái:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 141;
            this.label1.Text = "Mã hoá đơn bán:";
            // 
            // txtTrangthai
            // 
            this.txtTrangthai.Location = new System.Drawing.Point(170, 173);
            this.txtTrangthai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTrangthai.Name = "txtTrangthai";
            this.txtTrangthai.Size = new System.Drawing.Size(228, 22);
            this.txtTrangthai.TabIndex = 140;
            // 
            // txtIDHoadonban
            // 
            this.txtIDHoadonban.Location = new System.Drawing.Point(170, 77);
            this.txtIDHoadonban.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIDHoadonban.Name = "txtIDHoadonban";
            this.txtIDHoadonban.Size = new System.Drawing.Size(228, 22);
            this.txtIDHoadonban.TabIndex = 138;
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(69, 298);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 82;
            this.DataGridView.RowTemplate.Height = 33;
            this.DataGridView.Size = new System.Drawing.Size(427, 172);
            this.DataGridView.TabIndex = 137;
            // 
            // rdo5
            // 
            this.rdo5.AutoSize = true;
            this.rdo5.Location = new System.Drawing.Point(557, 174);
            this.rdo5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdo5.Name = "rdo5";
            this.rdo5.Size = new System.Drawing.Size(47, 20);
            this.rdo5.TabIndex = 159;
            this.rdo5.TabStop = true;
            this.rdo5.Text = "5%";
            this.rdo5.UseVisualStyleBackColor = true;
            // 
            // rdo10
            // 
            this.rdo10.AutoSize = true;
            this.rdo10.Location = new System.Drawing.Point(622, 175);
            this.rdo10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdo10.Name = "rdo10";
            this.rdo10.Size = new System.Drawing.Size(54, 20);
            this.rdo10.TabIndex = 160;
            this.rdo10.TabStop = true;
            this.rdo10.Text = "10%";
            this.rdo10.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 226);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 16);
            this.label3.TabIndex = 162;
            this.label3.Text = "Phương thức thanh toán:";
            // 
            // cboPhuongthucthanhtoan
            // 
            this.cboPhuongthucthanhtoan.FormattingEnabled = true;
            this.cboPhuongthucthanhtoan.Location = new System.Drawing.Point(609, 226);
            this.cboPhuongthucthanhtoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboPhuongthucthanhtoan.Name = "cboPhuongthucthanhtoan";
            this.cboPhuongthucthanhtoan.Size = new System.Drawing.Size(181, 24);
            this.cboPhuongthucthanhtoan.TabIndex = 163;
            // 
            // frmHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(824, 488);
            this.Controls.Add(this.cboPhuongthucthanhtoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdo10);
            this.Controls.Add(this.rdo5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboMakhachhang);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboManhanvien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskNgayban);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTongtien);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblThongbao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTrangthai);
            this.Controls.Add(this.txtIDHoadonban);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.lblDMKH);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmHoaDonBan";
            this.Text = "HoaDonBan";
            this.Load += new System.EventHandler(this.frmHoaDonBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDMKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboMakhachhang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboManhanvien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskNgayban;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblThongbao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTrangthai;
        private System.Windows.Forms.TextBox txtIDHoadonban;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.RadioButton rdo5;
        private System.Windows.Forms.RadioButton rdo10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPhuongthucthanhtoan;
    }
}