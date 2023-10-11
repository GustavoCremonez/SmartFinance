namespace SmartFinance.DTO.DTOs
{
    public class UserDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone_number { get; set; }

        public string Password { get; set; }

        public DateTime Birthdate { get; set; }

        public ICollection<AccountBankDto> BankAccounts { get; set; }
    }
}