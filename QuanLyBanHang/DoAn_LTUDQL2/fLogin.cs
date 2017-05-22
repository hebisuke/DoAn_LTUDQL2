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

namespace DoAn_LTUDQL2
{
    public partial class fLogin : DevExpress.XtraEditors.XtraForm
    {
        public fLogin()
        {
            InitializeComponent();
            this.SuspendLayout();
            this.Location = new System.Drawing.Point(100, 200);
            this.ResumeLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
        }

        private void label1_ForeColorChanged(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
        }

        private void label3_ForeColorChanged(object sender, EventArgs e)
        {
            label3.BackColor = System.Drawing.Color.Transparent;
        }

        private void label2_ForeColorChanged(object sender, EventArgs e)
        {
            label2.BackColor = System.Drawing.Color.Transparent;
        }

        private void txt_TaiKhoan_BackColorChanged(object sender, EventArgs e)
        {
            txt_TaiKhoan.BackColor = System.Drawing.Color.Transparent;
        }

        private void txt_MatKhau_BackColorChanged(object sender, EventArgs e)
        {
           txt_MatKhau.BackColor = System.Drawing.Color.Transparent;
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (txt_MatKhau.Text == "" && txt_TaiKhoan.Text == "")
            {
                MessageBox.Show("Mật Khẩu Hoặc Tài Khoản Chưa Đúng Yêu Cầu Kiểm Tra Lại!", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
                MainView m = new MainView();
                this.Hide();
                m.ShowDialog();
                this.Show();
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn Chưa Đăng Nhập Bạn Thật Sự Muốn Thoát!", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void txt_TaiKhoan_TextChanged(object sender, EventArgs e)
        {
            if (txt_TaiKhoan.Text == "")
            {
                txt_thongbaotk.Text = "Bạn Chưa Nhập Tài Khoản!";
                txt_thongbaotk.ForeColor = Color.DarkRed;
                txt_thongbaotk.Font = new Font(txt_thongbaotk.Font, FontStyle.Regular);
                txt_vkt.Text = "";
            }
            else if (txt_TaiKhoan.Text != "")
            {
               txt_vkt.Text = "V";
                txt_vkt.ForeColor = Color.Green;
                txt_vkt.Font = new Font(txt_vkt.Font, FontStyle.Italic);
                txt_thongbaotk.Text = "";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txt_MatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txt_MatKhau.UseSystemPasswordChar = true;
            }
        }

        private void txt_MatKhau_TextChanged(object sender, EventArgs e)
        {
            if (txt_MatKhau.Text == "")
            {
                txt_thongbaomk.Text = "Bạn Chưa Nhập Mật Khẩu!";
                txt_thongbaomk.ForeColor = Color.DarkRed;
                txt_thongbaomk.Font = new Font(txt_thongbaomk.Font, FontStyle.Regular);
                txt_vmk.Text = "";
            }
            else if (txt_MatKhau.Text != "")
            {
                txt_vmk.Text = "V";
                txt_vmk.ForeColor = Color.Green;
                txt_vmk.Font = new Font(txt_vmk.Font, FontStyle.Italic);
                txt_thongbaomk.Text = "";
            }
        }

        private void txt_thongbaotk_ForeColorChanged(object sender, EventArgs e)
        {
            txt_thongbaotk.BackColor = System.Drawing.Color.Transparent;
        }

        private void txt_thongbaomk_ForeColorChanged(object sender, EventArgs e)
        {
            txt_thongbaomk.BackColor = System.Drawing.Color.Transparent;
        }

        private void txt_vkt_ForeColorChanged(object sender, EventArgs e)
        {
            txt_vkt.BackColor = System.Drawing.Color.Transparent;
        }

        private void txt_vmk_ForeColorChanged(object sender, EventArgs e)
        {
            txt_vmk.BackColor = System.Drawing.Color.Transparent;
        }
    }
}