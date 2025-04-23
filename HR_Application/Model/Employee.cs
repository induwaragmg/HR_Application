using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Application.Model
{
       public class Employee
        {
            public int UserId { get; set; }
            public string FirstName { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public string Department { get; set; }
            public string Position { get; set; }
            public decimal Salary { get; set; }
            public DateTime DateOfBirth { get; set; }
            public DateTime JoiningDate { get; set; }
            public string ProfilePicturePath { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string Role { get; set; }
            public string Gender { get; set; }
            public string Address { get; set; }
        }
 }

