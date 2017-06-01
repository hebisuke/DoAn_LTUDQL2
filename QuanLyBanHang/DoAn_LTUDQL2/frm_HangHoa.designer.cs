namespace DoAn_LTUDQL2
{
    partial class frm_HangHoa
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
            this.hangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hangHoaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clMaHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXuatXu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChietKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTonKhoToiThieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTonKhoHienTai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaMua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaBanSi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaBanLe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKhoHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNhomHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaSKU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCHiTietBanHangs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChiTietMuaHangs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhoHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaPhanPhoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhomHangHoa = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Thêm", null, "Add"),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Sữa", null, "Customization"),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Xóa", null, "Delete"),
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
            this.clMaHang,
            this.colTenHang,
            this.colMaDVT,
            this.colXuatXu,
            this.colThue,
            this.colChietKhau,
            this.colTonKhoToiThieu,
            this.colTonKhoHienTai,
            this.colMaNCC,
            this.colGiaMua,
            this.colGiaBanSi,
            this.colGiaBanLe,
            this.colMaKhoHang,
            this.colMaNhomHang,
            this.colMaSKU,
            this.colCHiTietBanHangs,
            this.colChiTietMuaHangs,
            this.colDonViTinh,
            this.colKhoHang,
            this.colNhaPhanPhoi,
            this.colNhomHangHoa});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // hangHoaBindingSource
            // 
            this.hangHoaBindingSource.DataSource = typeof(DoAn_LTUDQL2.HangHoa);
            // 
            // hangHoaBindingSource1
            // 
            this.hangHoaBindingSource1.DataSource = typeof(DoAn_LTUDQL2.HangHoa);
            // 
            // clMaHang
            // 
            this.clMaHang.Caption = "Mã Hàng";
            this.clMaHang.FieldName = "MaHang";
            this.clMaHang.Name = "clMaHang";
            this.clMaHang.Visible = true;
            this.clMaHang.VisibleIndex = 0;
            // 
            // colTenHang
            // 
            this.colTenHang.Caption = "Tên Hàng";
            this.colTenHang.FieldName = "TenHang";
            this.colTenHang.Name = "colTenHang";
            this.colTenHang.Visible = true;
            this.colTenHang.VisibleIndex = 1;
            // 
            // colMaDVT
            // 
            this.colMaDVT.Caption = "Mã DVT";
            this.colMaDVT.FieldName = "MaDVT";
            this.colMaDVT.Name = "colMaDVT";
            this.colMaDVT.Visible = true;
            this.colMaDVT.VisibleIndex = 2;
            // 
            // colXuatXu
            // 
            this.colXuatXu.Caption = "Xuất Xứ";
            this.colXuatXu.FieldName = "XuatXu";
            this.colXuatXu.Name = "colXuatXu";
            this.colXuatXu.Visible = true;
            this.colXuatXu.VisibleIndex = 3;
            // 
            // colThue
            // 
            this.colThue.FieldName = "Thue";
            this.colThue.Name = "colThue";
            this.colThue.Visible = true;
            this.colThue.VisibleIndex = 4;
            // 
            // colChietKhau
            // 
            this.colChietKhau.FieldName = "ChietKhau";
            this.colChietKhau.Name = "colChietKhau";
            this.colChietKhau.Visible = true;
            this.colChietKhau.VisibleIndex = 5;
            // 
            // colTonKhoToiThieu
            // 
            this.colTonKhoToiThieu.FieldName = "TonKhoToiThieu";
            this.colTonKhoToiThieu.Name = "colTonKhoToiThieu";
            this.colTonKhoToiThieu.Visible = true;
            this.colTonKhoToiThieu.VisibleIndex = 6;
            // 
            // colTonKhoHienTai
            // 
            this.colTonKhoHienTai.FieldName = "TonKhoHienTai";
            this.colTonKhoHienTai.Name = "colTonKhoHienTai";
            this.colTonKhoHienTai.Visible = true;
            this.colTonKhoHienTai.VisibleIndex = 7;
            // 
            // colMaNCC
            // 
            this.colMaNCC.FieldName = "MaNCC";
            this.colMaNCC.Name = "colMaNCC";
            this.colMaNCC.Visible = true;
            this.colMaNCC.VisibleIndex = 8;
            // 
            // colGiaMua
            // 
            this.colGiaMua.FieldName = "GiaMua";
            this.colGiaMua.Name = "colGiaMua";
            this.colGiaMua.Visible = true;
            this.colGiaMua.VisibleIndex = 9;
            // 
            // colGiaBanSi
            // 
            this.colGiaBanSi.FieldName = "GiaBanSi";
            this.colGiaBanSi.Name = "colGiaBanSi";
            this.colGiaBanSi.Visible = true;
            this.colGiaBanSi.VisibleIndex = 10;
            // 
            // colGiaBanLe
            // 
            this.colGiaBanLe.FieldName = "GiaBanLe";
            this.colGiaBanLe.Name = "colGiaBanLe";
            this.colGiaBanLe.Visible = true;
            this.colGiaBanLe.VisibleIndex = 11;
            // 
            // colMaKhoHang
            // 
            this.colMaKhoHang.FieldName = "MaKhoHang";
            this.colMaKhoHang.Name = "colMaKhoHang";
            this.colMaKhoHang.Visible = true;
            this.colMaKhoHang.VisibleIndex = 12;
            // 
            // colMaNhomHang
            // 
            this.colMaNhomHang.FieldName = "MaNhomHang";
            this.colMaNhomHang.Name = "colMaNhomHang";
            this.colMaNhomHang.Visible = true;
            this.colMaNhomHang.VisibleIndex = 13;
            // 
            // colMaSKU
            // 
            this.colMaSKU.FieldName = "MaSKU";
            this.colMaSKU.Name = "colMaSKU";
            this.colMaSKU.Visible = true;
            this.colMaSKU.VisibleIndex = 14;
            // 
            // colCHiTietBanHangs
            // 
            this.colCHiTietBanHangs.FieldName = "CHiTietBanHangs";
            this.colCHiTietBanHangs.Name = "colCHiTietBanHangs";
            this.colCHiTietBanHangs.Visible = true;
            this.colCHiTietBanHangs.VisibleIndex = 15;
            // 
            // colChiTietMuaHangs
            // 
            this.colChiTietMuaHangs.FieldName = "ChiTietMuaHangs";
            this.colChiTietMuaHangs.Name = "colChiTietMuaHangs";
            this.colChiTietMuaHangs.Visible = true;
            this.colChiTietMuaHangs.VisibleIndex = 16;
            // 
            // colDonViTinh
            // 
            this.colDonViTinh.FieldName = "DonViTinh";
            this.colDonViTinh.Name = "colDonViTinh";
            this.colDonViTinh.Visible = true;
            this.colDonViTinh.VisibleIndex = 17;
            // 
            // colKhoHang
            // 
            this.colKhoHang.FieldName = "KhoHang";
            this.colKhoHang.Name = "colKhoHang";
            this.colKhoHang.Visible = true;
            this.colKhoHang.VisibleIndex = 18;
            // 
            // colNhaPhanPhoi
            // 
            this.colNhaPhanPhoi.FieldName = "NhaPhanPhoi";
            this.colNhaPhanPhoi.Name = "colNhaPhanPhoi";
            this.colNhaPhanPhoi.Visible = true;
            this.colNhaPhanPhoi.VisibleIndex = 19;
            // 
            // colNhomHangHoa
            // 
            this.colNhomHangHoa.FieldName = "NhomHangHoa";
            this.colNhomHangHoa.Name = "colNhomHangHoa";
            this.colNhomHangHoa.Visible = true;
            this.colNhomHangHoa.VisibleIndex = 20;
            // 
            // frm_HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 524);
            this.Controls.Add(this.groupControl1);
            this.Name = "frm_HangHoa";
            this.Text = "frm_HangHoa";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn clMaHang;
        private DevExpress.XtraGrid.Columns.GridColumn colTenHang;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colXuatXu;
        private DevExpress.XtraGrid.Columns.GridColumn colThue;
        private DevExpress.XtraGrid.Columns.GridColumn colChietKhau;
        private DevExpress.XtraGrid.Columns.GridColumn colTonKhoToiThieu;
        private DevExpress.XtraGrid.Columns.GridColumn colTonKhoHienTai;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNCC;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaMua;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaBanSi;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaBanLe;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKhoHang;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNhomHang;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSKU;
        private DevExpress.XtraGrid.Columns.GridColumn colCHiTietBanHangs;
        private DevExpress.XtraGrid.Columns.GridColumn colChiTietMuaHangs;
        private DevExpress.XtraGrid.Columns.GridColumn colDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colKhoHang;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaPhanPhoi;
        private DevExpress.XtraGrid.Columns.GridColumn colNhomHangHoa;
        private System.Windows.Forms.BindingSource hangHoaBindingSource;
        private System.Windows.Forms.BindingSource hangHoaBindingSource1;
    }
}