using Domain.Customers;
using Domain.Products;

namespace Domain.Orders;

public sealed class Order
{
    private Order(OrderId id, CustomerId customerId)
    {
        Id = id;
        CustomerId = customerId;
    }

    private readonly HashSet<LineItem> _lineItems = [];

    public OrderId Id { get; private set; }

    public CustomerId CustomerId { get; private set; }

    public IReadOnlyList<LineItem> LineItems => [.. _lineItems];

    public static Order Create(CustomerId customerId)
    {
        return new Order(new OrderId(Guid.NewGuid()), customerId);
    }

    public void Add(ProductId productId, Money productPrice)
    {
        var lineItem = new LineItem(new LineItemId(Guid.NewGuid()), Id, productId, productPrice);

        _lineItems.Add(lineItem);
    }
}
