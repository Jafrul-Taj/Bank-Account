using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public abstract class Account : IBaseRate
    {
        private string Name { get; set; }
        private string SSN { get; set; }
        protected string AccountNumber { get; set; }
        protected double Rate { get; set; }
        private double Balance { get; set; }
        public static double BaseRate = 2.5;
       
        static int index = 10000;
        
        public Account(string name, string ssn, double initDeposit)
        {

           // BaseRate = 2.5;
            Name = name;
            SSN = ssn;
            Balance = initDeposit;
            index++;
            AccountNumber = SetAccountNumber();
           
        }
        public void Transfer(double amount)
        {
            Balance -= amount;
            PrintBalance();
        }
        public void Deposit(double amount)
        {
            Balance += amount;

            PrintBalance();
        }
        public void WithDrow(double amount)
        {
            Balance -= amount;

            PrintBalance();
        }
        public void PrintBalance()
        {
            Console.WriteLine("Your Balance is " + Balance);
        }
        public void Compound()
        {
            var AccourdInterest = Balance * (Rate/100);
            Console.WriteLine("Accourd Interest: {0} ",AccourdInterest);
            Balance += AccourdInterest;
            PrintBalance();
        }

        private string SetAccountNumber()
        {
            string lastTwoNumber = SSN.Substring(SSN.Length - 2);
            int uniqueID = index;
            string random3numbers = null;
            for(int i = 0; i<2;i++)
            {
                Random random = new Random();
                int num = Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65));
                random3numbers +=  num;
            }
            
            return lastTwoNumber+uniqueID+random3numbers.Substring(1);
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine("Name: {0}" +
                "\nAccountNumber: {1} " +
                "\nBalance: {2}", Name,AccountNumber,Balance,Rate);
        }
    }
}
