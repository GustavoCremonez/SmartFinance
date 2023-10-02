namespace SmartFinance.Domain.Entities
{
    public sealed class Fixed
    {
        public Fixed(int id, int accountBankId, AccountBank accountBank, string description, decimal amount, int recurrence, int nextDueDate, DateTime createdDate, string fixedType)
        {
            Id = id;
            AccountBankId = accountBankId;
            AccountBank = accountBank;
            Description = description;
            Amount = amount;
            Recurrence = recurrence;
            NextDueDate = nextDueDate;
            CreatedDate = createdDate;
            FixedType = fixedType;
        }

        public Fixed()
        {
        }

        public int Id { get; private set; }

        public int AccountBankId { get; set; }

        public AccountBank AccountBank { get; set; }

        public string Description { get; private set; }

        public decimal Amount { get; private set; }

        public int Recurrence { get; private set; }

        public int NextDueDate { get; private set; }

        public DateTime CreatedDate { get; private set; }

        public string FixedType { get; private set; }
    }
}