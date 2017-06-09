using DoAn_LTUDQL2.DAO;
using DoAn_LTUDQL2.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_LTUDQL2.BUS
{
    class ThongTinBUS
    {
        public static ThongTinToChucCaNhan LoadDanhSach()
        {
            return ThongTinDAO.LoadDanhSach();
        }
    }
}
