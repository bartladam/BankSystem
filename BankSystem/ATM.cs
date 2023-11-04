using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BankSystem
{
    internal class ATM
    {
        public void LoginToATM(CreditCard creditCard, int password)
        {
            Account account = creditCard.LogIn(password);
            if(account is not null)
            {
                char choice;
                do
                {
                    Console.Clear();
                    Console.WriteLine(@"ATM:

Account number {0}
Your balance: {1},-

OPTIONS:
1 - INSERT MONEY
2 - PICK MONEY
3 - CLOSE", account.accountNumber, account.accountMoney);
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
                    }
                    Console.ReadKey();

                } while (choice != '3');
            }
        }
    }
}
