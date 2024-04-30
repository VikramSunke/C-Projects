using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class FixedDeposit:Account
    {
        public int WithdrawCount { get; set; } = 0;
        public int DepositCount { get; set; } = 0;
        public FixedDeposit(string name,decimal balance,accountOptions accountType):base(name,accountType,balance)
        {
            
        }
        public override void Deposit(decimal amount)
        {

            if (DepositCount > 1)
            {
                throw new Exception("Trasanction limit over");
            }
            else
            {
                if (amount > 0)
                {
                    balance += amount;
                    DepositCount++;
                }
                else
                {
                    throw new Exception("You are adding zero amount");
                }
            }

        }

        public override void Withdraw(decimal amount)
        {
            if (WithdrawCount > 1)
            {
                throw new Exception("Trasanction limit over");
            }
            else
            {
                if(amount>0 && amount<balance)
                {
                    balance -= amount;
                    WithdrawCount++;
                }
                else
                {
                    throw new Exception("Insuffient funds");
                }
            }
        }
    }
}
