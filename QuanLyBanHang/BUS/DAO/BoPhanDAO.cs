using BUS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.DAO
{
    public class BoPhanDAO
    {
        static QLBanHangEntities ql = new QLBanHangEntities();
        public static BoPhan LoadDanhSach() //load dnah sach ma di trar ve 1 ng. sida
        {
            return ql.BoPhan.FirstOrDefault();
        }

        public static BoPhan get(string id)
        {
            return ql.BoPhan.Where(x => x.MaBo == id).SingleOrDefault();
        }

        public static int sua(BoPhan nv)
        {
            var original = ql.NhanVien.Find(nv.MaBo);

            if (original != null)
            {
                ql.Entry(original).CurrentValues.SetValues(nv);
                return ql.SaveChanges();
            }
            return -1;
        }
    }
}
