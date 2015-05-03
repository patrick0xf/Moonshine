using Moonshine.Data.Interfaces.Results;

namespace Moonshine.Data.Interfaces
{
    public interface IBaseObject
    {
        byte[] Uid { get; }
        string WebSafeUid { get; }
        bool IsInactive { get; set; }
        IDataOperationResult Commit();
        IDataOperationResult Delete();
        IBaseObject InitializeDatabaseAdapter(object[] parameters);
    }
}