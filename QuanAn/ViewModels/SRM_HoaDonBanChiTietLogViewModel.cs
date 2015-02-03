using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using QuanAn.Common.Utils;
using QuanAn.QuanLyNhaHangEntitiesDataModel;
using QuanAn.Common.DataModel;
using QuanAn.Data;
using QuanAn.Common.ViewModel;

namespace QuanAn.ViewModels
{
    /// <summary>
    /// Represents the single SRM_HoaDonBanChiTietLog object view model.
    /// </summary>
    public partial class SRM_HoaDonBanChiTietLogViewModel : SingleObjectViewModel<SRM_HoaDonBanChiTietLog, int, IQuanLyNhaHangEntitiesUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of SRM_HoaDonBanChiTietLogViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static SRM_HoaDonBanChiTietLogViewModel Create(IUnitOfWorkFactory<IQuanLyNhaHangEntitiesUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new SRM_HoaDonBanChiTietLogViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the SRM_HoaDonBanChiTietLogViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the SRM_HoaDonBanChiTietLogViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected SRM_HoaDonBanChiTietLogViewModel(IUnitOfWorkFactory<IQuanLyNhaHangEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.SRM_HoaDonBanChiTietLog, x => x.GhiChu)
        {
        }
    }
}
