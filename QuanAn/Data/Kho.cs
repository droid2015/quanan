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
    
    public partial class Kho
    {
        public int KhoID { get; set; }
        public string TenKho { get; set; }
        public string MoTa { get; set; }
        public string MaKho { get; set; }
        public Nullable<bool> IsUse { get; set; }
        public Nullable<int> NhanVienID { get; set; }
        public byte[] LastUpdate { get; set; }
        public Nullable<int> CpyID { get; set; }
        public Nullable<bool> KiemTraTinhTrangTon { get; set; }
    }
}