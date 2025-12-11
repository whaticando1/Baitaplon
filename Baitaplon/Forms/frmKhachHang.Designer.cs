namespace Baitaplon.Forms
{
    partial class frmKhachHang
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
            this.btnDong = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.mskDienthoai = new System.Windows.Forms.MaskedTextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtTenkhach = new System.Windows.Forms.TextBox();
            this.txtMakhach = new System.Windows.Forms.TextBox();
            this.lblDienthoai = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblTenkhach = new System.Windows.Forms.Label();
            this.lblMakhach = new System.Windows.Forms.Label();
            this.lblDMKH = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mskDangky = new System.Windows.Forms.MaskedTextBox();
            this.lblThongbao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.Transparent;
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.Black;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnDong.Location = new System.Drawing.Point(1025, 656);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(125, 55);
            this.btnDong.TabIndex = 32;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.BackColor = System.Drawing.Color.Transparent;
            this.btnBoqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoqua.ForeColor = System.Drawing.Color.Black;
            this.btnBoqua.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnBoqua.Location = new System.Drawing.Point(858, 656);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(125, 55);
            this.btnBoqua.TabIndex = 31;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = false;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Transparent;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Black;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnLuu.Location = new System.Drawing.Point(1025, 546);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(125, 55);
            this.btnLuu.TabIndex = 30;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSua.Location = new System.Drawing.Point(858, 546);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(125, 55);
            this.btnSua.TabIndex = 29;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnXoa.Location = new System.Drawing.Point(1025, 445);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(125, 55);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(858, 445);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(125, 55);
            this.btnThem.TabIndex = 27;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.BackgroundColor = System.Drawing.Color.DarkGray;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(146, 378);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 82;
            this.DataGridView.RowTemplate.Height = 33;
            this.DataGridView.Size = new System.Drawing.Size(632, 374);
            this.DataGridView.TabIndex = 26;
            this.DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            // 
            // mskDienthoai
            // 
            this.mskDienthoai.BackColor = System.Drawing.Color.White;
            this.mskDienthoai.Location = new System.Drawing.Point(789, 166);
            this.mskDienthoai.Mask = "(999) 000-0000";
            this.mskDienthoai.Name = "mskDienthoai";
            this.mskDienthoai.Size = new System.Drawing.Size(278, 31);
            this.mskDienthoai.TabIndex = 25;
            // 
            // txtDiachi
            // 
            this.txtDiachi.BackColor = System.Drawing.Color.White;
            this.txtDiachi.Location = new System.Drawing.Point(264, 281);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(278, 31);
            this.txtDiachi.TabIndex = 24;
            // 
            // txtTenkhach
            // 
            this.txtTenkhach.BackColor = System.Drawing.Color.White;
            this.txtTenkhach.Location = new System.Drawing.Point(264, 223);
            this.txtTenkhach.Name = "txtTenkhach";
            this.txtTenkhach.Size = new System.Drawing.Size(278, 31);
            this.txtTenkhach.TabIndex = 23;
            // 
            // txtMakhach
            // 
            this.txtMakhach.BackColor = System.Drawing.Color.White;
            this.txtMakhach.Location = new System.Drawing.Point(264, 166);
            this.txtMakhach.Name = "txtMakhach";
            this.txtMakhach.Size = new System.Drawing.Size(278, 31);
            this.txtMakhach.TabIndex = 22;
            // 
            // lblDienthoai
            // 
            this.lblDienthoai.AutoSize = true;
            this.lblDienthoai.BackColor = System.Drawing.Color.Transparent;
            this.lblDienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDienthoai.ForeColor = System.Drawing.Color.Black;
            this.lblDienthoai.Location = new System.Drawing.Point(641, 169);
            this.lblDienthoai.Name = "lblDienthoai";
            this.lblDienthoai.Size = new System.Drawing.Size(115, 25);
            this.lblDienthoai.TabIndex = 21;
            this.lblDienthoai.Text = "Điện thoại:";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.BackColor = System.Drawing.Color.Transparent;
            this.lblDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiachi.ForeColor = System.Drawing.Color.Black;
            this.lblDiachi.Location = new System.Drawing.Point(141, 284);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(84, 25);
            this.lblDiachi.TabIndex = 20;
            this.lblDiachi.Text = "Địa chỉ:";
            // 
            // lblTenkhach
            // 
            this.lblTenkhach.AutoSize = true;
            this.lblTenkhach.BackColor = System.Drawing.Color.Transparent;
            this.lblTenkhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenkhach.ForeColor = System.Drawing.Color.Black;
            this.lblTenkhach.Location = new System.Drawing.Point(113, 226);
            this.lblTenkhach.Name = "lblTenkhach";
            this.lblTenkhach.Size = new System.Drawing.Size(119, 25);
            this.lblTenkhach.TabIndex = 19;
            this.lblTenkhach.Text = "Tên khách:";
            // 
            // lblMakhach
            // 
            this.lblMakhach.AutoSize = true;
            this.lblMakhach.BackColor = System.Drawing.Color.Transparent;
            this.lblMakhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMakhach.ForeColor = System.Drawing.Color.Black;
            this.lblMakhach.Location = new System.Drawing.Point(113, 169);
            this.lblMakhach.Name = "lblMakhach";
            this.lblMakhach.Size = new System.Drawing.Size(112, 25);
            this.lblMakhach.TabIndex = 18;
            this.lblMakhach.Text = "Mã khách:";
            // 
            // lblDMKH
            // 
            this.lblDMKH.AutoSize = true;
            this.lblDMKH.BackColor = System.Drawing.Color.Transparent;
            this.lblDMKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDMKH.ForeColor = System.Drawing.Color.Black;
            this.lblDMKH.Location = new System.Drawing.Point(337, 50);
            this.lblDMKH.Name = "lblDMKH";
            this.lblDMKH.Size = new System.Drawing.Size(569, 51);
            this.lblDMKH.TabIndex = 17;
            this.lblDMKH.Text = "DANH MỤC KHÁCH HÀNG";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(789, 281);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(278, 31);
            this.txtEmail.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(666, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(607, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "Ngày đăng ký:";
            // 
            // mskDangky
            // 
            this.mskDangky.BackColor = System.Drawing.Color.White;
            this.mskDangky.Location = new System.Drawing.Point(789, 220);
            this.mskDangky.Mask = "00/00/0000";
            this.mskDangky.Name = "mskDangky";
            this.mskDangky.Size = new System.Drawing.Size(278, 31);
            this.mskDangky.TabIndex = 39;
            this.mskDangky.ValidatingType = typeof(System.DateTime);
            // 
            // lblThongbao
            // 
            this.lblThongbao.AutoSize = true;
            this.lblThongbao.Location = new System.Drawing.Point(201, 338);
            this.lblThongbao.Name = "lblThongbao";
            this.lblThongbao.Size = new System.Drawing.Size(0, 25);
            this.lblThongbao.TabIndex = 107;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1216, 858);
            this.Controls.Add(this.lblThongbao);
            this.Controls.Add(this.mskDangky);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.mskDienthoai);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtTenkhach);
            this.Controls.Add(this.txtMakhach);
            this.Controls.Add(this.lblDienthoai);
            this.Controls.Add(this.lblDiachi);
            this.Controls.Add(this.lblTenkhach);
            this.Controls.Add(this.lblMakhach);
            this.Controls.Add(this.lblDMKH);
            this.Name = "frmKhachHang";
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.MaskedTextBox mskDienthoai;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtTenkhach;
        private System.Windows.Forms.TextBox txtMakhach;
        private System.Windows.Forms.Label lblDienthoai;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblTenkhach;
        private System.Windows.Forms.Label lblMakhach;
        private System.Windows.Forms.Label lblDMKH;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskDangky;
        private System.Windows.Forms.Label lblThongbao;
    }
}