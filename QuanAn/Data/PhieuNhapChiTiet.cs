//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanAn.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhieuNhapChiTiet
    {
        public int PhieuNhapChiTietID { get; set; }
        public int PhieuNhapID { get; set; }
        public int mhID { get; set; }
        public Nullable<decimal> SoLuong { get; set; }
        public Nullable<decimal> Gia { get; set; }
        public Nullable<decimal> GiamGia { get; set; }
        public Nullable<decimal> VAT { get; set; }
        public Nullable<System.DateTime> HanSuDung { get; set; }
        public string GhiChu { get; set; }
        public Nullable<int> DonViTinhID { get; set; }
        public byte[] LastUpdate { get; set; }
        public Nullable<int> CpyID { get; set; }
        public Nullable<decimal> SoLuongPhu { get; set; }
        public Nullable<decimal> DonGiaPhu { get; set; }
        public Nullable<decimal> SoLuongCon { get; set; }
    
        public virtual PhieuNhap PhieuNhap { get; set; }
    }
}
