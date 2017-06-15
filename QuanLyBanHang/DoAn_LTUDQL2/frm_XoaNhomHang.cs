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
    public partial class frm_XoaNhomHang : DevExpress.XtraEditors.XtraForm
    {
        QLBanHangEntities en = new QLBanHangEntities();
        public frm_XoaNhomHang()
        {
            InitializeComponent();
        }
        void HienThi()
        {
            List<NhomHangHoa> kh = en.NhomHangHoa.ToList();

            listBox1.DataSource = kh;
            listBox1.ValueMember = "MaNhom";
            listBox1.DisplayMember = "MaNhom";
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if ((listBox1.SelectedItem == null)) return;
            string ma = listBox1.SelectedValue.ToString();
            NhomHangHoa kh = en.NhomHangHoa.FirstOrDefault(x => x.MaNhom == ma);
            if (kh != null)
            {


                en.NhomHangHoa.Remove(kh);
                en.SaveChanges();
            }
            HienThi();
        }

        private void frm_XoaNhomHang_Load(object sender, EventArgs e)
        {
            HienThi();
        }
    }
}