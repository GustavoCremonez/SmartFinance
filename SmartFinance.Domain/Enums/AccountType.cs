using System.ComponentModel;

namespace SmartFinance.Domain.Enums
{
    public enum AccountType : int
    {
        [Description("Conta corrente")]
        ContaCorrente = 1,

        [Description("Conta poupança")]
        ContaPoupança = 2,

        [Description("Conta de investimento")]
        ContaInvestimento = 3
    }
}