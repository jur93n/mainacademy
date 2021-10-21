using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_3_lab
{
    // 1) declare enumeration CurrencyTypes, values UAH, USD, EU
    public enum CurrencyTypes 
    {
        Unknown,
        UAH,
        USD,
        EU
    }
    class Money
    {
        // 2) declare 2 properties Amount, CurrencyType
        public double Amount { get; private set; }
        public CurrencyTypes CurrencyType { get; private set; }
        //тут можна зробити 2 приватні змінні з курсом для євро і долара і через методи їм встановлювати нові значення

        // 3) declare parameter constructor for properties initialization
        public Money(double _Amount, CurrencyTypes _CurrencyType)
        {
            Amount = _Amount;
            CurrencyType = _CurrencyType;
        }
        // 4) declare overloading of operator + to add 2 objects of Money
        public static Money operator +(Money m1, Money m2)
        {
            if (m2.CurrencyType == CurrencyTypes.UAH)
            {
                m1.Amount += m2.Amount;

            }
            if (m2.CurrencyType == CurrencyTypes.USD)
            {
                m1.Amount += (m2.Amount * 26.3);

            }
            if (m2.CurrencyType == CurrencyTypes.EU)
            {
                m1.Amount += (m2.Amount * 30.5);
            }
            return m1;
        }
        // 5) declare overloading of operator -- to decrease object of Money by 1
        public static Money operator -(Money m1, Money m2)
        {
            if (m2.CurrencyType == CurrencyTypes.UAH)
            {
                m1.Amount -= m2.Amount;

            }
            if (m2.CurrencyType == CurrencyTypes.USD)
            {
                m1.Amount -= (m2.Amount * 26.3);

            }
            if (m2.CurrencyType == CurrencyTypes.EU)
            {
                m1.Amount -= (m2.Amount * 30.5);
            }
            return m1;
        }
        // 6) declare overloading of operator * to increase object of Money 3 times
        public static Money operator *(Money m1, Money m2)
        {
            if (m2.CurrencyType == CurrencyTypes.UAH)
            {
                m1.Amount *= m2.Amount;

            }
            if (m2.CurrencyType == CurrencyTypes.USD)
            {
                m1.Amount *= (m2.Amount * 26.3);

            }
            if (m2.CurrencyType == CurrencyTypes.EU)
            {
                m1.Amount *= (m2.Amount * 30.5);
            }
            return m1;
        }
        public static Money operator *( Money m1, double m2)
        {
            m1.Amount *= m2;
            return m1;
        }
        // 7) declare overloading of operator > and < to compare 2 objects of Money
        public static bool operator > (Money m1, Money m2)
        {
            bool status;
            if (m2.CurrencyType == CurrencyTypes.UAH && m1.Amount > m2.Amount)
            {
                status = true;
                return status;
            }            
            if (m2.CurrencyType == CurrencyTypes.USD)
            {
                m2.Amount *= 26.3;
                if (m1.Amount > m2.Amount)
                {
                    status = true;
                }
                else
                {
                    status = false;
                }
                return status;
            }            
            if (m2.CurrencyType == CurrencyTypes.EU)
            {
                m2.Amount *=30.5;
                if (m1.Amount > m2.Amount)
                {
                    status = true;
                }
                else
                {
                    status = false;
                }
                return status;                
            }
            status = false;
            return status;
        }            
        public static bool operator <(Money m1, Money m2)
        {
            bool status;
            if (m1.Amount < m2.Amount && m2.CurrencyType == CurrencyTypes.UAH)
            {
                status = true;
            }            
            else if (m2.CurrencyType == CurrencyTypes.USD)
            {
                m2.Amount *= 26.3;
                if (m1.Amount < m2.Amount)
                {
                    status = true;                    
                }
                else
                {
                    status = false;
                }
                return status;
            }            
            else if (m2.CurrencyType == CurrencyTypes.EU)
            {
                m2.Amount *= 30.5;
                if (m1.Amount < m2.Amount)
                {
                    status = true;                    
                }
                else
                {
                    status = false;
                }
                return status;
            }
            else
            {
                status = false;
                
            }
            return status;

        }
        // 8) метод void AddToBalance(float amount, CurrencyType type); - який докидує в гаманець потрібну кількість грошей потрібної валюти
        public void AddToBalance(Money m2) //тут лилити лиш другий гаманець так як ти вже знаходишся в першому гаманці
        {
            if (m2.CurrencyType == CurrencyTypes.UAH)
            {
                Amount += m2.Amount;

            }
            if (m2.CurrencyType == CurrencyTypes.USD)
            {
                Amount += (m2.Amount * 26.3);

            }
            if (m2.CurrencyType == CurrencyTypes.EU)
            {
                Amount += (m2.Amount * 30.5);
            }            
        }
        // 9) метод void RemoveFromBalance(float amount, CurrencyType type); - який забирає з гаманця потрібну кількість грошей у вказаній валюті 
        public void RemoveFromBalance(double _Amount, CurrencyTypes _CurrencyType)
        {
            if (_CurrencyType == CurrencyTypes.UAH)
            {
                Amount -= _Amount;
            }
            else if (_CurrencyType == CurrencyTypes.USD)
            {
                Amount -= _Amount * 26.3;
            }
            else if (_CurrencyType == CurrencyTypes.EU)
            {
                Amount -= _Amount * 30.5;
            }
            else
            {
                Console.WriteLine("Wrong currency");
            }
        }

        // 10) метод float GetBalance(CurrencyType type); - повертає кількість грошей у вказаній валюті
        public double GetBalance(CurrencyTypes _CurrencyType)
        {
            if (_CurrencyType == CurrencyTypes.UAH)
            {
                return Amount;
            }
            else if (_CurrencyType == CurrencyTypes.USD)
            {
                Amount /= 26.3;
                return Amount;
            }
            else if (_CurrencyType == CurrencyTypes.EU)
            {
                Amount /=  30.5;
                return Amount;
            }
            else
            {
                Console.WriteLine("Wrong currency");
            }
            return Amount;
        }

        // 11) метод void SetCourse(float course, CurrencyType type) - який встановлює курс обміну відносно гривні
        public void SetCourse(double _Course, CurrencyTypes _CurrencyType) //ніпалучилось ))
        {
            CurrencyType = _CurrencyType;
            Amount *= _Course;            
        }
    }
}
