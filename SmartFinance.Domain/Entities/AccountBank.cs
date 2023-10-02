namespace SmartFinance.Domain.Entities
{
    public sealed class AccountBank
    {
        public AccountBank(int id, int userId, User user, string bankName, int accountNumber, int agencyNumber, int accountType, decimal balance, decimal interestRate)
        {
            Id = id;
            UserId = userId;
            User = user;
            BankName = bankName;
            AccountNumber = accountNumber;
            AgencyNumber = agencyNumber;
            AccountType = accountType;
            Balance = balance;
            InterestRate = interestRate;
        }

        public int Id { get; private set; }

        public int UserId { get; private set; }

        public User User { get; private set; }

        public string BankName { get; private set; }

        public int AccountNumber { get; private set; }

        public int AgencyNumber { get; private set; }

        public int AccountType { get; private set; }

        public decimal Balance { get; private set; }

        public decimal InterestRate { get; private set; }
    }
}