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
    /// A QuanLyNhaHangEntitiesDesignTimeUnitOfWork instance that represents the design-time implementation of the IQuanLyNhaHangEntitiesUnitOfWork interface.
    /// </summary>
    public class QuanLyNhaHangEntitiesDesignTimeUnitOfWork : DesignTimeUnitOfWork, IQuanLyNhaHangEntitiesUnitOfWork
    {

        /// <summary>
        /// Initializes a new instance of the QuanLyNhaHangEntitiesDesignTimeUnitOfWork class.
        /// </summary>
        public QuanLyNhaHangEntitiesDesignTimeUnitOfWork()
        {
        }

        IRepository<BanAn, int> IQuanLyNhaHangEntitiesUnitOfWork.BanAns
        {
            get { return GetRepository((BanAn x) => x.BanAnID); }
        }

        IRepository<BanAnChiTiet, int> IQuanLyNhaHangEntitiesUnitOfWork.BanAnChiTiets
        {
            get { return GetRepository((BanAnChiTiet x) => x.BanAnChiTietID); }
        }

        IRepository<BangLuong, int> IQuanLyNhaHangEntitiesUnitOfWork.BangLuongs
        {
            get { return GetRepository((BangLuong x) => x.BangLuongID); }
        }

        IRepository<CaLamViec, int> IQuanLyNhaHangEntitiesUnitOfWork.CaLamViecs
        {
            get { return GetRepository((CaLamViec x) => x.CaID); }
        }

        IRepository<ChamCong, int> IQuanLyNhaHangEntitiesUnitOfWork.ChamCongs
        {
            get { return GetRepository((ChamCong x) => x.ChamCongID); }
        }

        IRepository<ChiTietKhoMatHang, int> IQuanLyNhaHangEntitiesUnitOfWork.ChiTietKhoMatHangs
        {
            get { return GetRepository((ChiTietKhoMatHang x) => x.ID); }
        }

        IRepository<ChungTu, int> IQuanLyNhaHangEntitiesUnitOfWork.ChungTus
        {
            get { return GetRepository((ChungTu x) => x.ChungTuID); }
        }

        IRepository<CRM_NguonKhach, int> IQuanLyNhaHangEntitiesUnitOfWork.CRM_NguonKhach
        {
            get { return GetRepository((CRM_NguonKhach x) => x.NguonKhachID); }
        }

        IRepository<DanhSachChi, int> IQuanLyNhaHangEntitiesUnitOfWork.DanhSachChis
        {
            get { return GetRepository((DanhSachChi x) => x.ChiID); }
        }

        IRepository<DanhSachThu, int> IQuanLyNhaHangEntitiesUnitOfWork.DanhSachThus
        {
            get { return GetRepository((DanhSachThu x) => x.ThuID); }
        }

        IRepository<DatBanMenuChiTiet, int> IQuanLyNhaHangEntitiesUnitOfWork.DatBanMenuChiTiets
        {
            get { return GetRepository((DatBanMenuChiTiet x) => x.DatBanMenuChiTietID); }
        }

        IRepository<DoiTac, int> IQuanLyNhaHangEntitiesUnitOfWork.DoiTacs
        {
            get { return GetRepository((DoiTac x) => x.ID); }
        }

        IRepository<DonViTinh, int> IQuanLyNhaHangEntitiesUnitOfWork.DonViTinhs
        {
            get { return GetRepository((DonViTinh x) => x.DonViTinhID); }
        }

        IRepository<DotKiemKe, int> IQuanLyNhaHangEntitiesUnitOfWork.DotKiemKes
        {
            get { return GetRepository((DotKiemKe x) => x.DotKiemKeID); }
        }

        IReadOnlyRepository<dtproperty> IQuanLyNhaHangEntitiesUnitOfWork.dtproperties
        {
            get { return GetReadOnlyRepository<dtproperty>(); }
        }

        IRepository<GiaoCA, int> IQuanLyNhaHangEntitiesUnitOfWork.GiaoCAs
        {
            get { return GetRepository((GiaoCA x) => x.ID); }
        }

        IRepository<HangDeKhuyenMai, int> IQuanLyNhaHangEntitiesUnitOfWork.HangDeKhuyenMais
        {
            get { return GetRepository((HangDeKhuyenMai x) => x.HangDeKhuyenMaiID); }
        }

        IRepository<HangDeTraLai, int> IQuanLyNhaHangEntitiesUnitOfWork.HangDeTraLais
        {
            get { return GetRepository((HangDeTraLai x) => x.HangTraLaiID); }
        }

        IRepository<HoaDonBan, int> IQuanLyNhaHangEntitiesUnitOfWork.HoaDonBans
        {
            get { return GetRepository((HoaDonBan x) => x.HoaDonID); }
        }

        IRepository<HoaDonBanChiTiet, int> IQuanLyNhaHangEntitiesUnitOfWork.HoaDonBanChiTiets
        {
            get { return GetRepository((HoaDonBanChiTiet x) => x.HoaDonBanChiTietID); }
        }

        IRepository<HoaDonVAT, int> IQuanLyNhaHangEntitiesUnitOfWork.HoaDonVATs
        {
            get { return GetRepository((HoaDonVAT x) => x.ID); }
        }

        IRepository<HoaHong, int> IQuanLyNhaHangEntitiesUnitOfWork.HoaHongs
        {
            get { return GetRepository((HoaHong x) => x.HoaHongID); }
        }

        IRepository<K_TheKho, int> IQuanLyNhaHangEntitiesUnitOfWork.K_TheKho
        {
            get { return GetRepository((K_TheKho x) => x.TheKhoID); }
        }

        IRepository<Kho, int> IQuanLyNhaHangEntitiesUnitOfWork.Khoes
        {
            get { return GetRepository((Kho x) => x.KhoID); }
        }

        IRepository<KhoKhuVuc, int> IQuanLyNhaHangEntitiesUnitOfWork.KhoKhuVucs
        {
            get { return GetRepository((KhoKhuVuc x) => x.ID); }
        }

        IRepository<KhuVucBan, int> IQuanLyNhaHangEntitiesUnitOfWork.KhuVucBans
        {
            get { return GetRepository((KhuVucBan x) => x.KhuVucID); }
        }

        IRepository<KhuyenMai, int> IQuanLyNhaHangEntitiesUnitOfWork.KhuyenMais
        {
            get { return GetRepository((KhuyenMai x) => x.KhuyenMaiID); }
        }

        IRepository<KiemKeKhoChiTiet, int> IQuanLyNhaHangEntitiesUnitOfWork.KiemKeKhoChiTiets
        {
            get { return GetRepository((KiemKeKhoChiTiet x) => x.KiemKeKhoChiTietID); }
        }

        IRepository<KieuDoiTac, int> IQuanLyNhaHangEntitiesUnitOfWork.KieuDoiTacs
        {
            get { return GetRepository((KieuDoiTac x) => x.ID); }
        }

        IRepository<LoaiNhomMatHang, int> IQuanLyNhaHangEntitiesUnitOfWork.LoaiNhomMatHangs
        {
            get { return GetRepository((LoaiNhomMatHang x) => x.LoaiNhomID); }
        }

        IRepository<LoaiNhomMatHangChiTiet, int> IQuanLyNhaHangEntitiesUnitOfWork.LoaiNhomMatHangChiTiets
        {
            get { return GetRepository((LoaiNhomMatHangChiTiet x) => x.ID); }
        }

        IRepository<LoaiTaiSan, Guid> IQuanLyNhaHangEntitiesUnitOfWork.LoaiTaiSans
        {
            get { return GetRepository((LoaiTaiSan x) => x.LoaiTaiSanID); }
        }

        IRepository<LoaiTheVIP, int> IQuanLyNhaHangEntitiesUnitOfWork.LoaiTheVIPs
        {
            get { return GetRepository((LoaiTheVIP x) => x.LoaiTheID); }
        }

        IRepository<LOG, int> IQuanLyNhaHangEntitiesUnitOfWork.LOGs
        {
            get { return GetRepository((LOG x) => x.LogID); }
        }

        IRepository<MatHang, int> IQuanLyNhaHangEntitiesUnitOfWork.MatHangs
        {
            get { return GetRepository((MatHang x) => x.MhID); }
        }

        IRepository<NguoiDaiDien, int> IQuanLyNhaHangEntitiesUnitOfWork.NguoiDaiDiens
        {
            get { return GetRepository((NguoiDaiDien x) => x.NguoiDaiDienID); }
        }

        IRepository<NhanVien, int> IQuanLyNhaHangEntitiesUnitOfWork.NhanViens
        {
            get { return GetRepository((NhanVien x) => x.NhanVienID); }
        }

        IRepository<NhomCa, int> IQuanLyNhaHangEntitiesUnitOfWork.NhomCas
        {
            get { return GetRepository((NhomCa x) => x.NhomCaID); }
        }

        IRepository<NhomMatHang, int> IQuanLyNhaHangEntitiesUnitOfWork.NhomMatHangs
        {
            get { return GetRepository((NhomMatHang x) => x.NhomID); }
        }

        IRepository<NhomThuChi, int> IQuanLyNhaHangEntitiesUnitOfWork.NhomThuChis
        {
            get { return GetRepository((NhomThuChi x) => x.NhomThuChiID); }
        }

        IRepository<PhaChe, int> IQuanLyNhaHangEntitiesUnitOfWork.PhaChes
        {
            get { return GetRepository((PhaChe x) => x.PhaCheID); }
        }

        IRepository<PhieuChi, int> IQuanLyNhaHangEntitiesUnitOfWork.PhieuChis
        {
            get { return GetRepository((PhieuChi x) => x.PhieuChiID); }
        }

        IRepository<PhieuChuyenKho, int> IQuanLyNhaHangEntitiesUnitOfWork.PhieuChuyenKhoes
        {
            get { return GetRepository((PhieuChuyenKho x) => x.PhieuChuyenKhoID); }
        }

        IRepository<PhieuDatBan, int> IQuanLyNhaHangEntitiesUnitOfWork.PhieuDatBans
        {
            get { return GetRepository((PhieuDatBan x) => x.PhieuDatID); }
        }

        IRepository<PhieuDatBanChiTiet, int> IQuanLyNhaHangEntitiesUnitOfWork.PhieuDatBanChiTiets
        {
            get { return GetRepository((PhieuDatBanChiTiet x) => x.PDChiTietID); }
        }

        IRepository<PhieuNhap, int> IQuanLyNhaHangEntitiesUnitOfWork.PhieuNhaps
        {
            get { return GetRepository((PhieuNhap x) => x.PhieuNhapID); }
        }

        IRepository<PhieuNhapChiTiet, int> IQuanLyNhaHangEntitiesUnitOfWork.PhieuNhapChiTiets
        {
            get { return GetRepository((PhieuNhapChiTiet x) => x.PhieuNhapChiTietID); }
        }

        IRepository<PhieuThu, int> IQuanLyNhaHangEntitiesUnitOfWork.PhieuThus
        {
            get { return GetRepository((PhieuThu x) => x.PhieuThuID); }
        }

        IRepository<PhieuXuat, int> IQuanLyNhaHangEntitiesUnitOfWork.PhieuXuats
        {
            get { return GetRepository((PhieuXuat x) => x.PhieuXuatID); }
        }

        IRepository<PhieuXuatChiTiet, int> IQuanLyNhaHangEntitiesUnitOfWork.PhieuXuatChiTiets
        {
            get { return GetRepository((PhieuXuatChiTiet x) => x.PhieuXuatChiTietID); }
        }

        IRepository<PhongBan, int> IQuanLyNhaHangEntitiesUnitOfWork.PhongBans
        {
            get { return GetRepository((PhongBan x) => x.PhongBanID); }
        }

        IRepository<PhuCapLuong, int> IQuanLyNhaHangEntitiesUnitOfWork.PhuCapLuongs
        {
            get { return GetRepository((PhuCapLuong x) => x.PhuCapID); }
        }

        IRepository<PhuongThucThanhToan, int> IQuanLyNhaHangEntitiesUnitOfWork.PhuongThucThanhToans
        {
            get { return GetRepository((PhuongThucThanhToan x) => x.PhuongThucID); }
        }

        IRepository<QuiDoiDonViTinh, int> IQuanLyNhaHangEntitiesUnitOfWork.QuiDoiDonViTinhs
        {
            get { return GetRepository((QuiDoiDonViTinh x) => x.ID); }
        }

        IRepository<Quyen, int> IQuanLyNhaHangEntitiesUnitOfWork.Quyens
        {
            get { return GetRepository((Quyen x) => x.QuyenID); }
        }

        IRepository<SRM_DichVuKhachHang, int> IQuanLyNhaHangEntitiesUnitOfWork.SRM_DichVuKhachHang
        {
            get { return GetRepository((SRM_DichVuKhachHang x) => x.DichVuKhachHangID); }
        }

        IRepository<SRM_GiamTaiSan, Guid> IQuanLyNhaHangEntitiesUnitOfWork.SRM_GiamTaiSan
        {
            get { return GetRepository((SRM_GiamTaiSan x) => x.GiamTaiSanID); }
        }

        IRepository<SRM_GiaNhaCC, int> IQuanLyNhaHangEntitiesUnitOfWork.SRM_GiaNhaCC
        {
            get { return GetRepository((SRM_GiaNhaCC x) => x.ID); }
        }

        IRepository<SRM_HoaDonBanChiTietLog, int> IQuanLyNhaHangEntitiesUnitOfWork.SRM_HoaDonBanChiTietLog
        {
            get { return GetRepository((SRM_HoaDonBanChiTietLog x) => x.HoaDonBanChiTietLogID); }
        }

        IRepository<SRM_KhachTraNoHoaDon, int> IQuanLyNhaHangEntitiesUnitOfWork.SRM_KhachTraNoHoaDon
        {
            get { return GetRepository((SRM_KhachTraNoHoaDon x) => x.KhachTraNoHoaDonID); }
        }

        IRepository<SRM_KhauHaoTaiSan, int> IQuanLyNhaHangEntitiesUnitOfWork.SRM_KhauHaoTaiSan
        {
            get { return GetRepository((SRM_KhauHaoTaiSan x) => x.KhauHaoID); }
        }

        IRepository<SRM_KhauHaoTaiSanChiTiet, int> IQuanLyNhaHangEntitiesUnitOfWork.SRM_KhauHaoTaiSanChiTiet
        {
            get { return GetRepository((SRM_KhauHaoTaiSanChiTiet x) => x.KhauHaoChiTietID); }
        }

        IRepository<SRM_KhuyenMaiHoaDon, int> IQuanLyNhaHangEntitiesUnitOfWork.SRM_KhuyenMaiHoaDon
        {
            get { return GetRepository((SRM_KhuyenMaiHoaDon x) => x.KhuyenMaiID); }
        }

        IRepository<SRM_NhomTaiSan, int> IQuanLyNhaHangEntitiesUnitOfWork.SRM_NhomTaiSan
        {
            get { return GetRepository((SRM_NhomTaiSan x) => x.NhomID); }
        }

        IRepository<SRM_PhieuThuChi, int> IQuanLyNhaHangEntitiesUnitOfWork.SRM_PhieuThuChi
        {
            get { return GetRepository((SRM_PhieuThuChi x) => x.PhieuThuChiID); }
        }

        IRepository<SRM_TaiSan, Guid> IQuanLyNhaHangEntitiesUnitOfWork.SRM_TaiSan
        {
            get { return GetRepository((SRM_TaiSan x) => x.TaiSanID); }
        }

        IRepository<SRM_TangTaiSan, Guid> IQuanLyNhaHangEntitiesUnitOfWork.SRM_TangTaiSan
        {
            get { return GetRepository((SRM_TangTaiSan x) => x.TangTaiSanID); }
        }

        IRepository<SRM_TinhTrangDoiTac, int> IQuanLyNhaHangEntitiesUnitOfWork.SRM_TinhTrangDoiTac
        {
            get { return GetRepository((SRM_TinhTrangDoiTac x) => x.TinhTrangDoiTacID); }
        }

        IRepository<SRM_TinhTrangHangHoa, int> IQuanLyNhaHangEntitiesUnitOfWork.SRM_TinhTrangHangHoa
        {
            get { return GetRepository((SRM_TinhTrangHangHoa x) => x.TinhTrangHangHoaID); }
        }

        IRepository<TheKho, int> IQuanLyNhaHangEntitiesUnitOfWork.TheKhoes
        {
            get { return GetRepository((TheKho x) => x.TheKhoID); }
        }

        IRepository<TheVIP, int> IQuanLyNhaHangEntitiesUnitOfWork.TheVIPs
        {
            get { return GetRepository((TheVIP x) => x.TheVIPID); }
        }

        IRepository<TheVIPChiTiet, int> IQuanLyNhaHangEntitiesUnitOfWork.TheVIPChiTiets
        {
            get { return GetRepository((TheVIPChiTiet x) => x.TheVIPChiTietID); }
        }

        IRepository<ThongTinNH, int> IQuanLyNhaHangEntitiesUnitOfWork.ThongTinNHs
        {
            get { return GetRepository((ThongTinNH x) => x.ID); }
        }

        IRepository<TienTe, int> IQuanLyNhaHangEntitiesUnitOfWork.TienTes
        {
            get { return GetRepository((TienTe x) => x.IDCurr); }
        }

        IReadOnlyRepository<BanAn_PhieuDB> IQuanLyNhaHangEntitiesUnitOfWork.BanAn_PhieuDB
        {
            get { return GetReadOnlyRepository<BanAn_PhieuDB>(); }
        }

        IReadOnlyRepository<BANAN_PHIEUDB_> IQuanLyNhaHangEntitiesUnitOfWork.BANAN_PHIEUDB_
        {
            get { return GetReadOnlyRepository<BANAN_PHIEUDB_>(); }
        }

        IReadOnlyRepository<c1_28> IQuanLyNhaHangEntitiesUnitOfWork.c1_28
        {
            get { return GetReadOnlyRepository<c1_28>(); }
        }

        IReadOnlyRepository<c1_HoaDonCT> IQuanLyNhaHangEntitiesUnitOfWork.c1_HoaDonCT
        {
            get { return GetReadOnlyRepository<c1_HoaDonCT>(); }
        }

        IReadOnlyRepository<c2_HangTL_notIn> IQuanLyNhaHangEntitiesUnitOfWork.c2_HangTL_notIn
        {
            get { return GetReadOnlyRepository<c2_HangTL_notIn>(); }
        }

        IReadOnlyRepository<c2_HDCT_HangTL> IQuanLyNhaHangEntitiesUnitOfWork.c2_HDCT_HangTL
        {
            get { return GetReadOnlyRepository<c2_HDCT_HangTL>(); }
        }

        IReadOnlyRepository<cCN1> IQuanLyNhaHangEntitiesUnitOfWork.cCN1
        {
            get { return GetReadOnlyRepository<cCN1>(); }
        }

        IReadOnlyRepository<cCN2> IQuanLyNhaHangEntitiesUnitOfWork.cCN2
        {
            get { return GetReadOnlyRepository<cCN2>(); }
        }

        IReadOnlyRepository<cDTKV> IQuanLyNhaHangEntitiesUnitOfWork.cDTKVs
        {
            get { return GetReadOnlyRepository<cDTKV>(); }
        }

        IReadOnlyRepository<CV1> IQuanLyNhaHangEntitiesUnitOfWork.CV1
        {
            get { return GetReadOnlyRepository<CV1>(); }
        }

        IReadOnlyRepository<ketquakd_1> IQuanLyNhaHangEntitiesUnitOfWork.ketquakd_1
        {
            get { return GetReadOnlyRepository<ketquakd_1>(); }
        }

        IReadOnlyRepository<kqkd_1Test> IQuanLyNhaHangEntitiesUnitOfWork.kqkd_1Test
        {
            get { return GetReadOnlyRepository<kqkd_1Test>(); }
        }

        IReadOnlyRepository<kqkd_2> IQuanLyNhaHangEntitiesUnitOfWork.kqkd_2
        {
            get { return GetReadOnlyRepository<kqkd_2>(); }
        }

        IReadOnlyRepository<kqkd_3> IQuanLyNhaHangEntitiesUnitOfWork.kqkd_3
        {
            get { return GetReadOnlyRepository<kqkd_3>(); }
        }

        IReadOnlyRepository<kv> IQuanLyNhaHangEntitiesUnitOfWork.kvs
        {
            get { return GetReadOnlyRepository<kv>(); }
        }

        IReadOnlyRepository<Nhap_Hang> IQuanLyNhaHangEntitiesUnitOfWork.Nhap_Hangs
        {
            get { return GetReadOnlyRepository<Nhap_Hang>(); }
        }

        IReadOnlyRepository<Nhap_TK> IQuanLyNhaHangEntitiesUnitOfWork.Nhap_TK
        {
            get { return GetReadOnlyRepository<Nhap_TK>(); }
        }

        IReadOnlyRepository<tb_ChiTietChi> IQuanLyNhaHangEntitiesUnitOfWork.tb_ChiTietChi
        {
            get { return GetReadOnlyRepository<tb_ChiTietChi>(); }
        }

        IReadOnlyRepository<test_v20> IQuanLyNhaHangEntitiesUnitOfWork.test_v20
        {
            get { return GetReadOnlyRepository<test_v20>(); }
        }

        IReadOnlyRepository<test_V20_1> IQuanLyNhaHangEntitiesUnitOfWork.test_V20_1
        {
            get { return GetReadOnlyRepository<test_V20_1>(); }
        }

        IReadOnlyRepository<thang_v1> IQuanLyNhaHangEntitiesUnitOfWork.thang_v1
        {
            get { return GetReadOnlyRepository<thang_v1>(); }
        }

        IReadOnlyRepository<TongChi_1> IQuanLyNhaHangEntitiesUnitOfWork.TongChi_1
        {
            get { return GetReadOnlyRepository<TongChi_1>(); }
        }

        IReadOnlyRepository<TongChi_2> IQuanLyNhaHangEntitiesUnitOfWork.TongChi_2
        {
            get { return GetReadOnlyRepository<TongChi_2>(); }
        }

        IReadOnlyRepository<TongGiaTri_PhieuXuat> IQuanLyNhaHangEntitiesUnitOfWork.TongGiaTri_PhieuXuat
        {
            get { return GetReadOnlyRepository<TongGiaTri_PhieuXuat>(); }
        }

        IReadOnlyRepository<TongHangNhap> IQuanLyNhaHangEntitiesUnitOfWork.TongHangNhaps
        {
            get { return GetReadOnlyRepository<TongHangNhap>(); }
        }

        IReadOnlyRepository<TongHangXuat> IQuanLyNhaHangEntitiesUnitOfWork.TongHangXuats
        {
            get { return GetReadOnlyRepository<TongHangXuat>(); }
        }

        IReadOnlyRepository<View_1> IQuanLyNhaHangEntitiesUnitOfWork.View_1
        {
            get { return GetReadOnlyRepository<View_1>(); }
        }

        IReadOnlyRepository<View_2> IQuanLyNhaHangEntitiesUnitOfWork.View_2
        {
            get { return GetReadOnlyRepository<View_2>(); }
        }

        IReadOnlyRepository<View_4> IQuanLyNhaHangEntitiesUnitOfWork.View_4
        {
            get { return GetReadOnlyRepository<View_4>(); }
        }

        IReadOnlyRepository<View_5> IQuanLyNhaHangEntitiesUnitOfWork.View_5
        {
            get { return GetReadOnlyRepository<View_5>(); }
        }

        IReadOnlyRepository<View_6> IQuanLyNhaHangEntitiesUnitOfWork.View_6
        {
            get { return GetReadOnlyRepository<View_6>(); }
        }

        IReadOnlyRepository<View_byGD> IQuanLyNhaHangEntitiesUnitOfWork.View_byGD
        {
            get { return GetReadOnlyRepository<View_byGD>(); }
        }

        IReadOnlyRepository<view_doanhthutheogd> IQuanLyNhaHangEntitiesUnitOfWork.view_doanhthutheogd
        {
            get { return GetReadOnlyRepository<view_doanhthutheogd>(); }
        }

        IReadOnlyRepository<View_lydoChi> IQuanLyNhaHangEntitiesUnitOfWork.View_lydoChi
        {
            get { return GetReadOnlyRepository<View_lydoChi>(); }
        }

        IReadOnlyRepository<ViewMain> IQuanLyNhaHangEntitiesUnitOfWork.ViewMains
        {
            get { return GetReadOnlyRepository<ViewMain>(); }
        }

        IReadOnlyRepository<Xuat_Hang> IQuanLyNhaHangEntitiesUnitOfWork.Xuat_Hangs
        {
            get { return GetReadOnlyRepository<Xuat_Hang>(); }
        }

        IReadOnlyRepository<Xuat_TK> IQuanLyNhaHangEntitiesUnitOfWork.Xuat_TK
        {
            get { return GetReadOnlyRepository<Xuat_TK>(); }
        }
    }
}
