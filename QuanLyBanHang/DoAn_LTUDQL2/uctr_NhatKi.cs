using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_LTUDQL2
{
    public partial class uctr_NhatKi : UserControl
    {
        QLBanHangEntities db = new QLBanHangEntities();
        public void ThemHoatDong(string motahoatdong, string idnguoidung, string tenchucnang)
        {
            // Create a new Order object.
            string myServer = Environment.MachineName;
            NhatKiHeThong ord = new NhatKiHeThong()
            {
                MaNV = idnguoidung,
                MayTinh = myServer,
                ThoiGian = DateTime.Now,
                TenChucNang = tenchucnang,
                HanhDong = motahoatdong
                // …
            };

            // Add the new object to the Orders collection.
            db.NhatKiHeThongs.Add(ord);

            // Submit the change to the database.
            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Lỗi!");
            }
        }
        public uctr_NhatKi()
        {
            InitializeComponent();
        }

        private void uctr_NhatKi_Load(object sender, EventArgs e)
        {
            var list = from x in db.NhatKiHeThongs select x;
            dgv_DSNhatKi.DataSource = list.ToList();
        }
    }
}
