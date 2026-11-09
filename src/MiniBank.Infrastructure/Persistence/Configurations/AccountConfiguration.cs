using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiniBank.Domain.Entities;

namespace MiniBank.Infrastructure.Persistence.Configurations;

public class AccountConfiguration : IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder.ToTable("Accounts");
        builder.HasKey(a => a.Id);

        builder.Property(a => a.UserId).IsRequired().HasMaxLength(450);
        builder.Property(a => a.AccountNumber).IsRequired().HasMaxLength(26);
        builder.HasIndex(a => a.AccountNumber).IsUnique();

        builder.Property(a => a.Balance).HasPrecision(18, 2);
        builder.Property(a => a.RowVersion).IsRowVersion();
    }
}