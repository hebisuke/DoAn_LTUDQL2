using BUS.DAO;
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
    public static class MuaHangBUS
    {
        public static BindingList<Mua_BanTam> LoadDS()
        {
            return MuaHangDAO.LoadDS();
        }
        public static int LayMaPhieuMuaHang()
        {
            return MuaHangDAO.LayMaPhieuMuaHang();
        }
        public static List<V_NhaPhanPhoi> LoadNhaPhanPhoi()
        {
            return MuaHangDAO.LoadNhaPhanPhoi();
        }
        public static List<V_NhanVien> LoadNhanVien()
        {
            return MuaHangDAO.LoadNhanVien();
        }
        public static List<V_KhoHang> LoadKhoHang()
        {
            return MuaHangDAO.LoadKhoHang();
        }
        public static List<V_HangHoa> LoadHangHoa()
        {
            return MuaHangDAO.LoadHangHoa();
        }
    }
}
