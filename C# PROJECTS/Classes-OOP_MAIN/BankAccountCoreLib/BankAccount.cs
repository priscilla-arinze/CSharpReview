using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountCoreLib
{
    public class BankAccount
    {
        // Shorthand getter & setter properties (automatic properties), see https://codeeasy.io/lesson/properties
        public string ID { get; }
        public string Owner { get; set; }
        public decimal Balance { 
            get { // custom getter
                decimal balance = 0;

                foreach (var transaction in _allTransactions) {
                    balance += transaction.Amount;
                }

                return balance;
            } 
        }

        private static int accountNumberSeed = 101;

        private readonly decimal _minimumBalance;
        
        private List<Transaction> _allTransactions = new List<Transaction>();

        // Constructor (& constructor chaining/overloading [constructor choice depends on derived class])
        public BankAccount(string name, decimal initialBalance) : this(name, initialBalance, 0) { }

        public BankAccount(string name, decimal initialBalance, decimal minimumBalance) {
            this.Owner = name;
            // no need to assign 'this.Balance' in constructor since a custom getter has been written above
            // this.Balance = initialBalance; 
            this.ID = accountNumberSeed.ToString();
            accountNumberSeed++;

            _minimumBalance = minimumBalance;
            if (initialBalance > 0)
                MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
        }

        public void MakeDeposit(decimal amount, DateTime date, string description) {
            if (amount <= 0) {
                // raising/throwing exceptions
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            
            var deposit = new Transaction(amount, date, description);
            _allTransactions.Add(deposit);
        }

        /* OLD VERSION***********************************************************************
        public void MakeWithdrawal(decimal amount, DateTime date, string description) {
            if (amount <= 0) {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance - amount < _minimumBalance) {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, description);
            allTransactions.Add(withdrawal);
        }
        */
        // NEW VERSION: nullable reference types ('?') for overdraft transactions
        // '?' annotation allows method to return null
        public void MakeWithdrawal(decimal amount, DateTime date, string note) {
            if (amount <= 0) {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }

            Transaction? overdraftTransaction = CheckWithdrawalLimit(Balance - amount < _minimumBalance);
            Transaction? withdrawal = new(-amount, date, note);

            _allTransactions.Add(withdrawal);

            if (overdraftTransaction != null)
                _allTransactions.Add(overdraftTransaction);
        }

        // `protected` access: can only be accessed from base/inherited classes (e.g. cannot be directly called from main())
        // `virtual` keyword gives inherited classes the (optional) ability to override base class implementation --> LineOfCreditAccount class
        protected virtual Transaction? CheckWithdrawalLimit(bool isOverdrawn) {
            if (isOverdrawn) {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            else {
                return default;
            }
        }

        // Will be used to demonstrate polymorphism in InterestEarningAccount class below
        // `virtual` keyword gives inherited classes the (optional) ability to override base class implementation
        // an `abstract` keyword is similar to `virtual`, but it is required to override base class implementation
        public virtual void PerformMonthEndTransactions() { }


        // Using a StringBuilder object to get transaction history
        // StringBuilders are kinda like Python's 3-quoted strings or .join()
        public string GetTransactionStatement() {
            var report = new StringBuilder(); // in System.Text 

            //HEADER
            report.AppendLine("Date\t\tAmount\tDescription"); // '\t' is tabbed whitespace

            foreach (var transaction in _allTransactions) {
                //ROWS
                // DateTime.ToShortDateString() excludes the time and only includes the date
                report.AppendLine($"{transaction.Date.ToShortDateString()}\t${transaction.Amount}\t{transaction.Description}");
            }

            return report.ToString();
        }
    }
}