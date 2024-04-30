using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public abstract class Account
    {
        public string name { get; set; }
        public decimal balance { get; set; }
        public accountOptions accountType { get; set; }

        public Account(string name, accountOptions accountType, decimal balance)
        {
            this.name = name;
            this.balance = balance;
            this.accountType = accountType;
        }

        public abstract void Withdraw(decimal amount);

        public abstract void Deposit(decimal amount);

        public string PrintAccountDetails()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"account Name: {0}{1}", name, Environment.NewLine);
            sb.AppendFormat($"account Balance: {0}{1}", balance, Environment.NewLine);
            sb.AppendFormat($"account Account Type: {0}{1}", accountType, Environment.NewLine);
            return sb.ToString();   
        }


    }
}
