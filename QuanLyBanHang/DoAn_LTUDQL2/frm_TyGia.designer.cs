namespace DoAn_LTUDQL2
{
    partial class frm_TyGia
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
            this.loaiTienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loaiTienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenLoaiTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThuTiens = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiTienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiTienBindingSource1)).BeginInit();
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
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Đóng", null, "Cancel")});
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1192, 524);
            this.groupControl1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.loaiTienBindingSource1;
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
            this.colid,
            this.colTenLoaiTien,
            this.colThuTiens});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // loaiTienBindingSource
            // 
            this.loaiTienBindingSource.DataSource = typeof(BUS.DTO.LoaiTien);
            // 
            // loaiTienBindingSource1
            // 
            this.loaiTienBindingSource1.DataSource = typeof(BUS.DTO.LoaiTien);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // colTenLoaiTien
            // 
            this.colTenLoaiTien.FieldName = "TenLoaiTien";
            this.colTenLoaiTien.Name = "colTenLoaiTien";
            this.colTenLoaiTien.Visible = true;
            this.colTenLoaiTien.VisibleIndex = 1;
            // 
            // colThuTiens
            // 
            this.colThuTiens.FieldName = "ThuTiens";
            this.colThuTiens.Name = "colThuTiens";
            this.colThuTiens.Visible = true;
            this.colThuTiens.VisibleIndex = 2;
            // 
            // frm_TyGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 524);
            this.Controls.Add(this.groupControl1);
            this.Name = "frm_TyGia";
            this.Text = "frm_TyGia";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiTienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiTienBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource loaiTienBindingSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colTenLoaiTien;
        private DevExpress.XtraGrid.Columns.GridColumn colThuTiens;
        private System.Windows.Forms.BindingSource loaiTienBindingSource;
    }
}