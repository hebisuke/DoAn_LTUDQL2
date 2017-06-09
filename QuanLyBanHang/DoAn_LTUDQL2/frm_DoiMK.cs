using DoAn_LTUDQL2.DTO;
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
    public partial class frm_DoiMK : DevExpress.XtraEditors.XtraForm
    {
        QLBanHangEntities db = new QLBanHangEntities();
        public frm_DoiMK()
        {
            InitializeComponent();
        }

        private void btn_DongY_Click(object sender, EventArgs e)
        {
            //var query = from TK in db.TaiKhoanNguoiDungs where TK.MatKhau = ;
            //var result = db.TaiKhoanNguoiDungs.GroupBy(
            //p => p.MaNV,
            //p => p.car,
            //(key, g) => new { PersonId = key, Cars = g.ToList() });
            if(txt_MKCu.Text.Trim() != "" && txt_MKMoi.Text.Trim() != "" && txt_ReMKMoi.Text.Trim() != "")
            {
                if (txt_MKMoi.Text == txt_ReMKMoi.Text)
                {
                    TaiKhoanNguoiDung TK = (from x in db.TaiKhoanNguoiDungs
                                            where x.MatKhau == txt_MKCu.Text
                                            select x).First();
                    if (TK.MatKhau == null)
                    { TK.MatKhau = txt_MKMoi.Text;
                        db.SaveChanges();
                        MessageBox.Show("Đổi Mật Khẩu Thành Công", "Thành Công!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else 
                        MessageBox.Show("Mật khẩu cũ chưa chính xác", "Báo lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //update;
                }
                else MessageBox.Show("Mật Khẩu nhập lại không giống với Mật Khẩu mới", "Báo lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Vui lòng nhập đủ thông tin", "Báo lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_DoiMK_Load(object sender, EventArgs e)
        {

        }
    }
}
