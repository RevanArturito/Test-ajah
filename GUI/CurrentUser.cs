using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class CurrentUser
    {
        static string username {  get; set; }
        static string roleUser { get; set; }
        static string emailUser { get; set; }
        static string phoneUser { get; set; }

        public CurrentUser(string user, string role, string email, string phone) 
        {
            username = user;
            roleUser = role;
            emailUser = email;
            phoneUser = phone;
        }

        public CurrentUser() { }

        public string GetCurrentUserName()
        {
            return username;
        }

        public  string getCurrentRoleUser()
        {
            return roleUser;
        }

        public string getCurrentEmailUser()
        {
            return emailUser;
        }

        public string getCurrentPhoneUser()
        {
            return phoneUser;
        }

    }
}
