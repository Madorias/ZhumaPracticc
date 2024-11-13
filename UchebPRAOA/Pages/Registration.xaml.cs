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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        public Registration()
        {
            InitializeComponent();
            RoleBox.ItemsSource = UchebPracsEntities1.GetContext().Roles.ToList();
            
        }

        private void ZV_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var TmpLogin = UchebPracsEntities1.GetContext().Users.Where(d => d.UserLogin == LoginBox.Text).FirstOrDefault();
                if (TmpLogin == null)
                {
                    try
                    {
                        Users user = new Users()
                        {
                            FIO = FioBox.Text,
                            UserLogin = LoginBox.Text,
                            UserPass = PasswordBox.Password,
                            Phone = PhoneBox.Text,
                            RoleID = UchebPracsEntities1.GetContext().Roles.Where(d => d.RoleName == RoleBox.Text).FirstOrDefault().RoleID
                        };
                        ErrUser.Visibility = Visibility.Hidden;
                        UchebPracsEntities1.GetContext().Users.Add(user);
                        UchebPracsEntities1.GetContext().SaveChanges();
                        
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    
                    
                }
                else
                {
                    ErrUser.Visibility = Visibility.Visible;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Manager.frame.Navigate(new Pages.ListofRequest());
        }
        
    }
    
}
