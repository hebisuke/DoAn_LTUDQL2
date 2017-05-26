using DevExpress.SpreadsheetSource.Implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DoAn_LTUDQL2
{
    public partial class frm_ThongTin : DevExpress.XtraEditors.XtraForm
    {
   
        QLBanHangEntities ql = new QLBanHangEntities();
      
        //public int ID { get; set; }
        //public string Ten { get; set; }
        public frm_ThongTin()
        {
            InitializeComponent();
    
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_ThongTin_Load(object sender, EventArgs e)
        {
            //List<frm_ThongTin> list = new List<frm_ThongTin>();
            //list.Add(new frm_ThongTin() { ID = 1, Ten = "Bán Hàng" });
            //list.Add(new frm_ThongTin() { ID = 2, Ten = "Thương Mại" });
            //list.Add(new frm_ThongTin() { ID = 3, Ten = "Kinh Doanh" });
            //cbLinhVuc.DataSource = list;
            //cbLinhVuc.ValueMember = "ID";
            //cbLinhVuc.DisplayMember = "Ten";

            var tt = ql.ThongTinToChucCaNhans.Single(p=>p.Ma==1);
            txt_Tendonvi.Text = tt.TenDonVi;
            txt_DiaChi.Text = tt.DiaCHi;
            txtDienThoai.Text = tt.DTBan;
            txtdtdd.Text = tt.DTDD;
            txtFax.Text = tt.Fax;
            txtweb.Text = tt.Website;
            txtEmail.Text = tt.Email;
            cbLinhVuc.Text = tt.LinhVuc;
            txtMaSoThue.Text = tt.MST;
            txtGPKD.Text = tt.GPKD;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            var tt = ql.ThongTinToChucCaNhans.Single(p => p.Ma == 1);
                tt.TenDonVi = txt_Tendonvi.Text;
                tt.DiaCHi=txt_DiaChi.Text;
                tt.DTBan =txtDienThoai.Text;
                tt.DTDD=txtdtdd.Text;
                tt.Fax=txtFax.Text ;
                tt.Website=txtweb.Text;
                tt.Email=txtEmail.Text;
                tt.LinhVuc= cbLinhVuc.Text;
                tt.MST=txtMaSoThue.Text;
                tt.GPKD=txtGPKD.Text;
            ql.SaveChanges();
            this.Close();
        }
                  
            }

        }
    
