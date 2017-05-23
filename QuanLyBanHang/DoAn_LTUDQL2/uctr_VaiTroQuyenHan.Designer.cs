namespace DoAn_LTUDQL2
{
    partial class uctr_VaiTroQuyenHan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.Sửa = new DevExpress.XtraEditors.SimpleButton();
            this.Xoá = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageUri.Uri = "Add";
            this.simpleButton1.Location = new System.Drawing.Point(6, 8);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(111, 39);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Thêm vai trò";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageUri.Uri = "Add";
            this.simpleButton2.Location = new System.Drawing.Point(123, 8);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(138, 39);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Thêm người dùng";
            // 
            // Sửa
            // 
            this.Sửa.ImageUri.Uri = "Replace";
            this.Sửa.Location = new System.Drawing.Point(267, 8);
            this.Sửa.Name = "Sửa";
            this.Sửa.Size = new System.Drawing.Size(68, 39);
            this.Sửa.TabIndex = 2;
            this.Sửa.Text = "Sửa";
            // 
            // Xoá
            // 
            this.Xoá.ImageUri.Uri = "Delete";
            this.Xoá.Location = new System.Drawing.Point(341, 8);
            this.Xoá.Name = "Xoá";
            this.Xoá.Size = new System.Drawing.Size(68, 39);
            this.Xoá.TabIndex = 3;
            this.Xoá.Text = "Xoá";
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageUri.Uri = "Close";
            this.simpleButton3.Location = new System.Drawing.Point(415, 8);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(68, 39);
            this.simpleButton3.TabIndex = 4;
            this.simpleButton3.Text = "Đóng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.simpleButton3);
            this.groupBox1.Controls.Add(this.Xoá);
            this.groupBox1.Controls.Add(this.Sửa);
            this.groupBox1.Controls.Add(this.simpleButton2);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(852, 50);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // uctr_VaiTroQuyenHan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "uctr_VaiTroQuyenHan";
            this.Size = new System.Drawing.Size(852, 480);
            this.Load += new System.EventHandler(this.uctr_VaiTroQuyenHan_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton Sửa;
        private DevExpress.XtraEditors.SimpleButton Xoá;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
