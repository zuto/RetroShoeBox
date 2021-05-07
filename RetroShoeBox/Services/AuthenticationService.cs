using RetroShoeBox.Models;

namespace RetroShoeBox.Services
{
    public class AuthenticationService
    {
        public UserDetails IsAuthenticated(string username, string password)
        {
            if (username == "Jade")
            {
                return new UserDetails
                {
                    FirstName = "Jade",
                    LastName = "Kneen",
                    IsLoggedIn = true
                };
            }

            if (username == "Dan")
            {
                return new UserDetails
                {
                    FirstName = "Dan",
                    LastName = "Smith",
                    IsLoggedIn = true
                };
            }

            return new UserDetails();
        }
    }
}
