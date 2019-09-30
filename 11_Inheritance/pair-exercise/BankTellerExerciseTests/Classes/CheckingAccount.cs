using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExerciseTests.Classes
{
    public class CheckingAccount : BankAccount
    {
        public override decimal Withdraw(decimal amountToWithdraw)
        {
            if (Balance - amountToWithdraw < -100)
            {
                return Balance = Balance;
            }
            else if (Balance - amountToWithdraw >= -100 && Balance - amountToWithdraw < 0)
            {
                return Balance = Balance - (amountToWithdraw + 10);
            }
            else
            {
                return Balance -= amountToWithdraw;
            }

        }
    }
}
