using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Application.Utils
{
    class SessionManager
    {
        // Holds the currently logged-in user
        public static Model.User CurrentUser { get; set; }

        //can do this for security
        //if (SessionManager.CurrentUser.Role != "Admin")
        //{
        //    MessageBox.Show("Access denied.");
        //    this.Close();
        //    }
}
}
