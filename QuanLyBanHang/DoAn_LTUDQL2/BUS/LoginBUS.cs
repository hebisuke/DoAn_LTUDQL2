﻿using DoAn_LTUDQL2.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_LTUDQL2.BUS
{
    class LoginBUS
    {
        public static string MD5Hash(string input)
        {
            return LoginDAO.MD5Hash(input);
        }
        public static Boolean DangNhap(string user, string pass)
        {
            return LoginDAO.DangNhap(user, pass);
        }
    }
}