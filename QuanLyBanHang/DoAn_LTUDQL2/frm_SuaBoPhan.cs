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
    public partial class frm_SuaBoPhan : DevExpress.XtraEditors.XtraForm
    {
        public frm_SuaBoPhan()
        {
            InitializeComponent();
        }

        private void frm_SuaBoPhan_Load(object sender, EventArgs e)
        {
            BoPhan bp = frm_BoPhan.nvStatic;
            txtMa.Text = bp.MaBo;
            txtTen.Text =bp.TenBo;
            txtGhiChu.Text = bp.GhiChu;
            ckQuanLy.Checked = bp.TinhTrangQL ?? false;
        }
        public delegate void sua(BoPhan bp);
        public event sua SuaBoPhan = null;

        private void btnLuu_Click(object sender, EventArgs e)
        {
            BoPhan bp = new BoPhan()
            {
                MaBo = txtMa.Text,
                TenBo = txtTen.Text,
                GhiChu = txtGhiChu.Text,
                TinhTrangQL = ckQuanLy.Checked
            };
            SuaBoPhan(bp);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}