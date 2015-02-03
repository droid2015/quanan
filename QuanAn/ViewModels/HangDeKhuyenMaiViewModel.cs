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
    /// Represents the single HangDeKhuyenMai object view model.
    /// </summary>
    public partial class HangDeKhuyenMaiViewModel : SingleObjectViewModel<HangDeKhuyenMai, int, IQuanLyNhaHangEntitiesUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of HangDeKhuyenMaiViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static HangDeKhuyenMaiViewModel Create(IUnitOfWorkFactory<IQuanLyNhaHangEntitiesUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new HangDeKhuyenMaiViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the HangDeKhuyenMaiViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the HangDeKhuyenMaiViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected HangDeKhuyenMaiViewModel(IUnitOfWorkFactory<IQuanLyNhaHangEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.HangDeKhuyenMais, x => x.HangDeKhuyenMaiID)
        {
        }
    }
}
