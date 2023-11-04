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
                    Console.WriteLine(@"
OPTIONS:
1 - INSERT MONEY
2 - PICK MONEY
3 - SEND MONEY
4 - CLOSE");
                    Console.Write("Select: ");
                    choice = Console.ReadKey().KeyChar;
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
                            Console.WriteLine("Account number");
                            while (!int.TryParse(Console.ReadLine(), out accountNumber))
                            {
                                Console.WriteLine("Account number");
                            }
                            Console.WriteLine("Amount money");
                            while (!int.TryParse(Console.ReadLine(), out money))
                            {
                                Console.Write("Amount money: ");
                            }
                            Console.WriteLine(account.SendMoney(accountNumber,money));
                            break;

                    }

                } while (choice != '4');
            }
        }
    }
}
