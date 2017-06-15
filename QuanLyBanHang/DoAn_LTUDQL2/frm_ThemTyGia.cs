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
    public partial class frm_ThemTyGia : DevExpress.XtraEditors.XtraForm
    {
        QLBanHangEntities en = new QLBanHangEntities();
        public frm_ThemTyGia()
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

                LoaiTien lt = new LoaiTien();
                lt.id = Convert.ToInt16(txtMaTG.Text);
                lt.TenLoaiTien = txtTenTG.Text;
                

                en.LoaiTien.Add(lt);
                en.SaveChanges();
                MessageBox.Show("Lưu Thành Công");
                this.Close();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}