using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Application.Model
{
    class User
    {
        public string? Username { get; set; }
        public string Role { get; set; } // "Admin", "HRManager", "Employee"
    }
}
