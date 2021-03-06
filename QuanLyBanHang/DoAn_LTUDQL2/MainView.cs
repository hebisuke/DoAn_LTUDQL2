﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Helpers;
using BUS;

namespace DoAn_LTUDQL2
{
    public partial class MainView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        
        public MainView()
        {
            Thread t = new Thread(new ThreadStart(SplashScreen));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
            if (!mvvmContext1.IsDesignMode)
                InitializeBindings();
        }
        private void SplashScreen()
        {
            Application.Run(new SplashScreen1());
        }

        void InitializeBindings()
        {
            var fluent = mvvmContext1.OfType<MainViewModel>();
        }
        private bool ExistForm(XtraForm form)
        {
            foreach(var child in MdiChildren)
            {
                if(child.Name== form.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }
        private void btn_KhuVuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmKhuVuc = new frm_KhuVuc();
            if (ExistForm(frmKhuVuc)) return;
            frmKhuVuc.MdiParent = this;
            frmKhuVuc.Show();
        }

        private void btn_KhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmkhachhang = new frm_KhachHang();
            if (ExistForm(frmkhachhang)) return;
            frmkhachhang.MdiParent = this;
            frmkhachhang.Show();
        }

        private void btn_DoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm_DoiMK = new frm_DoiMK();
            if (ExistForm(frm_DoiMK)) return;
            frm_DoiMK.ShowDialog();
        }

        private void btn_ThongTin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmThongTin = new frm_ThongTin();
            if (ExistForm(frmThongTin)) return;
            frmThongTin.Show();
        }

        private void btn_SaoLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmSaoLuu = new frm_SaoLuu();
            if (ExistForm(frmSaoLuu)) return;
            frmSaoLuu.ShowDialog();
        }

        private void btn_PhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmPhucHoi = new frm_PhucHoi();
            if (ExistForm(frmPhucHoi)) return;
            frmPhucHoi.ShowDialog();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            SkinHelper.InitSkinPopupMenu(SkinsLink);
            
        }

        private void btn_MuaHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmMuaHang = new frm_MuaHang();
            if (ExistForm(frmMuaHang)) return;
            frmMuaHang.MdiParent = this;
            frmMuaHang.Show();
        }

        private void btn_BanHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmBanHang = new frm_BanHang();
            if (ExistForm(frmBanHang)) return;
            frmBanHang.MdiParent = this;
            frmBanHang.Show();
        }

        private void btn_TonKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmTonKho = new frm_TonKho();
            if (ExistForm(frmTonKho)) return;
            frmTonKho.MdiParent = this;
            frmTonKho.Show();
        }

        private void btn_ChuyenKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmChuyenKho = new frm_ChuyenKho();
            if (ExistForm(frmChuyenKho)) return;
            frmChuyenKho.MdiParent = this;
            frmChuyenKho.Show();
        }

        private void btn_VaiTroQuyenHan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm_VaiTro = new frm_VaiTro();
            if (ExistForm(frm_VaiTro)) return;
            frm_VaiTro.MdiParent = this;
            frm_VaiTro.Show();
        }

        private void btn_NhatKyHeThong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm_NhatKiHeThong = new frm_NhatKiHeThong();
            if (ExistForm(frm_NhatKiHeThong)) return;
            frm_NhatKiHeThong.MdiParent = this;
            frm_NhatKiHeThong.Show();
        }

        private void btn_BoPhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_BoPhan frm_BoPhan = new frm_BoPhan();
            if (ExistForm(frm_BoPhan)) return;
            frm_BoPhan.MdiParent = this;
            frm_BoPhan.Show();
        }

        private void btn_NhanVien_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_NhanVien1 frm_NV = new frm_NhanVien1();
            if (ExistForm(frm_NV)) return;
            frm_NV.MdiParent = this;
            frm_NV.Show();
        }

        private void btn_KhoHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm_KhoHang = new frm_KhoHang();
            if (ExistForm(frm_KhoHang)) return;
            frm_KhoHang.MdiParent = this;
            frm_KhoHang.Show();
        }

        private void btn_DonViTinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm_DonViTinh = new frm_DonViTinh();
            if (ExistForm(frm_DonViTinh)) return;
            frm_DonViTinh.MdiParent = this;
            frm_DonViTinh.Show();
        }

        private void btn_NhomHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm_NhomHang = new frm_NhomHang();
            if (ExistForm(frm_NhomHang)) return;
            frm_NhomHang.MdiParent = this;
            frm_NhomHang.Show();
        }

        private void btn_HangHoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm_HangHoa = new frm_HangHoa();
            if (ExistForm(frm_HangHoa)) return;
            frm_HangHoa.MdiParent = this;
            frm_HangHoa.Show();
        }

        private void btn_InMaVach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm_InMaVach = new frm_InMaVach();
            if (ExistForm(frm_InMaVach)) return;
            frm_InMaVach.MdiParent = this;
            frm_InMaVach.Show();
        }

        private void btn_TyGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm_TyGia = new frm_TyGia();
            if (ExistForm(frm_TyGia)) return;
            frm_TyGia.MdiParent = this;
            frm_TyGia.Show();
        }

        private void btn_NhaPhanPhoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm_NhaPhanPhoi = new frm_NhaPhanPhoi();
            if (ExistForm(frm_NhaPhanPhoi)) return;
            frm_NhaPhanPhoi.MdiParent = this;
            frm_NhaPhanPhoi.Show();
        }

        private void btn_KetThuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void btn_HoTro_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Program Files (x86)\\TeamViewer\\TeamViewer.exe");
        }

        private void btn_ThongTinTroGiup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frm_ThongTinNhom();
            frm.ShowDialog();
        }

        private void btn_PhimHD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("http://perfect.com.vn/video-huong-dan-su-dung-phan-mem-quan-ly-ban-hang.html");
        }

        private void btn_HinhAnhHD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("http://perfect.com.vn/huong-dan-su-dung-phan-mem-quan-ly-ban-hang.html");
        }

        private void btn_CapNhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Chức năng này chưa được phát triển", "Thông báo", MessageBoxButtons.OK);

        }

        private void btn_LienHe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Chức năng này chưa được phát triển", "Thông báo", MessageBoxButtons.OK);
        }



        //------------- Hàm kiểm tra form đã mở chưa, nếu mở thì k mởi nữa, nếu chưa thì mở lên-------


    }
}
