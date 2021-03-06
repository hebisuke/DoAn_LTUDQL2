﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;
using BUS.DTO;
using BUS.DAO;

namespace DoAn_LTUDQL2
{
    public partial class frm_NhanVien1 : DevExpress.XtraEditors.XtraForm
    {
        static QLBanHangEntities dbContext = new QLBanHangEntities();
        public frm_NhanVien1()
        {
            InitializeComponent();
            
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_ThemNV frmnhanvien = new frm_ThemNV();
            frmnhanvien.ShowDialog();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_NhanVien1_Load(sender, e);
        }

        private void frm_NhanVien1_Load(object sender, EventArgs e)
        {
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
           
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.NhanVien.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.NhanVien.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn xóa dòng này không ", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                
                string pName = gridView1.GetFocusedRowCellValue("MaNV").ToString();
                var nv = (from item in dbContext.NhanVien where item.MaNV == pName select item).FirstOrDefault();
                dbContext.NhanVien.Remove(nv);
                dbContext.SaveChanges();
                MessageBox.Show("Xóa Thành Công");
                frm_NhanVien1_Load(sender, e);
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
            
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string ma = gridView1.GetFocusedRowCellValue("MaNV").ToString();
            
            nvStatic = NhanVienDAO.get(ma);
            frm_SuaNV frm = new frm_SuaNV();
            frm.SuaNhanVien += Frm_SuaNhanVien;
            frm.ShowDialog();
        }

        private void Frm_SuaNhanVien(NhanVien nv)
        {
            if (NhanVienDAO.sua(nv) > 0)
            {
                XtraMessageBox.Show("sửa thành công");
            }
        }
        public static NhanVien nvStatic = null;
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string ma = gridView1.GetRowCellValue(e.RowHandle, "MaNV").ToString();
            nvStatic = NhanVienDAO.get(ma);
        }
    }
}