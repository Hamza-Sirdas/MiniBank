namespace MiniBank.Domain.Enums;

public enum Currency { TRY = 1, USD = 2, EUR = 3 }

public enum TransactionType { Deposit = 1, Withdraw = 2, Transfer = 3 }

public enum AccountStatus { Active = 1, Frozen = 2, Closed = 3 }