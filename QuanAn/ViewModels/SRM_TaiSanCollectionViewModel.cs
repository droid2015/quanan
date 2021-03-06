using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using QuanAn.Common.Utils;
using QuanAn.QuanLyNhaHangEntitiesDataModel;
using QuanAn.Common.DataModel;
using QuanAn.Data;
using QuanAn.Common.ViewModel;

namespace QuanAn.ViewModels
{
    /// <summary>
    /// Represents the SRM_TaiSan collection view model.
    /// </summary>
    public partial class SRM_TaiSanCollectionViewModel : CollectionViewModel<SRM_TaiSan, Guid, IQuanLyNhaHangEntitiesUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of SRM_TaiSanCollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static SRM_TaiSanCollectionViewModel Create(IUnitOfWorkFactory<IQuanLyNhaHangEntitiesUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new SRM_TaiSanCollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the SRM_TaiSanCollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the SRM_TaiSanCollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected SRM_TaiSanCollectionViewModel(IUnitOfWorkFactory<IQuanLyNhaHangEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.SRM_TaiSan)
        {
        }
    }
}