namespace BasicSyntax_ClassesOOP;
class Program
{
    static void Main(string[] args)
    {
        var account1 = new BankAccount("Squidward", 260);
        Console.WriteLine($"New bank account for {account1.Owner} [Account ID #{account1.ID}], starting with ${account1.Balance}");


        Console.WriteLine("");
        

        account1.MakeWithdrawal(75, DateTime.Now, "Clarinet");
        Console.WriteLine($"$75 has been debited from {account1.Owner}'s account. Remaining balance: ${account1.Balance}");


        Console.WriteLine("");


        // Handling exceptions (try/catch)
        try{
            account1.MakeDeposit(-300, DateTime.Now, "tax fraud");
        }
        catch (ArgumentOutOfRangeException e){
            Console.WriteLine("Attempting to deposit a negative amount, cancelling transaction...");
            Console.WriteLine($"Exception is as follows: {e.ToString()}");
        }


        Console.WriteLine("");


        try{
            account1.MakeWithdrawal(9175, DateTime.Now, "Rent");
            Console.WriteLine($"$9175 has been debited from {account1.Owner}'s account. Remaining balance: ${account1.Balance}");
        }
        catch (InvalidOperationException e){
            Console.WriteLine("You're broke INSUFFICIENT FUNDS");
            Console.WriteLine($"Exception is as follows: {e.ToString()}");
        }


        Console.WriteLine("");


        Console.WriteLine(account1.GetTransactionStatement());
        
    }
}
