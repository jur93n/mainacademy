using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_3_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10) declare 2 objects
            Money Balance = new Money(0, CurrencyTypes.UAH) ; 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("============ Hello, this is National Bank of Mainacademy ============" );
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Your current balance is: {Balance.Amount} {Balance.CurrencyType}");
            Money Deposit = new Money(1000, CurrencyTypes.USD);
            Balance = Balance.AddToBalance(1000, CurrencyTypes.UAH);
            Console.WriteLine($"Your balance is {Balance + Deposit}");
            
            // 11) do operations

            // add 2 objects of Money

            // add 1st object of Money and double

            // decrease 2nd object of Money by 1 

            // increase 1st object of Money

            // compare 2 objects of Money

            // compare 2nd object of Money and string

            // check CurrencyType of every object

            // convert 1st object of Money to string

        }
    }
}
