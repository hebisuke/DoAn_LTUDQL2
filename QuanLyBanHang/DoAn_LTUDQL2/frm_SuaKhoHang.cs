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
    public partial class frm_SuaKhoHang : DevExpress.XtraEditors.XtraForm
    {

        QLBanHangEntities en = new QLBanHangEntities();
        public static int a;
        public frm_SuaKhoHang()
        {
            InitializeComponent();
        }
        private void simpleButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;
            string ma = comboBox1.SelectedValue.ToString();

            KhoHang kh1 = en.KhoHang.FirstOrDefault(x => x.MaKho == ma.ToString());
            if (kh1 != null)
            {
                txtMaKho.Text = kh1.MaKho;
                txtNgQuanLy.Text = kh1.NguoiQuanLy;
                txtTenKho.Text = kh1.TenKho;
                txtDiaChi1.Text = kh1.DiaChi;
                txtFax1.Text = kh1.Fax;
                txtDTB.Text = kh1.DTBan;
                txtSDT.Text = kh1.DTDD;
                txtEmail1.Text = kh1.Email;
                txtDienGiai1.Text = kh1.DienGiai;
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
           
            string ma = comboBox1.Text.ToString();
            KhoHang kh = en.KhoHang.FirstOrDefault(x => x.MaKho == ma.ToString());
            if (kh != null)
            {

                kh.MaKho = txtMaKho.Text;
                kh.NguoiQuanLy = txtNgQuanLy.Text;
                kh.TenKho = txtTenKho.Text;
                txtDiaChi1.Text = kh.DiaChi;
                kh.Fax  = txtFax1.Text;
                kh.DTBan = txtDTB.Text;
                kh.DTDD = txtSDT.Text ;
                kh.Email = txtEmail1.Text ;
                kh.DienGiai = txtDienGiai1.Text ;

                en.SaveChanges();
                MessageBox.Show("thanh cong");
            }

            this.Close();
        
    }
        void QuanLy()
        {

            List<NhanVien> kv = en.NhanVien.ToList();
            txtNgQuanLy.Items.Clear();
            foreach (NhanVien a in kv)
            {
                txtNgQuanLy.Items.Add(a.TenNV);
            }
        }

        void loading()
        {
            List<KhoHang> kh = new List<KhoHang>(); kh = en.KhoHang.ToList();
            comboBox1.DataSource = kh;
            comboBox1.ValueMember = "MaKho";
            comboBox1.DisplayMember = "MaKho";
        }
        private void frm_SuaKhoHang_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            loading();
            QuanLy();
        }
        
    }
}