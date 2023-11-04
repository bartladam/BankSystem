using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class BankLoan
    {
        public double amountMoney { get; private set; }
        public double interestRate { get; private set; }
        public double bankRecieved { get; private set; }
        private DateTime lengthLoan { get; set; }
        public BankLoan(double amountMoney, double interestRate, DateTime lengthLoan)
        {
            this.amountMoney = amountMoney;
            this.interestRate = interestRate;
            this.lengthLoan = lengthLoan;
            TimeSpan ts = lengthLoan - DateTime.Now;
            double months = ts.TotalDays / 31;
            this.bankRecieved = Math.Round(amountMoney + (amountMoney * (interestRate / 100) * months));
        }
        public override string ToString()
        {
            return string.Format("Human borrowed money: {0}\nBank interest rate: {1}%\nBank recieved: {2},-", amountMoney, interestRate, bankRecieved);
        }
    }
}
