
using System;
using System.Text.RegularExpressions;
using BankAccountCoreLib;

namespace BankAccountTests;

public class BankUnitTests
{
    [Fact]
    public void WhenDeposit_ShouldIncreaseBalance()
    {
        BankAccount testaccount = new BankAccount("TestAccount", 100);

        testaccount.MakeDeposit(10, DateTime.Now, "very successful bank robbery");

        Assert.Equal(110, testaccount.Balance);
    }
    
    [Fact]
    public void WhenWithdrawal_ShouldDecreaseBalance()
    {
        BankAccount testaccount = new BankAccount("TestAccount", 100);

        testaccount.MakeWithdrawal(95, DateTime.Now, "gambling");

        Assert.Equal(5, testaccount.Balance);
    }

    [Fact]
    public void ShouldSaveMultipleTransactions()
    {
        BankAccount testaccount = new BankAccount("TestAccount", 100); //initial transaction
        testaccount.MakeDeposit(7, DateTime.Now, "massive salary direct deposit");
        testaccount.MakeWithdrawal(20, DateTime.Now, "groceries");
        testaccount.MakeWithdrawal(5, DateTime.Now, "some more groceries");
        testaccount.MakeDeposit(500, DateTime.Now, "gambling winnings");
        testaccount.MakeWithdrawal(550, DateTime.Now, "irs back taxes <3");

        string transactionstmt = testaccount.GetTransactionStatement();

        Regex pattern = new Regex(@$"{DateTime.Now.ToShortDateString()}");
        MatchCollection matches = pattern.Matches(transactionstmt);
        Assert.Equal(6, matches.Count);

    }

    [Fact]
    public void WhenNegativeDeposit_ThrowsException()
    {
        BankAccount testaccount = new BankAccount("TestAccount", 100);

        // Anonymous function
        Assert.Throws<ArgumentOutOfRangeException>(
            () => testaccount.MakeDeposit(-300, DateTime.Now, "negative deposit glitch")
        );
    }

    [Fact]
    public void WhenInsufficientFunds_ThrowsException()
    {
        BankAccount testaccount = new BankAccount("TestAccount", 100);

        // Anonymous function
        Assert.Throws<InvalidOperationException>(
            () => testaccount.MakeWithdrawal(1275, DateTime.Now, "bananas")
        );
    }
}