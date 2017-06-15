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
    public partial class frm_NhomHang : DevExpress.XtraEditors.XtraForm
    {
        QLBanHangEntities en = new QLBanHangEntities();
        public frm_NhomHang()
        {
            InitializeComponent();
        }

        private void frm_NhomHang_Load(object sender, EventArgs e)
        {
            gridControl1_NH.DataSource = NhomHangBUS.DSNhomHangHoa();
        }

        private void gridControl1_NH_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_ThemNhomHang kv = new frm_ThemNhomHang (); kv.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_SuaNhomHang kv = new frm_SuaNhomHang(); kv.Show();
        }
        void load()
        {
            gridControl1_NH.RefreshDataSource();
            List<NhomHangHoa> kh = new List<NhomHangHoa>();
            kh = en.NhomHangHoa.ToList();
            gridControl1_NH.DataSource = kh;

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem4_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_XoaNhomHang kv = new frm_XoaNhomHang(); kv.Show();
        }
    }
}