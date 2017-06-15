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
    public partial class frm_BanHang : DevExpress.XtraEditors.XtraForm
    {
        QLBanHangEntities db = new QLBanHangEntities();
        public frm_BanHang()
        {
            InitializeComponent();
        }

        private void btn_TaoMoi_Click(object sender, EventArgs e)
        {
            frm_BanHang_Load(sender, e);
        }

        private void frm_BanHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBanHangDataSet.KhuVuc' table. You can move, or remove it, as needed.
            gridControl1.DataSource = BanHangBUS.LoadDS();
            //------------ load tên nhà cung cấp
            btn_TenKhachHang.Properties.DataSource = (from item in db.KhachHang select new { TenKhachHang = item.TenKH, MaKhachHang = item.MaKH }).ToList();
            btn_TenKhachHang.Properties.DisplayMember = "TenKhachHang";
            btn_TenKhachHang.Properties.ValueMember = "MaKhachHang";
            //------------load tên nhân viên--------------
            btn_NhanVien.Properties.DataSource = (from item in db.NhanVien select new { MaNV = item.MaNV, TenNV = item.TenNV }).ToList();
            btn_NhanVien.Properties.DisplayMember = "TenNV";
            btn_NhanVien.Properties.ValueMember = "MaNV";

            //----------load kho hàng---------------------
            btn_TenKho.Properties.DataSource = (from item in db.KhoHang select new { MaKho = item.MaKho, TenKho = item.TenKho }).ToList();
            btn_TenKho.Properties.DisplayMember = "TenKho";
            btn_TenKho.Properties.ValueMember = "MaKho";



            repositoryItemLookUpEdit1.DataSource = (from item in db.HangHoa select new { MaHang = item.MaHang, TenHang = item.TenHang, donvitinh = item.DonViTinh.TenDV }).ToList();
            repositoryItemLookUpEdit1.DisplayMember = "MaHang";
            repositoryItemLookUpEdit1.ValueMember = "MaHang";
            repositoryItemLookUpEdit1.PopupWidth = 1000;
            repositoryItemLookUpEdit1.PopulateColumns();


            repositoryItemLookUpEdit2.DataSource = (from item in db.HangHoa select new { MaHang = item.MaHang, TenHang = item.TenHang, donvitinh = item.DonViTinh.TenDV }).ToList();
            repositoryItemLookUpEdit2.DisplayMember = "TenHang";
            repositoryItemLookUpEdit2.ValueMember = "MaHang";
            repositoryItemLookUpEdit2.PopupWidth = 1000;
            repositoryItemLookUpEdit2.PopulateColumns();

            repositoryItemLookUpEdit3.DataSource = (from item in db.HangHoa select new { MaHang = item.MaHang, TenHang = item.TenHang, DonViTinh = item.DonViTinh.TenDV }).ToList();
            repositoryItemLookUpEdit3.DisplayMember = "DonViTinh";
            repositoryItemLookUpEdit3.ValueMember = "MaHang";
            repositoryItemLookUpEdit3.PopupWidth = 1000;
            repositoryItemLookUpEdit3.PopulateColumns();

            btn_TenKhachHang.Text = null;
            tbx_DiaChi.Text = null;
            tbx_SDT.Text = null;
            tbx_GhiChu.Text = null;
            tbx_SoHoaDonVAT.Text = null;
            tbx_SoPhieuVietTay.Text = null;
            btn_TenKho.Text = null;
            tbx_HanThanhToan.Text = null;
            cbx_DieuKhoanTT.Text = null;
            cbx_HTTToan.Text = null;
            btn_NhanVien.Text = null;
            for (int i = 0; i < gridView1.RowCount;)
                gridView1.DeleteRow(i);
            NhatKiHeThongBUS.ThemNhatKi("banhang", "Làm mới");

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            //Tạo đơn hàng mới
            // try
            // {
            BanHang banhang = new BanHang();
            if (btn_TenKhachHang.EditValue != null)
            {

                banhang.MaKhachHang = btn_TenKhachHang.EditValue.ToString();
            }
            else { MessageBox.Show("Lưu không thành công"); return; }

            banhang.NgayBan = DateTime.Now;

            if (cbx_DieuKhoanTT.Text != null)
            {
                banhang.DieuKhoanThanhToan = cbx_DieuKhoanTT.Text;
            }
            else { MessageBox.Show("Lưu không thành công"); return; }

            if (cbx_HTTToan.Text != null)
            {
                banhang.HinhThucThanhToan = cbx_HTTToan.Text;
            }
            else { MessageBox.Show("Lưu không thành công"); return; }

            if (btn_NhanVien.EditValue != null)
            {
                banhang.MaNVBan = btn_NhanVien.EditValue.ToString();
            }
            else { MessageBox.Show("Lưu không thành công"); return; }

            if (tbx_DiaChi.Text != null)
            {
                banhang.DiaChi = tbx_DiaChi.Text;
            }
            else { MessageBox.Show("Lưu không thành công"); return; }

            if (tbx_SDT.Text != null)
            {
                banhang.SoDienThoai = tbx_SDT.Text;
            }
            else { MessageBox.Show("Lưu không thành công"); return; }
            banhang.SoHoaDonVAT = tbx_SoHoaDonVAT.Text;
            banhang.SoPhieuVietTay = tbx_SoPhieuVietTay.Text;
            if (btn_TenKho.EditValue != null)
            {
                banhang.MaKhoXuat = btn_TenKho.EditValue.ToString();
            }
            if (DateTime.Compare(DateTime.Today, (DateTime)tbx_HanThanhToan.EditValue) <= 0)
            {
                banhang.HanThanhToan = (DateTime)tbx_HanThanhToan.EditValue;
            }
            // Tạo chi tiết hàng mới tạm
            int tongtien = 0;
            var dsct = new Mua_BanTam();
            //  try
            //{
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                dsct.MaHang = gridView1.GetRowCellValue(i, "MaHang").ToString();
                dsct.Gia = Convert.ToInt32(gridView1.GetRowCellValue(i, "Gia"));
                dsct.SoLuong = Convert.ToInt32(gridView1.GetRowCellValue(i, "SoLuong"));
                dsct.ThanhTien = Convert.ToInt32(gridView1.GetRowCellValue(i, "TongTien"));
                db.Mua_BanTam.Add(dsct);
                db.SaveChanges();
                tongtien = dsct.ThanhTien.Value + tongtien;

            }
            // }
            //catch(Exception ex)
            //{
            //    MessageBox.Show("Lưu Không thành công!!!");
            //    var tamp = (from item in db.Mua_BanTam select item );
            //    db.Mua_BanTam.RemoveRange(tamp);
            //}
            banhang.TongTien = tongtien.ToString();
            db.BanHang.Add(banhang);
            db.SaveChanges();

            var ct = (from item in db.Mua_BanTam select item);
            var chitiet = new CHiTietBanHang();
            foreach (var item in ct)
            {
                chitiet.MaBanHang = banhang.MaPhieuBanHang;
                chitiet.MaHang = item.MaHang;
                chitiet.Soluong = item.SoLuong;
                chitiet.ThanhToan = item.ThanhTien;
                db.CHiTietBanHang.Add(chitiet);
                var hanghoa = db.HangHoa.Where(s => s.MaHang == item.MaHang).First();
                hanghoa.TonKhoHienTai = hanghoa.TonKhoHienTai - item.SoLuong;
                db.Mua_BanTam.Remove(item);

            }
            db.SaveChanges();
            // }
            //     catch(Exception ex)
            //   {
            //     MessageBox.Show(ex.ToString());
            //}


            MessageBox.Show("save thành công!!");
            // hàm lấy mã phiếu mua hàng 
            btn_TaoMoi_Click(sender, e);
           NhatKiHeThongBUS.ThemNhatKi("Bán Hàng", "Bán Hàng");
        }

        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            int rowIndex = e.ListSourceRowIndex;

            decimal gia = Convert.ToDecimal(gridView1.GetListSourceRowCellValue(rowIndex, "Gia"));
            decimal soluong = Convert.ToDecimal(gridView1.GetListSourceRowCellValue(rowIndex, "SoLuong"));
            if (e.Column.FieldName != "TongTien") return;
            if (e.IsSetData)
                e.Value = gia * soluong;
        }
    }
 }