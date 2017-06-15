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
    public partial class frm_ThemNhomHang : DevExpress.XtraEditors.XtraForm
    {
        QLBanHangEntities en = new QLBanHangEntities();
        public static int a;
        public frm_ThemNhomHang()
        {
            InitializeComponent();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                NhomHangHoa nhh = new NhomHangHoa();
                nhh.MaNhom = txtMaNH.Text;
                nhh.TenNhom = txtTenNH.Text;
                nhh.GhiChu = txtGCNH.Text;

                if(txtTTQLNH.Checked)
                {
                   nhh.TinhTrangQL= 1;
                }
                else
                {
                    nhh.TinhTrangQL = 0;
                }
                en.NhomHangHoa.Add(nhh);
                en.SaveChanges();
                MessageBox.Show("Lưu Thành Công");
                this.Close();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}