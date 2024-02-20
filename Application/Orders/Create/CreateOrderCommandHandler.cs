using Application.Data;
using Domain.Orders;
using MediatR;

namespace Application.Orders.Create;

internal sealed class CreateOrderCommandHandler(IApplicationDbContext context) : IRequestHandler<CreateOrderCommand>
{
    private readonly IApplicationDbContext _context = context;

    public async Task Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        var customer = await _context.Customers.FindAsync([request.CustomerId], cancellationToken: cancellationToken);

        if ( customer is null)
        {
            return;
        }

        var order = Order.Create(customer.Id);

        _context.Orders.Add(order);

        await _context.SaveChangesAsync(cancellationToken);
    }
}
