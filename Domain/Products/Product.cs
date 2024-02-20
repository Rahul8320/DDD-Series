using Domain.Primitives;

namespace Domain.Products;

public sealed class Product : Entity
{
    internal Product(Guid id, string name, Money price, Sku sku) : base(id)
    {
        Name = name;
        Price = price;
        Sku = sku;
    }

    public string Name { get; private set; }

    public Money Price { get; private set; }

    public Sku Sku { get; private set; }
}
