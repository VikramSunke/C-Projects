namespace Assignment1
{
    public enum accountOptions
    {
        SavingsAccount,
        FixedAccount
    }
    public enum optionsToChoose
    {
        CreateAccount,
        WithDraw,
        Deposit
    }
    public class MenuOptions
    {

        public void UserOptions()
        {
            
            while (true)
            {
                Console.WriteLine("Choose your Account Type \n 0.Create Account \n1.Withdraw Account \n2.Deposit \n3.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                if(option == 3)
                {
                    break;
                }
                Bank bank = new Bank();
                switch (option)
                {
                    case 0:
                        Console.WriteLine("Enter account name: ");
                        string name = Console.ReadLine() ?? string.Empty;

                        Console.WriteLine("Enter initial balance: ");
                        decimal initialBalance = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Enter which type of account you want to create \n0.Savings Account \n1.Fixed Account");
                        int acctypeOption = Convert.ToInt32(Console.ReadLine());

                        accountOptions accountType = (accountOptions)acctypeOption;
                        if (accountType == accountOptions.SavingsAccount)
                        {
                            SavingsAccount savingsAccount = new SavingsAccount(name, initialBalance, accountType);
                            bank.CreateNewAccount(savingsAccount);
                        }
                        else
                        {
                            FixedDeposit fixedAccount = new FixedDeposit(name, initialBalance, accountType);
                            bank.CreateNewAccount(fixedAccount);
                        }

                        break;
                    case 1:
                        Console.WriteLine("Enter user name:");
                        string userName = Console.ReadLine() ?? string.Empty;

                        Console.WriteLine("Enter widthdrawl amount: ");
                        decimal withdrawlAmount = Convert.ToDecimal(Console.ReadLine());

                        Account result = bank.GetAccount(userName);
                        if (result != null)
                        {
                            try
                            {
                                result.Withdraw(withdrawlAmount);
                                Console.WriteLine(result.PrintAccountDetails());
                            }
                            catch (Exception ex)
                            {

                                Console.WriteLine(ex.Message);
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("Account not found");
                        }
                        break;

                    case 2:

                        Console.WriteLine("Enter user name:");
                        string depositUserName = Console.ReadLine() ?? string.Empty;

                        Console.WriteLine("Enter widthdrawl amount: ");
                        decimal depositlAmount = Convert.ToDecimal(Console.ReadLine());

                        Account result2 = bank.GetAccount(depositUserName);
                        if (result2 != null)
                        {
                            try
                            {
                                result2.Deposit(depositlAmount);
                                Console.WriteLine(result2.PrintAccountDetails());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);

                            }
                           
                        }
                        else
                        {
                            Console.WriteLine("Account not found");
                        }
                        break;

                    default:
                        break;

                }
            }
        }
    }
}



