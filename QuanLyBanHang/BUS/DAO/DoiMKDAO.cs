using BUS.BUS;
using BUS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.DAO
{
    public class DoiMKDAO
    {
        static QLBanHangEntities db = new QLBanHangEntities();
        public static TaiKhoanNguoiDung LayThongTin(string MaNV)
        {
            var TK = (from x in db.TaiKhoanNguoiDung
                                    where x.MaNV == MaNV
                                    select x).First();
            return TK;
        }
        public static int DoiMatKhau(string MatKhauCu, string MatKhauMoi, string MaNV)
        {
            var TK = LayThongTin(MaNV);
            if (TK.MatKhau == LoginBUS.MD5Hash(MatKhauCu))
            {
                TK.MatKhau = LoginBUS.MD5Hash(MatKhauMoi);
                db.SaveChanges();
                return 1;
            }
            else
                return -1;
        }
    }
}
