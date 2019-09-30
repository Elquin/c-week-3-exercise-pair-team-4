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
            decimal amountToWithdraw = 145.00M;

            decimal newBalanceChecking =checkingAccount.Deposit(amountToDeposit);
            Console.WriteLine($"Jay Gatsby deposited ${amountToDeposit} into his checking account and his new balance is ${newBalanceChecking}");

            decimal newBalanceWithdrawChecking = checkingAccount.Withdraw(amountToWithdraw);
            Console.WriteLine($"Jay Gatsby withdrew ${amountToWithdraw} from his checking account and his new balance is ${newBalanceWithdrawChecking}");

            decimal newBalanceSavings = savingsAccount.Deposit(amountToDeposit);
            Console.WriteLine($"Jay Gatsby deposited ${amountToDeposit} into his Savings account and his new balance is ${newBalanceSavings}");

            decimal newBalanceWithdrawSavings = savingsAccount.Withdraw(amountToWithdraw);
            Console.WriteLine($"Jay Gatsby withdrew ${amountToWithdraw} from his Savings account and his new balance is ${newBalanceWithdrawSavings}");
            

            decimal amountToTransfer = 50.0M;
            checkingAccount.Transfer(savingsAccount, amountToTransfer);

            BankCustomer jayGatsby = new BankCustomer();
            jayGatsby.AddAccount(checkingAccount);
            jayGatsby.AddAccount(savingsAccount);
            jayGatsby.AddAccount(checkingAccount);
            Console.WriteLine($"Jay Gatsby has {jayGatsby.Accounts.Length} accounts."); // Jay Gatsby has 3 accounts.

            
           
            



            Console.ReadLine();
        }
    }
}
