using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_LTUDQL2
{
    public partial class frm_SuaKV : Form
    {
        QLBanHangEntities en = new QLBanHangEntities();
        public frm_SuaKV()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_SuaKV_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        void HienThi()
        {
            List<KhuVuc> dsKV = en.KhuVucs.ToList();
            listView1.Items.Clear();
            dsKV.ForEach(x =>
            {
                ListViewItem lvi = new ListViewItem(x.MaKV);
                lvi.SubItems.Add(x.TenKV);
                lvi.SubItems.Add(x.GhiChu);
                listView1.Items.Add(lvi);
            });

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            ListViewItem lvi = listView1.SelectedItems[0];
            int ma = int.Parse(lvi.SubItems[0].Text);
            KhuVuc kv = en.KhuVucs.FirstOrDefault(x =>x.MaKV== ma.ToString());
            if (kv != null)
            {
                textBox1.Text = kv.MaKV;
                textBox2.Text = kv.TenKV;
                richTextBox1.Text = kv.GhiChu;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(textBox1.Text);
            KhuVuc kv=en.KhuVucs.FirstOrDefault(x =>x.MaKV== ma.ToString());
            if (kv != null)
            {
                kv.TenKV = textBox2.Text;
                kv.GhiChu = richTextBox1.Text;
                en.SaveChanges();
            }
        }
    }
}
