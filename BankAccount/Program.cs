using System;
using System.Collections.Generic;
using Utility;
using Utility.cs;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>();
            
            
            List<string[]> Records = CVS.Read();
            foreach (var record in Records)
            {
                var Name = record[0];
                var SSN = record[1];
                var deposit = double.Parse(record[3]);
                if (record[2] == "Savings")
                {
                    Console.WriteLine("\n****************");
                    var a = new Savings(Name, SSN, deposit);
                    accounts.Add(a);
                    a.ShowInfo();
                }
                else if (record[2] == "Checking")
                {
                    Console.WriteLine("\n****************");
                    var a = new Checkings(Name, SSN, deposit);
                    accounts.Add(a);
                    a.ShowInfo();
                }
            }

            //foreach(var record in Records)
            //{
            //    for (int i =0; i<record.Length;i++)
            //    {
            //        Console.Write(record[i] + " ");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
