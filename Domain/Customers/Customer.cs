using Domain.Primitives;

namespace Domain.Customers;

public sealed class Customer : Entity
{
    internal Customer(Guid id, string email, string name) : base(id)
    {
        Email = email;
        Name = name;
    }

    public string Name { get; private set; }
    public string Email { get; private set; }
}
