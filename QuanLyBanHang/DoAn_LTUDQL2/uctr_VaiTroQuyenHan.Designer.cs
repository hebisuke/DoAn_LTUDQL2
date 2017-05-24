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
            this.btn_ThemTKND = new DevExpress.XtraEditors.SimpleButton();
            this.Sửa = new DevExpress.XtraEditors.SimpleButton();
            this.Xoá = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.treeList2 = new DevExpress.XtraTreeList.TreeList();
            this.dgv_QuyenHan = new System.Windows.Forms.DataGridView();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QuyenHan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
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
            // btn_ThemTKND
            // 
            this.btn_ThemTKND.ImageUri.Uri = "Add";
            this.btn_ThemTKND.Location = new System.Drawing.Point(123, 8);
            this.btn_ThemTKND.Name = "btn_ThemTKND";
            this.btn_ThemTKND.Size = new System.Drawing.Size(138, 39);
            this.btn_ThemTKND.TabIndex = 1;
            this.btn_ThemTKND.Text = "Thêm người dùng";
            this.btn_ThemTKND.Click += new System.EventHandler(this.btn_ThemTKND_Click);
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
            this.groupBox1.Controls.Add(this.btn_ThemTKND);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(852, 50);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // treeList2
            // 
            this.treeList2.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeList2.Location = new System.Drawing.Point(0, 50);
            this.treeList2.Name = "treeList2";
            this.treeList2.Size = new System.Drawing.Size(190, 430);
            this.treeList2.TabIndex = 9;
            // 
            // dgv_QuyenHan
            // 
            this.dgv_QuyenHan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_QuyenHan.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_QuyenHan.Location = new System.Drawing.Point(190, 50);
            this.dgv_QuyenHan.Name = "dgv_QuyenHan";
            this.dgv_QuyenHan.Size = new System.Drawing.Size(662, 231);
            this.dgv_QuyenHan.TabIndex = 10;
            this.dgv_QuyenHan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_QuyenHan_CellContentClick);
            // 
            // treeList1
            // 
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.treeList1.Location = new System.Drawing.Point(190, 279);
            this.treeList1.Name = "treeList1";
            this.treeList1.Size = new System.Drawing.Size(662, 201);
            this.treeList1.TabIndex = 11;
            // 
            // uctr_VaiTroQuyenHan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.dgv_QuyenHan);
            this.Controls.Add(this.treeList2);
            this.Controls.Add(this.groupBox1);
            this.Name = "uctr_VaiTroQuyenHan";
            this.Size = new System.Drawing.Size(852, 480);
            this.Load += new System.EventHandler(this.uctr_VaiTroQuyenHan_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QuyenHan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btn_ThemTKND;
        private DevExpress.XtraEditors.SimpleButton Sửa;
        private DevExpress.XtraEditors.SimpleButton Xoá;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraTreeList.TreeList treeList2;
        private System.Windows.Forms.DataGridView dgv_QuyenHan;
        private DevExpress.XtraTreeList.TreeList treeList1;
    }
}
