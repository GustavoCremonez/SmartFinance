using SmartFinance.Domain.Entities;

namespace SmartFinance.DTO.DTOs
{
    public class FixedDto
    {
        public int Id { get; private set; }

        public int AccountBankId { get; set; }

        public AccountBankDto AccountBank { get; set; } = default!;

        public string Description { get; private set; } = default!;

        public decimal Amount { get; private set; }

        public int Recurrence { get; private set; }

        public int NextDueDate { get; private set; }

        public DateTime CreatedDate { get; private set; }

        public string FixedType { get; private set; } = default!;
    }
}