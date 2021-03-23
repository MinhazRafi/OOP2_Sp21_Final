using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account("Abdur Rahman", "1939", 65000);
            Account a2 = new Account("Minhazur Rahman", "2001", 80000);
            Account a3 = new Account("Radia Rahman", "2101", 58000);

            a1.Withdraw(500);
            a2.Withdraw(600);
            a1.Transfer(a2, 3500);
            a3.Deposit(5000);
            a1.showAllTranscation();
            a2.showAllTranscation();
        }
    }
}

