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
    
    public partial class NhatKiHeThong
    {
        public int id { get; set; }
        public string MaNV { get; set; }
        public string MayTinh { get; set; }
        public Nullable<System.DateTime> ThoiGian { get; set; }
        public Nullable<int> MaChucNang { get; set; }
        public string HanhDong { get; set; }
        public string MaDoiTuong { get; set; }
    
        public virtual BanHang BanHang { get; set; }
        public virtual HangHoa HangHoa { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual KhoHang KhoHang { get; set; }
        public virtual MuaHang MuaHang { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual NhanVien NhanVien1 { get; set; }
        public virtual NhaPhanPhoi NhaPhanPhoi { get; set; }
    }
}
