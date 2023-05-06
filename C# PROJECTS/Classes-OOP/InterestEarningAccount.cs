using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes_OOP
{
    public class InterestEarningAccount : BankAccount
    {
        // If constructor is defined in base class, derived class must also declare a constructor that includes all parameters
        // from base class constructor
        public InterestEarningAccount(string name, decimal initialBalance) : base(name, initialBalance) { }

        // derived from virtual method in BankAccount
        public override void PerformMonthEndTransactions() {
            if (Balance > 500m)
            {
                decimal interest = Balance * 0.05m;
                MakeDeposit(interest, DateTime.Now, "apply monthly interest");
            }
        }
    }
}