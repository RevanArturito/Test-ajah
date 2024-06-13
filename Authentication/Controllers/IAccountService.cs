using System.Security.Principal;

namespace Authentication.Controllers
{
    public interface IAccountService
    {
        List<Account> GetAccounts();
        void AddAccount(Account account);
        Account GetAccountById(int id);
        void DeleteAccount(int id);
    }
}
