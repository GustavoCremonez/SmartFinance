﻿namespace SmartFinance.Domain.Entities
{
    public sealed class Transaction
    {
        public Transaction(int id, int accountBankId, AccountBank accountBank, string transactionType, decimal amount, string description)
        {
            Id = id;
            AccountBankId = accountBankId;
            AccountBank = accountBank;
            TransactionType = transactionType;
            Amount = amount;
            Description = description;
        }

        public Transaction()
        {
            Id = default!;
            AccountBankId = default!;
            AccountBank = default!;
            TransactionType = default!;
            Amount = default!;
            Description = default!;
        }

        public int Id { get; private set; }

        public int AccountBankId { get; private set; }

        public AccountBank AccountBank { get; private set; }

        public string TransactionType { get; private set; }

        public decimal Amount { get; private set; }

        public string Description { get; private set; }
    }
}