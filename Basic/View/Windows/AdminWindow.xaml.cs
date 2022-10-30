using Basic.Core;
using Basic.Model;
using Basic.View.Pages;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Basic.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void btnLoadSomePage_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new UsersPage());
            Width = 800;
        }

        private void btnLoadUsers_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new SomePage());
        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            List<User> users = UserParser.ParseFile("users2.txt").ToList();

            var reapeatedUser = users.FirstOrDefault(u => u.FirstName == tbFirstName.Text &&
            u.MiddleName == tbMiddleName.Text && u.LastName == tbLastName.Text);

            if (reapeatedUser != null)
            {
                MessageBox.Show("Такой пользователь уже существует!");
            }
            /*else
            {
                UserParser.AddUser("users2.txt", new User(Convert.ToInt32(tbID.Text), tbFirstName.Text,
                    tbMiddleName.Text, tbLastName.Text, Convert.ToDateTime(tbDateOfBirth.Text),
                    Convert.ToDecimal(tbSalary.Text)));

                ClearTextFields();

                mainFrame.Navigate(new UsersPage());
            }*/
        }

        private void ClearTextFields()
        {
            tbID.Text = string.Empty;
            tbFirstName.Text = string.Empty;
            tbMiddleName.Text = string.Empty;
            tbLastName.Text = string.Empty;
            tbDateOfBirth.Text = string.Empty;
            tbSalary.Text = string.Empty;
        }
    }
}
