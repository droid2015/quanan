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
    
    public partial class NhomMatHang
    {
        public int NhomID { get; set; }
        public string MaNhomMH { get; set; }
        public string TenNhomMH { get; set; }
        public string MoTa { get; set; }
        public byte[] Icon { get; set; }
        public string TenMayIn { get; set; }
        public Nullable<int> LoaiNhomID { get; set; }
        public Nullable<bool> ChiTruTrongKho { get; set; }
        public byte[] LastUpdate { get; set; }
        public Nullable<int> CpyID { get; set; }
    }
}