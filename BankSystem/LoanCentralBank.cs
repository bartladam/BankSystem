﻿using System;
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
        public override string ToString()
        {
            return string.Format("Bank borrowed money: {0}\nCentral bank interest rate: {1}%\nCentral bank recieved: {2},-", amountMoney, interestRate, bankRecieved);
        }
    }
}
