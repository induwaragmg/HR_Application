using HR_Application.Model;
using HR_Application.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HR_Application.ViewModel
{
    //public class MainViewModel : INotifyPropertyChanged
    //{
    //    private object _currentView;

    //    public object CurrentView
    //    {
    //        get => _currentView;
    //        set
    //        {
    //            _currentView = value;
    //            OnPropertyChanged();
    //        }
    //    }

    //    public MainViewModel()
    //    {
    //        // Get role from the app properties
    //        string userRole = App.Current.Properties["Role"].ToString();

    //        switch (userRole)
    //        {
    //            case "Admin":
    //                CurrentView = new AdminDashboardPage();
    //                break;
    //            case "HR":
    //                CurrentView = new HRDashboardPage();
    //                break;
    //            case "Employee":
    //                CurrentView = new EmployeeDashboardPage();
    //                break;
    //            default:
    //                System.Windows.MessageBox.Show("Invalid role detected. Please contact support.", "Error", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
    //                //CurrentView = new ErrorView(); // You can have a default error view if needed
    //                break;
    //        }
    //    }

    //    public event PropertyChangedEventHandler PropertyChanged;

    //    protected void OnPropertyChanged(string propertyName = "")
    //    {
    //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    //    }
    //}

    public class MainViewModel : INotifyPropertyChanged
    {
        private Page _currentPage;

        public Page CurrentPage
        {
            get => _currentPage;
            set
            {
                _currentPage = value;
                OnPropertyChanged(nameof(CurrentPage));
            }
        }

        public MainViewModel()
        {
            LoadUserPage();
        }

        private void LoadUserPage()
        {
            if (App.Current.Properties["User"] is User user)
            {
                switch (user.Role)
                {
                    case "Admin":
                        CurrentPage = new AdminDashboardPage();
                        break;
                    case "HRManager":
                        CurrentPage = new HRDashboardPage();
                        break;
                    case "Employee":
                        CurrentPage = new EmployeeDashboardPage();
                        break;
                    default:
                        // optional: fallback page
                        break;
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }

}

