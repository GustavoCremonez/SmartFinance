using System.Collections;

namespace SmartFinance.Domain.Entities
{
    public sealed class User
    {
        public User(string name, string email, string phone_number, string password, DateTime birthdate)
        {
            Name = name;
            Email = email;
            Phone_number = phone_number;
            Password = password;
            Birthdate = birthdate;
            BankAccounts = default!;
        }

        protected User()
        {
        }

        public int Id { get; private set; }

        public string Name { get; private set; }

        public string Email { get; private set; }

        public string Phone_number { get; private set; }

        public string Password { get; private set; }

        public DateTime Birthdate { get; private set; }

        public ICollection<AccountBank> BankAccounts { get; set; }
    }
}