using BUS.DTO;
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
    public partial class frm_XoaKhoHang : DevExpress.XtraEditors.XtraForm
    {
        QLBanHangEntities en = new QLBanHangEntities();
        public frm_XoaKhoHang()
        {
            InitializeComponent();
        }
        void HienThi()
        {
            List<KhoHang> kh = en.KhoHang.ToList();

            listBox1.DataSource = kh;
            listBox1.ValueMember = "MaKho";
            listBox1.DisplayMember = "MaKho";
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if((listBox1.SelectedItem == null)) return;
            string ma = listBox1.SelectedValue.ToString();
            KhoHang kh = en.KhoHang.FirstOrDefault(x => x.MaKho == ma);
            if (kh != null)
            {

                en.KhoHang.Remove(kh);
                en.SaveChanges();
            }
            HienThi();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_XoaKhoHang_Load(object sender, EventArgs e)
        {
            HienThi();
        }
    }
}