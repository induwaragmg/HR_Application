﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Application.ViewModel
{
    public static class Genders
    {
        public static List<string> GenderList { get; } = new List<string>
        {
            "Male",
            "Female",
            "Other"
        };
    }  
    
    public static class Roles
    {
        public static List<string> RolesList { get; } = new List<string>
        {
            "Admin",
            "HRManager",
            "Employee"
        };
    }
    public static class Departments
    {
        public static List<string> DepartmentsList { get; } = new List<string>
        {
            "HR",
            "Marketting",
            "Finance"
        };
    }
    public static class Postions
    {
        public static List<string> PostionsList { get; } = new List<string>
        {
            "Executive",
            "Manager",
            "Worker",
            "Clark"
        };
    }
}
