using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_LTUDQL2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn Chưa Đăng Nhập Bạn Thật Sự Muốn Thoát!","Thông Báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if(txt_MatKhau.Text == "")
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

        private void txt_TenDangNhap_TextChanged(object sender, EventArgs e)
        {
            if (txt_TenDangNhap.Text == "")
            {
                txt_thongbaotk.Text = "Bạn Chưa Nhập Tài Khoản!";
                txt_thongbaotk.ForeColor = Color.Red;
                txt_thongbaotk.Font = new Font(txt_thongbaotk.Font, FontStyle.Regular);
                txt_vtk.Text = "";
            }
            else if (txt_TenDangNhap.Text != "")
            {
                txt_vtk.Text = "V";
                txt_vtk.ForeColor = Color.Green;
                txt_vtk.Font = new Font(txt_vtk.Font, FontStyle.Italic);
                txt_thongbaotk.Text = "";
            }
          

        }

        private void txt_MatKhau_TextChanged(object sender, EventArgs e)
        {
            if (txt_MatKhau.Text == "")
            {
                txt_thongbaomk.Text = "Bạn Chưa Nhập Mật Khẩu!";
                txt_thongbaomk.ForeColor = Color.Red;
                txt_thongbaomk.Font = new Font(txt_thongbaomk.Font, FontStyle.Regular);
                txt_vmk.Text = "";
            }
            else if (txt_MatKhau.Text != "")
            {
                txt_vmk.Text = "V";
                txt_vmk.ForeColor = Color.Green;
                txt_vmk.Font = new Font(txt_vmk.Font,FontStyle.Italic);
                txt_thongbaomk.Text = "";
            }
        }
    }
}
