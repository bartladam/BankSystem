using System;
using System.Collections.Generic;
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
        public int accountMoney { get; private set; }
        private Random randomAccountNumber { get; init; }
        public int accountNumber { get; init; }
        public int bankCode { get; init; }
        private int memoryBalance { get; set; }
        public Account(string nameOwner, string surnameOwner, DateTime birthday, int bankCode)
        {
            this.nameOwner = nameOwner;
            this.surnameOwner = surnameOwner;
            this.birthday = birthday;
            this.bankCode = bankCode;
            randomAccountNumber = new Random();
            this.accountNumber = randomAccountNumber.Next();
            BankLoan b = new LoanCentralBank(5,2,DateTime.Now);

        }
        public string InsertMoney(int amount)
        {
            memoryBalance = accountMoney;
            accountMoney += amount;
            return string.Format("Balance before inserted {0}\n your new balance {1}", memoryBalance, accountMoney);
        }
        public string PickMoney(int amount)
        {
            memoryBalance = accountMoney;
            accountMoney -= amount;
            return string.Format("Balance before picked money: {0}\n current balance: {1}", memoryBalance, accountMoney);
        }
        public string SendMoney(Account account)
        {

            account.RecieveMoney();
            return "";
        }
        public string RecieveMoney()
        {
            return "";
        }
    }
}
