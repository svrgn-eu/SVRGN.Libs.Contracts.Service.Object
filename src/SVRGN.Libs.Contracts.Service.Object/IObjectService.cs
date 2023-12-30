using SVRGN.Libs.Contracts.Base;
using SVRGN.Libs.Contracts.Service.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SVRGN.Libs.Contracts.Service.Object
{
    /// <summary>
    /// the service responsible for objects and their creation
    /// </summary>
    public interface IObjectService : IService
    {
        #region Properties

        #endregion Properties

        #region Methods

        T Create<T>(params object[] Parameters) where T : class;
        T CreateWithTypeName<T>(string TypeName, params object[] Parameters) where T : class;
        int Count();

        #endregion Methods  
    }
}
