using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Banking32
{
    public class TransferTransaction
    {
        private decimal _amount;
        private Account _fromAccount;
        private Account _toAccount;

        private bool _executed;
        private bool _success;
        private bool _reversed;


        public bool Executed { get { return _executed; } }
        public bool Success { get { return _success; } }
        public bool Reversed { get { return _reversed; } }

        private WithdrawTransaction _withdraw;
        private DepositTransaction _deposit;

        public TransferTransaction(Account fromAccount, Account toAccount, decimal amount)
        {
            _amount = amount;
            _fromAccount = fromAccount;
            _toAccount = toAccount;
            _withdraw = new WithdrawTransaction(fromAccount, _amount);
            _deposit = new DepositTransaction(toAccount, _amount);
        }

        public void Execute()
        {
            if(!_executed)
            {
                _withdraw.Exceute();
                if (_withdraw.Success)
                {
                    _deposit.Execute();
                    if(!_deposit.Success) 
                    {
                        _withdraw.RollBack();
                    }
                }
               
                
                
            }
        }

        public void Print()
        {
            Console.WriteLine($"Transfer: {(!Success ? "Successful" : "Failed")}");
            Console.WriteLine($"Amount Debited: {_amount}");
            Console.WriteLine($"Balance Amount in our account: {_fromAccount.BalanceAmount()}");
            

            if (!Success)
            {
                _reversed = true;
            }
        }
    }
}
