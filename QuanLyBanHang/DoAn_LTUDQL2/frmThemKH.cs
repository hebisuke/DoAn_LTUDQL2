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
    public partial class frmThemKH : Form
    {
        QLBanHangEntities en = new QLBanHangEntities();
        public static int a;
        public frmThemKH()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbKV_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        void KhuVucCB()
        {

            List<KhuVuc> kv = en.KhuVucs.ToList();
            cbKV.Items.Clear();
            foreach (KhuVuc a in kv)
            {
                cbKV.Items.Add(a.MaKV);
            }
        }

        private void frmThemKH_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            this.groupBox1.BackColor = Color.LightGray;
            this.panel1.BackColor = Color.LightGray;
            this.label1.BackColor = Color.LightGray;
            KhuVucCB();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHang kh = new KhachHang();
                kh.MaKH = txtMa.Text;
                kh.MaKhuVuc = cbKV.Text;
                kh.TenKH = txtTen.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.MST = txtMaSoThue.Text;
                kh.Fax = txtFax.Text;
                kh.DTBan = txtPhone.Text;
                kh.DTDD = txtMobile.Text;
                kh.Email = txtEmail.Text;
                kh.Website = txtWebSite.Text;
                kh.STK = txtTK.Text;
                kh.NganHang = txtNganHang.Text;
                kh.GioiHanNo = txtGioiHanNo.Text;
                kh.NoHienTai = txtNoHienTai.Text;
                kh.ChietKhau = int.Parse(txtChietKhau.Text);
                kh.NickYM = txtYahoo.Text;
                kh.NguoiLienHe = txtNguoiLienHe.Text;
                kh.NickSkype = txtSkyper.Text;
                if (chkQL.Checked)
                {
                    kh.TinhTrangQuanLy = 1;
                }
                else
                {
                    kh.TinhTrangQuanLy = 0;
                }
                if (rdDL.Checked)
                {
                    kh.LoaiKH = 1;
                }
                if (rdKL.Checked) { kh.LoaiKH = 2; }
                en.KhachHangs.Add(kh);
                en.SaveChanges();
                MessageBox.Show("Lưu Thành Công ^^ ");               
                this.Close();
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
       
        
    }
}
