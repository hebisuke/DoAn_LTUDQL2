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
    public partial class frm_SuaNPP : Form
    {
        QLBanHangEntities en = new QLBanHangEntities();
        public frm_SuaNPP()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string ma = comboBox1.Text;
            NhaPhanPhoi npp = en.NhaPhanPhoi.FirstOrDefault(x => x.MaNPP == ma);

            if (npp != null)
            {
                npp.MaNPP = textBox1.Text;
                npp.TenNPP = textBox2.Text;
                npp.MaKhuVuc = textBox3.Text;
                npp.DiaChi = textBox4.Text;
                npp.MST = textBox5.Text;
                npp.DTBan = textBox6.Text;
                npp.DTDD = textBox7.Text;
                npp.Fax = textBox8.Text;
                npp.Email = textBox9.Text;
                npp.Website = textBox10.Text;
                npp.STK = textBox11.Text;
                npp.NganHang = textBox12.Text;
                npp.GioiHanNo = textBox13.Text;
                npp.NoHienTai = textBox14.Text;
                npp.ChietKhau = int.Parse(textBox15.Text);
                npp.NguoiLienHe = textBox16.Text;
                npp.ChucVu = textBox17.Text;
                npp.TinhTrangQuanLy = int.Parse(textBox18.Text);
                npp.GhiChu = textBox19.Text;
                en.SaveChanges();
                MessageBox.Show("Thanh Cong");
                this.Close();

            }                     
        }
        void load()
        {
            List<NhaPhanPhoi> npp = new List<NhaPhanPhoi>(); npp = en.NhaPhanPhoi.ToList();
            comboBox1.DataSource = npp;
            comboBox1.ValueMember = "MaNPP";
            comboBox1.DisplayMember = "MaNPP";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;
            string ma = comboBox1.SelectedValue.ToString();

            NhaPhanPhoi npp = en.NhaPhanPhoi.FirstOrDefault(x => x.MaNPP == ma.ToString());
            if (npp != null)
            {
                textBox1.Text = npp.MaNPP;
                textBox2.Text = npp.TenNPP;
                textBox3.Text = npp.MaKhuVuc;
                textBox4.Text = npp.DiaChi;
                textBox5.Text = npp.MST;
                textBox6.Text = npp.DTBan;
                textBox7.Text = npp.DTDD;
                textBox8.Text = npp.Fax;
                textBox9.Text = npp.Email;
                textBox10.Text = npp.Website;
                textBox11.Text = npp.STK;
                textBox12.Text = npp.NganHang;
                textBox13.Text = npp.GioiHanNo;
                textBox14.Text = npp.NoHienTai;
                textBox15.Text = npp.ChietKhau.ToString();
                textBox16.Text = npp.NguoiLienHe;
                textBox17.Text = npp.ChucVu;
                textBox18.Text = npp.TinhTrangQuanLy.ToString();
                textBox19.Text = npp.GhiChu;
            }
        }

        private void frm_SuaNPP_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
