using DoAn_LTUDQL2.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_LTUDQL2.DAO
{
    
    class ThongTinDAO
    {
        static QLBanHangEntities ql = new QLBanHangEntities();
        public static ThongTinToChucCaNhan LoadDanhSach()
        {
            return ql.ThongTinToChucCaNhans.FirstOrDefault();
        }
    }
}
