namespace SmartFinance.Domain.Entities
{
    public sealed class Fixed
    {
        public Fixed(int id, int userId, User user, string description, decimal amount, int recurrence, int nextDueDate, DateTime createdDate, int fixedType)
        {
            Id = id;
            UserId = userId;
            User = user;
            Description = description;
            Amount = amount;
            Recurrence = recurrence;
            NextDueDate = nextDueDate;
            CreatedDate = createdDate;
            FixedType = fixedType;
        }

        public int Id { get; private set; }

        public int UserId { get; private set; }

        public User User { get; private set; }

        public string Description { get; private set; }

        public decimal Amount { get; private set; }

        public int Recurrence { get; private set; }

        public int NextDueDate { get; private set; }

        public DateTime CreatedDate { get; private set; }

        public int FixedType { get; private set; }
    }
}