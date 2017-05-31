using System;
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

        //------------- Hàm kiểm tra form đã mở chưa, nếu mở thì k mởi nữa, nếu chưa thì mở lên-------


    }
}
