using System;
using Moonshine.Data.Interfaces.Results;

namespace Moonshine.Data.Common.Results
{
    public class DeleteOperationResult : IDataOperationResult
    {
        public bool Success { get; private set; }
        public Exception Exception { get; private set; }

        public DeleteOperationResult()
        {
            Success = true;
        }

        public DeleteOperationResult(Exception exception)
        {
            Exception = exception;
        }
    }
}
