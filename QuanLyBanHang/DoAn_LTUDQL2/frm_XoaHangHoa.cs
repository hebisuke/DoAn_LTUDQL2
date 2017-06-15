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
    public partial class frm_XoaHangHoa : DevExpress.XtraEditors.XtraForm
    {
        QLBanHangEntities en = new QLBanHangEntities();
        public frm_XoaHangHoa()
        {
            InitializeComponent();
        }
        void HienThi()
        {
            List<HangHoa> kh = en.HangHoa.ToList();

            listBox1.DataSource = kh;
            listBox1.ValueMember = "MaHang";
            listBox1.DisplayMember = "MaHang";
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            if ((listBox1.SelectedItem == null)) return;
            string ma = listBox1.SelectedValue.ToString();
            HangHoa kh = en.HangHoa.FirstOrDefault(x => x.MaHang == ma);
            if (kh != null)
            {


                en.HangHoa.Remove(kh);
                en.SaveChanges();
            }
            HienThi();
        }

        private void frm_XoaHangHoa_Load(object sender, EventArgs e)
        {
            HienThi();
        }
    }
}