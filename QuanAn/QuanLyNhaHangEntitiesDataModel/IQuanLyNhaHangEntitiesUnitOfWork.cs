using System;
using System.Linq;
using System.Data;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Collections.Generic;
using QuanAn.Common.Utils;
using QuanAn.Common.DataModel;
using QuanAn.Common.DataModel.EntityFramework;
using QuanAn.Data;

namespace QuanAn.QuanLyNhaHangEntitiesDataModel
{
    /// <summary>
    /// IQuanLyNhaHangEntitiesUnitOfWork extends the IUnitOfWork interface with repositories representing specific entities.
    /// </summary>
    public interface IQuanLyNhaHangEntitiesUnitOfWork : IUnitOfWork
    {

        /// <summary>
        /// The BanAn entities repository.
        /// </summary>
        IRepository<BanAn, int> BanAns { get; }

        /// <summary>
        /// The BanAnChiTiet entities repository.
        /// </summary>
        IRepository<BanAnChiTiet, int> BanAnChiTiets { get; }

        /// <summary>
        /// The BangLuong entities repository.
        /// </summary>
        IRepository<BangLuong, int> BangLuongs { get; }

        /// <summary>
        /// The CaLamViec entities repository.
        /// </summary>
        IRepository<CaLamViec, int> CaLamViecs { get; }

        /// <summary>
        /// The ChamCong entities repository.
        /// </summary>
        IRepository<ChamCong, int> ChamCongs { get; }

        /// <summary>
        /// The ChiTietKhoMatHang entities repository.
        /// </summary>
        IRepository<ChiTietKhoMatHang, int> ChiTietKhoMatHangs { get; }

        /// <summary>
        /// The ChungTu entities repository.
        /// </summary>
        IRepository<ChungTu, int> ChungTus { get; }

        /// <summary>
        /// The CRM_NguonKhach entities repository.
        /// </summary>
        IRepository<CRM_NguonKhach, int> CRM_NguonKhach { get; }

        /// <summary>
        /// The DanhSachChi entities repository.
        /// </summary>
        IRepository<DanhSachChi, int> DanhSachChis { get; }

        /// <summary>
        /// The DanhSachThu entities repository.
        /// </summary>
        IRepository<DanhSachThu, int> DanhSachThus { get; }

        /// <summary>
        /// The DatBanMenuChiTiet entities repository.
        /// </summary>
        IRepository<DatBanMenuChiTiet, int> DatBanMenuChiTiets { get; }

        /// <summary>
        /// The DoiTac entities repository.
        /// </summary>
        IRepository<DoiTac, int> DoiTacs { get; }

        /// <summary>
        /// The DonViTinh entities repository.
        /// </summary>
        IRepository<DonViTinh, int> DonViTinhs { get; }

        /// <summary>
        /// The DotKiemKe entities repository.
        /// </summary>
        IRepository<DotKiemKe, int> DotKiemKes { get; }

        /// <summary>
        /// The dtproperty entities repository.
        /// </summary>
        IReadOnlyRepository<dtproperty> dtproperties { get; }

        /// <summary>
        /// The GiaoCA entities repository.
        /// </summary>
        IRepository<GiaoCA, int> GiaoCAs { get; }

        /// <summary>
        /// The HangDeKhuyenMai entities repository.
        /// </summary>
        IRepository<HangDeKhuyenMai, int> HangDeKhuyenMais { get; }

        /// <summary>
        /// The HangDeTraLai entities repository.
        /// </summary>
        IRepository<HangDeTraLai, int> HangDeTraLais { get; }

        /// <summary>
        /// The HoaDonBan entities repository.
        /// </summary>
        IRepository<HoaDonBan, int> HoaDonBans { get; }

        /// <summary>
        /// The HoaDonBanChiTiet entities repository.
        /// </summary>
        IRepository<HoaDonBanChiTiet, int> HoaDonBanChiTiets { get; }

        /// <summary>
        /// The HoaDonVAT entities repository.
        /// </summary>
        IRepository<HoaDonVAT, int> HoaDonVATs { get; }

        /// <summary>
        /// The HoaHong entities repository.
        /// </summary>
        IRepository<HoaHong, int> HoaHongs { get; }

        /// <summary>
        /// The K_TheKho entities repository.
        /// </summary>
        IRepository<K_TheKho, int> K_TheKho { get; }

        /// <summary>
        /// The Kho entities repository.
        /// </summary>
        IRepository<Kho, int> Khoes { get; }

        /// <summary>
        /// The KhoKhuVuc entities repository.
        /// </summary>
        IRepository<KhoKhuVuc, int> KhoKhuVucs { get; }

        /// <summary>
        /// The KhuVucBan entities repository.
        /// </summary>
        IRepository<KhuVucBan, int> KhuVucBans { get; }

        /// <summary>
        /// The KhuyenMai entities repository.
        /// </summary>
        IRepository<KhuyenMai, int> KhuyenMais { get; }

        /// <summary>
        /// The KiemKeKhoChiTiet entities repository.
        /// </summary>
        IRepository<KiemKeKhoChiTiet, int> KiemKeKhoChiTiets { get; }

        /// <summary>
        /// The KieuDoiTac entities repository.
        /// </summary>
        IRepository<KieuDoiTac, int> KieuDoiTacs { get; }

        /// <summary>
        /// The LoaiNhomMatHang entities repository.
        /// </summary>
        IRepository<LoaiNhomMatHang, int> LoaiNhomMatHangs { get; }

        /// <summary>
        /// The LoaiNhomMatHangChiTiet entities repository.
        /// </summary>
        IRepository<LoaiNhomMatHangChiTiet, int> LoaiNhomMatHangChiTiets { get; }

        /// <summary>
        /// The LoaiTaiSan entities repository.
        /// </summary>
        IRepository<LoaiTaiSan, Guid> LoaiTaiSans { get; }

        /// <summary>
        /// The LoaiTheVIP entities repository.
        /// </summary>
        IRepository<LoaiTheVIP, int> LoaiTheVIPs { get; }

        /// <summary>
        /// The LOG entities repository.
        /// </summary>
        IRepository<LOG, int> LOGs { get; }

        /// <summary>
        /// The MatHang entities repository.
        /// </summary>
        IRepository<MatHang, int> MatHangs { get; }

        /// <summary>
        /// The NguoiDaiDien entities repository.
        /// </summary>
        IRepository<NguoiDaiDien, int> NguoiDaiDiens { get; }

        /// <summary>
        /// The NhanVien entities repository.
        /// </summary>
        IRepository<NhanVien, int> NhanViens { get; }

        /// <summary>
        /// The NhomCa entities repository.
        /// </summary>
        IRepository<NhomCa, int> NhomCas { get; }

        /// <summary>
        /// The NhomMatHang entities repository.
        /// </summary>
        IRepository<NhomMatHang, int> NhomMatHangs { get; }

        /// <summary>
        /// The NhomThuChi entities repository.
        /// </summary>
        IRepository<NhomThuChi, int> NhomThuChis { get; }

        /// <summary>
        /// The PhaChe entities repository.
        /// </summary>
        IRepository<PhaChe, int> PhaChes { get; }

        /// <summary>
        /// The PhieuChi entities repository.
        /// </summary>
        IRepository<PhieuChi, int> PhieuChis { get; }

        /// <summary>
        /// The PhieuChuyenKho entities repository.
        /// </summary>
        IRepository<PhieuChuyenKho, int> PhieuChuyenKhoes { get; }

        /// <summary>
        /// The PhieuDatBan entities repository.
        /// </summary>
        IRepository<PhieuDatBan, int> PhieuDatBans { get; }

        /// <summary>
        /// The PhieuDatBanChiTiet entities repository.
        /// </summary>
        IRepository<PhieuDatBanChiTiet, int> PhieuDatBanChiTiets { get; }

        /// <summary>
        /// The PhieuNhap entities repository.
        /// </summary>
        IRepository<PhieuNhap, int> PhieuNhaps { get; }

        /// <summary>
        /// The PhieuNhapChiTiet entities repository.
        /// </summary>
        IRepository<PhieuNhapChiTiet, int> PhieuNhapChiTiets { get; }

        /// <summary>
        /// The PhieuThu entities repository.
        /// </summary>
        IRepository<PhieuThu, int> PhieuThus { get; }

        /// <summary>
        /// The PhieuXuat entities repository.
        /// </summary>
        IRepository<PhieuXuat, int> PhieuXuats { get; }

        /// <summary>
        /// The PhieuXuatChiTiet entities repository.
        /// </summary>
        IRepository<PhieuXuatChiTiet, int> PhieuXuatChiTiets { get; }

        /// <summary>
        /// The PhongBan entities repository.
        /// </summary>
        IRepository<PhongBan, int> PhongBans { get; }

        /// <summary>
        /// The PhuCapLuong entities repository.
        /// </summary>
        IRepository<PhuCapLuong, int> PhuCapLuongs { get; }

        /// <summary>
        /// The PhuongThucThanhToan entities repository.
        /// </summary>
        IRepository<PhuongThucThanhToan, int> PhuongThucThanhToans { get; }

        /// <summary>
        /// The QuiDoiDonViTinh entities repository.
        /// </summary>
        IRepository<QuiDoiDonViTinh, int> QuiDoiDonViTinhs { get; }

        /// <summary>
        /// The Quyen entities repository.
        /// </summary>
        IRepository<Quyen, int> Quyens { get; }

        /// <summary>
        /// The SRM_DichVuKhachHang entities repository.
        /// </summary>
        IRepository<SRM_DichVuKhachHang, int> SRM_DichVuKhachHang { get; }

        /// <summary>
        /// The SRM_GiamTaiSan entities repository.
        /// </summary>
        IRepository<SRM_GiamTaiSan, Guid> SRM_GiamTaiSan { get; }

        /// <summary>
        /// The SRM_GiaNhaCC entities repository.
        /// </summary>
        IRepository<SRM_GiaNhaCC, int> SRM_GiaNhaCC { get; }

        /// <summary>
        /// The SRM_HoaDonBanChiTietLog entities repository.
        /// </summary>
        IRepository<SRM_HoaDonBanChiTietLog, int> SRM_HoaDonBanChiTietLog { get; }

        /// <summary>
        /// The SRM_KhachTraNoHoaDon entities repository.
        /// </summary>
        IRepository<SRM_KhachTraNoHoaDon, int> SRM_KhachTraNoHoaDon { get; }

        /// <summary>
        /// The SRM_KhauHaoTaiSan entities repository.
        /// </summary>
        IRepository<SRM_KhauHaoTaiSan, int> SRM_KhauHaoTaiSan { get; }

        /// <summary>
        /// The SRM_KhauHaoTaiSanChiTiet entities repository.
        /// </summary>
        IRepository<SRM_KhauHaoTaiSanChiTiet, int> SRM_KhauHaoTaiSanChiTiet { get; }

        /// <summary>
        /// The SRM_KhuyenMaiHoaDon entities repository.
        /// </summary>
        IRepository<SRM_KhuyenMaiHoaDon, int> SRM_KhuyenMaiHoaDon { get; }

        /// <summary>
        /// The SRM_NhomTaiSan entities repository.
        /// </summary>
        IRepository<SRM_NhomTaiSan, int> SRM_NhomTaiSan { get; }

        /// <summary>
        /// The SRM_PhieuThuChi entities repository.
        /// </summary>
        IRepository<SRM_PhieuThuChi, int> SRM_PhieuThuChi { get; }

        /// <summary>
        /// The SRM_TaiSan entities repository.
        /// </summary>
        IRepository<SRM_TaiSan, Guid> SRM_TaiSan { get; }

        /// <summary>
        /// The SRM_TangTaiSan entities repository.
        /// </summary>
        IRepository<SRM_TangTaiSan, Guid> SRM_TangTaiSan { get; }

        /// <summary>
        /// The SRM_TinhTrangDoiTac entities repository.
        /// </summary>
        IRepository<SRM_TinhTrangDoiTac, int> SRM_TinhTrangDoiTac { get; }

        /// <summary>
        /// The SRM_TinhTrangHangHoa entities repository.
        /// </summary>
        IRepository<SRM_TinhTrangHangHoa, int> SRM_TinhTrangHangHoa { get; }

        /// <summary>
        /// The TheKho entities repository.
        /// </summary>
        IRepository<TheKho, int> TheKhoes { get; }

        /// <summary>
        /// The TheVIP entities repository.
        /// </summary>
        IRepository<TheVIP, int> TheVIPs { get; }

        /// <summary>
        /// The TheVIPChiTiet entities repository.
        /// </summary>
        IRepository<TheVIPChiTiet, int> TheVIPChiTiets { get; }

        /// <summary>
        /// The ThongTinNH entities repository.
        /// </summary>
        IRepository<ThongTinNH, int> ThongTinNHs { get; }

        /// <summary>
        /// The TienTe entities repository.
        /// </summary>
        IRepository<TienTe, int> TienTes { get; }

        /// <summary>
        /// The BanAn_PhieuDB entities repository.
        /// </summary>
        IReadOnlyRepository<BanAn_PhieuDB> BanAn_PhieuDB { get; }

        /// <summary>
        /// The BANAN_PHIEUDB_ entities repository.
        /// </summary>
        IReadOnlyRepository<BANAN_PHIEUDB_> BANAN_PHIEUDB_ { get; }

        /// <summary>
        /// The c1_28 entities repository.
        /// </summary>
        IReadOnlyRepository<c1_28> c1_28 { get; }

        /// <summary>
        /// The c1_HoaDonCT entities repository.
        /// </summary>
        IReadOnlyRepository<c1_HoaDonCT> c1_HoaDonCT { get; }

        /// <summary>
        /// The c2_HangTL_notIn entities repository.
        /// </summary>
        IReadOnlyRepository<c2_HangTL_notIn> c2_HangTL_notIn { get; }

        /// <summary>
        /// The c2_HDCT_HangTL entities repository.
        /// </summary>
        IReadOnlyRepository<c2_HDCT_HangTL> c2_HDCT_HangTL { get; }

        /// <summary>
        /// The cCN1 entities repository.
        /// </summary>
        IReadOnlyRepository<cCN1> cCN1 { get; }

        /// <summary>
        /// The cCN2 entities repository.
        /// </summary>
        IReadOnlyRepository<cCN2> cCN2 { get; }

        /// <summary>
        /// The cDTKV entities repository.
        /// </summary>
        IReadOnlyRepository<cDTKV> cDTKVs { get; }

        /// <summary>
        /// The CV1 entities repository.
        /// </summary>
        IReadOnlyRepository<CV1> CV1 { get; }

        /// <summary>
        /// The ketquakd_1 entities repository.
        /// </summary>
        IReadOnlyRepository<ketquakd_1> ketquakd_1 { get; }

        /// <summary>
        /// The kqkd_1Test entities repository.
        /// </summary>
        IReadOnlyRepository<kqkd_1Test> kqkd_1Test { get; }

        /// <summary>
        /// The kqkd_2 entities repository.
        /// </summary>
        IReadOnlyRepository<kqkd_2> kqkd_2 { get; }

        /// <summary>
        /// The kqkd_3 entities repository.
        /// </summary>
        IReadOnlyRepository<kqkd_3> kqkd_3 { get; }

        /// <summary>
        /// The kv entities repository.
        /// </summary>
        IReadOnlyRepository<kv> kvs { get; }

        /// <summary>
        /// The Nhap_Hang entities repository.
        /// </summary>
        IReadOnlyRepository<Nhap_Hang> Nhap_Hangs { get; }

        /// <summary>
        /// The Nhap_TK entities repository.
        /// </summary>
        IReadOnlyRepository<Nhap_TK> Nhap_TK { get; }

        /// <summary>
        /// The tb_ChiTietChi entities repository.
        /// </summary>
        IReadOnlyRepository<tb_ChiTietChi> tb_ChiTietChi { get; }

        /// <summary>
        /// The test_v20 entities repository.
        /// </summary>
        IReadOnlyRepository<test_v20> test_v20 { get; }

        /// <summary>
        /// The test_V20_1 entities repository.
        /// </summary>
        IReadOnlyRepository<test_V20_1> test_V20_1 { get; }

        /// <summary>
        /// The thang_v1 entities repository.
        /// </summary>
        IReadOnlyRepository<thang_v1> thang_v1 { get; }

        /// <summary>
        /// The TongChi_1 entities repository.
        /// </summary>
        IReadOnlyRepository<TongChi_1> TongChi_1 { get; }

        /// <summary>
        /// The TongChi_2 entities repository.
        /// </summary>
        IReadOnlyRepository<TongChi_2> TongChi_2 { get; }

        /// <summary>
        /// The TongGiaTri_PhieuXuat entities repository.
        /// </summary>
        IReadOnlyRepository<TongGiaTri_PhieuXuat> TongGiaTri_PhieuXuat { get; }

        /// <summary>
        /// The TongHangNhap entities repository.
        /// </summary>
        IReadOnlyRepository<TongHangNhap> TongHangNhaps { get; }

        /// <summary>
        /// The TongHangXuat entities repository.
        /// </summary>
        IReadOnlyRepository<TongHangXuat> TongHangXuats { get; }

        /// <summary>
        /// The View_1 entities repository.
        /// </summary>
        IReadOnlyRepository<View_1> View_1 { get; }

        /// <summary>
        /// The View_2 entities repository.
        /// </summary>
        IReadOnlyRepository<View_2> View_2 { get; }

        /// <summary>
        /// The View_4 entities repository.
        /// </summary>
        IReadOnlyRepository<View_4> View_4 { get; }

        /// <summary>
        /// The View_5 entities repository.
        /// </summary>
        IReadOnlyRepository<View_5> View_5 { get; }

        /// <summary>
        /// The View_6 entities repository.
        /// </summary>
        IReadOnlyRepository<View_6> View_6 { get; }

        /// <summary>
        /// The View_byGD entities repository.
        /// </summary>
        IReadOnlyRepository<View_byGD> View_byGD { get; }

        /// <summary>
        /// The view_doanhthutheogd entities repository.
        /// </summary>
        IReadOnlyRepository<view_doanhthutheogd> view_doanhthutheogd { get; }

        /// <summary>
        /// The View_lydoChi entities repository.
        /// </summary>
        IReadOnlyRepository<View_lydoChi> View_lydoChi { get; }

        /// <summary>
        /// The ViewMain entities repository.
        /// </summary>
        IReadOnlyRepository<ViewMain> ViewMains { get; }

        /// <summary>
        /// The Xuat_Hang entities repository.
        /// </summary>
        IReadOnlyRepository<Xuat_Hang> Xuat_Hangs { get; }

        /// <summary>
        /// The Xuat_TK entities repository.
        /// </summary>
        IReadOnlyRepository<Xuat_TK> Xuat_TK { get; }
    }
}
