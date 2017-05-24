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
    public partial class uctr_VaiTroQuyenHan : UserControl
    {
        public uctr_VaiTroQuyenHan()
        {
            InitializeComponent();
        }

        private void uctr_VaiTroQuyenHan_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton21_Click(object sender, EventArgs e)
        {

        }

        private void dgv_QuyenHan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_ThemTKND_Click(object sender, EventArgs e)
        {
            frm_ThemTKND abc = new frm_ThemTKND();
            abc.ShowDialog();
        }
    }
}
