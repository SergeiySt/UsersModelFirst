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
           if(MessageBox.Show("Вы точно хотите удалить пользователя", "Уведомлене", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var CurrentUser = UserGrid.SelectedItem as Users;
                AppData.db.Users.Remove(CurrentUser);
                AppData.db.SaveChanges();

                UserGrid.ItemsSource = AppData.db.Users.ToList();
                MessageBox.Show("Success");
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            RegistrationUsers registrationUsers = new RegistrationUsers();
            registrationUsers.UserRegistered += (s, args) => UpdateUserGrid();
            registrationUsers.ShowDialog();
        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
