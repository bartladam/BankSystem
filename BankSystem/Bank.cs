using System;
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
        private List<IAccount> accounts { get; set; }
        public List<ATM> ATMs { get; private set; }
        public CentralBank centralBank { get; set; }
        private LoanCentralBank loan { get; set; }
        public Bank(string bankName, countryResidence residence, string bankAdress, int bankCode, Website website)
        {
            this.bankName = bankName;
            this.residence = residence;
            this.bankAdress = bankAdress;
            this.bankCode = bankCode;
            this.website = website;
            accounts = new List<IAccount>();
            ATMs = new List<ATM>();
        }
        public void GiveLoan()
        {
            
        }
        public void CreateAccount()
        {

        }
        public void TakeLoan()
        {

        }
        public void NewATM()
        {
            ATMs.Add(new ATM());
        }
      


    }
}
