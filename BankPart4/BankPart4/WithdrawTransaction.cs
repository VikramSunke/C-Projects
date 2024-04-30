

namespace BankPart4
{
    public class WithdrawTransaction
    {
        private Account _account;
        private Bank _bank;
        private string _name;
        private decimal _amount;

        private bool _success;
        private bool _executed;
        private bool _reversed;

        public bool Success { get { return _success; } }
        public bool Executed { get { return _executed; } }
        public bool Reversed { get { return _reversed; } }

        public WithdrawTransaction(Account account, Bank bank, decimal amount)
        {
            _bank= bank;
            _account = account;
            _amount = amount;
        }

        public void Execute()
        {
            if (!_executed)
            {
                _success = _account.Withdraw(_amount);
                _executed = true;
            }
            else
            {
                throw new Exception("\nCannot execute this transaction");
            }
        }

        public void RollBack()
        {
            if (_executed && _success && !_reversed)
            {
                if (_account.BalanceAmount() >= _amount)
                {
                    _account.Deposit(_amount);
                    _reversed = true;
                }
                else
                {
                    Console.WriteLine("\nRollback: Failed due to insufficient balance for deposit.");
                }
            }
            else
            {
                Console.WriteLine("\nRollback: Failed due to invalid conditions.");
            }
        }


        public void Print()
        {
            if (_success)
            {
                Console.WriteLine("\nWithdrawal: Successful.");
                Console.WriteLine($"Account Holder: {_account.Name}");
                Console.WriteLine($"Withdrawn Amount: {_amount}");
                Console.WriteLine($"Balance Amount: {_account.BalanceAmount()}");
            }
            else
            {
                Console.WriteLine("Withdrawal: Failed.");
            }
        }
    }
}
