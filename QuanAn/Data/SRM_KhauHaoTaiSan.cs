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
    
    public partial class SRM_KhauHaoTaiSan
    {
        public int KhauHaoID { get; set; }
        public string MaKhauHao { get; set; }
        public Nullable<System.DateTime> NgayLap { get; set; }
        public string GhiChu { get; set; }
        public Nullable<decimal> TongTienKhauHao { get; set; }
        public Nullable<int> NamTinhKhauHao { get; set; }
        public Nullable<int> ThangTinhKhauHao { get; set; }
        public Nullable<int> CpyID { get; set; }
        public byte[] LastUpdate { get; set; }
    }
}