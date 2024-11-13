using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
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

namespace UchebPRAOA
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Manager.frame = MainFrame;
        }

        private void Auth_Click(object sender, RoutedEventArgs e)
        {
            var tmpLog = UchebPracsEntities1.GetContext().Users.Where(d => d.UserLogin == LoginBox.Text & d.UserPass == PasswordBox.Password).FirstOrDefault();
            if (tmpLog != null & tmpLog.RoleID == 1)
            {
                MainFrame.Navigate(new Pages.ListofRequest());
                errMsg.Visibility = Visibility.Hidden;
                Auth.Visibility = Visibility.Hidden;
                Registration.Visibility = Visibility.Hidden;
                Manager.user = tmpLog;
            }
            else if(tmpLog != null & tmpLog.RoleID == 2)
            {
                MainFrame.Navigate(new Pages.ListofRequest());
                errMsg.Visibility = Visibility.Hidden;
                Auth.Visibility = Visibility.Hidden;
                Registration.Visibility = Visibility.Hidden;
                Manager.user = tmpLog;
            }
            else if (tmpLog != null & tmpLog.RoleID == 3)
            {
                MainFrame.Navigate(new Pages.ListofRequest());
                errMsg.Visibility = Visibility.Hidden;
                Auth.Visibility = Visibility.Hidden;
                Registration.Visibility = Visibility.Hidden;
                Manager.user = tmpLog;
            }
            else if (tmpLog != null & tmpLog.RoleID == 4)
            {
                MainFrame.Navigate(new Pages.ListofRequest());
                errMsg.Visibility = Visibility.Hidden;
                Auth.Visibility = Visibility.Hidden;
                Registration.Visibility = Visibility.Hidden;
                Manager.user = tmpLog;
            }
            
            

        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.Registration());
            Auth.Visibility = Visibility.Hidden;
            Registration.Visibility = Visibility.Hidden;
        }

    }
}
