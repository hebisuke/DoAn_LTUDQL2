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
using BUS.BUS;
namespace DoAn_LTUDQL2
{
    
    public partial class frm_SuaNV : DevExpress.XtraEditors.XtraForm
    {
        static QLBanHangEntities ql = new QLBanHangEntities();
        public frm_SuaNV()
        {
            InitializeComponent();
        }

        private void frm_SuaNV_Load(object sender, EventArgs e)
        {
            lkBoPhan.Properties.DataSource = (from item in ql.BoPhan select new { mabophan = item.MaBo, tenbophan = item.TenBo }).ToList();
            lkBoPhan.Properties.DisplayMember = "tenbophan";
            lkBoPhan.Properties.ValueMember = "mabophan";

            lkQuanLy.Properties.DataSource = (from item in ql.NhanVien select new { manhanvien = item.MaNV, tennhanvien = item.TenNV }).ToList();
            lkQuanLy.Properties.DisplayMember = "tennhanvien";
            lkQuanLy.Properties.ValueMember = "manhanvien";

            NhanVien nv = frm_NhanVien1.nvStatic;
            txtMaNV.Text = nv.MaNV;
            txtTen.Text = nv.TenNV;
            txtDiaChi.Text = nv.DiaChi;
            txtChucVu.Text = nv.ChucVu;
            txtDienThoai.Text = nv.DienThoai;
            txtDiDong.Text = nv.DiDong;
            txtEmail.Text = nv.Email;
            ckQuanLy.Checked = nv.TinhTrangQL ?? false;
            lkBoPhan.EditValue = nv.MaBP;
            lkQuanLy.EditValue = nv.MaNVQL;
        }

        public delegate void sua(NhanVien nv);
        public event sua SuaNhanVien = null;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien()
            {
                MaNV = txtMaNV.Text,
                TenNV = txtTen.Text,
                DiaChi = txtDiaChi.Text,
                Email = txtEmail.Text,
                ChucVu = txtChucVu.Text,
                DienThoai = txtDienThoai.Text,
                DiDong = txtDiDong.Text,
                MaBP = lkBoPhan.EditValue.ToString(),
                MaNVQL = lkQuanLy.EditValue.ToString(),
                TinhTrangQL = ckQuanLy.Checked
            };
            SuaNhanVien(nv);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}