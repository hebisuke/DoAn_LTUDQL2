using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS.DTO;
namespace BUS.DAO
{
    public class KvDAL
    {
        QLBanHangEntities en = new QLBanHangEntities();
        public bool ThemKV(string ma, string ten, string gichu)
        {
            try
            {

                KhuVuc kv = new KhuVuc();
                kv.MaKV = ma;
                kv.TenKV = ten;
                kv.GhiChu = gichu;
                //en.KhuVuc.InsertOnSubmit(kv);
                //en.SubmitChanges();
                en.KhuVuc.Add(kv);
                en.SaveChanges();
                return true;

            }
            catch { }
            return false;
        }

        public List<KhuVuc> HienThi()
        {
            List<KhuVuc> dsKV = en.KhuVuc.ToList();
            return dsKV;
        }
        public KhuVuc Tim(int ma)
        {
            KhuVuc kv = en.KhuVuc.FirstOrDefault(x => x.MaKV == ma.ToString());

            return kv; 
        }
        public bool XoaKV(string ma)
        {
            
            KhuVuc kv = en.KhuVuc.FirstOrDefault(x => x.MaKV == ma);
            if (kv != null)
            {
                if (kv.KhachHang.Count > 0)
                {
                  
                    return false;
                }
                en.KhuVuc.Remove(kv);
                en.SaveChanges();
                
            }
            return true;
        }
        public bool SuaKV(int ma, string ten, string gichu)
        {
            KhuVuc kv = en.KhuVuc.FirstOrDefault(x => x.MaKV == ma.ToString());

            if (kv != null)
            {
                kv.TenKV = ten;
                kv.GhiChu = gichu;
                en.SaveChanges();
                return true;

            }
            return false;
            
        }

        
      
    }
}
