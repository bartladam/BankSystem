using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class CreditCard
    {
        public Account account { get; set; }
        private int password { get; set; }
        public CreditCard(int password)
        {
            this.password = password;
        }
        public Account LogIn(int password)
        {
            if(this.password.Equals(password))
            {
                return account;
            }
            return null;
        }
    }
}
