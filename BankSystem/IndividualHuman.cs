using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class IndividualHuman
    {
        public string name { get; private set; }
        public string surname { get; private set; }
        private DateTime birthday { get; set; }
        private Bank bank { get; set; }
        private CreditCard creditCard { get; set; }
        public const int maxAmountLoan = 2000000;
        public IndividualHuman(string name, string surname, DateTime birthday, Bank bank)
        {
            this.name = name;
            this.surname = surname;
            this.birthday = birthday;
            this.bank = bank;
        }
        public void CreateAccount(string password, int pinCode)
        {
            creditCard = bank.CreateAccount(name, surname, birthday, password, pinCode);
        }
        public void LookAtAccount(string password)
        {
            bank.website.LogIn(name, password);
        }
        public void GoATM(ATM atm, int pinCode)
        {
            atm.LoginToATM(creditCard, pinCode);
        }
        public void TakeLoan(int amount)
        {
            bank.GiveLoan()
        }
    }
}
