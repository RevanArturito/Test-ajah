using Newtonsoft.Json;
using System.Text.Json;

namespace Authentication.Controllers
{
    public class AccountService : IAccountService
    {
        private readonly string _filePath;

        public AccountService()
        {
            // Define the path to the account data file
            _filePath = "D:\\REVAN\\MATERI KULIAH\\SEMESTER 4\\KONSTRUKSI PERANGKAT LUNAK\\TUBES2\\Authentication\\Account.json";
        }

        public void AddAccount(Account account)
        {
            List<Account> accounts = GetAccounts();
            accounts.Add(account);

            var HasilKonversi = JsonConvert.SerializeObject(accounts);

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
            };
            using (StreamWriter write = new StreamWriter(_filePath))
            {
                write.Write(HasilKonversi);
            }
        }

        public void DeleteAccount(int id)
        {
            List<Account> accounts = GetAccounts();
            if (accounts != null)
            {
                accounts.RemoveAt(id);
            }

            var HasilKonversi = JsonConvert.SerializeObject(accounts);

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true,
            };
            using (StreamWriter write = new StreamWriter(_filePath))
            {
                write.Write(HasilKonversi);
            }
        }

        public Account GetAccountById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Account> GetAccounts()
        {
            try
            {
                // Read the account data from the file
                string json = File.ReadAllText(_filePath);
                return JsonConvert.DeserializeObject<List<Account>>(json);
            }
            catch (Exception ex)
            {
                // Log or handle the error appropriately
                throw new Exception($"Error reading account data: {ex.Message}");
            }
        }

    }
}
