//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAn_LTUDQL2
{
    using System;
    using System.Collections.Generic;
    
    public partial class CHiTietBanHang
    {
        public int MaPhieuCT { get; set; }
        public string MaBanHang { get; set; }
        public string MaHang { get; set; }
        public Nullable<int> Soluong { get; set; }
        public Nullable<int> VAT { get; set; }
        public Nullable<int> TienThue { get; set; }
        public Nullable<int> ChietKhau { get; set; }
        public Nullable<int> TienChietKhau { get; set; }
        public string ThanhToan { get; set; }
    
        public virtual BanHang BanHang { get; set; }
        public virtual HangHoa HangHoa { get; set; }
    }
}
