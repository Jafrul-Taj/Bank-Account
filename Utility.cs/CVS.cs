using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility.cs
{
    public class CVS
    {
        public static List<string[]> Read()
        {
            List<string[]> records = new List<string[]>();
            string a = File.ReadAllText(@"C:\Users\Jafrul Hasan Taj\source\repos\BankAccount\NewBankAccounts.csv");
            
            string[] b = a.Split('\n');

            for(int i =0; i<b.Length; i++)
            {
                string[] c = b[i].Split(',');
                records.Add(c);
            }
            return records;
        }
    }
}
