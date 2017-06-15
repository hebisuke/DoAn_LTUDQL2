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
    public partial class frm_SuaDVT : DevExpress.XtraEditors.XtraForm
    {
        QLBanHangEntities en = new QLBanHangEntities();
        public frm_SuaDVT()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            string ma = comboBox1.Text.ToString();
            DonViTinh dvt = en.DonViTinh.FirstOrDefault(x => x.MaDV == ma.ToString());
            if (dvt != null)
            {

                dvt.MaDV = txtMaDVT.Text;
                dvt.TenDV = txtTenDVT.Text;
                dvt.GhiChu = txtGCDVT1.Text;
                if (txtTTQL1.Checked)
                {
                  dvt.TinhTrangQL = 1;
                }
                else
                {
                    dvt.TinhTrangQL = 0;
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
        void load()
        {
            List<DonViTinh> dvt = new List<DonViTinh>(); dvt = en.DonViTinh.ToList();
            comboBox1.DataSource = dvt;
            comboBox1.ValueMember = "MaDV";
            comboBox1.DisplayMember = "MaDV";
        }
        private void frm_SuaDVT_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
            
            load();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;
            string ma = comboBox1.SelectedValue.ToString();

            DonViTinh dvt = en.DonViTinh.FirstOrDefault(x => x.MaDV == ma.ToString());
            if (dvt != null)
            {
                txtMaDVT.Text = dvt.MaDV;
                txtTenDVT.Text = dvt.TenDV;
                txtGCDVT1.Text = dvt.GhiChu;

                if (dvt.TinhTrangQL == 1)
                {
                    txtTTQL1.Checked = true;
                }
                else
                {
                    txtTTQL1.Checked = false;

                }
            }
        }
    }
}