
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS.DAO;
using BUS.DTO;
namespace BUS.BUS
{
    public class KvBLL
    {

        KvDAL kvd = new KvDAL();
        public bool ThemKV(string ma, string ten, string gichu)
        {
            return kvd.ThemKV(ma, ten, gichu);
        }
        public bool SuaKV(int ma, string ten, string gichu)
        {
            return kvd.SuaKV(ma, ten, gichu);
        }
        public bool XoaKV(string ma) { return kvd.XoaKV(ma); }
        public List<KhuVuc> HienThi() { return kvd.HienThi(); }
        public KhuVuc Tim(int ma) { return kvd.Tim(ma); }
    }
}
