using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExerciseTests.Classes
{
    public class SavingsAccount : BankAccount
    {
        public override decimal Withdraw(decimal amountToWithdraw)
        {
            if (amountToWithdraw > Balance)
            {
                return Balance;
            }
            else if (Balance < 150)
            {
                return Balance - (amountToWithdraw + 2);
            }

            else
            {
                return Balance - amountToWithdraw;
            }
        }
    }
}
