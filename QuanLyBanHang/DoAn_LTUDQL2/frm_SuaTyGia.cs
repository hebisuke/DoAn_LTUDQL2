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
using BUS.DTO;
namespace DoAn_LTUDQL2
{
    public partial class frm_SuaTyGia : DevExpress.XtraEditors.XtraForm
    {
        QLBanHangEntities en = new QLBanHangEntities();
        public frm_SuaTyGia()
        {
            InitializeComponent();
        }
        void load()
        {
            List<LoaiTien> kh = new List<LoaiTien>(); kh = en.LoaiTien.ToList();
            comboBox1.DataSource = kh;
            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "id";
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string ma = comboBox1.Text;
            LoaiTien lt = en.LoaiTien.FirstOrDefault(x => x.id.ToString() == ma);
            if (lt != null)
            {

                lt.id = Convert.ToInt16(txtMaTGia.Text);
                lt.TenLoaiTien = txtTenTGia.Text;
             
                en.SaveChanges();
                MessageBox.Show("thanh cong");
            }

            this.Close();
        }

        private void frm_SuaTyGia_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            load();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;
            string ma = comboBox1.Text;

            LoaiTien lt = en.LoaiTien.FirstOrDefault(x => x.id.ToString() == ma);
            if (lt != null)
            {
                txtMaTGia.Text = lt.id.ToString();
                txtTenTGia.Text = lt.TenLoaiTien;

            }
        }
    }
}
