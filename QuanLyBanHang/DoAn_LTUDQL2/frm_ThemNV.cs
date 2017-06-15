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
    public partial class frm_ThemNV : DevExpress.XtraEditors.XtraForm
    {
        static QLBanHangEntities ql = new QLBanHangEntities();
        public frm_ThemNV()
        {
            InitializeComponent();
        }

        private void frm_ThemNV_Load(object sender, EventArgs e)
        {
            lkBoPhan.Properties.DataSource = (from item in ql.BoPhan select new { mabophan = item.MaBo, tenbophan = item.TenBo }).ToList();
            lkBoPhan.Properties.DisplayMember = "tenbophan";
            lkBoPhan.Properties.ValueMember = "mabophan";

            lkQuanLy.Properties.DataSource = (from item in ql.NhanVien select new { manhanvien = item.MaNV, tennhanvien = item.TenNV }).ToList();
            lkQuanLy.Properties.DisplayMember = "tennhanvien";
            lkQuanLy.Properties.ValueMember = "manhanvien";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            if (txtMaNV.Text != null)
                nv.MaNV = txtMaNV.Text;
            else MessageBox.Show("Lỗi");
            if(ckQuanLy.Checked ==true)
            {
                nv.TinhTrangQL = true;
            }
            if (txtTenNV.Text != null)
                nv.TenNV = txtTenNV.Text;
            else MessageBox.Show("Lỗi");
            if (txtChucVu.Text != null)
                nv.ChucVu = txtChucVu.Text;
            else MessageBox.Show("Lỗi");

            if (txtDiaChi.Text != null)
                nv.DiaChi = txtDiaChi.Text;
            else MessageBox.Show("Lỗi");

            if (txtEmail.Text != null)
                nv.Email = txtEmail.Text;
            else MessageBox.Show("Lỗi");

            if (txtDienThoai.Text != null)
                nv.DienThoai = txtDienThoai.Text;
            else MessageBox.Show("Lỗi");

             nv.DiDong = txtDiDong.Text;

            if (lkBoPhan.EditValue != null)
                nv.MaBP = lkBoPhan.EditValue.ToString();
            else MessageBox.Show("Lỗi");

            if (lkQuanLy.EditValue != null)
                nv.MaNVQL = lkQuanLy.EditValue.ToString();
            else MessageBox.Show("Lỗi");

            ql.NhanVien.Add(nv);
            ql.SaveChanges();
            MessageBox.Show("Thêm thành công");
            this.Close();
        }

        private void btnBoPhan_Click(object sender, EventArgs e)
        {
            frm_ThemBoPhan thembp = new frm_ThemBoPhan();
            thembp.ShowDialog();
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            frm_ThemNV themnv = new frm_ThemNV();
            themnv.Show();
        }
    }
}