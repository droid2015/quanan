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
    
    public partial class DoiTac
    {
        public int ID { get; set; }
        public string MaDoiTac { get; set; }
        public string TenDoiTac { get; set; }
        public string TenNguoiDaiDien { get; set; }
        public string Address { get; set; }
        public string DienThoai1 { get; set; }
        public string Fax { get; set; }
        public string ThuDienTu { get; set; }
        public string MaSoThue { get; set; }
        public Nullable<decimal> DT331 { get; set; }
        public Nullable<decimal> DT131 { get; set; }
        public Nullable<decimal> Ton331 { get; set; }
        public Nullable<decimal> Ton131 { get; set; }
        public Nullable<bool> CongNo { get; set; }
        public string DienThoai2 { get; set; }
        public Nullable<int> NhomDoiTacID { get; set; }
        public int KieuDoiTacID { get; set; }
        public Nullable<int> CpyID { get; set; }
        public Nullable<decimal> GioiHanNo { get; set; }
        public Nullable<int> NganHang { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public Nullable<bool> IsCaNhan { get; set; }
        public Nullable<int> ParentID { get; set; }
        public string GhiChu { get; set; }
        public Nullable<int> NhanVienID { get; set; }
        public Nullable<decimal> TongSoTienHienTai { get; set; }
        public Nullable<decimal> TongSoTien { get; set; }
        public byte[] LastUpdate { get; set; }
        public Nullable<int> TinhTrangID { get; set; }
        public Nullable<int> NhanVienChamSocID { get; set; }
        public Nullable<int> NguonKhachID { get; set; }
    }
}