using Domain.Customers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

internal class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        // Primary key for customer table.
        builder.HasKey(c => c.Id);

        // conversion from cutomerId to id [to store id in database] and vice versa
        builder.Property(c => c.Id).HasConversion(customerId => customerId.Value, value => new CustomerId(value));

        builder.Property(c => c.Name).HasMaxLength(100);

        builder.Property(c => c.Email).HasMaxLength(255);
    
        builder.HasIndex(c => c.Email).IsUnique();
    }
}
