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
    class DonViTinhDAO
    {
        static QLBanHangEntities ql = new QLBanHangEntities();
        public static BindingList<DonViTinh> DSDonViTinh()
        {
            ql.DonViTinh.Load();
            return ql.DonViTinh.Local.ToBindingList();
        }
    }
}
