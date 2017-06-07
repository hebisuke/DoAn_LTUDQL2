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
    public partial class frm_XoaKV : Form
    {
        QLBanHangEntities en = new QLBanHangEntities();
        public frm_XoaKV()
        {
            InitializeComponent();
        }
        void HienThi()
        {
            List<KhuVuc> kv = en.KhuVucs.ToList();
            
            listBox1.DataSource = kv;
            listBox1.ValueMember = "MaKV";
            listBox1.DisplayMember = "TenKV";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if ((listBox1.SelectedItem == null)) return;
            string ma = listBox1.SelectedValue.ToString();
            KhuVuc kv = en.KhuVucs.FirstOrDefault(x => x.MaKV == ma);
            if (kv != null)
            {
                if (kv.KhachHangs.Count > 0)
                {
                    MessageBox.Show("Không thể xóa vì nó có khách hàng");
                    return;
                }
                en.KhuVucs.Remove(kv);
                en.SaveChanges();
            }
            HienThi();


        }

        private void frm_XoaKV_Load(object sender, EventArgs e)
        {
            HienThi();
        }
    }
}
