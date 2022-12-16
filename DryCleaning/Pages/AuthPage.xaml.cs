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

namespace DryCleaning.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
            if (Properties.Settings.Default.Login != null)
                LoginTb.Text = Properties.Settings.Default.Login;
            if (Properties.Settings.Default.Password != null)
                PasswordTb.Password = Properties.Settings.Default.Password;
        }

        private void EntrBtn_Click(object sender, RoutedEventArgs e)
        {
            int TimeAuth = Properties.Settings.Default.TimeAuth;
            string login = LoginTb.Text.Trim();
            string password = PasswordTb.Password.Trim();
            if(TimeAuth < 3)
            {
                if (login.Length == 0 && password.Length == 0)
                    MessageBox.Show("Заполните поля");
                else
                {

                }

            }
        }
    }
}
