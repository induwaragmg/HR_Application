using HR_Application.View;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HR_Application.View.HR_Role.UserControls
{
    /// <summary>
    /// Interaction logic for dashboard.xaml
    /// </summary>
    public partial class EmployeeManagement : UserControl
    {
        public EmployeeManagement()
        {
            InitializeComponent();
            LoadMembersData();

        }

        //// Public method to set the DataGrid's ItemsSource
        //public void SetMembersDataGridItemsSource(IEnumerable data)
        //{
        //    membersDataGrid.ItemsSource = data;
        //}

        private void LoadMembersData()
        {
            var converter = new BrushConverter();
            var members = new ObservableCollection<Member>
            {
                new Member
                {
                    Number = "1",
                    Character = "J",
                    BgColor = (Brush)converter.ConvertFromString("#1098AD"),
                    Name = "John Doe",
                    Position = "Coach",
                    Email = "john.doe@gmail.com",
                    Phone = "415-954-1475"
                },
                new Member
                {
                    Number = "2",
                    Character = "R",
                    BgColor = (Brush)converter.ConvertFromString("#1E88E5"),
                    Name = "Reza Alavi",
                    Position = "Administrator",
                    Email = "reza110@hotmail.com",
                    Phone = "254-451-7893"
                },
                new Member
                {
                    Number = "3",
                    Character = "D",
                    BgColor = (Brush)converter.ConvertFromString("#FF8F00"),
                    Name = "Dennis Castillo",
                    Position = "Coach",
                    Email = "deny.cast@gmail.com",
                    Phone = "125-520-0141"
                }
                // Add more members as needed
            };

            // Assign the collection to the DataGrid's ItemsSource
            membersDataGrid.ItemsSource = members;
        }

        // Inner class for the Member model
        public class Member
        {
            public string Character { get; set; }
            public Brush BgColor { get; set; }
            public string Number { get; set; }
            public string Name { get; set; }
            public string Position { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
        }


    }
}
