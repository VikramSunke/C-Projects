using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankPart4
{
    public class Bank
    {
        List<Account> _accounts = new List<Account>();

        public void AddAccount(Account account)    
        {
             _accounts.Add(account);  // Adding new account to the accounts list
        }

        public Account GetAccount(string name) 
        {
            foreach(Account account in _accounts)  // Finding account from the accounts list by account holder name
            {
                if(account.Name == name )
                {
                    return account;
                }
            }
            return null;    
           
        }

        public void ExecuteTransaction(DepositTransaction transaction)
        {
            transaction.Execute();
        }
        public void ExecuteTransaction(WithdrawTransaction transaction)
        {
            transaction.Execute();
        }

        public void ExecuteTransaction(TransferTransaction transaction)
        {
            transaction.Execute();
        }


    }
}
