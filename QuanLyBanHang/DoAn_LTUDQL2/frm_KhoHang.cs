using System;
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
using BUS;
using BUS.BUS;
using BUS.DTO;

namespace DoAn_LTUDQL2
{
    public partial class frm_KhoHang : DevExpress.XtraEditors.XtraForm
    {
        QLBanHangEntities en = new QLBanHangEntities();
        public frm_KhoHang()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_KhoHang_Load(object sender, EventArgs e)
        {
            gridControl1_DSKhoHang.DataSource = KhoHangBUS.DSKhoHang();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_ThemKhoHang kv = new frm_ThemKhoHang(); kv.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_XoaKhoHang kv = new frm_XoaKhoHang(); kv.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_SuaKhoHang kv = new frm_SuaKhoHang(); kv.Show();
        }
        void load()
        {
            gridControl1_DSKhoHang.RefreshDataSource();
            List<KhoHang> kh = new List<KhoHang>();
            kh = en.KhoHang.ToList();
            gridControl1_DSKhoHang.DataSource = kh;

        }
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load();
        }
    }
}