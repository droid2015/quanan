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
using DevExpress.Mvvm;

namespace QuanAn.QuanLyNhaHangEntitiesDataModel
{
    /// <summary>
    /// Provides methods to obtain the relevant IUnitOfWorkFactory.
    /// </summary>
    public static class UnitOfWorkSource
    {

        #region inner classes
        class DbUnitOfWorkFactory : IUnitOfWorkFactory<IQuanLyNhaHangEntitiesUnitOfWork>
        {
            public static readonly IUnitOfWorkFactory<IQuanLyNhaHangEntitiesUnitOfWork> Instance = new DbUnitOfWorkFactory();
            DbUnitOfWorkFactory() { }
            IQuanLyNhaHangEntitiesUnitOfWork IUnitOfWorkFactory<IQuanLyNhaHangEntitiesUnitOfWork>.CreateUnitOfWork()
            {
                return new QuanLyNhaHangEntitiesUnitOfWork(new QuanLyNhaHangEntities());
            }
        }

        class DesignUnitOfWorkFactory : IUnitOfWorkFactory<IQuanLyNhaHangEntitiesUnitOfWork>
        {
            public static readonly IUnitOfWorkFactory<IQuanLyNhaHangEntitiesUnitOfWork> Instance = new DesignUnitOfWorkFactory();

            readonly IQuanLyNhaHangEntitiesUnitOfWork UnitOfWork = new QuanLyNhaHangEntitiesDesignTimeUnitOfWork();
            DesignUnitOfWorkFactory() { }
            IQuanLyNhaHangEntitiesUnitOfWork IUnitOfWorkFactory<IQuanLyNhaHangEntitiesUnitOfWork>.CreateUnitOfWork()
            {
                return UnitOfWork;
            }
        }
        #endregion

        /// <summary>
        /// Returns the IUnitOfWorkFactory implementation based on the current mode (run-time or design-time).
        /// </summary>
        public static IUnitOfWorkFactory<IQuanLyNhaHangEntitiesUnitOfWork> GetUnitOfWorkFactory()
        {
            return GetUnitOfWorkFactory(ViewModelBase.IsInDesignMode);
        }

        /// <summary>
        /// Returns the IUnitOfWorkFactory implementation based on the given mode (run-time or design-time).
        /// </summary>
        /// <param name="isInDesignTime">Used to determine which implementation of IUnitOfWorkFactory should be returned.</param>
        public static IUnitOfWorkFactory<IQuanLyNhaHangEntitiesUnitOfWork> GetUnitOfWorkFactory(bool isInDesignTime)
        {
            return isInDesignTime ? DesignUnitOfWorkFactory.Instance : DbUnitOfWorkFactory.Instance;
        }
    }
}