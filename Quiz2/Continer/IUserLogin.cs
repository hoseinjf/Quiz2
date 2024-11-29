using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Quiz2.Continer
{
    public interface IUserLogin
    {
        public bool Login(string cardNumber, string password);
    }
}
