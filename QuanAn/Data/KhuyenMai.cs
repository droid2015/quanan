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
    
    public partial class KhuyenMai
    {
        public int KhuyenMaiID { get; set; }
        public string MhID { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public string NgayTrongTuan { get; set; }
        public Nullable<System.DateTime> FromTime { get; set; }
        public Nullable<System.DateTime> ToTime { get; set; }
        public Nullable<decimal> Giam { get; set; }
        public string Mua { get; set; }
        public Nullable<int> KieuKhuyenMai { get; set; }
        public string TenDotKhuyenMai { get; set; }
        public Nullable<bool> IsAvailable { get; set; }
        public Nullable<int> CpyID { get; set; }
        public byte[] LastUpdate { get; set; }
        public Nullable<bool> KhuyenMaiTheoDong { get; set; }
    }
}
