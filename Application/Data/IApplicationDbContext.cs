using Domain.Customers;
using Domain.Orders;
using Microsoft.EntityFrameworkCore;

namespace Application.Data;

public interface IApplicationDbContext
{
    DbSet<Customer> Customers { get; set; }
    DbSet<Order> Orders { get; set; }
    DbSet<OrderSummary> OrderSummaries { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
