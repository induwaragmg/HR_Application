﻿//using HR_Application.Services;
//using HR_Application.Utils;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Data;
//using System.Windows.Documents;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using System.Windows.Navigation;
//using System.Windows.Shapes;

//namespace HR_Application.View
//{
//    /// <summary>
//    /// Interaction logic for LoginPage.xaml
//    /// </summary>
//    public partial class LoginPage : Page
//    {
//        public LoginPage()
//        {
//            InitializeComponent();
//        }

//        private void LoginButton_Click(object sender, RoutedEventArgs e)
//        {
//            string username = UsernameTextBox.Text;
//            string password = PasswordBox.Password;

//            // Example logic
//            if (username == "admin")
//            {
//                NavigationService?.Navigate(new AdminDashboardPage());
//            }
//            else if (username == "hr")
//            {
//                NavigationService?.Navigate(new HRDashboardPage());
//            }
//            else if (username == "emp")
//            {
//                NavigationService?.Navigate(new EmployeeDashboardPage());
//            }
//            else
//            {
//                MessageBox.Show("Invalid credentials. Please try again.");
//            }
           
//        }

//        private void SignUp_Click(object sender, RoutedEventArgs e)
//        {
//            NavigationService?.Navigate(new HRDashboardPage());
//        }
//    }
//}
