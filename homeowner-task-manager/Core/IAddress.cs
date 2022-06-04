namespace Core
{
    public interface IAddress
    {
        string City { get; }
        string State { get; }
        string StreetName { get; }
        string StreetNumber { get; }
        string ZipCode { get; }
    }
}