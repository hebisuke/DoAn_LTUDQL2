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
    class NhomHangDAO
    {
        static QLBanHangEntities ql = new QLBanHangEntities();
        public static BindingList<NhomHangHoa> DSNhomHangHoa()
        {
            ql.NhomHangHoa.Load();
            return ql.NhomHangHoa.Local.ToBindingList();
        }
    }
}
