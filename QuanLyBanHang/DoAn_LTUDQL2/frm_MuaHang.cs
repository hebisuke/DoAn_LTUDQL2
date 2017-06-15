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
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraExport.Helpers;
using BUS.DTO;
using BUS.BUS;

namespace DoAn_LTUDQL2
{
    public partial class frm_MuaHang : DevExpress.XtraEditors.XtraForm
    {
        QLBanHangEntities db = new QLBanHangEntities();
        public frm_MuaHang()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            
        }

        private void frm_MuaHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBanHangDataSet.KhuVuc' table. You can move, or remove it, as needed.
            //gridControl1.DataSource = (from item in db.KhuVucs select new { MaKV = item.MaKV, TenKV = item.TenKV, GhiChu = item.GhiChu }).ToList();
            //------------ load tên nhà cung cấp
            btn_TenNCC.Properties.DataSource = MuaHangBUS.LoadNhaPhanPhoi();
            btn_TenNCC.Properties.DisplayMember = "TenNPP";
            btn_TenNCC.Properties.ValueMember = "MaNPP";
            //------------load tên nhân viên--------------
            btn_NhanVien.Properties.DataSource = MuaHangBUS.LoadNhanVien();
            btn_NhanVien.Properties.DisplayMember = "TenNV";
            btn_NhanVien.Properties.ValueMember = "MaNV";

            //----------load kho hàng---------------------
            btn_TenKho.Properties.DataSource = MuaHangBUS.LoadKhoHang();
            btn_TenKho.Properties.DisplayMember = "TenKho";
            btn_TenKho.Properties.ValueMember = "MaKho";



            //var ds = from item in db.ChiTietMuaHangs where item.MaMuaHang == "1" select new { MaPhieuCT = item.MaPhieuCT, MaMuaHang = item.MaMuaHang, MaHang = item.MaMuaHang, TenHang = item.TenHang, Gia = item.Gia, SoLuong = item.SoLuong, TienThue = item.TienThue, ThanhToan = item.ThanhToan };
            //gridControl1.DataSource = ds.ToList();

            //  cùng fiedname  và valuemember okc

            gridControl1.DataSource = MuaHangBUS.LoadDS();
            //gridControl1.DataSource = null;
            //GridView view = new GridView(gridControl1);

            //view.OptionsView.ShowGroupPanel = false;

            //view.OptionsView.ShowColumnHeaders = false;

            //gridControl1.MainView = view;

            repositoryItemLookUpEdit1.DataSource = MuaHangBUS.LoadHangHoa();
            repositoryItemLookUpEdit1.DisplayMember = "MaHang";
            repositoryItemLookUpEdit1.ValueMember = "MaHang";
            repositoryItemLookUpEdit1.PopupWidth = 1000;
            repositoryItemLookUpEdit1.PopulateColumns();


            repositoryItemLookUpEdit2.DataSource = MuaHangBUS.LoadHangHoa();
            repositoryItemLookUpEdit2.DisplayMember = "TenHang";
            repositoryItemLookUpEdit2.ValueMember = "MaHang";
            repositoryItemLookUpEdit2.PopupWidth = 1000;
            repositoryItemLookUpEdit2.PopulateColumns();

            repositoryItemLookUpEdit3.DataSource = MuaHangBUS.LoadHangHoa();
            repositoryItemLookUpEdit3.DisplayMember = "TenDV";
            repositoryItemLookUpEdit3.ValueMember = "MaHang";
            repositoryItemLookUpEdit3.PopupWidth = 1000;
            repositoryItemLookUpEdit3.PopulateColumns();




            btn_TenNCC.Text = null;
            tbx_DiaChi.Text = null;
            tbx_SDT.Text = null;
            tbx_GhiChu.Text = null;
            tbx_SoHoaDonVAT.Text = null;
            tbx_SoPhieuVietTay.Text = null;
            btn_TenKho.Text = null;
            tbx_HanThanhToan.Text = null;
            cbx_DieuKhoanTT.Text = null;
            cbx_HTTToan.Text = null;
            btn_NhanVien.Text = null;
            for (int i = 0; i < gridView1.RowCount;)
                gridView1.DeleteRow(i);
            NhatKiHeThongBUS.ThemNhatKi("MuaHang", "Làm mới");

        }


        private void btn_TaoMoi_Click(object sender, EventArgs e)
        {

            frm_MuaHang_Load(sender, e);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            //Tạo đơn hàng mới
           // try
           // {
                MuaHang muahang = new MuaHang();
                if (btn_TenNCC.EditValue != null)
                {

                    muahang.MaNPP = btn_TenNCC.EditValue.ToString();
                }
                else { MessageBox.Show("Lưu không thành công"); return; }

                muahang.NgayLap = DateTime.Now;

                if (cbx_DieuKhoanTT.Text != null)
                {
                    muahang.DieuKhoanThanhToan = cbx_DieuKhoanTT.Text;
                }
                else { MessageBox.Show("Lưu không thành công"); return; }

                if (cbx_HTTToan.Text != null)
                {
                    muahang.HinhThucThanhToan = cbx_HTTToan.Text;
                }
                else { MessageBox.Show("Lưu không thành công"); return; }

                if (btn_NhanVien.EditValue != null)
                {
                    muahang.MaNV = btn_NhanVien.EditValue.ToString();
                }
                else { MessageBox.Show("Lưu không thành công"); return; }

                if (tbx_DiaChi.Text != null)
                {
                    muahang.DiaChi = tbx_DiaChi.Text;
                }
                else { MessageBox.Show("Lưu không thành công"); return; }

                if (tbx_SDT.Text != null)
                {
                    muahang.SoDienThoai = tbx_SDT.Text;
                }
                else { MessageBox.Show("Lưu không thành công"); return; }
                muahang.SoHoaDonVAT = tbx_SoHoaDonVAT.Text;
                muahang.SoPhieuVietTay = tbx_SoPhieuVietTay.Text;
                if (btn_TenKho.EditValue != null)
                {
                    muahang.MaNhapKho = btn_TenKho.EditValue.ToString();
                }
                if (DateTime.Compare(DateTime.Today, (DateTime)tbx_HanThanhToan.EditValue) <= 0)
                {
                    muahang.HanThanhToan = (DateTime)tbx_HanThanhToan.EditValue;
                }
            // Tạo chi tiết hàng mới tạm
            int tongtien = 0;
            var dsct = new Mua_BanTam();
          //  try
            //{
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    dsct.MaHang = gridView1.GetRowCellValue(i, "MaHang").ToString();
                    dsct.Gia = Convert.ToInt32(gridView1.GetRowCellValue(i, "Gia"));
                    dsct.SoLuong = Convert.ToInt32(gridView1.GetRowCellValue(i, "SoLuong"));
                    dsct.ThanhTien = Convert.ToInt32(gridView1.GetRowCellValue(i, "TongTien"));
                    db.Mua_BanTam.Add(dsct);
                    db.SaveChanges();
                tongtien = dsct.ThanhTien.Value + tongtien;

                }
           // }
            //catch(Exception ex)
            //{
            //    MessageBox.Show("Lưu Không thành công!!!");
            //    var tamp = (from item in db.Mua_BanTam select item );
            //    db.Mua_BanTam.RemoveRange(tamp);
            //}
            muahang.TongTien = tongtien.ToString();
            db.MuaHang.Add(muahang);
            db.SaveChanges();

            var ct = (from item in db.Mua_BanTam select item);
            var chitiet = new ChiTietMuaHang();
                foreach(var item in ct)
                {
                    chitiet.MaMuaHang = muahang.MaPhieuMuaHang;
                    chitiet.MaHang = item.MaHang;
                    chitiet.SoLuong = item.SoLuong;
                    chitiet.ThanhToan =  item.ThanhTien;
                    db.ChiTietMuaHang.Add(chitiet);
                    var hanghoa = db.HangHoa.Where(s => s.MaHang == item.MaHang).First();
                    hanghoa.TonKhoHienTai = hanghoa.TonKhoHienTai + item.SoLuong;
                    db.Mua_BanTam.Remove(item);
                   
            }
            db.SaveChanges();
           
            // }
            //     catch(Exception ex)
            //   {
            //     MessageBox.Show(ex.ToString());
            //}


            MessageBox.Show("save thành công!!");
            // hàm lấy mã phiếu mua hàng 
            var tam = (from item in db.Mua_BanTam select item);
            db.Mua_BanTam.RemoveRange(tam);
            btn_TaoMoi_Click(sender, e);
            gridControl1.Refresh();
           NhatKiHeThongBUS.ThemNhatKi("Mua Hàng", "Thêm Mua Hàng");
        }
        
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            

        }

        private void gridView1_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            int rowIndex = e.ListSourceRowIndex;

            decimal gia = Convert.ToDecimal(gridView1.GetListSourceRowCellValue(rowIndex, "Gia"));
            decimal soluong = Convert.ToDecimal(gridView1.GetListSourceRowCellValue(rowIndex, "SoLuong"));
            if (e.Column.FieldName != "TongTien") return;
            if (e.IsSetData)
                e.Value = gia * soluong;

            //---------
        }
    }
}