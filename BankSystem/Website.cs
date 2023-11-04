using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class Website
    {
        public Bank bank { get; set; }
        private IAccount account { get; set; }
        public void LogIn(string username, string password)
        {
            foreach (IAccount accounts in bank.accounts)
            {
                if(accounts.nameOwner.Equals(username) && accounts.password.Equals(password))
                {
                    account = accounts;
                    UserInterface();
                }
            }
        }
        private void UserInterface()
        {
            char choice;
            do
            {
                Console.Clear();
                Console.WriteLine(@"WEBSITE {0}:

Account number {1}
Your balance: {2},-

OPTIONS:
1 - INSERT MONEY
2 - PICK MONEY
3 - SEND MONEY
4 - CLOSE", bank.bankName,account.accountNumber, account.accountMoney);
                Console.Write("Select: ");
                choice = Console.ReadKey().KeyChar;
                Console.WriteLine();
                int money;
                switch (choice)
                {
                    case '1':
                        Console.Write("Insert money: ");
                        while (!int.TryParse(Console.ReadLine(), out money))
                        {
                            Console.Write("Insert money: ");
                        }
                        Console.WriteLine(account.InsertMoney(money));
                        break;
                    case '2':

                        Console.Write("Amount money: ");
                        while (!int.TryParse(Console.ReadLine(), out money))
                        {
                            Console.Write("Amount money: ");
                        }
                        Console.WriteLine(account.PickMoney(money));
                        break;
                    case '3':
                        int accountNumber;
                        Console.Write("Account number: ");
                        while (!int.TryParse(Console.ReadLine(), out accountNumber))
                        {
                            Console.Write("Account number: ");
                        }
                        Console.Write("Amount money: ");
                        while (!int.TryParse(Console.ReadLine(), out money))
                        {
                            Console.Write("Amount money: ");
                        }
                        Console.WriteLine(account.SendMoney(accountNumber, money));
                        break;

                }
                Console.ReadKey();
            } while (choice != '4');
        }
    }
}
