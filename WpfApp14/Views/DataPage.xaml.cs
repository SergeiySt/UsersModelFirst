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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp14.Model;


namespace WpfApp14.Views
{
    /// <summary>
    /// Логика взаимодействия для DataPage.xaml
    /// </summary>
    /// 
    public partial class DataPage : Page
    {
        public DataPage()
        {
            InitializeComponent();
            comboBoxEditRole.ItemsSource = AppData.db.Roles.ToList();
            RegistrationUsers registrationUsers = new RegistrationUsers();
            registrationUsers.UserRegistered += RegistrationUsers_UserRegistered;
        }
        private void RegistrationUsers_UserRegistered(object sender, EventArgs e)
        {
            UserGrid.ItemsSource = AppData.db.Users.ToList();
        }
        private void UpdateUserGrid()
        {
            UserGrid.ItemsSource = AppData.db.Users.ToList();
        }

        private void Back_btn_click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Page_loaded(object sender, RoutedEventArgs e)
        {
            UserGrid.ItemsSource = AppData.db.Users.ToList();
          
        }

        private void Delite_btn_click(object sender, RoutedEventArgs e)
        {
           if (UserGrid.SelectedItems.Count == 0)
            {
                MessageBox.Show("Виберіть запис для видалення.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            
            if(MessageBox.Show("Ви точно хочете видалити користувача", "Попередження", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var CurrentUser = UserGrid.SelectedItem as Users;
                AppData.db.Users.Remove(CurrentUser);
                AppData.db.SaveChanges();

                UserGrid.ItemsSource = AppData.db.Users.ToList();
                MessageBox.Show("Успішно видалено");
            }
            textEditLogin.Text = " ";
            textEditPassword.Text = " ";
            comboBoxEditRole.SelectedIndex = -1;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            RegistrationUsers registrationUsers = new RegistrationUsers();
            registrationUsers.UserRegistered += (s, args) => UpdateUserGrid();
            registrationUsers.ShowDialog();
        }
  

        private void textBoxFind_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = textBoxFind.Text;

            if (string.IsNullOrEmpty(searchText))
            {
                UserGrid.ItemsSource = AppData.db.Users.ToList();
            }
            else
            {
                var searchResultsByLogin = AppData.db.Users.Where(u => u.Login.Contains(searchText));
                var searchResultsByRoles = AppData.db.Users.Where(u => u.Roles.Names.Contains(searchText));
                var searchResults = searchResultsByLogin.Union(searchResultsByRoles);
                UserGrid.ItemsSource = searchResults.ToList();
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

            if(UserGrid.SelectedItem != null && EditUser())
            {

                Users users = UserGrid.SelectedItem as Users;
                users.RolesId = (int)comboBoxEditRole.SelectedValue;
                users.Login = textEditLogin.Text;
                users.Password = textEditPassword.Text;

                AppData.db.SaveChanges();
                UserGrid.ItemsSource = AppData.db.Users.ToList();

                textEditLogin.Text = " ";
                textEditPassword.Text = " ";
                comboBoxEditRole.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Неможливо оновити запис. Перевірте, чи всі поля заповнені та вибрано запис в таблиці.", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private bool EditUser()
        {
            return !string.IsNullOrEmpty(textEditLogin.Text)
                 && !string.IsNullOrEmpty(textEditPassword.Text)
                 && comboBoxEditRole.SelectedValue != null;
        }

        private void UserGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (UserGrid.SelectedItem != null)
            {
                Users selectedUsers = UserGrid.SelectedItem as Users;
                if (selectedUsers != null)
                {
                    textEditLogin.Text = selectedUsers.Login;
                    textEditPassword.Text = selectedUsers.Password;
                    comboBoxEditRole.SelectedItem = comboBoxEditRole.Items.Cast<Roles>().FirstOrDefault(x => x.Id == selectedUsers.Roles.Id);
                }
            }
        }
    }
}
