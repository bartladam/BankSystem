using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class LoanCentralBank : BankLoan
    {
        public Bank bank { get; set; }
        public LoanCentralBank(int amountMoney, double interestRate, DateTime lengthLoan) : base(amountMoney, interestRate, lengthLoan)
        {
            
        }
    }
}
