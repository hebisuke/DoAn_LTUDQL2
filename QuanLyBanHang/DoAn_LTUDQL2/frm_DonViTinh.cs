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
using System.IO;
using BUS.DTO;
using BUS.BUS;


namespace DoAn_LTUDQL2
{
    public partial class frm_DonViTinh : DevExpress.XtraEditors.XtraForm
    {
        QLBanHangEntities en = new QLBanHangEntities();
        public frm_DonViTinh()
        {
            InitializeComponent();
        }

        private void frm_DonViTinh_Load(object sender, EventArgs e)
        {
            gridControl1_DVT.DataSource = DonViTinhBUS.DSDonViTinh();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_ThemDVT kv = new frm_ThemDVT(); kv.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_SuaDVT kv = new frm_SuaDVT(); kv.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_XoaDonViTinh kv = new frm_XoaDonViTinh(); kv.Show();
        }
        void load()
        {
            gridControl1_DVT.RefreshDataSource();
            List<DonViTinh> kh = new List<DonViTinh>();

            kh = en.DonViTinh.ToList();
            gridControl1_DVT.DataSource = kh;

        }
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load();
        }
    }
}