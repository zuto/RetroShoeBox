using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetroShoeBox.Services
{
    public class AuthenticationService
    {
        public bool IsAuthenticated(string username, string password)
        {
            if (username == "Jade")
            {
                return true;
            }

            return false;
        }
    }
}
