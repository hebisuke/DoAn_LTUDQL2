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
            var frmDoiMatKhau = new frm_DoiMK();
            if (ExistForm(frmDoiMatKhau)) return;
            frmDoiMatKhau.Show();
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

        //------------- Hàm kiểm tra form đã mở chưa, nếu mở thì k mởi nữa, nếu chưa thì mở lên-------


    }
}
