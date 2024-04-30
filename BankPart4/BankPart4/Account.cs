namespace BankPart4
{
    public class Account
    {
        private string _name;
        private decimal _balance;

        public string Name { get { return _name; } }
        public decimal Balance { get { return _balance; } } 
            
        public Account(string name, decimal balance)
        {
            _name = name;
            _balance = balance;
        }

        public decimal BalanceAmount()                // Method to get the current balance of the account
        {
            return _balance;
        }


        public bool Deposit(decimal amount)           // Method to deposit money into the account
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
        public bool Withdraw(decimal amount)                // Method to withdraw money from the account
        {
            if (amount > 0 && amount <= _balance)
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

        public void Print() // Corrected method signature
        {
            Console.WriteLine("Name: {0}", _name);
            Console.WriteLine("Current balance: {0}", _balance);
        }
    }
}
