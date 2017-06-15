using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS.DAO;

namespace BUS.BUS
{
    public static class DoiMKBUS
    {
        public static int DoiMatKhau(string MatKhauCu, string MatKhauMoi, string MaNV)
        {
            return DoiMKDAO.DoiMatKhau(MatKhauCu,MatKhauMoi,MaNV);
        }
    }
}
