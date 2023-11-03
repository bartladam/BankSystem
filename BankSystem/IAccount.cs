using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal interface IAccount
    {
        string nameOwner { get; }
        string surnameOwner { get; }
        DateTime birthday { get; }
        int accountMoney { get; }
        int accountNumber { get; }
        int bankCode { get; }
        string InsertMoney(int amount);
        string PickMoney(int amount);
        string SendMoney(Account account);
        string RecieveMoney();
    }
}
