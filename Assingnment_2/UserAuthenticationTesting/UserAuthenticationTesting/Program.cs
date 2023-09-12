using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAuthenticationTesting
{
    public class UserAuthenticator
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public UserAuthenticator()
        {
            Username = null;
            Password = null;
        }

        public bool RegisterUser(string username, string password)
        {
            if(Username == null) 
            {
                Username = username;
                Password = password;

                return true;
            }
            
            return false;
                   
        }

        public bool LoginUser(string username, string password)
        {
            if(Username == username && Password == password) 
            {
                return true;
            }
           
            return false;
            
        }

        public bool ResetPassword(string username, string password)
        {
            if(Username == username)
            {
                Password = password;
                return true;
            }
            
            return false;
            
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
