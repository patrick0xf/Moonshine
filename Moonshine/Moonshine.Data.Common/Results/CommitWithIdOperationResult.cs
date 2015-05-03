using System;
using Moonshine.Data.Interfaces.Results;

namespace Moonshine.Data.Common.Results
{
    public class CommitWithIdOperationResult : IDataOperationResult
    {
        public bool Success { get; private set; }
        public Exception Exception { get; private set; }
        public byte[] Uid { get; private set; }

        public CommitWithIdOperationResult(byte[] uid)
        {
            Success = true;
            Uid = uid;
        }

        public CommitWithIdOperationResult(Exception exception)
        {
            Exception = exception;
        }
    }
}
