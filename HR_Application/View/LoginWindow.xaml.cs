using HR_Application.Services;
using HR_Application.Utils;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace HR_Application.View
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        //public LoginWindow()
        //{
        //    InitializeComponent();
        //}

        //private void Login_Button(object sender, RoutedEventArgs e)
        //{
        //    // Validate credentials
        //    string username = UsernameTextBox.Text;
        //    string password = PasswordBox.Password;
        //    var authenticatedUser = AuthService.Authenticate(username, password);

        //    if (authenticatedUser != null)
        //    {
        //        // Start a new session with the authenticated user
        //        SessionManager.Login(authenticatedUser);

        //        // Switch based on role to open the corresponding window
        //        Window dashboardWindow = null;

        //        switch (authenticatedUser.Role)
        //        {
        //            case "Admin":
        //                dashboardWindow = new AdminDashboardWindow();
        //                break;
        //            case "HRManager":
        //                dashboardWindow = new HRDashboardWindow();
        //                break;
        //            case "Employee":
        //                dashboardWindow = new EmployeeDashboardWindow();
        //                break;
        //            default:
        //                MessageBox.Show("Unknown user role.", "Access Denied", MessageBoxButton.OK, MessageBoxImage.Warning);
        //                return;
        //        }

        //        dashboardWindow.Show();
        //        this.Close();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error);
        //    }
        //}

        private readonly AuthService _authService;

        public LoginWindow(AuthService authService)
        {
            InitializeComponent();
            _authService = authService;
        }

        private void Login_Button(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;

            // Authenticate the user
            var authenticatedUser = _authService.Authenticate(username, password);

            if (authenticatedUser != null)
            {
                // Start a session with the authenticated user
                SessionManager.Login(authenticatedUser);

                //***
                // Open the corresponding dashboard based on the user's role
                Window? dashboardWindow = authenticatedUser.Role switch
                {
                    "Admin" => new AdminDashboardWindow(),
                    "HRManager" => new HRDashboardWindow(),
                    "Employee" => new EmployeeDashboardWindow(),
                    _ => null
                };

                if (dashboardWindow != null)
                {
                    dashboardWindow.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Unknown user role.", "Access Denied", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        

        // Close button (X icon) handler
        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(); // Shut down application
        }

        // Make window draggable from canvas
        private void Canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove(); // Enable window dragging
        }

        public void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            // Clear the text fields
            UsernameTextBox.Clear();
            PasswordBox.Clear();
            // Optionally, reset any other UI elements or states
        }

        // Username Placeholder Logic
        private void UsernameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            UsernamePlaceholder2.Visibility = Visibility.Hidden; // hide on focus
        }

        private void UsernameTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameTextBox.Text))
                UsernamePlaceholder2.Visibility = Visibility.Visible; // show if empty
        }

        private void UsernameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(UsernameTextBox.Text))
                UsernamePlaceholder2.Visibility = Visibility.Hidden; // hide when typing
            else if (!UsernameTextBox.IsFocused)
                UsernamePlaceholder2.Visibility = Visibility.Visible;
        }


        // Password Placeholder Logic
        private void PasswordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            UsernamePlaceholder1.Visibility = Visibility.Hidden; // hide on focus
        }

        private void PasswordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PasswordBox.Password))
                UsernamePlaceholder1.Visibility = Visibility.Visible; // show if empty
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(PasswordBox.Password))
                UsernamePlaceholder1.Visibility = Visibility.Hidden; // hide when typing
            else if (!PasswordBox.IsFocused)
                UsernamePlaceholder1.Visibility = Visibility.Visible;
        }


    }
}
