using BankTellerExerciseTests.Classes;
using System;

namespace BankTellerExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount checkingAccount = new CheckingAccount();
            BankAccount savingsAccount = new SavingsAccount();
            decimal amountToDeposit = 100.00M;
            decimal newBalance = checkingAccount.Deposit(amountToDeposit);
            decimal amountToWithdraw = 100.00M;
            decimal newBalanceWithdraw = checkingAccount.Withdraw(amountToWithdraw);
            decimal newBalanceWithdrawSavings = savingsAccount.Withdraw(amountToWithdraw);
            decimal newBalanceSavings = savingsAccount.Deposit(amountToDeposit);

            decimal amountToTransfer = 50.0M;
            checkingAccount.Transfer(savingsAccount, amountToTransfer);

            BankCustomer jayGatsby = new BankCustomer();
            jayGatsby.AddAccount(checkingAccount);
            jayGatsby.AddAccount(savingsAccount);



            Console.WriteLine($"Jay Gatsby withdrew {amountToWithdraw} from his Savings account and his new balance is {newBalanceWithdrawSavings}");
            Console.WriteLine($"Jay Gatsby deposited {amountToDeposit} into his Savings account and his new balance is {newBalanceSavings}");
            Console.WriteLine($"Jay Gatsby withdrew {amountToWithdraw} from his checking account and his new balance is {newBalanceWithdraw}");
            Console.WriteLine($"Jay Gatsby deposited {amountToDeposit} into his checking account and his new balance is {newBalance}");
            Console.WriteLine($"Jay Gatsby has {jayGatsby.Accounts.Length} accounts."); // Jay Gatsby has 2 accounts.
            Console.ReadLine();
        }
    }
}
