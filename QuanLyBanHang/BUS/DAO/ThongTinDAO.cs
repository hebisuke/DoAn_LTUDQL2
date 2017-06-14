using BUS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    
    class ThongTinDAO
    {
        static QLBanHangEntities ql = new QLBanHangEntities();
        public static ThongTinToChucCaNhan LoadDanhSach()
        {
            return ql.ThongTinToChucCaNhan.FirstOrDefault();
        }
    }
}
