using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public class Checkings : Account

    { 
        private string DebitCardNumber { get; set; }
        readonly int DebitCartNumberSize = 12;
        private int DebitPin { get; set; }
        

        public Checkings(String name, string SSN, double initDeposite) : base(name,SSN,initDeposite)
        {
            AccountNumber = '2' + AccountNumber;
            SetDebitAccoutNumber();
            setRate();

        }
        public   void setRate()
        {
            Rate = BaseRate * .15;
        }
        private void SetDebitAccoutNumber()
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            StringBuilder builder = new StringBuilder();
            string s;
            for (int i = 0; i < DebitCartNumberSize; i++)
            {
                s = Convert.ToString(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(s);
            }
            DebitCardNumber= builder.ToString();

            DebitPin = random.Next(1000, 9999);
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("AccountNumber: " + AccountNumber);
            Console.WriteLine("DebitCardNumber: " + DebitCardNumber);
            Console.WriteLine("DebitPin: " + DebitPin);
            Console.WriteLine("rate " + Rate);
        }
    }
}
