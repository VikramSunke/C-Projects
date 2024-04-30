namespace Banking32
{
    public enum MenuOptions
    {
        Balance,
        Deposit,
        Withdraw,
        Transfer,
        Quit
    }
    internal class Program
    {
        public static void Bank(MenuOptions menuOptions, Account account)
        {
            switch (menuOptions)
            {
                case MenuOptions.Balance:
                    account.Print(); // Prints current balance
                    break;

                case MenuOptions.Deposit:
                    DoDeposit(account); // Calls method to handle deposit
                    break;

                case MenuOptions.Withdraw:
                    DoWithdraw(account); // Calls method to handle withdrawal
                    break;

                case MenuOptions.Transfer:
                    DoTransfer(account);
                    break;

                case MenuOptions.Quit:
                    Console.WriteLine("No transactions have been made"); // Message for quitting
                    break;
            }
        }
        static void Main(string[] args)
        {
            Account account = new Account("vikram", 1000); // Creates an account with initial balance

            bool continueTransaction = true;

            while (continueTransaction)
            {
                Console.WriteLine("\nChoose your method:\n 1.Balance \n 2.Deposit \n 3.Withdraw \n 4.Transfer \n 5.Quit");
                int option = Convert.ToInt32(Console.ReadLine()); // Reads user input

                switch (option)
                {
                    case 1:
                        Bank(MenuOptions.Balance, account); // Displays balance
                        break;
                    case 2:
                        Bank(MenuOptions.Deposit, account); // Handles deposit
                        break;
                    case 3:
                        Bank(MenuOptions.Withdraw, account); // Handles withdrawal
                        break;
                    case 4:
                        Bank(MenuOptions.Transfer, account); // Handles transfer
                        break;
                    case 5:
                        Bank(MenuOptions.Quit, account); // Quits the program
                        continueTransaction = false; // Setting flag to end the loop
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please choose again."); // Message for invalid input
                        break;
                }
            }
        }

        private static void DoDeposit(Account account)
        {
            Console.WriteLine("\nEnter the amount to be deposited:");
            decimal depositedAmount = Convert.ToDecimal(Console.ReadLine());

            DepositTransaction depositTransaction=new DepositTransaction(account, depositedAmount);
            depositTransaction.Execute();
            depositTransaction.Print();

        }

        private static void DoWithdraw(Account account)
        {
            Console.WriteLine("\n ENter the amount to withdraw : ");
            decimal withdrawAmount=Convert.ToDecimal(Console.ReadLine());
            WithdrawTransaction withdrawTransaction = new WithdrawTransaction(account, withdrawAmount);
            withdrawTransaction.Exceute();
            withdrawTransaction.Print();

        }

        private static void DoTransfer(Account fromAccount)
        {
            Console.WriteLine("\n ENter the amount to Transfer : ");
            decimal transferAmount = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\n Enter ToAccount number: ");
            string toAccountNumber = Console.ReadLine();

            Account toAccount = new Account(toAccountNumber, 0);

            TransferTransaction transferTransaction = new TransferTransaction(fromAccount, toAccount, transferAmount);

            transferTransaction.Execute();
            transferTransaction.Print();


        }
    }
}
