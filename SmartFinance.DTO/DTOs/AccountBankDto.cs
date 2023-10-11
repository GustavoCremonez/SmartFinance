using SmartFinance.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SmartFinance.DTO.DTOs
{
    public class AccountBankDto
    {
        public int Id { get; private set; }

        public int UserId { get; private set; }

        public UserDto User { get; private set; } = default!;

        public string BankName { get; private set; } = default!;

        public int AccountNumber { get; private set; }

        public int AgencyNumber { get; private set; }

        public AccountType AccountType { get; private set; }

        public decimal Balance { get; private set; }

        public decimal InterestRate { get; private set; }

        public ICollection<TransactionDto> Transactions { get; set; } = default!;

        public ICollection<FixedDto> Fixeds { get; set; } = default!;
    }
}