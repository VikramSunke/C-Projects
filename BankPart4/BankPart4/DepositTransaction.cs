using BankPart4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankPart4
{
    public class DepositTransaction
    {
        private Account _account;
        private string _name;
        private Bank _bank;
        private decimal _amount;

        private bool _success;
        private bool _executed;
        private bool _reversed;

        public bool Success { get { return _success; } }
        public bool Executed { get { return _executed; } }
        public bool Reversed { get { return _reversed; } }

        public decimal Amount
        {
            get { return _amount; }
        }
        public string Name
        {
            get { return _name; }
        }
        public DepositTransaction(Account toaccount, Bank bank, decimal amount)
        {
            _amount = amount;
            _bank = bank;
            _account = toaccount;
        }

        public void Execute()
        {
            if (!_executed)
            {
                _success = _account.Deposit(_amount);
                _executed = true;
            }
        }
        public void RollBack()
        {
            if (!_executed)
            {
                throw new Exception("\nCannot rollback this transaction as it has not been executed.");
            }
            if (_reversed)
            {
                throw new Exception("\nCannot rollback this transaction as it has already been rolled back.");
            }

            _account.Withdraw(_amount);
            _reversed = true;
        }


        public void Print()
        {
            if (_success)
            {
                Console.WriteLine("\nDeposit: Successful.");
                Console.WriteLine($"Account Holder: {_account.Name}");

                Console.WriteLine($"Deposited Amount: {_amount}");
                Console.WriteLine($"Balance Amount: {_account.BalanceAmount()}");
            }
            else
            {
                Console.WriteLine("\nDeposit: Failed.");
            }
 
        }

    }
}
