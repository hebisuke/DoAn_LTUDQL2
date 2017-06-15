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
    public partial class frm_TyGia : DevExpress.XtraEditors.XtraForm
    {
        QLBanHangEntities en = new QLBanHangEntities();
        public frm_TyGia()
        {
            InitializeComponent();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frm_TyGia_Load(object sender, EventArgs e)
        {
            gridControl1_TG.DataSource = TyGiaBUS.DSLoaiTien();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_SuaTyGia kv = new frm_SuaTyGia(); kv.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_ThemTyGia kv = new frm_ThemTyGia(); kv.Show();
        }

        private void gridControl1_TG_Click(object sender, EventArgs e)
        {

        }
        void load()
        {
            gridControl1_TG.RefreshDataSource();
            List<LoaiTien> kh = new List<LoaiTien>();

            kh = en.LoaiTien.ToList();
            gridControl1_TG.DataSource = kh;

        }
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_XoaTyGia kv = new frm_XoaTyGia(); kv.Show();
        }
    }
}