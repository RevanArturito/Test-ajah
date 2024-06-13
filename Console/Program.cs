// See https://aka.ms/new-console-template for more information
using Authentication.Controllers;

class Program
{
    public static List<Account> accounts = new List<Account>();

    
    public static void Main(string[] args)
    {
        IAccountService accountService = new AccountService();

        accounts = accountService.GetAccounts();

        /*AccountService accountService = new AccountService();
        accounts = accountService.GetAccounts();*/
        foreach (var account in accounts)
        {
            Console.WriteLine($"Username: {account.username}, Username: {account.password}, Email: {account.phone}, Phone: {account.phone}, Role: {account.role}");
        }
    }
   
}

