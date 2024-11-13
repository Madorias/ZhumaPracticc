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

namespace UchebPRAOA.Pages
{
    /// <summary>
    /// Логика взаимодействия для ListofRequest.xaml
    /// </summary>
    public partial class ListofRequest : Page
    {
        public ListofRequest()
        {
            InitializeComponent();
            ListRequest.ItemsSource = UchebPracsEntities1.GetContext().Request.ToList();
        }

        private void AddRequest_Click(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new Pages.AddRequest());
        }

        private void EditRequest_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void EDitBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
