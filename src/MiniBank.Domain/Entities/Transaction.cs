using MiniBank.Domain.Common;
using MiniBank.Domain.Enums;


namespace MiniBank.Domain.Entities;

public class Transaction : BaseEntity
{
    public Guid AccountId { get; set; }
    public Account Account { get; set; } = null!;

    public Guid? TargetAccountId { get; set; }   // Sadece transferlerde dolu
    public TransactionType Type { get; set; }
    public decimal Amount { get; set; }
    public string? Description { get; set; }
}