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
    /// Логика взаимодействия для SigIn.xaml
    /// </summary>
    public partial class SigIn : Page
    {
        public SigIn()
        {
            InitializeComponent();
        }

        private void SinIn_btn_click(object sender, RoutedEventArgs e)
        {
            string password = new System.Net.NetworkCredential(string.Empty, password4.SecurePassword).Password;
            var CurrentUser = AppData.db.Users.FirstOrDefault(u => u.Login == login.Text && u.Password == password);
            
            if(CurrentUser != null)
            {
                if(CurrentUser.RolesId == 1)
                {
                    NavigationService.Navigate(new DataPage());
                }
                else
                {
                    MessageBox.Show("Ты не админ или гуляй!");
                }
            }
            else
            {
                MessageBox.Show("Нет таких пользователей");
            }
        }
    }
}
