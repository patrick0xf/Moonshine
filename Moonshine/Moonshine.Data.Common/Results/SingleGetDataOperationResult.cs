using System;
using Moonshine.Data.Interfaces;
using Moonshine.Data.Interfaces.Results;

namespace Moonshine.Data.Common.Results
{
    public class SingleGetDataOperationResult<T> : IGetDataOperationResult<T> where T : IBaseObject
    {
        public SingleGetDataOperationResult(T result)
        {
            Success = true;
            Result = result;
        }

        public SingleGetDataOperationResult(Exception exception)
        {
            Exception = exception;
        }

        public bool Success { get; private set; }
        public Exception Exception { get; private set; }
        public T Result { get; private set; }
    }
}