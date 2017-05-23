using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace DoAn_LTUDQL2
{
    public partial class MainView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        
        public MainView()
        {
            Thread t = new Thread(new ThreadStart(SplashScreen));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
            if (!mvvmContext1.IsDesignMode)
                InitializeBindings();
        }
        private void SplashScreen()
        {
            Application.Run(new SplashScreen1());
        }

        void InitializeBindings()
        {
            var fluent = mvvmContext1.OfType<MainViewModel>();
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            //This code will render a "x" mark at the end of the Tab caption. 
            e.Graphics.DrawString("✖", e.Font, Brushes.Red, e.Bounds.Right - 15, e.Bounds.Top + 4);
            e.Graphics.DrawString(this.tabControl1.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 12, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }

        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < this.tabControl1.TabPages.Count; i++)
            {
                Rectangle r = tabControl1.GetTabRect(i);
                //Getting the position of the "x" mark.
                Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 4, 9, 7);
                if (closeButton.Contains(e.Location))
                {
                    if (MessageBox.Show("Would you like to Close this Tab?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.tabControl1.TabPages.RemoveAt(i);
                        break;
                    }
                }
            }
        }
        //--------------------Đây là đề mô sau này sẽ xóa đoạn demo này ----------------
        private void btn_Demo1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // đâu tiên là kiểm tra xem trong cái tabpages , có control nào tên là ryo k ?
            // nếu có thì ruturn ra khỏi event click , nếu không thì tạo mới tabpage
            foreach (Control ctrl in tabControl1.Controls)
            {
                if (ctrl.Name == "Ryo")
                {
                    tabControl1.SelectTab(tabControl1.TabPages["Ryo"]);
                    return;
                }
            }
            // usercontrol1 chính là tên của usercontrol , nhớ đỏi khi làm nhé
            UserControl1 myUserControl = new UserControl1();
            myUserControl.Dock = DockStyle.Fill;
            TabPage myTabPage = new TabPage();//Create new tabpage
            myTabPage.Controls.Add(myUserControl);
            // mytabpage là đại diện , k ảnh hưởng nên có thể làm giống nhau
            myTabPage.Name = "Ryo";
            // .text đây là tên của tabpage hiển thị ra , tên này k được quá 10 kí tự
            myTabPage.Text = "Demo KT";
            tabControl1.TabPages.Add(myTabPage);
            tabControl1.SelectTab(tabControl1.TabPages["Ryo"]);
        }

        private void btn_Demo2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Control ctrl in tabControl1.Controls)
            {
                if (ctrl.Name == "Ryokaka")
                {
                    tabControl1.SelectTab(tabControl1.TabPages["Ryokaka"]);
                    return;
                }
            }
            UserControl2 myUserControl = new UserControl2();
            myUserControl.Dock = DockStyle.Fill;
            TabPage myTabPage = new TabPage();//Create new tabpage
            myTabPage.Controls.Add(myUserControl);
            myTabPage.Name = "Ryokaka";
            myTabPage.Text = "Demo DX";
            tabControl1.TabPages.Add(myTabPage);
            tabControl1.SelectTab(tabControl1.TabPages["Ryokaka"]);
        }
        // text đại diện cho tabpage k được quá 10 kí tự 
        //------------------------------------- Sao Lưu dữ liệu----------------------------------
        private void btn_SaoLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Control ctrl in tabControl1.Controls)
            {
                if (ctrl.Name == "uctr_SaoLuu")
                {
                    tabControl1.SelectTab(tabControl1.TabPages["uctr_SaoLuu"]);
                    return;
                }
            }
            uctr_SaoLuu SaoLuu = new uctr_SaoLuu();
            SaoLuu.Dock = DockStyle.Fill;
            TabPage myTabPage = new TabPage();//Create new tabpage
            myTabPage.Controls.Add(SaoLuu);
            myTabPage.Name = "uctr_SaoLuu";
            myTabPage.Text = "Sao Lưu";
            tabControl1.TabPages.Add(myTabPage);
            tabControl1.SelectTab(tabControl1.TabPages["uctr_SaoLuu"]);
        }

        private void btn_PhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach(Control ctrl in tabControl1.Controls)
            {
                if (ctrl.Name == "uctr_PhucHoi")
                {
                    tabControl1.SelectTab(tabControl1.TabPages["uctr_PhucHoi"]);
                    return;
                }
            }
            uctr_PhucHoi PhucHoi = new uctr_PhucHoi();
            PhucHoi.Dock = DockStyle.Fill;
            TabPage myTabPage = new TabPage();//Create new tabpage
            myTabPage.Controls.Add(PhucHoi);
            myTabPage.Name = "uctr_PhucHoi";
            myTabPage.Text = "Phục Hồi";
            tabControl1.TabPages.Add(myTabPage);
            tabControl1.SelectTab(tabControl1.TabPages["uctr_PhucHoi"]);
        }

        private void btn_VaiTroQuyenHan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Control ctrl in tabControl1.Controls)
            {
                if (ctrl.Name == "uctr_VaiTroQuyenHan")
                {
                    tabControl1.SelectTab(tabControl1.TabPages["uctr_VaiTroQuyenHan"]);
                    return;
                }
            }
            uctr_VaiTroQuyenHan VaiTro = new uctr_VaiTroQuyenHan();
            VaiTro.Dock = DockStyle.Fill;
            TabPage myTabPage = new TabPage();//Create new tabpage
            myTabPage.Controls.Add(VaiTro);
            myTabPage.Name = "uctr_VaiTroQuyenHan";
            myTabPage.Text = "Vai Trò";
            tabControl1.TabPages.Add(myTabPage);
            tabControl1.SelectTab(tabControl1.TabPages["uctr_VaiTroQuyenHan"]);
        }

        private void btn_NguoiDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Control ctrl in tabControl1.Controls)
            {
                if (ctrl.Name == "uctr_NguoiDung")
                {
                    tabControl1.SelectTab(tabControl1.TabPages["uctr_NguoiDung"]);
                    return;
                }
            }
            uctr_NguoiDung NguoiDung = new uctr_NguoiDung();
            NguoiDung.Dock = DockStyle.Fill;
            TabPage myTabPage = new TabPage();//Create new tabpage
            myTabPage.Controls.Add(NguoiDung);
            myTabPage.Name = "uctr_NguoiDung";
            myTabPage.Text = "Người Dùng";
            tabControl1.TabPages.Add(myTabPage);
            tabControl1.SelectTab(tabControl1.TabPages["uctr_NguoiDung"]);
        }

        private void btn_DoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_DoiMK DMK = new frm_DoiMK();
            DMK.ShowDialog();
        }

        private void btn_NhatKyHeThong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Control ctrl in tabControl1.Controls)
            {
                if (ctrl.Name == "uctr_NhatKi")
                {
                    tabControl1.SelectTab(tabControl1.TabPages["uctr_NhatKi"]);
                    return;
                }
            }
            uctr_NhatKi NguoiDung = new uctr_NhatKi();
            NguoiDung.Dock = DockStyle.Fill;
            TabPage myTabPage = new TabPage();//Create new tabpage
            myTabPage.Controls.Add(NguoiDung);
            myTabPage.Name = "uctr_NhatKi";
            myTabPage.Text = "Người Dùng";
            tabControl1.TabPages.Add(myTabPage);
            tabControl1.SelectTab(tabControl1.TabPages["uctr_NhatKi"]);
        }
    }
}
