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
    /// Represents the single BanAn object view model.
    /// </summary>
    public partial class BanAnViewModel : SingleObjectViewModel<BanAn, int, IQuanLyNhaHangEntitiesUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of BanAnViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static BanAnViewModel Create(IUnitOfWorkFactory<IQuanLyNhaHangEntitiesUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new BanAnViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the BanAnViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the BanAnViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected BanAnViewModel(IUnitOfWorkFactory<IQuanLyNhaHangEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.BanAns, x => x.TenBan)
        {
        }
    }
}
