namespace BankPart4
{
    public class TransferTransaction
    {
        private decimal _amount;
        private Account _fromAccount;
        private Account _toAccount;
        private Bank _toBank;

        private bool _executed;
        private bool _success;
        private bool _reversed;

        private WithdrawTransaction _withdraw;
        private DepositTransaction _deposit;

        public bool Executed { get { return _executed; } }
        public bool Success { get { return _success; } }
        public bool Reversed { get { return _reversed; } }

        public TransferTransaction(Account fromAccount, Account toAccount, Bank bank, decimal amount)
        {
            _amount = amount;
            _fromAccount = fromAccount;
            _toAccount = toAccount;
            _toBank = bank;

            // Initialize WithdrawTransaction and DepositTransaction objects
            _withdraw = new WithdrawTransaction(_fromAccount, _toBank, _amount);
            _deposit = new DepositTransaction(_toAccount, _toBank, _amount);
        }

        public void Execute()
        {
            try
            {
                // Execute WithdrawTransaction
                _withdraw.Execute();

                // Check if withdrawal was successful before depositing
                if (_withdraw.Success)
                {
                    // Execute DepositTransaction
                    _deposit.Execute();
                    _success = _deposit.Success; // Update success based on deposit success
                }
                else
                {
                    _success = false; // If withdrawal failed, set success to false
                }

                _executed = true;
            }
            catch (Exception ex)
            {
                _success = false;
                _executed = true;
                Console.WriteLine($"Transaction execution failed: {ex.Message}");
            }
        }

        public void RollBack()
        {
            if (!_executed || _reversed)
            {
                throw new Exception("\nCannot rollback this transaction as it has not been executed or has already been rolled back");
            }
            _reversed = true;

            // Rollback deposit and withdrawal transactions
            _deposit.RollBack();
            _withdraw.RollBack();
        }

        public void Print()
        {
            Console.WriteLine($"\nTransfer: {(Success ? "Successful" : "Failed")}");
            Console.WriteLine($"Amount Transferred: {_amount}");
            Console.WriteLine($"Account Holder (From): {_fromAccount.Name}");
            Console.WriteLine($"Balance Amount (From): {_fromAccount.BalanceAmount()}");
            Console.WriteLine($"\nAccount Holder (To): {_toAccount.Name}");
            Console.WriteLine($"Balance Amount (To): {_toAccount.BalanceAmount()}");

            if (!Success)
            {
                Console.WriteLine("\nTransfer failed. Rolling back transaction...");
                RollBack();
            }
        }
    }
}
