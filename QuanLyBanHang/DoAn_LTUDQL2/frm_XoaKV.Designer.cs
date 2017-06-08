namespace DoAn_LTUDQL2
{
    partial class frm_XoaKV
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
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Location = new System.Drawing.Point(12, 12);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(599, 175);
            this.listBoxControl1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(115, 203);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(149, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Xác Nhận";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(343, 203);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(158, 23);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Thoát";
            // 
            // frm_XoaKV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 254);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.listBoxControl1);
            this.Name = "frm_XoaKV";
            this.Text = "frm_XoaKV";
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}