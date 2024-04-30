using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Bank
    {
        List<Account> accounts = new List<Account>();

        public void CreateNewAccount(Account account)
        {
            accounts.Add(account);
        }

        public Account GetAccount(string name)
        {
            foreach(var account in accounts)
            {
                if(account.name == name)
                    return account;
                
            }
            return null;
        }
    }
}
