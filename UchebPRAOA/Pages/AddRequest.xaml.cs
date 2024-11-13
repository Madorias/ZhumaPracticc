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
    /// Логика взаимодействия для AddRequest.xaml
    /// </summary>
    public partial class AddRequest : Page
    {
        public AddRequest()
        {
            InitializeComponent();
            Type.ItemsSource = UchebPracsEntities1.GetContext().TechType.ToList();
        }

        private void AddRquest_Click(object sender, RoutedEventArgs e)
        {
            Request request = new Request()
            {
                StatusID = 3,
                TechTypeID = UchebPracsEntities1.GetContext().TechType.Where(d => d.TechTypeName == Type.Text).FirstOrDefault().TechTypeID,
                MasterID = null,
                ClientID = Manager.user.UserID,
                TechModel = Model.Text,
                Description = Description.Text,
                StartDate = DateTime.Now.Date,
                CompletionDate = null,
                RepairParts = null,
                MasterComment = null,
                Cost = null,

            };
            UchebPracsEntities1.GetContext().Request.Add(request);
            UchebPracsEntities1.GetContext().SaveChanges();

            Manager.frame.Navigate(new Pages.ListofRequest());
        }

        private void Gback_Click(object sender, RoutedEventArgs e)
        {
            Manager.frame.Navigate(new Pages.ListofRequest());
        }
    }
}
