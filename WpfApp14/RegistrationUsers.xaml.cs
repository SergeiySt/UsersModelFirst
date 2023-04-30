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
using System.Xml.Linq;
using WpfApp14.Model;
using WpfApp14.Views;
using static WpfApp14.Views.DataPage;

namespace WpfApp14
{
    /// <summary>
    /// Interaction logic for RegistrationUsers.xaml
    /// </summary>
    public partial class RegistrationUsers : Window
    {

        public RegistrationUsers()
        {
            InitializeComponent();
            comboboxRole.ItemsSource = AppData.db.Roles.ToList();
        }

        public event EventHandler UserRegistered;

        private void OnUserRegistered()
        {
            UserRegistered?.Invoke(this, EventArgs.Empty);
        }

        private void buttonRegister_Click(object sender, RoutedEventArgs e)
        {
            if (!AddUser())
            {
                MessageBox.Show("Заповніть всі поля!", "Примітка", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            string Login = login.Text;
            string Password = password2.Text;
            int roleId = (int)comboboxRole.SelectedValue;

            if(AppData.db.Users.Any(x=> x.Login == login.Text))
            {
                MessageBox.Show("Такий логін вже існує.", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            Users users = new Users
            {
                RolesId = roleId,
                Login = login.Text,
                Password = password2.Text
            };

            using (var db = new Financial_conditionEntities())
            {
                db.Users.Add(users);
                db.SaveChanges();
            }

            login.Text = " ";
            password2.Text = " ";
            comboboxRole.SelectedIndex = -1;

            OnUserRegistered();
        }
        private bool AddUser()
        {
            return !string.IsNullOrEmpty(login.Text)
                 && !string.IsNullOrEmpty(password2.Text)
                 && comboboxRole.SelectedValue != null;
        }
    }
}
