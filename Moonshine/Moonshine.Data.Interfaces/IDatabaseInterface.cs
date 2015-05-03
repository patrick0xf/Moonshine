using System.Collections.Generic;
using Moonshine.Data.Interfaces.Results;

namespace Moonshine.Data.Interfaces
{
    public interface IDatabaseInterface
    {
        //Common Getters
        IGetDataOperationResult<T> GetObject<T>(byte[] uid) where T : IBaseObject;
        IGetDataOperationResult<T> GetObjects<T>(IEnumerable<byte[]> uids) where T : IBaseObject;
        IDataOperationResult GetAll<T>(Order order = null) where T : IBaseObject;
    }
}
