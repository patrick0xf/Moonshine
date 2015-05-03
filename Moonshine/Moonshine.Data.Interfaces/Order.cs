namespace Moonshine.Data.Interfaces
{
    public class Order
    {
        public Order(bool isAscending, string fieldName)
        {
            IsAscending = isAscending;
            FieldName = fieldName;
        }

        public bool IsAscending { get; private set; }
        public string FieldName { get; private set; }
    }
}
