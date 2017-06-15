using BUS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS.DAO;

namespace BUS.BUS
{
    public static class LoginBUS
    {
        public static V_ThongTinLogin Working;
        
        public static string MD5Hash(string input)
        {
            return LoginDAO.MD5Hash(input);
        }
        public static V_ThongTinLogin DangNhap(string user, string pass)
        {
            return LoginDAO.DangNhap(user, pass);
        }
    }
}
