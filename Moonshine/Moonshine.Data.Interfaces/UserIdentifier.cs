namespace Moonshine.Data.Interfaces
{
    public class UserIdentifier
    {
        public string StaticStringForHash { get; private set; }
        public string PrivateUserIdentifier { get; private set; }
        public string DisplayValue { get; private set; }
        public object PassThroughObject { get; private set; }

        public UserIdentifier(string staticStringForHash, string privateUserIdentifier, string displayValue, object passThroughObject)
        {
            StaticStringForHash = staticStringForHash;
            PrivateUserIdentifier = privateUserIdentifier;
            DisplayValue = displayValue;
            PassThroughObject = passThroughObject;
        }
    }
}