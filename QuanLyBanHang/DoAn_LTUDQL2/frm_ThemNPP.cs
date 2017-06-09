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
    public partial class frm_ThemNPP : Form
    {
        QLBanHangEntities en = new QLBanHangEntities();
        public frm_ThemNPP()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                NhaPhanPhoi npp = new NhaPhanPhoi();
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
                en.NhaPhanPhois.Add(npp);
                en.SaveChanges();
                MessageBox.Show("save Thanh cong");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
