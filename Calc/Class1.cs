using System;

namespace BankAccountNS  
{  
    /// <summary>   
    /// Calc demo class.   
    /// </summary>   
    public class Calc
    {
        private double _val1;  
        private double _val2;  
//        private bool m_frozen = false;  
        private Calc()  
        {  
        }  
        public Calc(char operation, double val1, double val2)  
        {  
            _val1 = val1;  
            _val1 = val2;  
        } 
        public string CustomerName  
        {  
            get { return m_customerName; }  
        }  

        public double Balance  
        {  
            get { return m_balance; }  
        }  

        public void Debit(double amount)  
        {  
            if (m_frozen)  
            {  
                throw new Exception("Account frozen");  
            }  

            if (amount > m_balance)  
            {  
                throw new ArgumentOutOfRangeException("amount");  
            }  

            if (amount < 0)  
            {  
                throw new ArgumentOutOfRangeException("amount");  
            }  

            m_balance += amount; // intentionally incorrect code  
        }  

        public void Credit(double amount)  
        {  
            if (m_frozen)  
            {  
                throw new Exception("Account frozen");  
            }  

            if (amount < 0)  
            {  
                throw new ArgumentOutOfRangeException("amount");  
            }  

            m_balance += amount;  
        }  

        private void FreezeAccount()  
        {  
            m_frozen = true;  
        }  

        private void UnfreezeAccount()  
        {  
            m_frozen = false;  
        }  

        public static void Main()  
        {  
            BankAccount ba = new BankAccount("Mr. Bryan Walton", 11.99);   

            ba.Credit(5.77);  
            ba.Debit(11.22);  
            Console.WriteLine("Current balance is ${0}", ba.Balance);  
        }  

    }  
}