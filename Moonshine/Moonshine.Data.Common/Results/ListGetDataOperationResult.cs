using System;
using System.Collections.Generic;
using Moonshine.Data.Interfaces;
using Moonshine.Data.Interfaces.Results;

namespace Moonshine.Data.Common.Results
{
    public class ListGetDataOperationResult<T> : IGetDataOperationResult<T> where T : IBaseObject
    {
        public ListGetDataOperationResult(List<T> result)
        {
            Success = true;
            Result = result;
        }

        public ListGetDataOperationResult(Exception exception)
        {
            Exception = exception;
        }

        public bool Success { get; private set; }
        public Exception Exception { get; private set; }
        public List<T> Result { get; private set; } 
    }
}