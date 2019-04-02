using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public  class Savings : Account
    {
        private int SaftyDepositeBoxID { get; set; }
        private int SaftyDepositeKey { get; set; }
        public Savings(string name, string SSN, double initDeposite ) : base (name,SSN,initDeposite)
        {
            AccountNumber = '1' + AccountNumber;
            setSeftyDepositeBOXID();
            SetRate();
        }
        public void SetRate()
        {
            Rate = BaseRate - .25;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Saving Account Features:");
            Console.WriteLine("AccountNumber: " + AccountNumber);
            Console.WriteLine("Safety Deposite BoxID: " + SaftyDepositeBoxID);
            Console.WriteLine("Safty Deposite Key: " + SaftyDepositeKey);
            Console.WriteLine("rate " + Rate);
        }

        private void setSeftyDepositeBOXID()
        {
            Random rnd = new Random();
            SaftyDepositeBoxID = rnd.Next(100, 1000);
            SaftyDepositeKey = rnd.Next(1000, 10000);
        }
    }
}
