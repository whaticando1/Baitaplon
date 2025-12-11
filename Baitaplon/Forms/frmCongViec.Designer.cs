namespace Baitaplon.Forms
{
    partial class frmCongViec
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
            this.dataGridViewCV = new System.Windows.Forms.DataGridView();
            this.txtIDCongViec = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtTenCongViec = new System.Windows.Forms.TextBox();
            this.txtLuongCoBan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblThongbaoCV = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.lblDMKH = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCV
            // 
            this.dataGridViewCV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCV.Location = new System.Drawing.Point(142, 363);
            this.dataGridViewCV.Name = "dataGridViewCV";
            this.dataGridViewCV.RowHeadersWidth = 82;
            this.dataGridViewCV.RowTemplate.Height = 33;
            this.dataGridViewCV.Size = new System.Drawing.Size(593, 239);
            this.dataGridViewCV.TabIndex = 0;
            this.dataGridViewCV.Click += new System.EventHandler(this.dataGridViewCV_Click);
            // 
            // txtIDCongViec
            // 
            this.txtIDCongViec.Location = new System.Drawing.Point(261, 103);
            this.txtIDCongViec.Name = "txtIDCongViec";
            this.txtIDCongViec.Size = new System.Drawing.Size(340, 31);
            this.txtIDCongViec.TabIndex = 1;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(761, 138);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(414, 146);
            this.txtMoTa.TabIndex = 2;
            // 
            // txtTenCongViec
            // 
            this.txtTenCongViec.Location = new System.Drawing.Point(261, 177);
            this.txtTenCongViec.Name = "txtTenCongViec";
            this.txtTenCongViec.Size = new System.Drawing.Size(340, 31);
            this.txtTenCongViec.TabIndex = 3;
            // 
            // txtLuongCoBan
            // 
            this.txtLuongCoBan.Location = new System.Drawing.Point(261, 253);
            this.txtLuongCoBan.Name = "txtLuongCoBan";
            this.txtLuongCoBan.Size = new System.Drawing.Size(340, 31);
            this.txtLuongCoBan.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID việc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên việc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Lương cơ bản:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(773, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mô tả:";
            // 
            // lblThongbaoCV
            // 
            this.lblThongbaoCV.AutoSize = true;
            this.lblThongbaoCV.Location = new System.Drawing.Point(256, 308);
            this.lblThongbaoCV.Name = "lblThongbaoCV";
            this.lblThongbaoCV.Size = new System.Drawing.Size(0, 25);
            this.lblThongbaoCV.TabIndex = 9;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(838, 553);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(107, 49);
            this.btnDong.TabIndex = 42;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(838, 459);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(107, 49);
            this.btnBoqua.TabIndex = 41;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(838, 363);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(107, 49);
            this.btnSua.TabIndex = 39;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // lblDMKH
            // 
            this.lblDMKH.AutoSize = true;
            this.lblDMKH.BackColor = System.Drawing.Color.Transparent;
            this.lblDMKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDMKH.ForeColor = System.Drawing.Color.Black;
            this.lblDMKH.Location = new System.Drawing.Point(477, 19);
            this.lblDMKH.Name = "lblDMKH";
            this.lblDMKH.Size = new System.Drawing.Size(271, 51);
            this.lblDMKH.TabIndex = 75;
            this.lblDMKH.Text = "CÔNG VIỆC";
            // 
            // frmCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1256, 742);
            this.Controls.Add(this.lblDMKH);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.lblThongbaoCV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLuongCoBan);
            this.Controls.Add(this.txtTenCongViec);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtIDCongViec);
            this.Controls.Add(this.dataGridViewCV);
            this.Name = "frmCongViec";
            this.Text = "Công việc";
            this.Load += new System.EventHandler(this.frmCongViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCV;
        private System.Windows.Forms.TextBox txtIDCongViec;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtTenCongViec;
        private System.Windows.Forms.TextBox txtLuongCoBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblThongbaoCV;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label lblDMKH;
    }
}