using System;
using System.Text;

namespace BasicSyntax_ClassesOOP {
    public class BankAccount {
        // Shorthand getter & setter methods, see https://codeeasy.io/lesson/properties
        public string ID { get; }
        public string Owner { get; set; }
        public decimal Balance { 
            get { // custom getter
                decimal balance = 0;

                foreach (var transaction in allTransactions) {
                    balance += transaction.Amount;
                }

                return balance;
            } 
        }

        private static int accountNumberSeed = 101;
        private List<Transaction> allTransactions = new List<Transaction>();


        // CONSTRUCTOR
        public BankAccount(string name, decimal initialBalance) {
            this.Owner = name;
            // this.Balance = initialBalance; // no need to assign 'this.Balance' in constructor since a custom getter has been written above
            this.MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
            this.ID = accountNumberSeed.ToString();
            accountNumberSeed++;
        }


        // METHODS
        public void MakeDeposit(decimal amount, DateTime date, string description) {
            if (amount <= 0) {
                // raising/throwing exceptions
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            
            var deposit = new Transaction(amount, date, description);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string description) {
            if (Balance - amount < 0) {
                throw new InvalidOperationException("You're broke INSUFFICIENT FUNDS");
            }
            var withdrawal = new Transaction(-amount, date, description);
            allTransactions.Add(withdrawal);
        }


        // Using a StringBuilder object to get transaction history
        // StringBuilders are kinda like Python's 3-quoted strings or .join()
        public string GetTransactionStatement() {
            var report = new StringBuilder(); // in System.Text 

            //HEADER
            report.AppendLine("Date\t\tAmount\tDescription"); // '\t' is tabbed whitespace

            foreach (var transaction in allTransactions) {
                //ROWS
                // DateTime.ToShortDateString() excludes the time and only includes the date
                report.AppendLine($"{transaction.Date.ToShortDateString()}\t${transaction.Amount}\t{transaction.Description}");
            }

            return report.ToString();
        }
    }
}

