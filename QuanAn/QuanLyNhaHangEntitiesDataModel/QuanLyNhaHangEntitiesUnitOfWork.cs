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
    /// A QuanLyNhaHangEntitiesUnitOfWork instance that represents the run-time implementation of the IQuanLyNhaHangEntitiesUnitOfWork interface.
    /// </summary>
    public class QuanLyNhaHangEntitiesUnitOfWork : DbUnitOfWork<QuanLyNhaHangEntities>, IQuanLyNhaHangEntitiesUnitOfWork
    {

        /// <summary>
        /// Initializes a new instance of the QuanLyNhaHangEntitiesUnitOfWork class.
        /// </summary>
        /// <param name="context">An underlying DbContext.</param>
        public QuanLyNhaHangEntitiesUnitOfWork(QuanLyNhaHangEntities context)
            : base(context)
        {
        }

        IRepository<BanAn, int> IQuanLyNhaHangEntitiesUnitOfWork.BanAns
        {
            get { return GetRepository(x => x.Set<BanAn>(), x => x.BanAnID); }
        }

        IRepository<BanAnChiTiet, int> IQuanLyNhaHangEntitiesUnitOfWork.BanAnChiTiets
        {
            get { return GetRepository(x => x.Set<BanAnChiTiet>(), x => x.BanAnChiTietID); }
        }

        IRepository<BangLuong, int> IQuanLyNhaHangEntitiesUnitOfWork.BangLuongs
        {
            get { return GetRepository(x => x.Set<BangLuong>(), x => x.BangLuongID); }
        }

        IRepository<CaLamViec, int> IQuanLyNhaHangEntitiesUnitOfWork.CaLamViecs
        {
            get { return GetRepository(x => x.Set<CaLamViec>(), x => x.CaID); }
        }

        IRepository<ChamCong, int> IQuanLyNhaHangEntitiesUnitOfWork.ChamCongs
        {
            get { return GetRepository(x => x.Set<ChamCong>(), x => x.ChamCongID); }
        }

        IRepository<ChiTietKhoMatHang, int> IQuanLyNhaHangEntitiesUnitOfWork.ChiTietKhoMatHangs
        {
            get { return GetRepository(x => x.Set<ChiTietKhoMatHang>(), x => x.ID); }
        }

        IRepository<ChungTu, int> IQuanLyNhaHangEntitiesUnitOfWork.ChungTus
        {
            get { return GetRepository(x => x.Set<ChungTu>(), x => x.ChungTuID); }
        }

        IRepository<CRM_NguonKhach, int> IQuanLyNhaHangEntitiesUnitOfWork.CRM_NguonKhach
        {
            get { return GetRepository(x => x.Set<CRM_NguonKhach>(), x => x.NguonKhachID); }
        }

        IRepository<DanhSachChi, int> IQuanLyNhaHangEntitiesUnitOfWork.DanhSachChis
        {
            get { return GetRepository(x => x.Set<DanhSachChi>(), x => x.ChiID); }
        }

        IRepository<DanhSachThu, int> IQuanLyNhaHangEntitiesUnitOfWork.DanhSachThus
        {
            get { return GetRepository(x => x.Set<DanhSachThu>(), x => x.ThuID); }
        }

        IRepository<DatBanMenuChiTiet, int> IQuanLyNhaHangEntitiesUnitOfWork.DatBanMenuChiTiets
        {
            get { return GetRepository(x => x.Set<DatBanMenuChiTiet>(), x => x.DatBanMenuChiTietID); }
        }

        IRepository<DoiTac, int> IQuanLyNhaHangEntitiesUnitOfWork.DoiTacs
        {
            get { return GetRepository(x => x.Set<DoiTac>(), x => x.ID); }
        }

        IRepository<DonViTinh, int> IQuanLyNhaHangEntitiesUnitOfWork.DonViTinhs
        {
            get { return GetRepository(x => x.Set<DonViTinh>(), x => x.DonViTinhID); }
        }

        IRepository<DotKiemKe, int> IQuanLyNhaHangEntitiesUnitOfWork.DotKiemKes
        {
            get { return GetRepository(x => x.Set<DotKiemKe>(), x => x.DotKiemKeID); }
        }

        IReadOnlyRepository<dtproperty> IQuanLyNhaHangEntitiesUnitOfWork.dtproperties
        {
            get { return GetReadOnlyRepository(x => x.Set<dtproperty>()); }
        }

        IRepository<GiaoCA, int> IQuanLyNhaHangEntitiesUnitOfWork.GiaoCAs
        {
            get { return GetRepository(x => x.Set<GiaoCA>(), x => x.ID); }
        }

        IRepository<HangDeKhuyenMai, int> IQuanLyNhaHangEntitiesUnitOfWork.HangDeKhuyenMais
        {
            get { return GetRepository(x => x.Set<HangDeKhuyenMai>(), x => x.HangDeKhuyenMaiID); }
        }

        IRepository<HangDeTraLai, int> IQuanLyNhaHangEntitiesUnitOfWork.HangDeTraLais
        {
            get { return GetRepository(x => x.Set<HangDeTraLai>(), x => x.HangTraLaiID); }
        }

        IRepository<HoaDonBan, int> IQuanLyNhaHangEntitiesUnitOfWork.HoaDonBans
        {
            get { return GetRepository(x => x.Set<HoaDonBan>(), x => x.HoaDonID); }
        }

        IRepository<HoaDonBanChiTiet, int> IQuanLyNhaHangEntitiesUnitOfWork.HoaDonBanChiTiets
        {
            get { return GetRepository(x => x.Set<HoaDonBanChiTiet>(), x => x.HoaDonBanChiTietID); }
        }

        IRepository<HoaDonVAT, int> IQuanLyNhaHangEntitiesUnitOfWork.HoaDonVATs
        {
            get { return GetRepository(x => x.Set<HoaDonVAT>(), x => x.ID); }
        }

        IRepository<HoaHong, int> IQuanLyNhaHangEntitiesUnitOfWork.HoaHongs
        {
            get { return GetRepository(x => x.Set<HoaHong>(), x => x.HoaHongID); }
        }

        IRepository<K_TheKho, int> IQuanLyNhaHangEntitiesUnitOfWork.K_TheKho
        {
            get { return GetRepository(x => x.Set<K_TheKho>(), x => x.TheKhoID); }
        }

        IRepository<Kho, int> IQuanLyNhaHangEntitiesUnitOfWork.Khoes
        {
            get { return GetRepository(x => x.Set<Kho>(), x => x.KhoID); }
        }

        IRepository<KhoKhuVuc, int> IQuanLyNhaHangEntitiesUnitOfWork.KhoKhuVucs
        {
            get { return GetRepository(x => x.Set<KhoKhuVuc>(), x => x.ID); }
        }

        IRepository<KhuVucBan, int> IQuanLyNhaHangEntitiesUnitOfWork.KhuVucBans
        {
            get { return GetRepository(x => x.Set<KhuVucBan>(), x => x.KhuVucID); }
        }

        IRepository<KhuyenMai, int> IQuanLyNhaHangEntitiesUnitOfWork.KhuyenMais
        {
            get { return GetRepository(x => x.Set<KhuyenMai>(), x => x.KhuyenMaiID); }
        }

        IRepository<KiemKeKhoChiTiet, int> IQuanLyNhaHangEntitiesUnitOfWork.KiemKeKhoChiTiets
        {
            get { return GetRepository(x => x.Set<KiemKeKhoChiTiet>(), x => x.KiemKeKhoChiTietID); }
        }

        IRepository<KieuDoiTac, int> IQuanLyNhaHangEntitiesUnitOfWork.KieuDoiTacs
        {
            get { return GetRepository(x => x.Set<KieuDoiTac>(), x => x.ID); }
        }

        IRepository<LoaiNhomMatHang, int> IQuanLyNhaHangEntitiesUnitOfWork.LoaiNhomMatHangs
        {
            get { return GetRepository(x => x.Set<LoaiNhomMatHang>(), x => x.LoaiNhomID); }
        }

        IRepository<LoaiNhomMatHangChiTiet, int> IQuanLyNhaHangEntitiesUnitOfWork.LoaiNhomMatHangChiTiets
        {
            get { return GetRepository(x => x.Set<LoaiNhomMatHangChiTiet>(), x => x.ID); }
        }

        IRepository<LoaiTaiSan, Guid> IQuanLyNhaHangEntitiesUnitOfWork.LoaiTaiSans
        {
            get { return GetRepository(x => x.Set<LoaiTaiSan>(), x => x.LoaiTaiSanID); }
        }

        IRepository<LoaiTheVIP, int> IQuanLyNhaHangEntitiesUnitOfWork.LoaiTheVIPs
        {
            get { return GetRepository(x => x.Set<LoaiTheVIP>(), x => x.LoaiTheID); }
        }

        IRepository<LOG, int> IQuanLyNhaHangEntitiesUnitOfWork.LOGs
        {
            get { return GetRepository(x => x.Set<LOG>(), x => x.LogID); }
        }

        IRepository<MatHang, int> IQuanLyNhaHangEntitiesUnitOfWork.MatHangs
        {
            get { return GetRepository(x => x.Set<MatHang>(), x => x.MhID); }
        }

        IRepository<NguoiDaiDien, int> IQuanLyNhaHangEntitiesUnitOfWork.NguoiDaiDiens
        {
            get { return GetRepository(x => x.Set<NguoiDaiDien>(), x => x.NguoiDaiDienID); }
        }

        IRepository<NhanVien, int> IQuanLyNhaHangEntitiesUnitOfWork.NhanViens
        {
            get { return GetRepository(x => x.Set<NhanVien>(), x => x.NhanVienID); }
        }

        IRepository<NhomCa, int> IQuanLyNhaHangEntitiesUnitOfWork.NhomCas
        {
            get { return GetRepository(x => x.Set<NhomCa>(), x => x.NhomCaID); }
        }

        IRepository<NhomMatHang, int> IQuanLyNhaHangEntitiesUnitOfWork.NhomMatHangs
        {
            get { return GetRepository(x => x.Set<NhomMatHang>(), x => x.NhomID); }
        }

        IRepository<NhomThuChi, int> IQuanLyNhaHangEntitiesUnitOfWork.NhomThuChis
        {
            get { return GetRepository(x => x.Set<NhomThuChi>(), x => x.NhomThuChiID); }
        }

        IRepository<PhaChe, int> IQuanLyNhaHangEntitiesUnitOfWork.PhaChes
        {
            get { return GetRepository(x => x.Set<PhaChe>(), x => x.PhaCheID); }
        }

        IRepository<PhieuChi, int> IQuanLyNhaHangEntitiesUnitOfWork.PhieuChis
        {
            get { return GetRepository(x => x.Set<PhieuChi>(), x => x.PhieuChiID); }
        }

        IRepository<PhieuChuyenKho, int> IQuanLyNhaHangEntitiesUnitOfWork.PhieuChuyenKhoes
        {
            get { return GetRepository(x => x.Set<PhieuChuyenKho>(), x => x.PhieuChuyenKhoID); }
        }

        IRepository<PhieuDatBan, int> IQuanLyNhaHangEntitiesUnitOfWork.PhieuDatBans
        {
            get { return GetRepository(x => x.Set<PhieuDatBan>(), x => x.PhieuDatID); }
        }

        IRepository<PhieuDatBanChiTiet, int> IQuanLyNhaHangEntitiesUnitOfWork.PhieuDatBanChiTiets
        {
            get { return GetRepository(x => x.Set<PhieuDatBanChiTiet>(), x => x.PDChiTietID); }
        }

        IRepository<PhieuNhap, int> IQuanLyNhaHangEntitiesUnitOfWork.PhieuNhaps
        {
            get { return GetRepository(x => x.Set<PhieuNhap>(), x => x.PhieuNhapID); }
        }

        IRepository<PhieuNhapChiTiet, int> IQuanLyNhaHangEntitiesUnitOfWork.PhieuNhapChiTiets
        {
            get { return GetRepository(x => x.Set<PhieuNhapChiTiet>(), x => x.PhieuNhapChiTietID); }
        }

        IRepository<PhieuThu, int> IQuanLyNhaHangEntitiesUnitOfWork.PhieuThus
        {
            get { return GetRepository(x => x.Set<PhieuThu>(), x => x.PhieuThuID); }
        }

        IRepository<PhieuXuat, int> IQuanLyNhaHangEntitiesUnitOfWork.PhieuXuats
        {
            get { return GetRepository(x => x.Set<PhieuXuat>(), x => x.PhieuXuatID); }
        }

        IRepository<PhieuXuatChiTiet, int> IQuanLyNhaHangEntitiesUnitOfWork.PhieuXuatChiTiets
        {
            get { return GetRepository(x => x.Set<PhieuXuatChiTiet>(), x => x.PhieuXuatChiTietID); }
        }

        IRepository<PhongBan, int> IQuanLyNhaHangEntitiesUnitOfWork.PhongBans
        {
            get { return GetRepository(x => x.Set<PhongBan>(), x => x.PhongBanID); }
        }

        IRepository<PhuCapLuong, int> IQuanLyNhaHangEntitiesUnitOfWork.PhuCapLuongs
        {
            get { return GetRepository(x => x.Set<PhuCapLuong>(), x => x.PhuCapID); }
        }

        IRepository<PhuongThucThanhToan, int> IQuanLyNhaHangEntitiesUnitOfWork.PhuongThucThanhToans
        {
            get { return GetRepository(x => x.Set<PhuongThucThanhToan>(), x => x.PhuongThucID); }
        }

        IRepository<QuiDoiDonViTinh, int> IQuanLyNhaHangEntitiesUnitOfWork.QuiDoiDonViTinhs
        {
            get { return GetRepository(x => x.Set<QuiDoiDonViTinh>(), x => x.ID); }
        }

        IRepository<Quyen, int> IQuanLyNhaHangEntitiesUnitOfWork.Quyens
        {
            get { return GetRepository(x => x.Set<Quyen>(), x => x.QuyenID); }
        }

        IRepository<SRM_DichVuKhachHang, int> IQuanLyNhaHangEntitiesUnitOfWork.SRM_DichVuKhachHang
        {
            get { return GetRepository(x => x.Set<SRM_DichVuKhachHang>(), x => x.DichVuKhachHangID); }
        }

        IRepository<SRM_GiamTaiSan, Guid> IQuanLyNhaHangEntitiesUnitOfWork.SRM_GiamTaiSan
        {
            get { return GetRepository(x => x.Set<SRM_GiamTaiSan>(), x => x.GiamTaiSanID); }
        }

        IRepository<SRM_GiaNhaCC, int> IQuanLyNhaHangEntitiesUnitOfWork.SRM_GiaNhaCC
        {
            get { return GetRepository(x => x.Set<SRM_GiaNhaCC>(), x => x.ID); }
        }

        IRepository<SRM_HoaDonBanChiTietLog, int> IQuanLyNhaHangEntitiesUnitOfWork.SRM_HoaDonBanChiTietLog
        {
            get { return GetRepository(x => x.Set<SRM_HoaDonBanChiTietLog>(), x => x.HoaDonBanChiTietLogID); }
        }

        IRepository<SRM_KhachTraNoHoaDon, int> IQuanLyNhaHangEntitiesUnitOfWork.SRM_KhachTraNoHoaDon
        {
            get { return GetRepository(x => x.Set<SRM_KhachTraNoHoaDon>(), x => x.KhachTraNoHoaDonID); }
        }

        IRepository<SRM_KhauHaoTaiSan, int> IQuanLyNhaHangEntitiesUnitOfWork.SRM_KhauHaoTaiSan
        {
            get { return GetRepository(x => x.Set<SRM_KhauHaoTaiSan>(), x => x.KhauHaoID); }
        }

        IRepository<SRM_KhauHaoTaiSanChiTiet, int> IQuanLyNhaHangEntitiesUnitOfWork.SRM_KhauHaoTaiSanChiTiet
        {
            get { return GetRepository(x => x.Set<SRM_KhauHaoTaiSanChiTiet>(), x => x.KhauHaoChiTietID); }
        }

        IRepository<SRM_KhuyenMaiHoaDon, int> IQuanLyNhaHangEntitiesUnitOfWork.SRM_KhuyenMaiHoaDon
        {
            get { return GetRepository(x => x.Set<SRM_KhuyenMaiHoaDon>(), x => x.KhuyenMaiID); }
        }

        IRepository<SRM_NhomTaiSan, int> IQuanLyNhaHangEntitiesUnitOfWork.SRM_NhomTaiSan
        {
            get { return GetRepository(x => x.Set<SRM_NhomTaiSan>(), x => x.NhomID); }
        }

        IRepository<SRM_PhieuThuChi, int> IQuanLyNhaHangEntitiesUnitOfWork.SRM_PhieuThuChi
        {
            get { return GetRepository(x => x.Set<SRM_PhieuThuChi>(), x => x.PhieuThuChiID); }
        }

        IRepository<SRM_TaiSan, Guid> IQuanLyNhaHangEntitiesUnitOfWork.SRM_TaiSan
        {
            get { return GetRepository(x => x.Set<SRM_TaiSan>(), x => x.TaiSanID); }
        }

        IRepository<SRM_TangTaiSan, Guid> IQuanLyNhaHangEntitiesUnitOfWork.SRM_TangTaiSan
        {
            get { return GetRepository(x => x.Set<SRM_TangTaiSan>(), x => x.TangTaiSanID); }
        }

        IRepository<SRM_TinhTrangDoiTac, int> IQuanLyNhaHangEntitiesUnitOfWork.SRM_TinhTrangDoiTac
        {
            get { return GetRepository(x => x.Set<SRM_TinhTrangDoiTac>(), x => x.TinhTrangDoiTacID); }
        }

        IRepository<SRM_TinhTrangHangHoa, int> IQuanLyNhaHangEntitiesUnitOfWork.SRM_TinhTrangHangHoa
        {
            get { return GetRepository(x => x.Set<SRM_TinhTrangHangHoa>(), x => x.TinhTrangHangHoaID); }
        }

        IRepository<TheKho, int> IQuanLyNhaHangEntitiesUnitOfWork.TheKhoes
        {
            get { return GetRepository(x => x.Set<TheKho>(), x => x.TheKhoID); }
        }

        IRepository<TheVIP, int> IQuanLyNhaHangEntitiesUnitOfWork.TheVIPs
        {
            get { return GetRepository(x => x.Set<TheVIP>(), x => x.TheVIPID); }
        }

        IRepository<TheVIPChiTiet, int> IQuanLyNhaHangEntitiesUnitOfWork.TheVIPChiTiets
        {
            get { return GetRepository(x => x.Set<TheVIPChiTiet>(), x => x.TheVIPChiTietID); }
        }

        IRepository<ThongTinNH, int> IQuanLyNhaHangEntitiesUnitOfWork.ThongTinNHs
        {
            get { return GetRepository(x => x.Set<ThongTinNH>(), x => x.ID); }
        }

        IRepository<TienTe, int> IQuanLyNhaHangEntitiesUnitOfWork.TienTes
        {
            get { return GetRepository(x => x.Set<TienTe>(), x => x.IDCurr); }
        }

        IReadOnlyRepository<BanAn_PhieuDB> IQuanLyNhaHangEntitiesUnitOfWork.BanAn_PhieuDB
        {
            get { return GetReadOnlyRepository(x => x.Set<BanAn_PhieuDB>()); }
        }

        IReadOnlyRepository<BANAN_PHIEUDB_> IQuanLyNhaHangEntitiesUnitOfWork.BANAN_PHIEUDB_
        {
            get { return GetReadOnlyRepository(x => x.Set<BANAN_PHIEUDB_>()); }
        }

        IReadOnlyRepository<c1_28> IQuanLyNhaHangEntitiesUnitOfWork.c1_28
        {
            get { return GetReadOnlyRepository(x => x.Set<c1_28>()); }
        }

        IReadOnlyRepository<c1_HoaDonCT> IQuanLyNhaHangEntitiesUnitOfWork.c1_HoaDonCT
        {
            get { return GetReadOnlyRepository(x => x.Set<c1_HoaDonCT>()); }
        }

        IReadOnlyRepository<c2_HangTL_notIn> IQuanLyNhaHangEntitiesUnitOfWork.c2_HangTL_notIn
        {
            get { return GetReadOnlyRepository(x => x.Set<c2_HangTL_notIn>()); }
        }

        IReadOnlyRepository<c2_HDCT_HangTL> IQuanLyNhaHangEntitiesUnitOfWork.c2_HDCT_HangTL
        {
            get { return GetReadOnlyRepository(x => x.Set<c2_HDCT_HangTL>()); }
        }

        IReadOnlyRepository<cCN1> IQuanLyNhaHangEntitiesUnitOfWork.cCN1
        {
            get { return GetReadOnlyRepository(x => x.Set<cCN1>()); }
        }

        IReadOnlyRepository<cCN2> IQuanLyNhaHangEntitiesUnitOfWork.cCN2
        {
            get { return GetReadOnlyRepository(x => x.Set<cCN2>()); }
        }

        IReadOnlyRepository<cDTKV> IQuanLyNhaHangEntitiesUnitOfWork.cDTKVs
        {
            get { return GetReadOnlyRepository(x => x.Set<cDTKV>()); }
        }

        IReadOnlyRepository<CV1> IQuanLyNhaHangEntitiesUnitOfWork.CV1
        {
            get { return GetReadOnlyRepository(x => x.Set<CV1>()); }
        }

        IReadOnlyRepository<ketquakd_1> IQuanLyNhaHangEntitiesUnitOfWork.ketquakd_1
        {
            get { return GetReadOnlyRepository(x => x.Set<ketquakd_1>()); }
        }

        IReadOnlyRepository<kqkd_1Test> IQuanLyNhaHangEntitiesUnitOfWork.kqkd_1Test
        {
            get { return GetReadOnlyRepository(x => x.Set<kqkd_1Test>()); }
        }

        IReadOnlyRepository<kqkd_2> IQuanLyNhaHangEntitiesUnitOfWork.kqkd_2
        {
            get { return GetReadOnlyRepository(x => x.Set<kqkd_2>()); }
        }

        IReadOnlyRepository<kqkd_3> IQuanLyNhaHangEntitiesUnitOfWork.kqkd_3
        {
            get { return GetReadOnlyRepository(x => x.Set<kqkd_3>()); }
        }

        IReadOnlyRepository<kv> IQuanLyNhaHangEntitiesUnitOfWork.kvs
        {
            get { return GetReadOnlyRepository(x => x.Set<kv>()); }
        }

        IReadOnlyRepository<Nhap_Hang> IQuanLyNhaHangEntitiesUnitOfWork.Nhap_Hangs
        {
            get { return GetReadOnlyRepository(x => x.Set<Nhap_Hang>()); }
        }

        IReadOnlyRepository<Nhap_TK> IQuanLyNhaHangEntitiesUnitOfWork.Nhap_TK
        {
            get { return GetReadOnlyRepository(x => x.Set<Nhap_TK>()); }
        }

        IReadOnlyRepository<tb_ChiTietChi> IQuanLyNhaHangEntitiesUnitOfWork.tb_ChiTietChi
        {
            get { return GetReadOnlyRepository(x => x.Set<tb_ChiTietChi>()); }
        }

        IReadOnlyRepository<test_v20> IQuanLyNhaHangEntitiesUnitOfWork.test_v20
        {
            get { return GetReadOnlyRepository(x => x.Set<test_v20>()); }
        }

        IReadOnlyRepository<test_V20_1> IQuanLyNhaHangEntitiesUnitOfWork.test_V20_1
        {
            get { return GetReadOnlyRepository(x => x.Set<test_V20_1>()); }
        }

        IReadOnlyRepository<thang_v1> IQuanLyNhaHangEntitiesUnitOfWork.thang_v1
        {
            get { return GetReadOnlyRepository(x => x.Set<thang_v1>()); }
        }

        IReadOnlyRepository<TongChi_1> IQuanLyNhaHangEntitiesUnitOfWork.TongChi_1
        {
            get { return GetReadOnlyRepository(x => x.Set<TongChi_1>()); }
        }

        IReadOnlyRepository<TongChi_2> IQuanLyNhaHangEntitiesUnitOfWork.TongChi_2
        {
            get { return GetReadOnlyRepository(x => x.Set<TongChi_2>()); }
        }

        IReadOnlyRepository<TongGiaTri_PhieuXuat> IQuanLyNhaHangEntitiesUnitOfWork.TongGiaTri_PhieuXuat
        {
            get { return GetReadOnlyRepository(x => x.Set<TongGiaTri_PhieuXuat>()); }
        }

        IReadOnlyRepository<TongHangNhap> IQuanLyNhaHangEntitiesUnitOfWork.TongHangNhaps
        {
            get { return GetReadOnlyRepository(x => x.Set<TongHangNhap>()); }
        }

        IReadOnlyRepository<TongHangXuat> IQuanLyNhaHangEntitiesUnitOfWork.TongHangXuats
        {
            get { return GetReadOnlyRepository(x => x.Set<TongHangXuat>()); }
        }

        IReadOnlyRepository<View_1> IQuanLyNhaHangEntitiesUnitOfWork.View_1
        {
            get { return GetReadOnlyRepository(x => x.Set<View_1>()); }
        }

        IReadOnlyRepository<View_2> IQuanLyNhaHangEntitiesUnitOfWork.View_2
        {
            get { return GetReadOnlyRepository(x => x.Set<View_2>()); }
        }

        IReadOnlyRepository<View_4> IQuanLyNhaHangEntitiesUnitOfWork.View_4
        {
            get { return GetReadOnlyRepository(x => x.Set<View_4>()); }
        }

        IReadOnlyRepository<View_5> IQuanLyNhaHangEntitiesUnitOfWork.View_5
        {
            get { return GetReadOnlyRepository(x => x.Set<View_5>()); }
        }

        IReadOnlyRepository<View_6> IQuanLyNhaHangEntitiesUnitOfWork.View_6
        {
            get { return GetReadOnlyRepository(x => x.Set<View_6>()); }
        }

        IReadOnlyRepository<View_byGD> IQuanLyNhaHangEntitiesUnitOfWork.View_byGD
        {
            get { return GetReadOnlyRepository(x => x.Set<View_byGD>()); }
        }

        IReadOnlyRepository<view_doanhthutheogd> IQuanLyNhaHangEntitiesUnitOfWork.view_doanhthutheogd
        {
            get { return GetReadOnlyRepository(x => x.Set<view_doanhthutheogd>()); }
        }

        IReadOnlyRepository<View_lydoChi> IQuanLyNhaHangEntitiesUnitOfWork.View_lydoChi
        {
            get { return GetReadOnlyRepository(x => x.Set<View_lydoChi>()); }
        }

        IReadOnlyRepository<ViewMain> IQuanLyNhaHangEntitiesUnitOfWork.ViewMains
        {
            get { return GetReadOnlyRepository(x => x.Set<ViewMain>()); }
        }

        IReadOnlyRepository<Xuat_Hang> IQuanLyNhaHangEntitiesUnitOfWork.Xuat_Hangs
        {
            get { return GetReadOnlyRepository(x => x.Set<Xuat_Hang>()); }
        }

        IReadOnlyRepository<Xuat_TK> IQuanLyNhaHangEntitiesUnitOfWork.Xuat_TK
        {
            get { return GetReadOnlyRepository(x => x.Set<Xuat_TK>()); }
        }
    }
}
