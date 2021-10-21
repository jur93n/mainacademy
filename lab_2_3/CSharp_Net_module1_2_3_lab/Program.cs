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

            // Declare 3 objects
            Money BalanceUAH = new Money(21000, CurrencyTypes.UAH);
            Money BalanceUSD = new Money(250, CurrencyTypes.USD);
            Money Deposit = new Money(1000, CurrencyTypes.EU);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("====== Hello, this is National Bank of Mainacademy ======");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Your current UAH balance is: {BalanceUAH.Amount} {BalanceUAH.CurrencyType}");
            Console.WriteLine($"Your current USD balance is: {BalanceUSD.Amount} {BalanceUSD.CurrencyType}");
            Console.WriteLine($"And you have an {Deposit.Amount} {Deposit.CurrencyType} on cash");

            // Do operations
            // Add 2 objects of Money
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Add {Deposit.Amount} {Deposit.CurrencyType} to UAH balance");
            BalanceUAH += Deposit; //or method var balanceUAH = Money.AddToBalance(BalanceUAH, Deposit
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Your UAH balance is {BalanceUAH.Amount} {BalanceUAH.CurrencyType}");

            // Compare two Balances UAH and USD
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Compare two Balances UAH and USD");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Your UAH balance is: {BalanceUAH.Amount} {BalanceUAH.CurrencyType}");
            Console.WriteLine($"Your USD balance is: {BalanceUSD.Amount} {BalanceUSD.CurrencyType}");
            bool status = BalanceUAH > BalanceUSD;
            if (status == true)
            {
                Console.WriteLine("UAH balance > USD Balance");
            }
            else
            {
                Console.WriteLine("UAH balance < USD Balance");
            }
            
            //Remove from UA balance some money
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Remove from UAH Balance 100 USD");
            BalanceUAH.RemoveFromBalance(100, CurrencyTypes.USD);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Your UAH balance is: {BalanceUAH.Amount} {BalanceUAH.CurrencyType}");

            //Show UA balance in EU
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Show UAH Balance in EU, current balance is: {BalanceUAH.Amount} {BalanceUAH.CurrencyType}");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Your UAH balance in EU (30,5) is: {BalanceUAH.GetBalance(CurrencyTypes.EU)}");

            //Change cost of EU to UAH
            Console.ForegroundColor = ConsoleColor.Green;
            var course = 31.4;
            Console.WriteLine($"EU is up to {course} UAH per EU");
            BalanceUAH.SetCourse(course, CurrencyTypes.EU);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Your UAH balance in EU ({course}) is: {BalanceUAH.GetBalance(CurrencyTypes.EU)}");

            // !!!Not actual task below
            // add 1st object of Money and double
            // decrease 2nd object of Money by 1 
            // increase 1st object of Money
            // compare 2 objects of Money
            // compare 2nd object of Money and string
            // check CurrencyType of every object
            // convert 1st object of Money to string
            Console.ReadKey();
        }
    }
}
