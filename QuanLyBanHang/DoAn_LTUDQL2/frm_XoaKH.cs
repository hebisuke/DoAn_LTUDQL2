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
    
    public partial class frm_XoaKH : Form
    {
        QLBanHangEntities en = new QLBanHangEntities();
        public frm_XoaKH()
        {
            InitializeComponent();
        }
        void HienThi()
        {
            List<KhachHang> kh = en.KhachHangs.ToList();

            listBox1.DataSource = kh;
            listBox1.ValueMember = "MaKH";
            listBox1.DisplayMember ="MaKH";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if ((listBox1.SelectedItem == null)) return;
            string ma = listBox1.SelectedValue.ToString();
            KhachHang kh = en.KhachHangs.FirstOrDefault(x => x.MaKH == ma);
            if (kh != null)
            {
               
                
                en.KhachHangs.Remove(kh);
                en.SaveChanges();
            }
            HienThi();
        }

        private void frm_XoaKH_Load(object sender, EventArgs e)
        {
            HienThi();
        }
    }
}
