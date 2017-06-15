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
using BUS.BUS;
using BUS.DTO;
namespace DoAn_LTUDQL2
{
    public partial class frm_ThemKV : DevExpress.XtraEditors.XtraForm
    {
        public frm_ThemKV()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            KvBLL kvb = new KvBLL();
            KhuVuc kv = new KhuVuc();
            kv.MaKV = textEdit1.Text;
            kv.TenKV = textEdit2.Text;
            kv.GhiChu = textEdit3.Text;
            bool kq = kvb.ThemKV(kv.MaKV, kv.TenKV, kv.GhiChu);
            if (kq)
            {
                MessageBox.Show("Thanh Cong!");
            }
            else
            {
                MessageBox.Show("That Bai");
            }
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}