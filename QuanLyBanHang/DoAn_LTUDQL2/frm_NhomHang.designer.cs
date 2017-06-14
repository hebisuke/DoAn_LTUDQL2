namespace DoAn_LTUDQL2
{
    partial class frm_NhomHang
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
            this.nhomHangHoaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clMaNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clTenNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clTinhTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clHangHoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nhomHangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomHangHoaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomHangHoaBindingSource)).BeginInit();
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
            this.gridControl1.DataSource = this.nhomHangHoaBindingSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 45);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1188, 477);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // nhomHangHoaBindingSource1
            // 
            this.nhomHangHoaBindingSource1.DataSource = typeof(BUS.DTO.NhomHangHoa);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clMaNhom,
            this.clTenNhom,
            this.clGhiChu,
            this.clTinhTrang,
            this.clHangHoa});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // clMaNhom
            // 
            this.clMaNhom.Caption = "Mã Nhóm";
            this.clMaNhom.FieldName = "MaNhom";
            this.clMaNhom.Name = "clMaNhom";
            this.clMaNhom.Visible = true;
            this.clMaNhom.VisibleIndex = 0;
            // 
            // clTenNhom
            // 
            this.clTenNhom.Caption = "Tên Nhóm";
            this.clTenNhom.FieldName = "TenNhom";
            this.clTenNhom.Name = "clTenNhom";
            this.clTenNhom.Visible = true;
            this.clTenNhom.VisibleIndex = 1;
            // 
            // clGhiChu
            // 
            this.clGhiChu.Caption = "Ghi Chú";
            this.clGhiChu.FieldName = "GhiChu";
            this.clGhiChu.Name = "clGhiChu";
            this.clGhiChu.Visible = true;
            this.clGhiChu.VisibleIndex = 2;
            // 
            // clTinhTrang
            // 
            this.clTinhTrang.Caption = "Tinh Trạng Quản Lý";
            this.clTinhTrang.FieldName = "TinhTrangQL";
            this.clTinhTrang.Name = "clTinhTrang";
            this.clTinhTrang.Visible = true;
            this.clTinhTrang.VisibleIndex = 3;
            // 
            // clHangHoa
            // 
            this.clHangHoa.Caption = "Hàng Hóa";
            this.clHangHoa.FieldName = "HangHoas";
            this.clHangHoa.Name = "clHangHoa";
            this.clHangHoa.Visible = true;
            this.clHangHoa.VisibleIndex = 4;
            // 
            // nhomHangHoaBindingSource
            // 
            this.nhomHangHoaBindingSource.DataSource = typeof(BUS.DTO.NhomHangHoa);
            // 
            // frm_NhomHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 524);
            this.Controls.Add(this.groupControl1);
            this.Name = "frm_NhomHang";
            this.Text = "frm_NhomHang";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomHangHoaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomHangHoaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource nhomHangHoaBindingSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn clMaNhom;
        private DevExpress.XtraGrid.Columns.GridColumn clTenNhom;
        private DevExpress.XtraGrid.Columns.GridColumn clGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn clTinhTrang;
        private DevExpress.XtraGrid.Columns.GridColumn clHangHoa;
        private System.Windows.Forms.BindingSource nhomHangHoaBindingSource;
    }
}