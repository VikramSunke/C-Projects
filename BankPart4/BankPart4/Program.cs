namespace BankPart4
{
    public enum MenuOptions
    {
        NewAccount,
        Deposit,
        Withdraw,
        Transfer,
        Balance,
        Quit
    }
    internal class Program
    {
        public static void Bank(MenuOptions menuOptions,Bank bank)
        {
            switch (menuOptions)
            {
                case MenuOptions.NewAccount:
                
                    DoAddAccount(bank);  //Calls method add account
                    break;

                case MenuOptions.Deposit:
                    DoDeposit(bank); // Calls method to handle deposit
                    break;

                case MenuOptions.Withdraw:
                    DoWithdraw(bank); // Calls method to handle withdrawal
                    break;

                case MenuOptions.Transfer:
                    DoTransfer(bank);  //calls method to handle Transfer
                    break;
                case MenuOptions.Balance:
                    DoPrint(bank);
                    break;

                case MenuOptions.Quit:
                    Console.WriteLine("\nNo transactions have been made"); // Message for quitting
                    break;
            }
        }
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            
            //Account account = new Account("vikram", 1000); // Creates an account with initial balance

            bool continueTransaction = true;

            while (continueTransaction)
            {
                Console.WriteLine("\nChoose your method:\n 1.New Account \n 2.Deposit \n 3.Withdraw \n 4.Transfer \n 5.Balance \n 6.Quit\n");
                int option = Convert.ToInt32(Console.ReadLine()); // Reads user input

                switch (option)
                {
                    case 1:
                        Bank(MenuOptions.NewAccount,bank);
                        break;
                    case 2:
                        Bank(MenuOptions.Deposit,bank); // Handles deposit
                        break;
                    case 3:
                        Bank(MenuOptions.Withdraw,bank); // Handles withdrawal
                        break;
                    case 4:
                        Bank(MenuOptions.Transfer,bank); // Handles transfer
                        break;
                    case 5:
                        Bank(MenuOptions.Balance,bank);
                        break;
                    case 6:
                        Bank(MenuOptions.Quit,bank); // Quits the program
                        continueTransaction = false; // Setting flag to end the loop
                        break;
                    default:
                        Console.WriteLine("\nInvalid option. Please choose again."); // Message for invalid input
                        break;
                }
            }
        }


        private static void DoAddAccount(Bank frombank)  // Method to add a new account to the bank
        {
            Console.WriteLine("\nEnter account holder name: ");
            string _name = Console.ReadLine();

            Console.WriteLine("\nEnter amount : ");
            decimal _amount = Convert.ToDecimal(Console.ReadLine());

            Account account = new Account(_name, _amount);
            frombank.AddAccount(account);   // Add the account to the bank
            Console.WriteLine("\nAccount Added Successfully");
        }

        public static Account FindAccount(Bank frombank)     // Method to find an account in the bank based on account holder name

        {
            Console.Write("\nEnter account holder name: ");
            string name=Console.ReadLine();

            Account result=frombank.GetAccount(name);   // Retrieve the account from the bank

            if (result == null)
            {
                Console.WriteLine($"\nNo account found with name{name}");
            }
            else 
            {
                Console.WriteLine($"\nAccount found with the name {name}");
            }
            return result;
        }

        private static void DoDeposit(Bank toBank)         // Method to handle deposit into an account
        {
            Account toAccount = FindAccount(toBank);           // Finding the account in which deposit needs to be made

            if (toAccount == null)
            {
                return;
            }

            Console.WriteLine("\nEnter the amount to be deposited:");
            decimal depositedAmount = Convert.ToDecimal(Console.ReadLine());

            DepositTransaction depositTransaction = new DepositTransaction(toAccount, toBank, depositedAmount);       // Creating a deposit transaction object and execute the transaction

            toBank.ExecuteTransaction(depositTransaction);
            depositTransaction.Print();
        }
         
        private static void DoWithdraw(Bank toBank)          // Method to handle withdrawal from an account
        {
            Account toAccount = FindAccount(toBank);
            if (toAccount == null) return;
            
            Console.WriteLine("\n ENter the amount to do withdraw : ");
            decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());

            WithdrawTransaction withdrawTransaction = new WithdrawTransaction(toAccount, toBank,withdrawAmount);
            toBank.ExecuteTransaction(withdrawTransaction);
            withdrawTransaction.Print();
        }

        private static void DoTransfer(Bank toBank)            // Method to handle transfer between two accounts
        {
            Console.WriteLine("\nEnter From Account Holder name: ");
            Account fromAccount = FindAccount(toBank);

            Console.WriteLine("\nEnter To Account Holder name:");
            Account toAccount = FindAccount(toBank);

            if(toAccount==null || fromAccount==null) return;           // If either of the accounts is not found, return

            Console.WriteLine("\n ENter the amount to Transfer : ");
            decimal transferAmount = Convert.ToDecimal(Console.ReadLine());

            TransferTransaction transferTransaction = new TransferTransaction(fromAccount, toAccount, toBank, transferAmount);
            toBank.ExecuteTransaction(transferTransaction);
            transferTransaction.Print();
        }
        
        private static void DoPrint(Bank toBank)
        {
            Account toAccount = FindAccount(toBank);
            if (toAccount == null) return;
            toAccount.Print();

        }

    }
}
