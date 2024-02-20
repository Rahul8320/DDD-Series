using Domain.Customers;
using MediatR;

namespace Application.Orders.Create;

public record CreateOrderCommand(CustomerId CustomerId): IRequest;
