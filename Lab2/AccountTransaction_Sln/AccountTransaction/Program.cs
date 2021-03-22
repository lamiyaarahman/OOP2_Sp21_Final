using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountTransaction
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account("Lamiya", "1234", 60000);
            Account a2 = new Account("Bony", "5678", 90000);
            a1.showInfo();
            a2.showInfo();
            a1.Withdraw(1000);
            a1.Deposit(10000);
            a1.Transfer(a2, 5000);
            a1.showInfo();
            a2.showInfo();
            Transaction t1 = new Transaction(a1, a2, 7000, "Business perpose");
            t1.showInfo();
        }
    }
}
