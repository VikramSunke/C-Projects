using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking32
{
    public class DepositTransaction
    {
        private Account _account;
        private decimal _amount;

        private bool _success;
        private bool _executed;
        private bool _reversed;

        public bool Success { get { return _success; } }
        public bool Executed { get { return _executed; } }
        public bool Reversed { get { return _reversed; } }
        public DepositTransaction(Account account, decimal amount)
        {
            _account=account;
            _amount=amount;
        }

        public void Execute()
        {
            if(!_executed)
            {
                _success=_account.Deposit(_amount);
                _executed=true;
            }
        }

        public void Print()
        {
            if(_success)
            {
                Console.WriteLine("Deposit: Successful.");
                Console.WriteLine($"Deposited Amount: {_amount}");
                Console.WriteLine($"Balance Amount: {_account.BalanceAmount()}");
            }
            else
            {
                {
                    Console.WriteLine("Deposit: Failed.");
                }
            }
        }
    }
}
