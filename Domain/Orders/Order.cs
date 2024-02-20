using Domain.Customers;
using Domain.Primitives;
using Domain.Products;

namespace Domain.Orders;

public sealed class Order : Entity
{
    private Order(Guid id, Guid customerId) : base(id)
    {
        CustomerId = customerId;
    }

    private readonly HashSet<LineItem> _lineItems = [];

    public Guid CustomerId { get; private set; }

    public static Order Create(Customer customer)
    {
        return new Order(Guid.NewGuid(), customer.Id);
    }

    public void Add(Product product)
    {
        var lineItem = new LineItem(Guid.NewGuid(), Id, product.Id, product.Price);

        _lineItems.Add(lineItem);
    }
}

public sealed class LineItem : Entity
{
    internal LineItem(Guid id, Guid orderId, Guid productId, Money price) : base(id)
    {
        OrderId = orderId;
        ProductId = productId;
        Price = price;
    }

    public Guid OrderId { get; private set; }

    public Guid ProductId { get; private set; }

    public Money Price { get; private set; }
}