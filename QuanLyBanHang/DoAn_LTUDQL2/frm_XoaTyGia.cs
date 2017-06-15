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
    public partial class frm_XoaTyGia : DevExpress.XtraEditors.XtraForm
    {
        QLBanHangEntities en = new QLBanHangEntities();
        public frm_XoaTyGia()
        {
            InitializeComponent();
        }
        void HienThi()
        {
            List<KhachHang> kh = en.KhachHang.ToList();

            listBox1.DataSource = kh;
            listBox1.ValueMember = "id";
            listBox1.DisplayMember = "id";
        }
        private void frm_XoaTyGia_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if ((listBox1.SelectedItem == null)) return;
            string ma = listBox1.SelectedValue.ToString();
            LoaiTien lt = en.LoaiTien.FirstOrDefault(x => x.id.ToString() == ma);
            if (lt != null)
            {
                en.LoaiTien.Remove(lt);
                en.SaveChanges();
            }
            HienThi();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}