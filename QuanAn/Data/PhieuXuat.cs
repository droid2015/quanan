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
    
    public partial class PhieuXuat
    {
        public int PhieuXuatID { get; set; }
        public string MaPhieuXuat { get; set; }
        public int NhanVienID { get; set; }
        public Nullable<System.DateTime> NgayLapPhieu { get; set; }
        public string ChuY { get; set; }
        public Nullable<int> NhaCungCapID { get; set; }
        public Nullable<decimal> TongGiaTri { get; set; }
        public Nullable<decimal> VAT { get; set; }
        public Nullable<bool> CongNo { get; set; }
        public string NguoiNhanHang { get; set; }
        public int KieuXuat { get; set; }
        public string FromID { get; set; }
        public Nullable<int> CpyID { get; set; }
        public Nullable<System.DateTime> HanThanhToan { get; set; }
        public int KhoID { get; set; }
        public Nullable<decimal> TienDaTra { get; set; }
        public byte[] LastUpdate { get; set; }
        public Nullable<decimal> TienThanhToan { get; set; }
    }
}
