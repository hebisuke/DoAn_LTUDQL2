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
    public partial class frm_ThemDVT : DevExpress.XtraEditors.XtraForm
    {
        QLBanHangEntities en = new QLBanHangEntities();
        public static int a;
        public frm_ThemDVT()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                DonViTinh dv = new DonViTinh();
                dv.MaDV = txt_MaDV.Text;
                dv.TenDV = txt_TenDV.Text;
                dv.GhiChu = txt_GhiChu.Text;

                if (txtTinhTrang.Checked)
                {
                    dv.TinhTrangQL = 1;
                }
                else
                {
                    dv.TinhTrangQL = 0;
                }
                en.DonViTinh.Add(dv);
                en.SaveChanges();
                MessageBox.Show("Lưu Thành Công");
                this.Close();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}