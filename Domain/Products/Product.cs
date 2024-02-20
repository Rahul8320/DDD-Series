namespace Domain.Products;

public sealed class Product
{
    private Product(ProductId id, string name, Money price, Sku sku)
    {
        Id = id;
        Name = name;
        Price = price;
        Sku = sku;
    }

    private Product() { }

    public static Product Create(string name, Money price, Sku sku) 
    { 
        return new Product(new ProductId(Guid.NewGuid()), name, price, sku); 
    }

    public ProductId Id { get; private set; }

    public string Name { get; private set; }

    public Money Price { get; private set; }

    public Sku Sku { get; private set; }
}
