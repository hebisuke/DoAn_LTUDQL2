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
using DevExpress.XtraEditors;

namespace DoAn_LTUDQL2
{
    public partial class frm_ThemHangHoa : DevExpress.XtraEditors.XtraForm
    {
        QLBanHangEntities en = new QLBanHangEntities();
        public static int a;
        public frm_ThemHangHoa()
        {
            InitializeComponent();
        }
        void Kho()
        {

            List<KhoHang> kv = en.KhoHang.ToList();
            txtKhoMacDinh.Items.Clear();
            foreach (KhoHang a in kv)
            {
                txtKhoMacDinh.Items.Add(a.TenKho);
            }
        }
        void NhaCC()
        {

            List<NhaPhanPhoi> kv = en.NhaPhanPhoi.ToList();
            txtNhaCC.Items.Clear();
            foreach (NhaPhanPhoi a in kv)
            {
                txtNhaCC.Items.Add(a.MaNPP);
            }
        }
        void MaNHomHang()
        {

            List<NhomHangHoa> kv = en.NhomHangHoa.ToList();
            txtMaNhomHang.Items.Clear();
            foreach (NhomHangHoa a in kv)
            {
                txtMaNhomHang.Items.Add(a.MaNhom);
            }
        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try
            {
                HangHoa hh = new HangHoa();
                hh.MaHang = txtMaHang.Text;
                hh.TenHang = txtTenHang.Text;
                hh.MaDVT = txtDonVi.Text;
                hh.XuatXu = txtXuatXu.Text;
                hh.Thue = Convert.ToInt16(txtThue.Text);
                hh.ChietKhau = Convert.ToInt16(txtChietKhau.Text);
                hh.MaNCC = txtNhaCC.Text;
                hh.TonKhoHienTai = Convert.ToInt16(txtTonKhohienTai.Text);
                hh.TonKhoToiThieu = Convert.ToInt16(txtTonKhoToiThieu.Text);
                hh.GiaMua = Convert.ToInt16(txtGiaMua.Text);
                hh.GiaBanSi = Convert.ToInt16(txtGiaBanSi.Text);
                hh.GiaBanLe = Convert.ToInt16(txtGiaBanLe.Text);
                hh.MaKhoHang = txtKhoMacDinh.Text;
                hh.MaNhomHang = txtMaNhomHang.Text;
                hh.MaKhoHang = txtKhoMacDinh.Text;
                
                en.HangHoa.Add(hh);
                en.SaveChanges();
                MessageBox.Show("Lưu Thành Cônga");
                this.Close();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_ThemHangHoa_Load(object sender, EventArgs e)
        {
            Kho();
            NhaCC();
            MaNHomHang();


        }
    }
}