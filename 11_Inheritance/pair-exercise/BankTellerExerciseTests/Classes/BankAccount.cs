using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExerciseTests.Classes
{
    public class BankAccount
    {
        public BankAccount()
        {
            Balance = 0;
        }
        public string AccountNumber { get; set; }
        public decimal Balance { get; private set; }


        public decimal Deposit(decimal amountToDeposit)
        {
            return Balance += amountToDeposit;
        }
        virtual public decimal Withdraw(decimal amountToWithdraw)
        {
            return Balance -= amountToWithdraw;
        }
        public void Transfer(BankAccount destinationAccount, decimal transferAmount)
        {
            Balance -= transferAmount;
            destinationAccount.Balance += transferAmount;
        }
    }
}
