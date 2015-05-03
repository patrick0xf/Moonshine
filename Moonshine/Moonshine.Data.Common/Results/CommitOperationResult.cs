using System;
using Moonshine.Data.Interfaces.Results;

namespace Moonshine.Data.Common.Results
{
    public class CommitOperationResult : IDataOperationResult
    {
        public bool Success { get; private set; }
        public Exception Exception { get; private set; }

        public CommitOperationResult()
        {
            Success = true;
        }

        public CommitOperationResult(Exception exception)
        {
            Exception = exception;
        }
    }
}
