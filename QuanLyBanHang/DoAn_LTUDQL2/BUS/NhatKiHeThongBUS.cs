using DoAn_LTUDQL2.DAO;
using DoAn_LTUDQL2.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_LTUDQL2.BUS
{
    class NhatKiHeThongBUS
    {
        public static void ThemNhatKi(string TenChucNang, string HanhDong)
        {
            NhatKiHeThongDAO.ThemNhatKi(TenChucNang, HanhDong);
        }
        public static BindingList<NhatKiHeThong> DSNhatKyHeThong()
        {
            return NhatKiHeThongDAO.DSNhatKyHeThong();
        }
    }
}
