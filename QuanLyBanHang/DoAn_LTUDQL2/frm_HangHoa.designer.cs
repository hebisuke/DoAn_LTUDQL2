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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HangHoa));
            this.hangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hangHoaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1_HH = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1_HH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // hangHoaBindingSource
            // 
            this.hangHoaBindingSource.DataSource = typeof(BUS.DTO.HangHoa);
            // 
            // hangHoaBindingSource1
            // 
            this.hangHoaBindingSource1.DataSource = typeof(BUS.DTO.HangHoa);
            // 
            // gridControl1_HH
            // 
            this.gridControl1_HH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1_HH.Location = new System.Drawing.Point(0, 40);
            this.gridControl1_HH.MainView = this.gridView1;
            this.gridControl1_HH.Name = "gridControl1_HH";
            this.gridControl1_HH.Size = new System.Drawing.Size(1192, 461);
            this.gridControl1_HH.TabIndex = 1;
            this.gridControl1_HH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.gridView1.GridControl = this.gridControl1_HH;
            this.gridView1.Name = "gridView1";
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
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem4, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem5, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem6, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem7, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thêm";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Sửa";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Xóa";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Nạp Lại";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Xuất";
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Nhập";
            this.barButtonItem6.Id = 5;
            this.barButtonItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Đóng";
            this.barButtonItem7.Id = 6;
            this.barButtonItem7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.Image")));
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1192, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 501);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1192, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 461);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1192, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 461);
            // 
            // frm_HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 524);
            this.Controls.Add(this.gridControl1_HH);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frm_HangHoa";
            this.Text = "frm_HangHoa";
            this.Load += new System.EventHandler(this.frm_HangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1_HH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource hangHoaBindingSource;
        private System.Windows.Forms.BindingSource hangHoaBindingSource1;
        private DevExpress.XtraGrid.GridControl gridControl1_HH;
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
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}