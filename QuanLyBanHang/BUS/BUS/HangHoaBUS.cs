using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BUS.DTO;
using System.ComponentModel;
using BUS.DAO;

namespace BUS.BUS
{
   public static class HangHoaBUS
    {
        public static BindingList<HangHoa> DSHangHoa()
        {
            return HangHoaDAO.DSHangHoa();
        }
    }
}
