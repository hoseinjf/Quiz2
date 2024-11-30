using Quiz2.Continer;
using Quiz2.Entity;
using Quiz2.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2.Servise
{
    public class LoginServise
    {
        private readonly IUserLogin userLogin;
        public LoginServise()
        {
            userLogin = new UserLogin();
        }
        public Card Login(string cardNumber, string password) 
        {
            var login = userLogin.Login(cardNumber, password);
            if (login != null)
            {
                Console.WriteLine("welcom");
                return login;
            }
            else
            {
                Console.WriteLine("card number or password is not true");
                return null;
            }
        }
    }
}
