using System;

namespace Moonshine.Data.Interfaces.Results
{
    public interface IDataOperationResult
    {
        bool Success { get; }
        Exception Exception { get; }
    }
}
