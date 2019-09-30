using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExerciseTests.Classes
{
    public class BankCustomer
    {



        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public List<BankAccount> accounts = new List<BankAccount>();
        public BankAccount[] Accounts
        {
            get
            {
                return accounts.ToArray();
            }
        }


        public void AddAccount(BankAccount newAccount)
        {
            accounts.Add(newAccount);
        }
    }
}
