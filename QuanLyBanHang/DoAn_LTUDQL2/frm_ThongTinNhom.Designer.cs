namespace DoAn_LTUDQL2
{
    partial class frm_ThongTinNhom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ThongTinNhom));
            this.txtdtdd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtweb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txt_Tendonvi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.thongTinToChucCaNhanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKetThuc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinToChucCaNhanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtdtdd
            // 
            this.txtdtdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thongTinToChucCaNhanBindingSource, "DTDD", true));
            this.txtdtdd.Location = new System.Drawing.Point(114, 214);
            this.txtdtdd.Name = "txtdtdd";
            this.txtdtdd.ReadOnly = true;
            this.txtdtdd.Size = new System.Drawing.Size(231, 20);
            this.txtdtdd.TabIndex = 88;
            this.txtdtdd.Text = "0989527499";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 87;
            this.label11.Text = "ĐTDĐ";
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thongTinToChucCaNhanBindingSource, "Email", true));
            this.txtEmail.Location = new System.Drawing.Point(114, 319);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(231, 20);
            this.txtEmail.TabIndex = 85;
            this.txtEmail.Text = "layloi@nhomABC.com";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 84;
            this.label7.Text = "Email";
            // 
            // txtweb
            // 
            this.txtweb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thongTinToChucCaNhanBindingSource, "Website", true));
            this.txtweb.Location = new System.Drawing.Point(114, 284);
            this.txtweb.Name = "txtweb";
            this.txtweb.ReadOnly = true;
            this.txtweb.Size = new System.Drawing.Size(231, 20);
            this.txtweb.TabIndex = 83;
            this.txtweb.Text = "www.nhomABC.com";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 82;
            this.label6.Text = "Website";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 80;
            this.label5.Text = "Fax";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thongTinToChucCaNhanBindingSource, "DTBan", true));
            this.txtDienThoai.Location = new System.Drawing.Point(114, 180);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.ReadOnly = true;
            this.txtDienThoai.Size = new System.Drawing.Size(231, 20);
            this.txtDienThoai.TabIndex = 79;
            this.txtDienThoai.Text = "19006008";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thongTinToChucCaNhanBindingSource, "DiaCHi", true));
            this.txt_DiaChi.Location = new System.Drawing.Point(114, 143);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.ReadOnly = true;
            this.txt_DiaChi.Size = new System.Drawing.Size(387, 20);
            this.txt_DiaChi.TabIndex = 78;
            this.txt_DiaChi.Text = "227 Nguyễn Văn Cừ Q5 TP.HCM";
            // 
            // txtFax
            // 
            this.txtFax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thongTinToChucCaNhanBindingSource, "Fax", true));
            this.txtFax.Location = new System.Drawing.Point(114, 249);
            this.txtFax.Name = "txtFax";
            this.txtFax.ReadOnly = true;
            this.txtFax.Size = new System.Drawing.Size(231, 20);
            this.txtFax.TabIndex = 81;
            this.txtFax.Text = "0838489825";
            // 
            // txt_Tendonvi
            // 
            this.txt_Tendonvi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.thongTinToChucCaNhanBindingSource, "TenDonVi", true));
            this.txt_Tendonvi.Location = new System.Drawing.Point(114, 108);
            this.txt_Tendonvi.Name = "txt_Tendonvi";
            this.txt_Tendonvi.ReadOnly = true;
            this.txt_Tendonvi.Size = new System.Drawing.Size(387, 20);
            this.txt_Tendonvi.TabIndex = 77;
            this.txt_Tendonvi.Text = "Nhóm Thành Sử Ân Hiển Huyền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "Điện Thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "Địa Chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "Tên Đơn Vị";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(151, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(210, 25);
            this.label12.TabIndex = 73;
            this.label12.Text = "THÔNG TIN NHÓM";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // thongTinToChucCaNhanBindingSource
            // 
            this.thongTinToChucCaNhanBindingSource.DataSource = typeof(BUS.DTO.ThongTinToChucCaNhan);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(351, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 178);
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Image = ((System.Drawing.Image)(resources.GetObject("btnKetThuc.Image")));
            this.btnKetThuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKetThuc.Location = new System.Drawing.Point(206, 370);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(139, 65);
            this.btnKetThuc.TabIndex = 72;
            this.btnKetThuc.Text = "Kết Thúc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // frm_ThongTinNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 450);
            this.Controls.Add(this.txtdtdd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtweb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txt_Tendonvi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnKetThuc);
            this.Name = "frm_ThongTinNhom";
            this.Text = "frm_ThongTinNhom";
            ((System.ComponentModel.ISupportInitialize)(this.thongTinToChucCaNhanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdtdd;
        private System.Windows.Forms.BindingSource thongTinToChucCaNhanBindingSource;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtweb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txt_Tendonvi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.ImageList imageList1;
    }
}