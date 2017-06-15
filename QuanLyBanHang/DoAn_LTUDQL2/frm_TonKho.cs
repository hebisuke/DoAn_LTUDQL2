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
using DevExpress.XtraPrinting;
using DevExpress.Export;
using BUS.BUS;

namespace DoAn_LTUDQL2
{
    public partial class frm_TonKho : DevExpress.XtraEditors.XtraForm
    {
        QLBanHangEntities db = new QLBanHangEntities();
        public frm_TonKho()
        {
            InitializeComponent();
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from item in db.HangHoa select new { MaHang = item.MaHang,TenHang = item.TenHang,DonVi = item.DonViTinh.TenDV,SoLuong = item.TonKhoHienTai,NhomHang = item.NhomHangHoa.TenNhom, Kho = item.KhoHang.TenKho} ).ToList();
         
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridControl1_Load(sender, e);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                gridControl1.ExportToXlsx("TonKho.Xlsx");
            }
            catch(Exception ex)
            {
               MessageBox.Show(ex.Message) ;
            }
            MessageBox.Show("Lưu thành công!!");
            NhatKiHeThongBUS.ThemNhatKi("frm_TonKho", "Xuât tồn kho");

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                gridControl1.ExportToPdf("TonKho.pdf");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Lưu thành công!!");
           NhatKiHeThongBUS.ThemNhatKi("frm_TonKho", "In tồn kho");
        }
    }
}