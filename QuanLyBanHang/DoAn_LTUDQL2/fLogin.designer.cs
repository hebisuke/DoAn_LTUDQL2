namespace DoAn_LTUDQL2
{
    partial class fLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TaiKhoan = new System.Windows.Forms.TextBox();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.txt_thongbaotk = new System.Windows.Forms.Label();
            this.txt_thongbaomk = new System.Windows.Forms.Label();
            this.txt_vkt = new System.Windows.Forms.Label();
            this.txt_vmk = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Nhập";
            this.label1.ForeColorChanged += new System.EventHandler(this.label1_ForeColorChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu:";
            this.label2.ForeColorChanged += new System.EventHandler(this.label2_ForeColorChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tài Khoản:";
            this.label3.ForeColorChanged += new System.EventHandler(this.label3_ForeColorChanged);
            // 
            // txt_TaiKhoan
            // 
            this.txt_TaiKhoan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TaiKhoan.Location = new System.Drawing.Point(216, 82);
            this.txt_TaiKhoan.Name = "txt_TaiKhoan";
            this.txt_TaiKhoan.Size = new System.Drawing.Size(218, 29);
            this.txt_TaiKhoan.TabIndex = 3;
            this.txt_TaiKhoan.BackColorChanged += new System.EventHandler(this.txt_TaiKhoan_BackColorChanged);
            this.txt_TaiKhoan.TextChanged += new System.EventHandler(this.txt_TaiKhoan_TextChanged);
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.Location = new System.Drawing.Point(216, 140);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(218, 29);
            this.txt_MatKhau.TabIndex = 4;
            this.txt_MatKhau.UseSystemPasswordChar = true;
            this.txt_MatKhau.BackColorChanged += new System.EventHandler(this.txt_MatKhau_BackColorChanged);
            this.txt_MatKhau.TextChanged += new System.EventHandler(this.txt_MatKhau_TextChanged);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.Location = new System.Drawing.Point(131, 253);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(115, 35);
            this.btn_DangNhap.TabIndex = 5;
            this.btn_DangNhap.Text = "Đăng Nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(341, 253);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(93, 35);
            this.btn_Thoat.TabIndex = 6;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // txt_thongbaotk
            // 
            this.txt_thongbaotk.AutoSize = true;
            this.txt_thongbaotk.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_thongbaotk.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_thongbaotk.Location = new System.Drawing.Point(212, 114);
            this.txt_thongbaotk.Name = "txt_thongbaotk";
            this.txt_thongbaotk.Size = new System.Drawing.Size(0, 21);
            this.txt_thongbaotk.TabIndex = 7;
            this.txt_thongbaotk.ForeColorChanged += new System.EventHandler(this.txt_thongbaotk_ForeColorChanged);
            // 
            // txt_thongbaomk
            // 
            this.txt_thongbaomk.AutoSize = true;
            this.txt_thongbaomk.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_thongbaomk.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_thongbaomk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_thongbaomk.Location = new System.Drawing.Point(212, 172);
            this.txt_thongbaomk.Name = "txt_thongbaomk";
            this.txt_thongbaomk.Size = new System.Drawing.Size(0, 21);
            this.txt_thongbaomk.TabIndex = 8;
            this.txt_thongbaomk.ForeColorChanged += new System.EventHandler(this.txt_thongbaomk_ForeColorChanged);
            // 
            // txt_vkt
            // 
            this.txt_vkt.AutoSize = true;
            this.txt_vkt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_vkt.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vkt.Location = new System.Drawing.Point(440, 90);
            this.txt_vkt.Name = "txt_vkt";
            this.txt_vkt.Size = new System.Drawing.Size(0, 26);
            this.txt_vkt.TabIndex = 9;
            this.txt_vkt.ForeColorChanged += new System.EventHandler(this.txt_vkt_ForeColorChanged);
            // 
            // txt_vmk
            // 
            this.txt_vmk.AutoSize = true;
            this.txt_vmk.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_vmk.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vmk.Location = new System.Drawing.Point(440, 148);
            this.txt_vmk.Name = "txt_vmk";
            this.txt_vmk.Size = new System.Drawing.Size(0, 26);
            this.txt_vmk.TabIndex = 10;
            this.txt_vmk.ForeColorChanged += new System.EventHandler(this.txt_vmk_ForeColorChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(216, 210);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(112, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Hiển Thị Mật Khẩu";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.None;
            this.BackgroundImageStore = global::DoAn_LTUDQL2.Properties.Resources.Nexus_5_Background;
            this.ClientSize = new System.Drawing.Size(566, 327);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txt_vmk);
            this.Controls.Add(this.txt_vkt);
            this.Controls.Add(this.txt_thongbaomk);
            this.Controls.Add(this.txt_thongbaotk);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.txt_MatKhau);
            this.Controls.Add(this.txt_TaiKhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TaiKhoan;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label txt_thongbaotk;
        private System.Windows.Forms.Label txt_thongbaomk;
        private System.Windows.Forms.Label txt_vkt;
        private System.Windows.Forms.Label txt_vmk;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}