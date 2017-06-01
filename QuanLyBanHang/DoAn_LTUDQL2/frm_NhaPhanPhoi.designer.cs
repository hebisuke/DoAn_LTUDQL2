namespace DoAn_LTUDQL2
{
    partial class frm_NhaPhanPhoi
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nhaPhanPhoiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhaPhanPhoiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.colMaNPP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNPP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKhuVuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDTBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDTDD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWebsite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNganHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioiHanNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoHienTai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChietKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNguoiLienHe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTinhTrangQuanLy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHangHoas = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhuVuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMuaHangs = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaPhanPhoiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaPhanPhoiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Thêm", null, "Add"),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Xóa", null, "Delete"),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Sữa", null, "Customization"),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Nạp Lại", null, "Refresh"),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Xuất", null, "IndentIncrease"),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Nhập", null, "IndentDecrease"),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Đóng", null, "Cancel")});
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1192, 524);
            this.groupControl1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 45);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1188, 477);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNPP,
            this.colTenNPP,
            this.colMaKhuVuc,
            this.colDiaChi,
            this.colMST,
            this.colDTBan,
            this.colDTDD,
            this.colFax,
            this.colEmail,
            this.colWebsite,
            this.colSTK,
            this.colNganHang,
            this.colGioiHanNo,
            this.colNoHienTai,
            this.colChietKhau,
            this.colNguoiLienHe,
            this.colChucVu,
            this.colTinhTrangQuanLy,
            this.colGhiChu,
            this.colHangHoas,
            this.colKhuVuc,
            this.colMuaHangs});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // nhaPhanPhoiBindingSource
            // 
            this.nhaPhanPhoiBindingSource.DataSource = typeof(DoAn_LTUDQL2.NhaPhanPhoi);
            // 
            // nhaPhanPhoiBindingSource1
            // 
            this.nhaPhanPhoiBindingSource1.DataSource = typeof(DoAn_LTUDQL2.NhaPhanPhoi);
            // 
            // colMaNPP
            // 
            this.colMaNPP.FieldName = "MaNPP";
            this.colMaNPP.Name = "colMaNPP";
            this.colMaNPP.Visible = true;
            this.colMaNPP.VisibleIndex = 0;
            // 
            // colTenNPP
            // 
            this.colTenNPP.FieldName = "TenNPP";
            this.colTenNPP.Name = "colTenNPP";
            this.colTenNPP.Visible = true;
            this.colTenNPP.VisibleIndex = 1;
            // 
            // colMaKhuVuc
            // 
            this.colMaKhuVuc.FieldName = "MaKhuVuc";
            this.colMaKhuVuc.Name = "colMaKhuVuc";
            this.colMaKhuVuc.Visible = true;
            this.colMaKhuVuc.VisibleIndex = 2;
            // 
            // colDiaChi
            // 
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 3;
            // 
            // colMST
            // 
            this.colMST.FieldName = "MST";
            this.colMST.Name = "colMST";
            this.colMST.Visible = true;
            this.colMST.VisibleIndex = 4;
            // 
            // colDTBan
            // 
            this.colDTBan.FieldName = "DTBan";
            this.colDTBan.Name = "colDTBan";
            this.colDTBan.Visible = true;
            this.colDTBan.VisibleIndex = 5;
            // 
            // colDTDD
            // 
            this.colDTDD.FieldName = "DTDD";
            this.colDTDD.Name = "colDTDD";
            this.colDTDD.Visible = true;
            this.colDTDD.VisibleIndex = 6;
            // 
            // colFax
            // 
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.Visible = true;
            this.colFax.VisibleIndex = 7;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 8;
            // 
            // colWebsite
            // 
            this.colWebsite.FieldName = "Website";
            this.colWebsite.Name = "colWebsite";
            this.colWebsite.Visible = true;
            this.colWebsite.VisibleIndex = 9;
            // 
            // colSTK
            // 
            this.colSTK.FieldName = "STK";
            this.colSTK.Name = "colSTK";
            this.colSTK.Visible = true;
            this.colSTK.VisibleIndex = 10;
            // 
            // colNganHang
            // 
            this.colNganHang.FieldName = "NganHang";
            this.colNganHang.Name = "colNganHang";
            this.colNganHang.Visible = true;
            this.colNganHang.VisibleIndex = 11;
            // 
            // colGioiHanNo
            // 
            this.colGioiHanNo.FieldName = "GioiHanNo";
            this.colGioiHanNo.Name = "colGioiHanNo";
            this.colGioiHanNo.Visible = true;
            this.colGioiHanNo.VisibleIndex = 12;
            // 
            // colNoHienTai
            // 
            this.colNoHienTai.FieldName = "NoHienTai";
            this.colNoHienTai.Name = "colNoHienTai";
            this.colNoHienTai.Visible = true;
            this.colNoHienTai.VisibleIndex = 13;
            // 
            // colChietKhau
            // 
            this.colChietKhau.FieldName = "ChietKhau";
            this.colChietKhau.Name = "colChietKhau";
            this.colChietKhau.Visible = true;
            this.colChietKhau.VisibleIndex = 14;
            // 
            // colNguoiLienHe
            // 
            this.colNguoiLienHe.FieldName = "NguoiLienHe";
            this.colNguoiLienHe.Name = "colNguoiLienHe";
            this.colNguoiLienHe.Visible = true;
            this.colNguoiLienHe.VisibleIndex = 15;
            // 
            // colChucVu
            // 
            this.colChucVu.FieldName = "ChucVu";
            this.colChucVu.Name = "colChucVu";
            this.colChucVu.Visible = true;
            this.colChucVu.VisibleIndex = 16;
            // 
            // colTinhTrangQuanLy
            // 
            this.colTinhTrangQuanLy.FieldName = "TinhTrangQuanLy";
            this.colTinhTrangQuanLy.Name = "colTinhTrangQuanLy";
            this.colTinhTrangQuanLy.Visible = true;
            this.colTinhTrangQuanLy.VisibleIndex = 17;
            // 
            // colGhiChu
            // 
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 18;
            // 
            // colHangHoas
            // 
            this.colHangHoas.FieldName = "HangHoas";
            this.colHangHoas.Name = "colHangHoas";
            this.colHangHoas.Visible = true;
            this.colHangHoas.VisibleIndex = 19;
            // 
            // colKhuVuc
            // 
            this.colKhuVuc.FieldName = "KhuVuc";
            this.colKhuVuc.Name = "colKhuVuc";
            this.colKhuVuc.Visible = true;
            this.colKhuVuc.VisibleIndex = 20;
            // 
            // colMuaHangs
            // 
            this.colMuaHangs.FieldName = "MuaHangs";
            this.colMuaHangs.Name = "colMuaHangs";
            this.colMuaHangs.Visible = true;
            this.colMuaHangs.VisibleIndex = 21;
            // 
            // frm_NhaPhanPhoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 524);
            this.Controls.Add(this.groupControl1);
            this.Name = "frm_NhaPhanPhoi";
            this.Text = "frm_NhaPhanPhoi";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaPhanPhoiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaPhanPhoiBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNPP;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNPP;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKhuVuc;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colMST;
        private DevExpress.XtraGrid.Columns.GridColumn colDTBan;
        private DevExpress.XtraGrid.Columns.GridColumn colDTDD;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colWebsite;
        private DevExpress.XtraGrid.Columns.GridColumn colSTK;
        private DevExpress.XtraGrid.Columns.GridColumn colNganHang;
        private DevExpress.XtraGrid.Columns.GridColumn colGioiHanNo;
        private DevExpress.XtraGrid.Columns.GridColumn colNoHienTai;
        private DevExpress.XtraGrid.Columns.GridColumn colChietKhau;
        private DevExpress.XtraGrid.Columns.GridColumn colNguoiLienHe;
        private DevExpress.XtraGrid.Columns.GridColumn colChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn colTinhTrangQuanLy;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colHangHoas;
        private DevExpress.XtraGrid.Columns.GridColumn colKhuVuc;
        private DevExpress.XtraGrid.Columns.GridColumn colMuaHangs;
        private System.Windows.Forms.BindingSource nhaPhanPhoiBindingSource;
        private System.Windows.Forms.BindingSource nhaPhanPhoiBindingSource1;
    }
}