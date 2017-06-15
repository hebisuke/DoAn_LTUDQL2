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
    public partial class frm_ChuyenKho : DevExpress.XtraEditors.XtraForm
    {
        QLBanHangEntities db = new QLBanHangEntities();
        public frm_ChuyenKho() 
        {
            InitializeComponent();
        }

        private void frm_ChuyenKho_Load(object sender, EventArgs e)
         {
           
            Lue_KhoChuyen.Properties.DataSource = (from item in db.KhoHang select new { MaKho = item.MaKho, TenKho = item.TenKho }).ToList();
            Lue_KhoChuyen.Properties.DisplayMember = "TenKho";
            Lue_KhoChuyen.Properties.ValueMember = "MaKho";

            Lue_KhoNhan.Properties.DataSource = (from item in db.KhoHang select new { MaKho = item.MaKho, TenKho = item.TenKho }).ToList();
            Lue_KhoNhan.Properties.DisplayMember = "TenKho";
            Lue_KhoNhan.Properties.ValueMember = "MaKho";

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

            gridControl1.DataSource = MuaHangBUS.LoadDS();                
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

        private void btn_Them_Click(object sender, EventArgs e)
        {
            var khochuyen = "";

            var khonhan= "";
            if (Lue_KhoChuyen.EditValue != null)
            {
                 khochuyen = Lue_KhoChuyen.EditValue.ToString();
            }
            else { MessageBox.Show("Khong de trong kho chuyen"); return; }

            if (Lue_KhoNhan.EditValue != null)
            {
                 khonhan = Lue_KhoNhan.EditValue.ToString();
            }
            else { MessageBox.Show("Khong de trong kho nhan"); return; }
            if(khochuyen == khonhan )
            {
                MessageBox.Show("Kho chuyen khong duoc giong kho nhan"); return;
            }

            //for (int i = 0; i < gridView1.RowCount; i++)
            //{
            //    var mahang= gridView1.GetRowCellValue(i, "MaHang").ToString();
            //    // kiem tra , neu moi thi tao moi roi them so luong
            //    // nguoi lai neu co roi thi cong o luong len
            //    var a = (from item in db.HangHoa where item.MaHang == mahang select item.TenHang).FirstOrDefault();
                 

                    
            //    if(temp ==null)
            //    {
            //        MessageBox.Show("Ten hang phai co trong ca hai kho");
            //        return;
            //    }

            //    MessageBox.Show(temp.TenHang.ToString());
            //  //  var soluong = Convert.ToInt32(gridView1.GetRowCellValue(i, "SoLuong"));

  
            //}

        }
    }
}