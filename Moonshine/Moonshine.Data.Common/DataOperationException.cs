using System;

namespace Moonshine.Data.Common
{
    public class DataOperationException : Exception
    {
        public DataOperationException(string message) : base(message)
        {
        }
    }
}
