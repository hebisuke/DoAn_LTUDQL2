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
    public partial class frm_ThemBoPhan : DevExpress.XtraEditors.XtraForm
    {
        static QLBanHangEntities ql = new QLBanHangEntities();
        public frm_ThemBoPhan()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            BoPhan bp = new BoPhan();
            if (txtMa.Text != null)
                bp.MaBo = txtMa.Text;
            else MessageBox.Show("Lỗi");
            if (ckQuanLy.Checked == true)
            {
                bp.TinhTrangQL = true;
            }
            if (txtTen.Text != null)
                bp.TenBo = txtTen.Text;
            else MessageBox.Show("Lỗi");
            bp.GhiChu = txtGhiChu.Text;
            ql.BoPhan.Add(bp);
            ql.SaveChanges();
            MessageBox.Show("Thêm thành công");
            this.Close();
        }
    }
    }
