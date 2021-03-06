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
    /// Represents the kqkd_3 collection view model.
    /// </summary>
    public partial class kqkd_3CollectionViewModel : ReadOnlyCollectionViewModel<kqkd_3, IQuanLyNhaHangEntitiesUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of kqkd_3CollectionViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static kqkd_3CollectionViewModel Create(IUnitOfWorkFactory<IQuanLyNhaHangEntitiesUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new kqkd_3CollectionViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the kqkd_3CollectionViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the kqkd_3CollectionViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected kqkd_3CollectionViewModel(IUnitOfWorkFactory<IQuanLyNhaHangEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.kqkd_3)
        {
        }
    }
}