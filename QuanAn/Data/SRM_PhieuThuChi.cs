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
    
    public partial class SRM_PhieuThuChi
    {
        public int PhieuThuChiID { get; set; }
        public string MaPhieu { get; set; }
        public Nullable<System.DateTime> NgayTaoPhieu { get; set; }
        public string MaChungTu { get; set; }
        public string SoSerial { get; set; }
        public Nullable<int> DoiTacID { get; set; }
        public string TenDoiTac { get; set; }
        public string DiaChiDoiTac { get; set; }
        public string MaSoThue { get; set; }
        public Nullable<int> SoLanIn { get; set; }
        public string Mota { get; set; }
        public Nullable<decimal> TienHang { get; set; }
        public Nullable<decimal> TienVAT { get; set; }
        public Nullable<decimal> TongTien { get; set; }
        public string FromID { get; set; }
        public Nullable<int> CpyID { get; set; }
        public byte[] LastUpdate { get; set; }
    }
}
