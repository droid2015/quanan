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
    /// Represents the single SRM_GiaNhaCC object view model.
    /// </summary>
    public partial class SRM_GiaNhaCCViewModel : SingleObjectViewModel<SRM_GiaNhaCC, int, IQuanLyNhaHangEntitiesUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of SRM_GiaNhaCCViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static SRM_GiaNhaCCViewModel Create(IUnitOfWorkFactory<IQuanLyNhaHangEntitiesUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new SRM_GiaNhaCCViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the SRM_GiaNhaCCViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the SRM_GiaNhaCCViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected SRM_GiaNhaCCViewModel(IUnitOfWorkFactory<IQuanLyNhaHangEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.SRM_GiaNhaCC, x => x.GhiChu)
        {
        }
    }
}
