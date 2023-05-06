namespace Classes_OOP;
class Program
{
    static void Main(string[] args)
    {
        BasicBankAccountSetup();
        SpecificBankAccountSetup();
    }





    private static void BasicBankAccountSetup() {
        var account1 = new BankAccount("Squidward", 260);
        Console.WriteLine($"New bank account for {account1.Owner} [Account ID #{account1.ID}], starting with ${account1.Balance}");

        account1.MakeWithdrawal(75, DateTime.Now, "Clarinet");
        Console.WriteLine($"$75 has been debited from {account1.Owner}'s account. Remaining balance: ${account1.Balance}");


        // Handling exceptions (try/catch):
        try{
            account1.MakeDeposit(-300, DateTime.Now, "tax fraud");
        }
        catch (ArgumentOutOfRangeException e){
            Console.WriteLine("Attempting to deposit a negative amount, cancelling transaction...");
            Console.WriteLine($"Exception is as follows: {e.ToString()}");
        }

        try{
            account1.MakeWithdrawal(9175, DateTime.Now, "Rent");
            Console.WriteLine($"$9175 has been debited from {account1.Owner}'s account. Remaining balance: ${account1.Balance}");
        }
        catch (InvalidOperationException e){
            Console.WriteLine("You're broke INSUFFICIENT FUNDS");
            Console.WriteLine($"Exception is as follows: {e.ToString()}");
        }


        Console.WriteLine(account1.GetTransactionStatement());
    }


    private static void SpecificBankAccountSetup() {
        var giftCard = new GiftCardAccount("gift card", 100, 50);
        giftCard.MakeWithdrawal(20, DateTime.Now, "get expensive coffee");
        giftCard.MakeWithdrawal(50, DateTime.Now, "buy groceries");
        giftCard.PerformMonthEndTransactions();
        // can make additional deposits:
        giftCard.MakeDeposit(27.50m, DateTime.Now, "add some additional spending money");
        Console.WriteLine(giftCard.GetTransactionStatement());

        var savings = new InterestEarningAccount("savings account", 10000);
        savings.MakeDeposit(750, DateTime.Now, "save some money");
        savings.MakeDeposit(1250, DateTime.Now, "Add more savings");
        savings.MakeWithdrawal(250, DateTime.Now, "Needed to pay monthly bills");
        savings.PerformMonthEndTransactions();
        Console.WriteLine(savings.GetTransactionStatement());

        
        // Sufficient line of credit:
        Console.WriteLine("\nSufficient line of credit:");
        var lineOfCredit = new LineOfCreditAccount("line of credit", 0, 11000);
        //How much is too much to borrow?
        lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, "Take out monthly advance");
        lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
        lineOfCredit.MakeWithdrawal(5000m, DateTime.Now, "Emergency funds for repairs");
        lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
        lineOfCredit.PerformMonthEndTransactions();
        Console.WriteLine(lineOfCredit.GetTransactionStatement());


        // Insufficient line of credit:
        Console.WriteLine("\nInsufficient line of credit:");
        var lineOfCredit1 = new LineOfCreditAccount("line of credit", 0, 500);
        //How much is too much to borrow?
        lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, "Take out monthly advance");
        lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
        lineOfCredit.MakeWithdrawal(5000m, DateTime.Now, "Emergency funds for repairs");
        lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
        lineOfCredit.PerformMonthEndTransactions();
        Console.WriteLine(lineOfCredit.GetTransactionStatement());

        // Overdraft transactions:
        Console.WriteLine("\nOverdraft transactions:");
        var lineOfCredit2 = new LineOfCreditAccount("line of credit", 0, 2000);
        // How much is too much to borrow?
        lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, "Take out monthly advance");
        lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
        lineOfCredit.MakeWithdrawal(5000m, DateTime.Now, "Emergency funds for repairs");
        lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
        lineOfCredit.PerformMonthEndTransactions();
        Console.WriteLine(lineOfCredit.GetTransactionStatement());

    }
}
