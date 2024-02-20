using Domain.Primitives;

namespace Domain.Entities;

public sealed class Address : Entity
{
    internal Address(
        Guid id,
        int houseNo,
        string streetName,
        string district,
        string city,
        string state,
        string country,
        int pinCode) : base(id)
    {
        HouseNo = houseNo;
        StreetName = streetName;
        District = district;
        City = city;
        State = state;
        Country = country;
        PinCode = pinCode;
    }

    public int HouseNo { get; private set; }
    public string StreetName { get; private set; }
    public string District { get; private set; }
    public string City { get; private set; }
    public string State { get; private set; }
    public string Country { get; private set; }
    public int PinCode { get; private set; }
}
