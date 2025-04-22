using HR_Application.Services;
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
        public LoginWindow()
        {
            InitializeComponent();
        }

        //// ✅ Handles login button click
        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    string username = UsernameTextBox.Text; // ☑️ UsernameTextBox must exist in XAML
        //    string password = PasswordBox.Password;

        //    // ☑️ Simplified credential check (replace with real logic later)
        //    if (username == "admin")
        //    {
        //        OpenDashboard(new AdminDashboardPage());
        //    }
        //    else if (username == "hr")
        //    {
        //        OpenDashboard(new HRDashboardPage());
        //    }
        //    else if (username == "emp")
        //    {
        //        OpenDashboard(new EmployeeDashboardPage());
        //    }
        //    else
        //    {
        //        MessageBox.Show("Invalid credentials. Please try again.");
        //    }
        //}



        //// ✅ Method to open dashboard and close login window
        //private void OpenDashboard(Page dashboardPage)
        //{
        //    MainWindow mainWindow = new MainWindow(); // Create main window instance
        //    mainWindow.Show(); // Show main window
        //    mainWindow.MainFrame.Navigate(dashboardPage); // Navigate to dashboard
        //    this.Close(); // Close login window
        //}

        private void Login_Button(object sender, RoutedEventArgs e)
        {
            // Validate credentials
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;
            var authenticatedUser = AuthService.Authenticate(username, password);

            if (authenticatedUser != null)
            {
                // Store user info globally
                App.Current.Properties["User"] = authenticatedUser;
                App.Current.Properties["Role"] = authenticatedUser.Role;

                // Navigate to MainWindow
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        // ✅ Handle PasswordBox change (optional if you want real-time logic)
       

        // ✅ Close button (X icon) handler
        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(); // Shut down application
        }

        // ✅ Make window draggable from canvas
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

        // 🔸 Username Placeholder Logic
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


        // 🔸 Password Placeholder Logic
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
