using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class CentralBank:Bank
    {
        public double interestRate { get; private set; }
        public List<Bank> banks { get; private set; }
        public CentralBank(string bankName, countryResidence residence, string bankAdress, int bankCode, Website website) : base(bankName, residence, bankAdress, bankCode, website)
        {
            banks = new List<Bank>();
        }
        public void ChangeInterestRate(double percentage)
        {
            interestRate = percentage;
        }
        public override LoanCentralBank GiveLoan(int amount, DateTime lengthLoan) => new LoanCentralBank(amount, interestRate, lengthLoan);

        public void AddBank(Bank bank)
        {
            banks.Add(bank);
        }
        public void RemoveBank(Bank bank)
        {
            banks.Remove(bank);
        }
    }
}
