using System;
using Moonshine.Data.Interfaces.Results;

namespace Moonshine.Data.Common.Results
{
    public class ObjectGetDataOperationResult : IDataOperationResult
    {
        public ObjectGetDataOperationResult(object obj)
        {
            Success = true;
            Result = obj;
        }

        public object Result { get; private set; }

        public ObjectGetDataOperationResult(Exception exception)
        {
            Exception = exception;
        }

        public bool Success { get; private set; }
        public Exception Exception { get; private set; }
    }
}
