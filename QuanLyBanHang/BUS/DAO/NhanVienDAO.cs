using BUS.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.DAO
{
    public class NhanVienDAO
    {
        static QLBanHangEntities ql = new QLBanHangEntities();
        public static NhanVien LoadDanhSach() //load dnah sach ma di trar ve 1 ng. sida
        {
            return ql.NhanVien.FirstOrDefault();
        }

        public static NhanVien get(string id)
        {
            return ql.NhanVien.Where(x => x.MaNV == id).SingleOrDefault();
        }

        public static int sua(NhanVien nv)
        {
            var original = ql.NhanVien.Find(nv.MaNV);

            if (original != null)
            {
                ql.Entry(original).CurrentValues.SetValues(nv);
                return ql.SaveChanges();
            }
            return -1;
        }
    }
}
