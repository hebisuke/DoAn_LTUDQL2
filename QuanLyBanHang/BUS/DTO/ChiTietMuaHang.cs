//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BUS.DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietMuaHang
    {
        public int MaPhieuCT { get; set; }
        public Nullable<int> MaMuaHang { get; set; }
        public string MaHang { get; set; }
        public Nullable<int> Gia { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<int> ThanhToan { get; set; }
    
        public virtual HangHoa HangHoa { get; set; }
        public virtual MuaHang MuaHang { get; set; }
    }
}
