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


namespace Practice1.Pages
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
            DGInfo.ItemsSource = App.DB.Mebel.ToList();
        }

        private void BAddMebel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddMebelPage());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DGInfo.ItemsSource = App.DB.Mebel.ToList();
        }
    }
}
