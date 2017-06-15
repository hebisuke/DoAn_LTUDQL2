using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS.DTO;
using BUS;
using System.ComponentModel;
using System.Data.Entity;

namespace BUS.DAO
{
    class KhoHangDAO
    {
        static QLBanHangEntities ql = new QLBanHangEntities();
        public static BindingList<KhoHang> DSKhoHang()
        {
            ql.KhoHang.Load();
            return ql.KhoHang.Local.ToBindingList();
        }
    }
}
