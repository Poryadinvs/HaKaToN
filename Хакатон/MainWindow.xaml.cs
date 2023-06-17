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
using Хакатон.ApplicationData;

namespace Хакатон
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AppConnect.model0db = new HakatonUsersEntities();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            userPage UP = new userPage();
            AdminPage AP = new AdminPage();

            if(LoginA.Text == "user")
            {
                UP.Show();
                this.Hide();
            }    
            else if(LoginA.Text == "admin")
            {
                AP.Show();
                this.Hide();
            }

            //try
            //{
            //    var userObj = AppConnect.model0db.Users.FirstOrDefault(x => x.Login == LoginA.Text && x.Password == PasswordA.Password);
            //    if (userObj == null)
            //    {
            //        MessageBox.Show("Такого пользователя нет!", "Ошибка при авторизации!",
            //            MessageBoxButton.OK, MessageBoxImage.Error);
            //    }
            //    else
            //    {
            //        switch (userObj.idRole)
            //        {
            //            case 1:
            //                AP.Show();
            //                this.Hide();
            //                break;
            //            case 2:
            //                UP.Show();
            //                this.Hide();
            //                break;
            //            default:
            //                MessageBox.Show("Данные не обнаружены!", "Уведомления", MessageBoxButton.OK, MessageBoxImage.Warning);
            //                break;
            //        }
            //    }
            //}
            //catch (Exception Ex)
            //{
            //    MessageBox.Show("Ошибка" + Ex.Message.ToString() + "Критическая работа приложения",
            //        "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            //}
        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow RW = new RegistrationWindow();
            RW.Show();
            this.Hide();
        }

       
    }
}
