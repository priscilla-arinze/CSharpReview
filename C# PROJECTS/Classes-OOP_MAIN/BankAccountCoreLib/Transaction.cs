using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccountCoreLib
{
    public class Transaction
    {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Description { get; }

        public Transaction(decimal amount, DateTime date, string description) {
            this.Amount = amount;
            this.Date = date;
            this.Description = description;
        }
    }
}