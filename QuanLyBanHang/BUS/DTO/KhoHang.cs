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
    
    public partial class KhoHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhoHang()
        {
            this.HangHoa = new HashSet<HangHoa>();
            this.MuaHang = new HashSet<MuaHang>();
        }
    
        public string MaKho { get; set; }
        public string TenKho { get; set; }
        public string NguoiLienHe { get; set; }
        public string DiaChi { get; set; }
        public string DTBan { get; set; }
        public string DTDD { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string NguoiQuanLy { get; set; }
        public string DienGiai { get; set; }
        public Nullable<int> TinhTrangQuanLy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HangHoa> HangHoa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MuaHang> MuaHang { get; set; }
    }
}