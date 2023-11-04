using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class Account:IAccount
    {
        public string nameOwner { get; private set; }
        public string surnameOwner { get; private set; }
        public DateTime birthday { get; init; }
        public string password { get; private set; }
        public int accountMoney { get; private set; }
        private Random randomAccountNumber { get; init; }
        public int accountNumber { get; init; }
        public int bankCode { get; init; }
        public CreditCard creditCard { get; private set; }
        public CentralBank centralBank { get; private set; }
        public Account(string nameOwner, string surnameOwner, DateTime birthday, string password,int bankCode, CreditCard creditCard, CentralBank centralBank)
        {
            this.nameOwner = nameOwner;
            this.surnameOwner = surnameOwner;
            this.birthday = birthday;
            this.password = password;
            this.bankCode = bankCode;
            this.creditCard = creditCard;
            this.centralBank = centralBank;
            randomAccountNumber = new Random();
            this.accountNumber = randomAccountNumber.Next();
            creditCard.account = this;
        }
        public string InsertMoney(int amount)
        {
            accountMoney += amount;
            return string.Format("Your new balance {0},-", accountMoney);
        }
        public string PickMoney(int amount)
        {
            accountMoney -= amount;
            return string.Format("Current balance: {0},-", accountMoney);
        }
        public string SendMoney(int accountNumber, int amountMoney)
        {
            foreach (Bank banks in centralBank.banks)
            {
                foreach (IAccount account in banks.accounts)
                {
                    if (account.accountNumber.Equals(accountNumber))
                    {
                        account.RecieveMoney(this.accountNumber,amountMoney);
                        accountMoney -= amountMoney;
                        return string.Format("Send to account number {0} amount {1},-\nYour balance {2},-",accountNumber ,amountMoney, accountMoney);
                    }
                }
            }
            return string.Format("Account doesn't exists");
        }
        public string RecieveMoney(int accountNumber ,int amountMoney)
        {
            accountMoney += amountMoney;
            return string.Format("account: {0}\nrecieved money {1},-\nYour balance {2},-", accountNumber, amountMoney, accountMoney);
        }
        public override string ToString()
        {
            return accountNumber.ToString();
        }
    }
}
