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
    class HangHoaDAO
    {
        static QLBanHangEntities ql = new QLBanHangEntities();
        public static BindingList<HangHoa> DSHangHoa()
        {
            ql.HangHoa.Load();
            return ql.HangHoa.Local.ToBindingList();
        }
    }
}
