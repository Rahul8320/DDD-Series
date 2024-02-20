namespace Domain.Customers;

public sealed class Customer 
{
    private const int MaxNameLength = 100;
    private const int MaxEmailLength = 255;
    private Customer(CustomerId id, string email, string name)
    {
        Id = id;
        Email = email;
        Name = name;
    }

    public static Customer? Create(string email, string name)
    {
        if(email == null || name == null) return null;

        if(name.Length > MaxNameLength || email.Length > MaxEmailLength) return null;

        return new Customer(new CustomerId(Guid.NewGuid()), email, name);
    }

    public CustomerId Id { get; private set; }
    public string Name { get; private set; }
    public string Email { get; private set; }
}
