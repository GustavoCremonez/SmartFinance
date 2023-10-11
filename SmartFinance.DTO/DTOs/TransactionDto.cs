namespace SmartFinance.DTO.DTOs
{
    public class TransactionDto
    {
        public int Id { get; set; }

        public int AccountBankId { get; set; }

        public AccountBankDto AccountBank { get; set; } = default!;

        public string TransactionType { get; set; } = default!;

        public decimal Amount { get; set; }

        public string Description { get; set; } = default!;
    }
}