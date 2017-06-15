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
    public partial class frm_ThemKhoHang : DevExpress.XtraEditors.XtraForm
    {
            QLBanHangEntities en = new QLBanHangEntities();
            public static int a;
        public frm_ThemKhoHang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
                    }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        void NguoiQuanLyCB()
        {

            List<NhanVien> kv = en.NhanVien.ToList();
            txtNguoiQuanLy.Items.Clear();
            foreach (NhanVien a in kv)
            {
                txtNguoiQuanLy.Items.Add(a.TenNV);
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                KhoHang kh = new KhoHang();
                kh.MaKho = txtMa.Text;
                kh.TenKho = txtTen.Text;
                kh.NguoiQuanLy = txtNguoiQuanLy.Text;
                kh.DiaChi = txtDiaChi.Text;
                kh.NguoiLienHe = txtNguoiLienHe.Text;
                kh.Fax = txtFax.Text;
                kh.DTBan = txtDienThoaiBan.Text;
                kh.DTDD = txtDienThoai.Text;
                kh.Email = txtEmail.Text;
                kh.DienGiai = txtDienGiai.Text;
               
                if (txtQuanLy.Checked)
                {
                    kh.TinhTrangQuanLy = 1;
                }
                else
                {
                    kh.TinhTrangQuanLy = 0;
                }
                en.KhoHang.Add(kh);
                en.SaveChanges();
                MessageBox.Show("Lưu Thành Công ^^ ");
                this.Close();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void frm_ThemKhoHang_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            NguoiQuanLyCB();
        }
    }
}