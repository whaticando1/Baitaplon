namespace Baitaplon.Forms
{
    partial class frmNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhaCungCap));
            this.lblDMKH = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblThongbaoCV = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTennhacungcap = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtIDCungcap = new System.Windows.Forms.TextBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mskDienthoai = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblThongbao = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboTrangthai = new System.Windows.Forms.ComboBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDMKH
            // 
            this.lblDMKH.AutoSize = true;
            this.lblDMKH.BackColor = System.Drawing.Color.Transparent;
            this.lblDMKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDMKH.ForeColor = System.Drawing.Color.Black;
            this.lblDMKH.Location = new System.Drawing.Point(450, 56);
            this.lblDMKH.Name = "lblDMKH";
            this.lblDMKH.Size = new System.Drawing.Size(362, 51);
            this.lblDMKH.TabIndex = 92;
            this.lblDMKH.Text = "NHÀ CUNG CẤP";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(919, 676);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(107, 49);
            this.btnDong.TabIndex = 91;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(1004, 508);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(107, 49);
            this.btnBoqua.TabIndex = 90;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(1004, 591);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(107, 49);
            this.btnLuu.TabIndex = 89;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(830, 591);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(107, 49);
            this.btnSua.TabIndex = 88;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(830, 508);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 49);
            this.btnThem.TabIndex = 86;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblThongbaoCV
            // 
            this.lblThongbaoCV.AutoSize = true;
            this.lblThongbaoCV.Location = new System.Drawing.Point(257, 352);
            this.lblThongbaoCV.Name = "lblThongbaoCV";
            this.lblThongbaoCV.Size = new System.Drawing.Size(0, 25);
            this.lblThongbaoCV.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(712, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 84;
            this.label4.Text = "Mô tả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 25);
            this.label2.TabIndex = 82;
            this.label2.Text = "Tên nhà cung cấp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 81;
            this.label1.Text = "Mã nhà cung cấp:";
            // 
            // txtTennhacungcap
            // 
            this.txtTennhacungcap.Location = new System.Drawing.Point(262, 221);
            this.txtTennhacungcap.Name = "txtTennhacungcap";
            this.txtTennhacungcap.Size = new System.Drawing.Size(340, 31);
            this.txtTennhacungcap.TabIndex = 79;
            this.txtTennhacungcap.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTennhacungcap_KeyUp);
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(790, 150);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(406, 128);
            this.txtMoTa.TabIndex = 78;
            // 
            // txtIDCungcap
            // 
            this.txtIDCungcap.Location = new System.Drawing.Point(262, 147);
            this.txtIDCungcap.Name = "txtIDCungcap";
            this.txtIDCungcap.Size = new System.Drawing.Size(340, 31);
            this.txtIDCungcap.TabIndex = 77;
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(110, 491);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 82;
            this.DataGridView.RowTemplate.Height = 33;
            this.DataGridView.Size = new System.Drawing.Size(641, 269);
            this.DataGridView.TabIndex = 76;
            this.DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 94;
            this.label5.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(262, 365);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(340, 31);
            this.txtEmail.TabIndex = 93;
            this.txtEmail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyUp);
            // 
            // mskDienthoai
            // 
            this.mskDienthoai.Location = new System.Drawing.Point(836, 368);
            this.mskDienthoai.Mask = "(999) 000-0000";
            this.mskDienthoai.Name = "mskDienthoai";
            this.mskDienthoai.Size = new System.Drawing.Size(168, 31);
            this.mskDienthoai.TabIndex = 95;
            this.mskDienthoai.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mskDienthoai_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(712, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 96;
            this.label6.Text = "Điện thoại:";
            // 
            // lblThongbao
            // 
            this.lblThongbao.AutoSize = true;
            this.lblThongbao.Location = new System.Drawing.Point(214, 436);
            this.lblThongbao.Name = "lblThongbao";
            this.lblThongbao.Size = new System.Drawing.Size(0, 25);
            this.lblThongbao.TabIndex = 107;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(712, 307);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 25);
            this.label11.TabIndex = 109;
            this.label11.Text = "Trạng thái:";
            // 
            // cboTrangthai
            // 
            this.cboTrangthai.FormattingEnabled = true;
            this.cboTrangthai.Location = new System.Drawing.Point(836, 304);
            this.cboTrangthai.Name = "cboTrangthai";
            this.cboTrangthai.Size = new System.Drawing.Size(168, 33);
            this.cboTrangthai.TabIndex = 108;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(262, 292);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(340, 31);
            this.txtDiachi.TabIndex = 80;
            this.txtDiachi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDiachi_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 83;
            this.label3.Text = "Địa chỉ:";
            // 
            // frmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1257, 809);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cboTrangthai);
            this.Controls.Add(this.lblThongbao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskDienthoai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblDMKH);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblThongbaoCV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtTennhacungcap);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtIDCungcap);
            this.Controls.Add(this.DataGridView);
            this.Name = "frmNhaCungCap";
            this.Text = "Nhà cung cấp";
            this.Load += new System.EventHandler(this.frmNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDMKH;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblThongbaoCV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTennhacungcap;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtIDCungcap;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mskDienthoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblThongbao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboTrangthai;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label label3;
    }
}