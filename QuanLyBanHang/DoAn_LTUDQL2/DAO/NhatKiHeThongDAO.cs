using DoAn_LTUDQL2.DTO;
using DoAn_LTUDQL2.BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data.Entity;

namespace DoAn_LTUDQL2.DAO
{
    class NhatKiHeThongDAO
    {
        // Instantiate a new DBContext
        static QLBanHangEntities ql = new QLBanHangEntities();
        public static void ThemNhatKi(string TenChucNang, string HanhDong)
        {
            string myServer = Environment.MachineName;
            string Manv = LoginBUS.Working.MaNV;
            DateTime date = DateTime.Now;
            NhatKiHeThong NK = new NhatKiHeThong
            {
                MaNV = Manv,
                MayTinh = myServer,
                ThoiGian = date,
                TenChucNang = TenChucNang,
                HanhDong = HanhDong
            };
            ql.NhatKiHeThongs.Add(NK);

            // Submit the change to the database.
            try
            {
                ql.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                // Make some adjustments.
                // ...
                // Try again.
                ql.SaveChanges();
            }
        }
        public static BindingList<NhatKiHeThong> DSNhatKyHeThong()
        {
            ql.NhatKiHeThongs.Load();
            return ql.NhatKiHeThongs.Local.ToBindingList();
        }
    }
}
