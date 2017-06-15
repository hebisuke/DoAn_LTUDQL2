using BUS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BUS
{
    public static class BanHangBUS
    {
        public static BindingList<Mua_BanTam> LoadDS()
        {
            return DAO.BanHangDAO.LoadDS();
        }
        public static int LayMaPhieuMuaHang()
        {
            return DAO.BanHangDAO.LayMaPhieuBanHang();
        }
    }
}
