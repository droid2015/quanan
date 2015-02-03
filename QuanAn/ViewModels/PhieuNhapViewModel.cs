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
    /// Represents the single PhieuNhap object view model.
    /// </summary>
    public partial class PhieuNhapViewModel : SingleObjectViewModel<PhieuNhap, int, IQuanLyNhaHangEntitiesUnitOfWork>
    {

        /// <summary>
        /// Creates a new instance of PhieuNhapViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static PhieuNhapViewModel Create(IUnitOfWorkFactory<IQuanLyNhaHangEntitiesUnitOfWork> unitOfWorkFactory = null)
        {
            return ViewModelSource.Create(() => new PhieuNhapViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the PhieuNhapViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the PhieuNhapViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected PhieuNhapViewModel(IUnitOfWorkFactory<IQuanLyNhaHangEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.PhieuNhaps, x => x.MaPhieuNhap)
        {
        }

        protected override void RefreshLookUpCollections(int key)
        {
            PhieuNhapPhieuNhapChiTietsLookUp = CreateLookUpCollectionViewModel(x => x.PhieuNhapChiTiets, x => x.PhieuNhapID, (x, m) => x.PhieuNhap = m, key);
        }

        /// <summary>
        /// The view model for the PhieuNhapPhieuNhapChiTiets detail collection.
        /// </summary>
        public virtual CollectionViewModel<PhieuNhapChiTiet, int, IQuanLyNhaHangEntitiesUnitOfWork> PhieuNhapPhieuNhapChiTietsLookUp { get; set; }
    }
}
