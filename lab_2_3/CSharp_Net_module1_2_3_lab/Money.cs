using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_3_lab
{
    // 1) declare enumeration CurrencyTypes, values UAH, USD, EU
    enum CurrencyTypes
    {
        UAH,
        USD,
        EU
    }

    class Money
    {
        // 2) declare 2 properties Amount, CurrencyType
        public double Amount { get; set; }
        public CurrencyTypes CurrencyType;
        // 3) declare parameter constructor for properties initialization
        public Money(double Amount, CurrencyTypes CurrencyType)
        {
            double _amount = Amount;
            CurrencyTypes _currencyType = CurrencyType;
        }
        // 4) declare overloading of operator + to add 2 objects of Money
        public static Money operator +(Money m1, Money m2)
        {
            return new Money(m1.Amount + m2.Amount, m1.CurrencyType);
        }
        // 5) declare overloading of operator -- to decrease object of Money by 1

        // 6) declare overloading of operator * to increase object of Money 3 times

        // 7) declare overloading of operator > and < to compare 2 objects of Money

        // 8) declare overloading of operator true and false to check CurrencyType of object

        // 9) declare overloading of implicit/ explicit conversion  to convert Money to double, string and vice versa
        /*public static AddToBalance(double amount, CurrencyTypes type)
        {
            if (type == CurrencyTypes.UAH)
            {
                Money.Amount = Money.Amount + amount;
                return 
            }
            if (this.CurrencyType == CurrencyTypes.USD)
            {
                this.Amount = this.Amount + (amount * 26.3);
                
            }
            if (this.CurrencyType == CurrencyTypes.EU)
            {
                this.Amount = this.Amount + (amount * 30.5);
            }
            else
            {
                Console.WriteLine("Wrong Currency");
            }

        }*/

    }
}
