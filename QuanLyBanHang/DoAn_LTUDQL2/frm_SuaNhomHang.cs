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
    public partial class frm_SuaNhomHang : DevExpress.XtraEditors.XtraForm
    {
        QLBanHangEntities en = new QLBanHangEntities();
        public frm_SuaNhomHang()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string ma = comboBox1.Text.ToString();
            NhomHangHoa nhh = en.NhomHangHoa.FirstOrDefault(x => x.MaNhom == ma.ToString());
            if (nhh != null)
            {
                nhh.MaNhom = txtMaNHH.Text;
                nhh.TenNhom = txtTenNHH.Text;
                nhh.GhiChu = txtGCNHH.Text;
               
               
              
                if (txtTTQLNHH.Checked)
                {
                    nhh.TinhTrangQL = 1;
                }
                else
                {
                    nhh.TinhTrangQL = 0;
                }
                en.SaveChanges();
                MessageBox.Show("thanh cong");
            }

            this.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void loading()
        {
            List<NhomHangHoa> nhh = new List<NhomHangHoa>(); nhh = en.NhomHangHoa.ToList();
            comboBox1.DataSource = nhh;
            comboBox1.ValueMember = "MaNhom";
            comboBox1.DisplayMember = "MaNhom";
        }
        private void frm_SuaNhomHang_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            
            loading();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;
            string ma = comboBox1.SelectedValue.ToString();

            NhomHangHoa nhh = en.NhomHangHoa.FirstOrDefault(x => x.MaNhom == ma.ToString());
            if (nhh != null)
            {
                txtMaNHH.Text = nhh.MaNhom;
                txtTenNHH.Text = nhh.TenNhom;
                txtGCNHH.Text = nhh.GhiChu;
                if (nhh.TinhTrangQL == 1)
                {
                    txtTTQLNHH.Checked = true;
                }
                else
                {
                    txtTTQLNHH.Checked = false;
                }
            }
            }
    }
}