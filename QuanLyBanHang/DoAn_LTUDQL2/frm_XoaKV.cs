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
    public partial class frm_XoaKV : DevExpress.XtraEditors.XtraForm
    {
        public frm_XoaKV()
        {
            InitializeComponent();
        }
        void HienThi()
        {
            KvBLL bll = new KvBLL();
            List<KhuVuc> kv = bll.HienThi();
            listBox1.DataSource = kv;
            listBox1.ValueMember = "MaKV";
            listBox1.DisplayMember = "TenKV";
        }

        private void frm_XoaKV_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if ((listBox1.SelectedItem == null)) return;
            string ma = listBox1.SelectedValue.ToString();
            KvBLL bll = new KvBLL();
            bool kq = bll.XoaKV(ma);
            if (kq)
            {
                MessageBox.Show("Thanh Cong!");
            }
            else
            {
                MessageBox.Show("That Bai");
            }
            
            HienThi();
        }

    }
}