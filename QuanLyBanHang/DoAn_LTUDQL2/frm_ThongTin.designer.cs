namespace DoAn_LTUDQL2
{
    partial class frm_ThongTin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ThongTin));
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Tendonvi = new System.Windows.Forms.TextBox();
            this.thongTinToChucCaNhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtweb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaSoThue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbLinhVuc = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGPKD = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtdtdd = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.thongTinToChucCaNhanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDangKy
            // 
            this.btnDangKy.Image = ((System.Drawing.Image)(resources.GetObject("btnDangKy.Image")));
            this.btnDangKy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangKy.Location = new System.Drawing.Point(117, 365);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(85, 28);
            this.btnDangKy.TabIndex = 1;
            this.btnDangKy.Text = "Đồng Ý";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Image = ((System.Drawing.Image)(resources.GetObject("btnKetThuc.Image")));
            this.btnKetThuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKetThuc.Location = new System.Drawing.Point(224, 365);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(85, 28);
            this.btnKetThuc.TabIndex = 2;
            this.btnKetThuc.Text = "Kết Thúc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 25);
            this.label12.TabIndex = 26;
            this.label12.Text = "THÔNG TIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tên Đơn Vị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Điện Thoại";
            // 
            // txt_Tendonvi
            // 
            this.txt_Tendonvi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thongTinToChucCaNhanBindingSource, "TenDonVi", true));
            this.txt_Tendonvi.Location = new System.Drawing.Point(117, 87);
            this.txt_Tendonvi.Name = "txt_Tendonvi";
            this.txt_Tendonvi.Size = new System.Drawing.Size(387, 20);
            this.txt_Tendonvi.TabIndex = 30;
            // 
            // thongTinToChucCaNhanBindingSource
            // 
            this.thongTinToChucCaNhanBindingSource.DataSource = typeof(DoAn_LTUDQL2.ThongTinToChucCaNhan);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thongTinToChucCaNhanBindingSource, "DiaCHi", true));
            this.txt_DiaChi.Location = new System.Drawing.Point(117, 113);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(387, 20);
            this.txt_DiaChi.TabIndex = 31;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thongTinToChucCaNhanBindingSource, "DTBan", true));
            this.txtDienThoai.Location = new System.Drawing.Point(117, 141);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(231, 20);
            this.txtDienThoai.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Fax";
            // 
            // txtFax
            // 
            this.txtFax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thongTinToChucCaNhanBindingSource, "Fax", true));
            this.txtFax.Location = new System.Drawing.Point(117, 192);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(231, 20);
            this.txtFax.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Website";
            // 
            // txtweb
            // 
            this.txtweb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thongTinToChucCaNhanBindingSource, "Website", true));
            this.txtweb.Location = new System.Drawing.Point(117, 218);
            this.txtweb.Name = "txtweb";
            this.txtweb.Size = new System.Drawing.Size(231, 20);
            this.txtweb.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thongTinToChucCaNhanBindingSource, "Email", true));
            this.txtEmail.Location = new System.Drawing.Point(117, 244);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(231, 20);
            this.txtEmail.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Lĩnh Vực";
            // 
            // txtMaSoThue
            // 
            this.txtMaSoThue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thongTinToChucCaNhanBindingSource, "MST", true));
            this.txtMaSoThue.Location = new System.Drawing.Point(117, 297);
            this.txtMaSoThue.Name = "txtMaSoThue";
            this.txtMaSoThue.Size = new System.Drawing.Size(231, 20);
            this.txtMaSoThue.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Mã Số Thuế";
            // 
            // cbLinhVuc
            // 
            this.cbLinhVuc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thongTinToChucCaNhanBindingSource, "LinhVuc", true));
            this.cbLinhVuc.FormattingEnabled = true;
            this.cbLinhVuc.Items.AddRange(new object[] {
            "1.Bán Hàng,",
            "2.Thương Mại,",
            "3.Kinh Doanh"});
            this.cbLinhVuc.Location = new System.Drawing.Point(117, 270);
            this.cbLinhVuc.Name = "cbLinhVuc";
            this.cbLinhVuc.Size = new System.Drawing.Size(231, 21);
            this.cbLinhVuc.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 330);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "GPKD";
            // 
            // txtGPKD
            // 
            this.txtGPKD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thongTinToChucCaNhanBindingSource, "GPKD", true));
            this.txtGPKD.Location = new System.Drawing.Point(117, 323);
            this.txtGPKD.Name = "txtGPKD";
            this.txtGPKD.Size = new System.Drawing.Size(387, 20);
            this.txtGPKD.TabIndex = 44;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(354, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 178);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "ĐTDĐ";
            // 
            // txtdtdd
            // 
            this.txtdtdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thongTinToChucCaNhanBindingSource, "DTDD", true));
            this.txtdtdd.Location = new System.Drawing.Point(117, 166);
            this.txtdtdd.Name = "txtdtdd";
            this.txtdtdd.Size = new System.Drawing.Size(231, 20);
            this.txtdtdd.TabIndex = 47;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // frm_ThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(524, 410);
            this.Controls.Add(this.txtdtdd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtGPKD);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbLinhVuc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMaSoThue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtweb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.txt_Tendonvi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.btnDangKy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_ThongTin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin";
            this.Load += new System.EventHandler(this.frm_ThongTin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thongTinToChucCaNhanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Tendonvi;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtweb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaSoThue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbLinhVuc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGPKD;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtdtdd;
        private System.Windows.Forms.BindingSource thongTinToChucCaNhanBindingSource;
        private System.Windows.Forms.ImageList imageList1;
    }
}