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
using Practice1.Pages;

namespace Practice1.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void BLogin_Click(object sender, RoutedEventArgs e)
        {
            var user = App.DB.Users.FirstOrDefault(u => u.Name == TBLogin.Text);
            if (user == null || user.Password != TBPassword.Text)
            {
                MessageBox.Show("Неверный логин или пароль");
                return;
            }
            NavigationService.Navigate(new MainPage());
            
        }
    }
}
