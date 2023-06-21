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
using System.Windows.Shapes;
using Хакатон.ApplicationData;
using System.Data.SqlClient;
using StackExchange.Redis;

namespace Хакатон
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            //MainWindow MW = new MainWindow();
            //MW.Show();
            //this.Close();

            if(AppConnect.model0db.Users.Count(x=> x.Login== LoginR.Text)>0)
            {
                MessageBox.Show("Пользователь с таким логином есть!", 
                    "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            if(Password2.Password == PasswordR.Password)
            {
                MessageBox.Show("Пароли не сходятся, введите один и тот-же пароль",
                    "Ошибка регистарции", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            try
            {
                Users userObj = new Users()
                {
                    Login = LoginR.Text,
                    Password = PasswordR.Password,
                    Name = NameR.Text,
                    idRole = +1 
                };

                AppConnect.model0db.Users.Add(userObj);
                AppConnect.model0db.SaveChanges();

                MainWindow MW = new MainWindow();
                MW.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при регистрации!", "Уведомление", MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }
    }
}
