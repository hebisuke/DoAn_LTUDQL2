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
    public partial class frm_HangHoa : DevExpress.XtraEditors.XtraForm
    {
        QLBanHangEntities en = new QLBanHangEntities();
        public frm_HangHoa()
        {
            InitializeComponent();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frm_HangHoa_Load(object sender, EventArgs e)
        {
            gridControl1_HH.DataSource = HangHoaBUS.DSHangHoa();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_ThemHangHoa kv = new frm_ThemHangHoa(); kv.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_SuaHangHoa kv = new frm_SuaHangHoa(); kv.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_XoaHangHoa kv = new frm_XoaHangHoa(); kv.Show();
        }
        void load()
        {
            gridControl1_HH.RefreshDataSource();
            List<HangHoa> kh = new List<HangHoa>();

            kh = en.HangHoa.ToList();
            gridControl1_HH.DataSource = kh;

        }
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            load();
        }
    }
}