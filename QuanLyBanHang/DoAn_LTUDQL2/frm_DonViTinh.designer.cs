namespace DoAn_LTUDQL2
{
    partial class frm_DonViTinh
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
            this.clMaDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clTenDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.donViTinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donViTinhBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.donViTinhBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.clGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clTinhTrangQL = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donViTinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donViTinhBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donViTinhBindingSource2)).BeginInit();
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
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Xuất ", null, "Replace"),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Đóng", null, "Cancel")});
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1192, 524);
            this.groupControl1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.donViTinhBindingSource2;
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
            this.clMaDVT,
            this.clTenDVT,
            this.clGhiChu,
            this.clTinhTrangQL});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // clMaDVT
            // 
            this.clMaDVT.Caption = "Mã";
            this.clMaDVT.FieldName = "MaDV";
            this.clMaDVT.Name = "clMaDVT";
            this.clMaDVT.Visible = true;
            this.clMaDVT.VisibleIndex = 0;
            // 
            // clTenDVT
            // 
            this.clTenDVT.Caption = "Tên";
            this.clTenDVT.FieldName = "TenDV";
            this.clTenDVT.Name = "clTenDVT";
            this.clTenDVT.Visible = true;
            this.clTenDVT.VisibleIndex = 1;
            // 
            // donViTinhBindingSource
            // 
            this.donViTinhBindingSource.DataSource = typeof(DoAn_LTUDQL2.DonViTinh);
            // 
            // donViTinhBindingSource1
            // 
            this.donViTinhBindingSource1.DataSource = typeof(DoAn_LTUDQL2.DonViTinh);
            // 
            // donViTinhBindingSource2
            // 
            this.donViTinhBindingSource2.DataSource = typeof(DoAn_LTUDQL2.DonViTinh);
            // 
            // clGhiChu
            // 
            this.clGhiChu.Caption = "Ghi Chú";
            this.clGhiChu.FieldName = "GhiChu";
            this.clGhiChu.Name = "clGhiChu";
            this.clGhiChu.Visible = true;
            this.clGhiChu.VisibleIndex = 2;
            // 
            // clTinhTrangQL
            // 
            this.clTinhTrangQL.Caption = "Tinh Trạng Quản Lý";
            this.clTinhTrangQL.FieldName = "TinhTrangQL";
            this.clTinhTrangQL.Name = "clTinhTrangQL";
            this.clTinhTrangQL.Visible = true;
            this.clTinhTrangQL.VisibleIndex = 3;
            // 
            // frm_DonViTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 524);
            this.Controls.Add(this.groupControl1);
            this.Name = "frm_DonViTinh";
            this.Text = "con";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donViTinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donViTinhBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donViTinhBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource donViTinhBindingSource2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn clMaDVT;
        private DevExpress.XtraGrid.Columns.GridColumn clTenDVT;
        private DevExpress.XtraGrid.Columns.GridColumn clGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn clTinhTrangQL;
        private System.Windows.Forms.BindingSource donViTinhBindingSource;
        private System.Windows.Forms.BindingSource donViTinhBindingSource1;
    }
}