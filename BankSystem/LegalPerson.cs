using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class LegalPerson:IndividualHuman
    {
        public string nameCompany { get; private set; }
        public LegalPerson(string name, string surname, DateTime birthday, Bank bank, string nameCompany) : base (name, surname, birthday, bank)
        {
            this.nameCompany = nameCompany;
            maxAmountLoan = 8000000;
        }
    }
}
