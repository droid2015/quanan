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
    
    public partial class ChamCong
    {
        public int ChamCongID { get; set; }
        public int NhanVienID { get; set; }
        public System.DateTime NgayChamCong { get; set; }
        public int CaID { get; set; }
        public string DanhGia { get; set; }
        public Nullable<int> CpyID { get; set; }
        public Nullable<System.DateTime> GioDen { get; set; }
        public Nullable<System.DateTime> GioVe { get; set; }
        public Nullable<decimal> TongSoPhut { get; set; }
        public string Data { get; set; }
        public byte[] LastUpdate { get; set; }
    }
}