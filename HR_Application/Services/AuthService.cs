using HR_Application.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Application.Services
{
    class AuthService
    {
        // Stub: Replace with real DB lookup and password verification
        public static User Authenticate(string username, string password)
        {
            // Example: hardcoded users for demo
            if (username == "admin" && password == "adminpw")
                return new User { Username = "admin", Role = "Admin" };
            if (username == "hr" && password == "hrpw")
                return new User { Username = "hr", Role = "HRManager" };
            if (username == "emp" && password == "emppw")
                return new User { Username = "emp", Role = "Employee" };
            else
                return null; // invalid
        }
    }
}
