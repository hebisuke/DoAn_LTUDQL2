﻿using BUS.DAO;
using BUS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BUS
{
    public static class ThongTinBUS
    {
        public static ThongTinToChucCaNhan LoadDanhSach()
        {
            return ThongTinDAO.LoadDanhSach();
        }
    }
}
