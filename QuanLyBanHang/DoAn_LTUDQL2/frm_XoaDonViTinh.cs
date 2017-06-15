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
    public partial class frm_XoaDonViTinh : DevExpress.XtraEditors.XtraForm
    {
        QLBanHangEntities en = new QLBanHangEntities();
        public frm_XoaDonViTinh()
        {
            InitializeComponent();
        }
        void HienThi()
        {
            List<DonViTinh> kh = en.DonViTinh.ToList();

            listBox1.DataSource = kh;
            listBox1.ValueMember = "MaDV";
            listBox1.DisplayMember = "MaDV";
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if ((listBox1.SelectedItem == null)) return;
            string ma = listBox1.SelectedValue.ToString();
            DonViTinh kh = en.DonViTinh.FirstOrDefault(x => x.MaDV == ma);
            if (kh != null)
            {


                en.DonViTinh.Remove(kh);
                en.SaveChanges();
            }
            HienThi();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_XoaDonViTinh_Load(object sender, EventArgs e)
        {
            HienThi();
        }
    }
}