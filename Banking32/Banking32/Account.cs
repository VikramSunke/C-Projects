using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking32
{
    public class Account
    {
        private string _name;
        private decimal _balance;

        public Account(string name, decimal balance)
        {
            _name = name;
            _balance = balance;
        }
        public decimal BalanceAmount()
        {
            return _balance;
        }
        public bool Deposit(decimal amount)
        {
            if (amount > 0)
            {
                _balance += amount;
                return true;
            }
            else
            {
                Console.WriteLine("You've entered an invalid amount. Please enter a positive value.");
                return false;
            }
        }
        public bool Withdraw(decimal amount)
        {
            if(amount > 0 && amount<= _balance) 
            {
                _balance -= amount;
                return true;
            }
            else
            {
                Console.WriteLine("Withdrawal failed due to insufficient funds or invalid amount.");
                return false;
            }
        }

        public void Print()
        {
            Console.WriteLine("Name : {0}", _name);
            Console.WriteLine("Current balance : {0}", _balance);
        }
    }
}
