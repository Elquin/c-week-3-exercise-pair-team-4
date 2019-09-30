using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExerciseTests.Classes
{
    public class SavingsAccount : BankAccount
    {
        public override decimal Withdraw(decimal amountToWithdraw)
        {
            if (Balance < 150)
            {
                return Balance = Balance - (amountToWithdraw + 2);
            }
            else if (amountToWithdraw > Balance)
            {
                return Balance = Balance;
            }
            else
            {
                return Balance -= amountToWithdraw;
            }
        }
    }
}
