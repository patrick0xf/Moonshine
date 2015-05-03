namespace Moonshine.Data.Interfaces
{
    public interface IDatabaseAdapter
    {
        void Initialize(params object[] initializationParameters);

        byte[] GetUid(string webSafeUid);
        string GetWebSafeUid(byte[] uid);
    }
}
