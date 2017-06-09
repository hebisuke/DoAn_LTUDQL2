namespace DoAn_LTUDQL2
{
    partial class frm_KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_KhachHang));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.khachHangsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiKH = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colNickYM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNickSkype = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTinhTrangQuanLy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
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
            this.barButtonItem6});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem6, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Thoát";
            this.barButtonItem6.Id = 5;
            this.barButtonItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1264, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 515);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1264, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 475);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1264, 40);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 475);
            // 
            // khachHangsBindingSource
            // 
            this.khachHangsBindingSource.DataSource = typeof(DoAn_LTUDQL2.DTO.KhachHang);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.khachHangsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 40);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1264, 475);
            this.gridControl1.TabIndex = 19;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaKH,
            this.colTenKH,
            this.colLoaiKH,
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
            this.colNickYM,
            this.colNickSkype,
            this.colTinhTrangQuanLy,
            this.colGhiChu});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "KhuVuc.TenKV", null, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsLayout.LayoutVersion = "0.0.1";
            this.gridView1.OptionsView.AutoCalcPreviewLineCount = true;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.PaintStyleName = "Skin";
            // 
            // colMaKH
            // 
            this.colMaKH.Caption = "Mã Khách Hàng";
            this.colMaKH.FieldName = "MaKH";
            this.colMaKH.Name = "colMaKH";
            this.colMaKH.OptionsColumn.AllowEdit = false;
            this.colMaKH.OptionsColumn.AllowMove = false;
            this.colMaKH.Visible = true;
            this.colMaKH.VisibleIndex = 0;
            this.colMaKH.Width = 58;
            // 
            // colTenKH
            // 
            this.colTenKH.Caption = "Tên Khách Hàng";
            this.colTenKH.FieldName = "TenKH";
            this.colTenKH.Name = "colTenKH";
            this.colTenKH.Visible = true;
            this.colTenKH.VisibleIndex = 1;
            this.colTenKH.Width = 89;
            // 
            // colLoaiKH
            // 
            this.colLoaiKH.Caption = "Tên Loại Khách Hàng";
            this.colLoaiKH.FieldName = "LoaiKH1.TenLoaiKH";
            this.colLoaiKH.Name = "colLoaiKH";
            this.colLoaiKH.Visible = true;
            this.colLoaiKH.VisibleIndex = 2;
            this.colLoaiKH.Width = 86;
            // 
            // colMaKhuVuc
            // 
            this.colMaKhuVuc.Caption = "Tên Khu Vực";
            this.colMaKhuVuc.FieldName = "KhuVuc.TenKV";
            this.colMaKhuVuc.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colMaKhuVuc.Name = "colMaKhuVuc";
            this.colMaKhuVuc.Visible = true;
            this.colMaKhuVuc.VisibleIndex = 3;
            this.colMaKhuVuc.Width = 106;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Caption = "Địa Chỉ";
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 4;
            this.colDiaChi.Width = 20;
            // 
            // colMST
            // 
            this.colMST.Caption = "Mã Số Thuế";
            this.colMST.FieldName = "MST";
            this.colMST.Name = "colMST";
            this.colMST.Visible = true;
            this.colMST.VisibleIndex = 5;
            this.colMST.Width = 20;
            // 
            // colDTBan
            // 
            this.colDTBan.Caption = "Điện Thoại Bàn";
            this.colDTBan.FieldName = "DTBan";
            this.colDTBan.Name = "colDTBan";
            this.colDTBan.Visible = true;
            this.colDTBan.VisibleIndex = 6;
            this.colDTBan.Width = 69;
            // 
            // colDTDD
            // 
            this.colDTDD.Caption = "Điện Thoại Di Động";
            this.colDTDD.FieldName = "DTDD";
            this.colDTDD.Name = "colDTDD";
            this.colDTDD.Visible = true;
            this.colDTDD.VisibleIndex = 7;
            this.colDTDD.Width = 69;
            // 
            // colFax
            // 
            this.colFax.Caption = "Fax";
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.Visible = true;
            this.colFax.VisibleIndex = 8;
            this.colFax.Width = 37;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 9;
            this.colEmail.Width = 60;
            // 
            // colWebsite
            // 
            this.colWebsite.Caption = "Website";
            this.colWebsite.FieldName = "Website";
            this.colWebsite.Name = "colWebsite";
            this.colWebsite.Visible = true;
            this.colWebsite.VisibleIndex = 10;
            this.colWebsite.Width = 125;
            // 
            // colSTK
            // 
            this.colSTK.Caption = "Số Tài Khoản";
            this.colSTK.FieldName = "STK";
            this.colSTK.Name = "colSTK";
            this.colSTK.Visible = true;
            this.colSTK.VisibleIndex = 11;
            this.colSTK.Width = 36;
            // 
            // colNganHang
            // 
            this.colNganHang.Caption = "Ngân Hàng";
            this.colNganHang.FieldName = "NganHang";
            this.colNganHang.Name = "colNganHang";
            this.colNganHang.Visible = true;
            this.colNganHang.VisibleIndex = 12;
            this.colNganHang.Width = 20;
            // 
            // colGioiHanNo
            // 
            this.colGioiHanNo.Caption = "Giới Hạn Nợ";
            this.colGioiHanNo.FieldName = "GioiHanNo";
            this.colGioiHanNo.Name = "colGioiHanNo";
            this.colGioiHanNo.Visible = true;
            this.colGioiHanNo.VisibleIndex = 13;
            this.colGioiHanNo.Width = 30;
            // 
            // colNoHienTai
            // 
            this.colNoHienTai.Caption = "Số Nợ Hiện Tại";
            this.colNoHienTai.FieldName = "NoHienTai";
            this.colNoHienTai.Name = "colNoHienTai";
            this.colNoHienTai.Visible = true;
            this.colNoHienTai.VisibleIndex = 14;
            this.colNoHienTai.Width = 35;
            // 
            // colChietKhau
            // 
            this.colChietKhau.Caption = "Chiết Khấu";
            this.colChietKhau.FieldName = "ChietKhau";
            this.colChietKhau.Name = "colChietKhau";
            this.colChietKhau.Visible = true;
            this.colChietKhau.VisibleIndex = 15;
            this.colChietKhau.Width = 59;
            // 
            // colNguoiLienHe
            // 
            this.colNguoiLienHe.Caption = "Người Liên Hệ";
            this.colNguoiLienHe.FieldName = "NguoiLienHe";
            this.colNguoiLienHe.Name = "colNguoiLienHe";
            this.colNguoiLienHe.Visible = true;
            this.colNguoiLienHe.VisibleIndex = 16;
            this.colNguoiLienHe.Width = 59;
            // 
            // colNickYM
            // 
            this.colNickYM.Caption = "Nick Yahoo";
            this.colNickYM.FieldName = "NickYM";
            this.colNickYM.Name = "colNickYM";
            this.colNickYM.Visible = true;
            this.colNickYM.VisibleIndex = 17;
            this.colNickYM.Width = 59;
            // 
            // colNickSkype
            // 
            this.colNickSkype.Caption = "Nick Skype";
            this.colNickSkype.FieldName = "NickSkype";
            this.colNickSkype.Name = "colNickSkype";
            this.colNickSkype.Visible = true;
            this.colNickSkype.VisibleIndex = 18;
            this.colNickSkype.Width = 59;
            // 
            // colTinhTrangQuanLy
            // 
            this.colTinhTrangQuanLy.Caption = "Tình Trạng Quản Lý";
            this.colTinhTrangQuanLy.FieldName = "TinhTrangQuanLy";
            this.colTinhTrangQuanLy.Name = "colTinhTrangQuanLy";
            this.colTinhTrangQuanLy.Visible = true;
            this.colTinhTrangQuanLy.VisibleIndex = 19;
            this.colTinhTrangQuanLy.Width = 59;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi Chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 20;
            this.colGhiChu.Width = 91;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // frm_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 515);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frm_KhachHang";
            this.Text = "frm_KhachHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource khachHangsBindingSource;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKH;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiKH;
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
        private DevExpress.XtraGrid.Columns.GridColumn colNickYM;
        private DevExpress.XtraGrid.Columns.GridColumn colNickSkype;
        private DevExpress.XtraGrid.Columns.GridColumn colTinhTrangQuanLy;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}