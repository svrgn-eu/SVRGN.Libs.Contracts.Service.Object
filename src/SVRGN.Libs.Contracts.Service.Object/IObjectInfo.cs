using SVRGN.Libs.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SVRGN.Libs.Contracts.Service.Object
{
    public interface IObjectInfo : IBaseObject
    {
        #region Properties

        object Data { get; }
        Type DataType { get; }
        DateTime CreatedAt { get; }

        #endregion Properties

        #region Methods

        #endregion Methods
    }
}
