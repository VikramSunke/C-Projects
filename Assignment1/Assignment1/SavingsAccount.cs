using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class SavingsAccount : Account
    {
        public int TransactionCount { get; set; } = 0;
        public SavingsAccount(string name,decimal balance, accountOptions accountType):base(name,accountType,balance)
        {
            
        }
        public override void Deposit(decimal amount)
        {

            if (TransactionCount >= 5)

            {

                throw new Exception("Transactions limit completed");

            }

            if (amount <= 0)

            {

                throw new Exception("amount could not be less than 0.");
            }

            if (amount > balance)

            {

                throw new Exception("Insufficient funds.");

            }
            decimal minBalance = balance - amount;
            if (minBalance < 1000)
            {
                throw new Exception("Minimum Balance of 1000 required in account.");
            }


            if (amount > 50000)
            {
                throw new Exception("Max of 50000 is allowed for transaction");
            }
            balance -= amount;
            TransactionCount++;
        }

        public override void Withdraw(decimal amount)
        {
            if (TransactionCount >= 5)

            {
                throw new Exception("Max transactions reached");

            }

            if (amount <= 0)

            {

                throw new Exception("amount shouldn't be less than 0.");

            }

            if (amount > 50000)

            {

                throw new Exception("Max of 50000 are allowed.");

            }


            base.balance += amount;

            TransactionCount++;
        }
    }
}
