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
using Practice1.Models;

namespace Practice1.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddMebelPage.xaml
    /// </summary>
    public partial class AddMebelPage : Page
    {
        Mebel contextMebel;
        public AddMebelPage()
        {
            InitializeComponent();
            
            contextMebel = new Mebel();
            DataContext = contextMebel;
        }
        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            App.DB.Mebel.Add(contextMebel);
            App.DB.SaveChanges();
            NavigationService.GoBack();
        }

        private void BCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
