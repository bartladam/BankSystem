﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class Bank
    {
        public string bankName { get; private set; }
        public enum countryResidence {CzechRepublic, Slovakia, Germany, Poland, Hungary, Austria, Switzerland}
        public countryResidence residence { get; private set; }
        public string bankAdress { get; private set; }
        public int bankCode { get; init; }
        public Website website { get; init; }
        public List<IAccount> accounts { get; private set; }
        public List<ATM> ATMs { get; private set; }
        public CentralBank centralBank { get; set; }
        public LoanCentralBank loan { get; set; }
        public Bank(string bankName, countryResidence residence, string bankAdress, int bankCode, Website website)
        {
            this.bankName = bankName;
            this.residence = residence;
            this.bankAdress = bankAdress;
            this.bankCode = bankCode;
            this.website = website;
            accounts = new List<IAccount>();
            ATMs = new List<ATM>();
            website.bank = this;
        }
        public virtual BankLoan GiveLoan(int amount, DateTime lengthLoan)
        {
            return new BankLoan(amount,centralBank.interestRate - 0.2d, lengthLoan);
        }
        public CreditCard CreateAccount(string name, string surname, DateTime birthday,string accountPassword, int pinCode)
        {
            CreditCard creditCard = new CreditCard(pinCode);
            accounts.Add(new Account(name, surname, birthday, accountPassword, bankCode, creditCard, centralBank));
            return creditCard;
        }
        public void TakeLoan(int amount, DateTime lengthLoan)
        {
            loan = centralBank.GiveLoan(amount, lengthLoan);
            loan.bank = this;            
        }
        public void NewATM(ATM atm)
        {
            ATMs.Add(atm);
        }
      


    }
}
