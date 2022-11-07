using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pra.ClassesAndObjects.Introduction.Core
{
    public class BankAccount
    {

        public Person owner;
        public string accountNumber;
        public decimal balance;

        public BankAccount(Person owner, string accountNumber)
        {
            this.owner = owner;
            this.balance = 0;
            this.accountNumber = accountNumber;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > balance)
                throw new ArgumentException("Insufficient funds");
            balance -= amount;
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Transfer(BankAccount recepient, decimal amount)
        {
            Withdraw(amount);
            recepient.Deposit(amount);
        }

        public override string ToString()
        {
            return accountNumber;
        }

    }
}
