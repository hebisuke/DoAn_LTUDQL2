//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAn_LTUDQL2.DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class MuaHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MuaHang()
        {
            this.ChiTietMuaHangs = new HashSet<ChiTietMuaHang>();
        }
    
        public string MaPhieuMuaHang { get; set; }
        public string MaNPP { get; set; }
        public Nullable<System.DateTime> NgayLap { get; set; }
        public string NoCu { get; set; }
        public string NoMoi { get; set; }
        public Nullable<int> MaLoaiTien { get; set; }
        public string DieuKhoanThanhToan { get; set; }
        public Nullable<System.DateTime> HanThanhToan { get; set; }
        public string TongTien { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietMuaHang> ChiTietMuaHangs { get; set; }
        public virtual NhaPhanPhoi NhaPhanPhoi { get; set; }
    }
}