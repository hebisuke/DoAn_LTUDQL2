using BUS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public static class LoginDAO
    {
        static QLBanHangEntities ql = new QLBanHangEntities();
        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
        public static V_ThongTinLogin DangNhap(string user, string pass)
        {
            pass = MD5Hash(pass);
            var TK = from p in ql.V_ThongTinLogin
                         where p.TenTaiKhoan == user && p.MatKhau == pass
                         select p;
            return (TK.Count() == 0) ? null : TK.FirstOrDefault();
        }
    }
}
