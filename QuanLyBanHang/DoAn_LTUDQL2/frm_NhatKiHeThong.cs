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

namespace DoAn_LTUDQL2
{
    public partial class frm_NhatKiHeThong : DevExpress.XtraEditors.XtraForm
    {
        public frm_NhatKiHeThong()
        {
            InitializeComponent();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frm_NhatKiHeThong_Load(object sender, EventArgs e)
        {
            gridControl_DSNhatKy.DataSource = NhatKiHeThongBUS.DSNhatKyHeThong();
        }
    }
}