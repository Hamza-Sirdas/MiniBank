using MiniBank.Domain.Common;
using MiniBank.Domain.Enums;


namespace MiniBank.Domain.Entities;

public class Account : BaseEntity
{
    public string UserId { get; set; } = string.Empty;   // Identity kullanıcısının Id'si (Faz 2'de bağlayacağız)
    public string AccountNumber { get; set; } = string.Empty;
    public Currency Currency { get; set; }
    public decimal Balance { get; private set; }
    public AccountStatus Status { get; set; } = AccountStatus.Active;

    public byte[] RowVersion { get; set; } = Array.Empty<byte>();   // Faz 4'te concurrency için

    public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new InvalidOperationException("Yatırılacak tutar sıfırdan büyük olmalıdır.");
        if (Status != AccountStatus.Active)
            throw new InvalidOperationException("Hesap aktif değil.");

        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new InvalidOperationException("Çekilecek tutar sıfırdan büyük olmalıdır.");
        if (Status != AccountStatus.Active)
            throw new InvalidOperationException("Hesap aktif değil.");
        if (Balance < amount)
            throw new InvalidOperationException("Yetersiz bakiye.");

        Balance -= amount;
    }
}