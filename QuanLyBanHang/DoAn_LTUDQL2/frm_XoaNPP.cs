using DoAn_LTUDQL2.DTO;
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
    public partial class frm_XoaNPP : Form
    {
        QLBanHangEntities en = new QLBanHangEntities();
        public frm_XoaNPP()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void HienThi()
        {
            List<NhaPhanPhoi> npp = en.NhaPhanPhois.ToList();
            listBox1.DataSource = npp;
            listBox1.ValueMember = "MaNPP";
            listBox1.DisplayMember = "MaNPP";

        }
        private void frm_XoaNPP_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((listBox1.SelectedItem == null)) return;
            string ma = listBox1.SelectedValue.ToString();
            NhaPhanPhoi npp = en.NhaPhanPhois.FirstOrDefault(x => x.MaNPP == ma);
            if (npp != null)
            {
                if (npp.HangHoas.Count>0 || npp.MuaHangs.Count>0)
                {
                    MessageBox.Show("Không thể xóa vì nó có dữ liệu con");
                    return;
                }
                en.NhaPhanPhois.Remove(npp);
                en.SaveChanges();
            }
            HienThi();
        }
    }
}
