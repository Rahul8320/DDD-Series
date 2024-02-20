using Domain.Primitives;

namespace Domain.Customers;

public sealed class Customer 
{
    internal Customer(CustomerId id, string email, string name)
    {
        Id = id;
        Email = email;
        Name = name;
    }

    public CustomerId Id { get; private set; }
    public string Name { get; private set; }
    public string Email { get; private set; }
}
