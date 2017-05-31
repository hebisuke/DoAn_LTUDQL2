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
    public partial class frm_Login : Form
    {
        QLBanHangEntities ql = new QLBanHangEntities();
        public frm_Login()
        {
            InitializeComponent();
        }

        private void tbx_User_TextChanged(object sender, EventArgs e)
        {
            tbx_User.ForeColor = Color.Black;
            if (tbx_User.Text == "")
            {
                lbx_ThongBao.Text = "Vui lòng không để trống Username";
                tbx_User.Focus();
            }
            else
            {
                lbx_ThongBao.Text = "";
            }
        }

        private void tbx_Pass_TextChanged(object sender, EventArgs e)
        {
            tbx_User.ForeColor = Color.Black;
            if(tbx_Pass.Text =="")
            {
                lbx_ThongBao.Text = "Vui lòng không để trống password";
                tbx_Pass.Focus();
            }
            else
            {
                lbx_ThongBao.Text = "";
            }
        }

        private void pictureEdit_ShowPass_Click(object sender, EventArgs e)
        {
            tbx_Pass.UseSystemPasswordChar = false;
        }

        private void pictureEdit_ShowPass_MouseDown(object sender, MouseEventArgs e)
        {
            tbx_Pass.UseSystemPasswordChar = true;
        }

        private void pictureEdit_ShowPass_MouseUp(object sender, MouseEventArgs e)
        {
            tbx_Pass.UseSystemPasswordChar = false;
        }

        private void lbx_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbx_User_MouseDown(object sender, MouseEventArgs e)
        {
            tbx_User.Text = "";
        }
        private void tbx_Pass_MouseDown(object sender, MouseEventArgs e)
        {
            tbx_Pass.Text = "";
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (tbx_User.Text == "")
            {
                lbx_ThongBao.Text = "Vui lòng không để trống Username";
                return;
            }
            if (tbx_Pass.Text == "")
            {
                lbx_ThongBao.Text = "Vui lòng không để trống password";
                return;
            }

            //------------  đăng nhập thành công---------------
            this.Hide();

            var myQuery = from Q in ql.ThongTinToChucCaNhans select Q.Ma;
            if (myQuery != null && myQuery.Count() > 0)
            {
                MainView mn = new MainView();
                mn.ShowDialog();
            }
               else
            {
                frm_ThongTin tt = new frm_ThongTin();
                tt.ShowDialog();
            }
            this.Close();
            Application.Exit();
        }
    }
}
