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
    public partial class frm_SuaKH : Form
    {
        QLBanHangEntities en = new QLBanHangEntities();
        public frm_SuaKH()
        {
            InitializeComponent();
        }

        private void frm_SuaKH_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            this.groupBox1.BackColor = Color.LightGray;
           
            this.label1.BackColor = Color.LightGray;
            load();
        }
        void load()
        {
            List<KhachHang> kh = new List<KhachHang>(); kh = en.KhachHang.ToList();
            comboBox1.DataSource = kh;
            comboBox1.ValueMember = "MaKH";
            comboBox1.DisplayMember = "MaKH";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;
            string ma = comboBox1.SelectedValue.ToString();
           
            KhachHang kh = en.KhachHang.FirstOrDefault(x => x.MaKH == ma.ToString());
            if (kh != null)
            {
                txtMa.Text = kh.MaKH;
                cbKV.Text=kh.MaKhuVuc;
                txtTen.Text = kh.TenKH;
                txtDiaChi.Text = kh.DiaChi;
                txtMaSoThue.Text=kh.MST;
                txtFax.Text=  kh.Fax;
                txtPhone.Text=kh.DTBan;
                txtMobile.Text=kh.DTDD;
                txtEmail.Text=kh.Email;
                txtWebSite.Text=kh.Website;
                txtTK.Text=kh.STK;
                txtNganHang.Text = kh.NganHang;
                txtGioiHanNo.Text=kh.GioiHanNo;
                txtNoHienTai.Text=kh.NoHienTai;
                txtChietKhau.Text= kh.ChietKhau.ToString();
                txtYahoo.Text = kh.NickYM;
                txtNguoiLienHe.Text=kh.NguoiLienHe;
                txtSkyper.Text = kh.NickSkype;
                if (kh.TinhTrangQuanLy == 1)
                {
                    chkQL.Checked = true;
                }
                else
                {
                    chkQL.Checked = false;
                }
                if (kh.LoaiKH == 1)
                {
                    rdDL.Checked = true;
                }
                if (kh.LoaiKH == 2) { rdKL.Checked = true; }
                else { rdKL.Checked = false; }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(comboBox1.Text);
            KhachHang kh = en.KhachHang.FirstOrDefault(x => x.MaKH == ma.ToString());
            if (kh != null)
            {
               
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
                en.SaveChanges();
                MessageBox.Show("thanh cong");
            }
            
            this.Close();
        }
    }
}
