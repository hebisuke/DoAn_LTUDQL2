using DevExpress.SpreadsheetSource.Implementation;
using BUS;
using BUS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DoAn_LTUDQL2
{
    public partial class frm_ThongTin : DevExpress.XtraEditors.XtraForm
    {

        QLBanHangEntities ql = new QLBanHangEntities();
        public frm_ThongTin()
        {
            InitializeComponent();

        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {

            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(txt_Tendonvi.Text)|| string.IsNullOrEmpty(txt_DiaChi.Text) || string.IsNullOrEmpty(txtDienThoai.Text) || string.IsNullOrEmpty(txtdtdd.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtFax.Text) || string.IsNullOrEmpty(txtweb.Text) || string.IsNullOrEmpty(txtMaSoThue.Text) || string.IsNullOrEmpty(txtGPKD.Text))
                {
                    MessageBox.Show("Bạn chưa nhập dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                   
                }
                else
                {
                    this.Close();
                }
            }

        }

        public void LoadThongTin()
        {
            var tt = ThongTinBUS.LoadDanhSach();
            txt_Tendonvi.Text = tt.TenDonVi;
            txt_DiaChi.Text = tt.DiaCHi;
            txtDienThoai.Text = tt.DTBan;
            txtdtdd.Text = tt.DTDD;
            txtFax.Text = tt.Fax;
            txtweb.Text = tt.Website;
            txtEmail.Text = tt.Email;
            cbLinhVuc.Text = tt.LinhVuc;
            txtMaSoThue.Text = tt.MST;
            txtGPKD.Text = tt.GPKD;
        }
        public void Add()
        {
      
            using (var ql = new QLBanHangEntities())
            {
                ThongTinToChucCaNhan thongtintochuc = new ThongTinToChucCaNhan();
                thongtintochuc.Ma = 1;
                thongtintochuc.TenDonVi = txt_Tendonvi.Text;
                thongtintochuc.DiaCHi = txt_DiaChi.Text;
                thongtintochuc.DTBan = txtDienThoai.Text;
                thongtintochuc.DTDD = txtdtdd.Text;
                thongtintochuc.Fax = txtFax.Text;
                thongtintochuc.Website = txtweb.Text;
                thongtintochuc.Email = txtEmail.Text;
                thongtintochuc.LinhVuc = cbLinhVuc.Text;
                thongtintochuc.MST = txtMaSoThue.Text;
                thongtintochuc.GPKD = txtGPKD.Text;
                ql.ThongTinToChucCaNhan.Add(thongtintochuc);
                ql.SaveChanges();
            }
        }
        public void Sua()
        {
            var thongtintochuc = ql.ThongTinToChucCaNhan.FirstOrDefault();
            thongtintochuc.TenDonVi = txt_Tendonvi.Text;
            thongtintochuc.DiaCHi = txt_DiaChi.Text;
            thongtintochuc.DTBan = txtDienThoai.Text;
            thongtintochuc.DTDD = txtdtdd.Text;
            thongtintochuc.Fax = txtFax.Text;
            thongtintochuc.Website = txtweb.Text;
            thongtintochuc.Email = txtEmail.Text;
            thongtintochuc.LinhVuc = cbLinhVuc.Text;
            thongtintochuc.MST = txtMaSoThue.Text;
            thongtintochuc.GPKD = txtGPKD.Text;
            ql.SaveChanges();
        }

        private void frm_ThongTin_Load(object sender, EventArgs e)
        {
            var myQuery = from Q in ql.ThongTinToChucCaNhan select Q.Ma;
            if (myQuery != null && myQuery.Count() > 0)
            {
                LoadThongTin();
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            var myQuery = from Q in ql.ThongTinToChucCaNhan select Q.Ma;
            if (myQuery != null && myQuery.Count() > 0)
            {
                if (string.IsNullOrEmpty(txt_Tendonvi.Text) || string.IsNullOrEmpty(txt_DiaChi.Text) || string.IsNullOrEmpty(txtDienThoai.Text) || string.IsNullOrEmpty(txtdtdd.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtFax.Text) || string.IsNullOrEmpty(txtweb.Text) || string.IsNullOrEmpty(txtMaSoThue.Text) || string.IsNullOrEmpty(txtGPKD.Text))
                {
                    MessageBox.Show("Bạn chưa nhập dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Sua();
                    MessageBox.Show("Cập nhật thành công!");
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txt_Tendonvi.Text) || string.IsNullOrEmpty(txt_DiaChi.Text) || string.IsNullOrEmpty(txtDienThoai.Text) || string.IsNullOrEmpty(txtdtdd.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtFax.Text) || string.IsNullOrEmpty(txtweb.Text) || string.IsNullOrEmpty(txtMaSoThue.Text) || string.IsNullOrEmpty(txtGPKD.Text))
                {
                    MessageBox.Show("Bạn chưa nhập dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Add();
                    MessageBox.Show("Đăng ký thành công!");
                }
            }
        }
    }
}

  
  
