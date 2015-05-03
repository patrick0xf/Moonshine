using System;

namespace Moonshine.Data.Interfaces.Results
{
    public interface IGetDataOperationResult<T> where T: IBaseObject
    {
        bool Success { get; }
        Exception Exception { get; }
    }
}
