using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MiniBank.Domain.Entities;

namespace MiniBank.Infrastructure.Persistence.Configurations;

public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
{
    public void Configure(EntityTypeBuilder<Transaction> builder)
    {
        builder.ToTable("Transactions");
        builder.HasKey(t => t.Id);

        builder.Property(t => t.Amount).HasPrecision(18, 2);
        builder.Property(t => t.Description).HasMaxLength(250);

        builder.HasOne(t => t.Account)
               .WithMany(a => a.Transactions)
               .HasForeignKey(t => t.AccountId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(t => new { t.AccountId, t.CreatedAt });
    }
}