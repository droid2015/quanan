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
    
    public partial class SRM_DichVuKhachHang
    {
        public int DichVuKhachHangID { get; set; }
        public Nullable<int> DoiTacID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string NoiDung { get; set; }
        public string TieuDe { get; set; }
        public Nullable<bool> DaThucHien { get; set; }
        public Nullable<bool> LaLichHen { get; set; }
        public byte[] LastUpdate { get; set; }
        public Nullable<int> CpyID { get; set; }
    }
}