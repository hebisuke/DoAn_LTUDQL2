namespace DoAn_LTUDQL2
{
    partial class frm_DoiMK
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
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_ReMKMoi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_MKMoi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_MKCu = new DevExpress.XtraEditors.TextEdit();
            this.btn_Thoat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_DongY = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txt_ReMKMoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MKMoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MKCu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(14, 157);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(89, 13);
            this.labelControl4.TabIndex = 19;
            this.labelControl4.Text = "Nhập Lại Mật Khẩu";
            // 
            // txt_ReMKMoi
            // 
            this.txt_ReMKMoi.EditValue = "";
            this.txt_ReMKMoi.Location = new System.Drawing.Point(114, 154);
            this.txt_ReMKMoi.Name = "txt_ReMKMoi";
            this.txt_ReMKMoi.Properties.UseSystemPasswordChar = true;
            this.txt_ReMKMoi.Size = new System.Drawing.Size(157, 20);
            this.txt_ReMKMoi.TabIndex = 18;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(14, 115);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 13);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "Mật Khẩu Mới";
            // 
            // txt_MKMoi
            // 
            this.txt_MKMoi.EditValue = "";
            this.txt_MKMoi.Location = new System.Drawing.Point(114, 112);
            this.txt_MKMoi.Name = "txt_MKMoi";
            this.txt_MKMoi.Properties.UseSystemPasswordChar = true;
            this.txt_MKMoi.Size = new System.Drawing.Size(157, 20);
            this.txt_MKMoi.TabIndex = 16;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 13);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "Mật Khẩu Cũ";
            // 
            // txt_MKCu
            // 
            this.txt_MKCu.EditValue = "";
            this.txt_MKCu.Location = new System.Drawing.Point(114, 68);
            this.txt_MKCu.Name = "txt_MKCu";
            this.txt_MKCu.Properties.UseSystemPasswordChar = true;
            this.txt_MKCu.Size = new System.Drawing.Size(157, 20);
            this.txt_MKCu.TabIndex = 14;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.ImageUri.Uri = "Cancel";
            this.btn_Thoat.Location = new System.Drawing.Point(163, 200);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(89, 37);
            this.btn_Thoat.TabIndex = 13;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_DongY
            // 
            this.btn_DongY.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_DongY.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_DongY.ImageUri.Uri = "Apply";
            this.btn_DongY.Location = new System.Drawing.Point(37, 200);
            this.btn_DongY.Name = "btn_DongY";
            this.btn_DongY.Size = new System.Drawing.Size(85, 37);
            this.btn_DongY.TabIndex = 12;
            this.btn_DongY.Text = "Đồng Ý";
            this.btn_DongY.Click += new System.EventHandler(this.btn_DongY_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.behaviorManager1.SetBehaviors(this.labelControl1, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.Behaviors.Common.FileIconBehavior.Create(typeof(DevExpress.XtraEditors.Behaviors.FileIconBehaviorSourceForLabelControl), DevExpress.Utils.Behaviors.Common.FileIconSize.ExtraLarge, global::DoAn_LTUDQL2.Properties.Resources.key, global::DoAn_LTUDQL2.Properties.Resources.key)))});
            this.labelControl1.Location = new System.Drawing.Point(34, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(178, 25);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Thay Đổi Mật Khẩu";
            // 
            // frm_DoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txt_ReMKMoi);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txt_MKMoi);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_MKCu);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_DongY);
            this.Controls.Add(this.labelControl1);
            this.Name = "frm_DoiMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_DoiMK";
            this.Load += new System.EventHandler(this.frm_DoiMK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_ReMKMoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MKMoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MKCu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_ReMKMoi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_MKMoi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_MKCu;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_DongY;
        private DevExpress.XtraEditors.SimpleButton btn_Thoat;
    }
}