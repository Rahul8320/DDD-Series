using Domain.Products;

namespace Domain.Orders;

public sealed class LineItem 
{
    private LineItem(LineItemId id, OrderId orderId, ProductId productId, Money price)
    {
        Id = id;
        OrderId = orderId;
        ProductId = productId;
        Price = price;
    }

    public static LineItem Create(OrderId orderId, ProductId productId, Money price)
    {
        return new LineItem(new LineItemId(Guid.NewGuid()), orderId, productId, price);
    }

    private LineItem() { }

    public LineItemId Id { get; private set; }

    public OrderId OrderId { get; private set; }

    public ProductId ProductId { get; private set; }

    public Money Price { get; private set; }
}
