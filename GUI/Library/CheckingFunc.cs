using Authentication;
using Authentication.Controllers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace GUI.Library
{

    public class CheckingFunc
    {
        CurrentUser currentUser;
        public static List<Account> accounts = new List<Account>();
        string FilePath = "C:\\n.i.n.e.x\\VisualStudio\\Test-ajah\\Authentication\\Account.json";
        //string FilePath = "D:\\test\\Test-ajah\\Authentication\\Account.json";

        /*public static List<ProductPanelSurya> products = new List<ProductPanelSurya>();
        const string ProductFilePath = @"./ProductSolarPanels.json";*/
        public bool LoginCheck(string username, string password)
        {

            using (StreamReader Read = new StreamReader(FilePath))
            {
                accounts = JsonConvert.DeserializeObject<List<Account>>(Read.ReadToEnd());
            }
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].username == username && accounts[i].password == password)
                {
                    currentUser = new CurrentUser(username, accounts[i].role, accounts[i].email, accounts[i].phone);
                    return true;
                }
            }
            return false;
        }

        public bool AdminCheck(string username, string password)
        {
            using (StreamReader Read = new StreamReader(FilePath))
            {
                accounts = JsonConvert.DeserializeObject<List<Account>>(Read.ReadToEnd());
            }
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].username == username && accounts[i].password == password)
                {
                    if (accounts[i].role == "admin")
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /* public bool StockCheck(int index)
         {
             using (StreamReader Read = new StreamReader(ProductFilePath))
             {
                 products = JsonConvert.DeserializeObject<List<ProductPanelSurya>>(Read.ReadToEnd());
             }
             return (products[index-1].stokProduk > 0);
         }*/

        public bool isAccount(string username, string password)
        {
            using (StreamReader Read = new StreamReader(FilePath))
            {
                accounts = JsonConvert.DeserializeObject<List<Account>>(Read.ReadToEnd());
            }
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].username == username && accounts[i].password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public int isAccountIndex(string username, string password)
        {
            using (StreamReader Read = new StreamReader(FilePath))
            {
                accounts = JsonConvert.DeserializeObject<List<Account>>(Read.ReadToEnd());
            }
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].username == username && accounts[i].password == password)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
