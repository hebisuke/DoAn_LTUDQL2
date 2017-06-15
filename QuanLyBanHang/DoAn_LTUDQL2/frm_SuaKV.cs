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
    public partial class frm_SuaKV : DevExpress.XtraEditors.XtraForm
    {
        public frm_SuaKV()
        {
            InitializeComponent();
        }
        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(textEdit1.Text);
            KvBLL bll = new KvBLL();
            string ten=textEdit2.Text;
            string gichu = textBox1.Text;
            bool kq = bll.SuaKV(ma, ten,gichu );
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
        void HienThi()
        {
            KvBLL bll = new KvBLL();
            List<KhuVuc> kv = bll.HienThi();
            
            listView1.Items.Clear();
            kv.ForEach(x =>
            {
                ListViewItem lvi = new ListViewItem(x.MaKV);
                lvi.SubItems.Add(x.TenKV);
                lvi.SubItems.Add(x.GhiChu);
                listView1.Items.Add(lvi);
            });

        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_SuaKV_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            ListViewItem lvi = listView1.SelectedItems[0];
            int ma = int.Parse(lvi.SubItems[0].Text);
            KvBLL kvd = new KvBLL();
            KhuVuc kv = kvd.Tim(ma);
            if (kv != null)
            {
                textEdit1.Text = kv.MaKV;
                textEdit2.Text = kv.TenKV;
                textBox1.Text = kv.GhiChu;
            }

        }
    }
}