using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Application.ViewModel
{
    public static class Genders
    {
        public static List<string> All { get; } = new List<string>
        {
            "Male",
            "Female",
            "Other"
        };
    }
}
