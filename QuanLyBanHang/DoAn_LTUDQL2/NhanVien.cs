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
    
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            this.BanHangs = new HashSet<BanHang>();
            this.NhanVien1 = new HashSet<NhanVien>();
            this.NhatKiHeThongs = new HashSet<NhatKiHeThong>();
            this.NhatKiHeThongs1 = new HashSet<NhatKiHeThong>();
            this.TaiKhoanNguoiDungs = new HashSet<TaiKhoanNguoiDung>();
        }
    
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public Nullable<int> DocThan { get; set; }
        public string ChucVu { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string DienThoai { get; set; }
        public string DiDong { get; set; }
        public string DienGiai { get; set; }
        public string MaBP { get; set; }
        public string MaNVQL { get; set; }
        public Nullable<int> TinhTrangQL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BanHang> BanHangs { get; set; }
        public virtual BoPhan BoPhan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhanVien> NhanVien1 { get; set; }
        public virtual NhanVien NhanVien2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhatKiHeThong> NhatKiHeThongs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhatKiHeThong> NhatKiHeThongs1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaiKhoanNguoiDung> TaiKhoanNguoiDungs { get; set; }
    }
}
