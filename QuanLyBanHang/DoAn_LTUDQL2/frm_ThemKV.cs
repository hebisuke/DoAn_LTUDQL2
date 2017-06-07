using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevExpress.XtraEditors;
using DevExpress.XtraBars.Helpers;

namespace DoAn_LTUDQL2
{
    public partial class frm_ThemKV : Form
    {
        QLBanHangEntities en = new QLBanHangEntities();
       
        public frm_ThemKV()
        {
            InitializeComponent();
        }
       
        private void btnThem_Click(object sender, EventArgs e)
        {
            KhuVuc kv = new KhuVuc();
            kv.MaKV = textBox1.Text;
            kv.TenKV = textBox2.Text;
            kv.GhiChu = richTextBox1.Text;
            en.KhuVucs.Add(kv);
            en.SaveChanges();
            
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            this.Close();
;        }
    }
}
