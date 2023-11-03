using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class BankLoan
    {
        public int amountMoney { get; private set; }
        public double interestRate { get; private set; }
        public double bankRecieved { get; private set; }
        private DateTime lengthLoan { get; set; }
        public BankLoan(int amountMoney, double interestRate, DateTime lengthLoan)
        {
            this.amountMoney = amountMoney;
            this.interestRate = interestRate;
            this.lengthLoan = lengthLoan;
            TimeSpan ts = lengthLoan - DateTime.Now;
            double months = ts.TotalDays / 31;
            this.bankRecieved = amountMoney + (amountMoney * (interestRate / 100) * months);
        }
    }
}
