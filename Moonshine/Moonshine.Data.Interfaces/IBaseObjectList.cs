using System.Collections.Generic;

namespace Moonshine.Data.Interfaces
{
    public interface IBaseObjectList
    {
        IEnumerable<byte[]> GetUids();
        void AddUid(byte[] uid);
        void RemoveUid(byte[] uid);
        void Clear();
        bool IsEmpty();
    }
}
