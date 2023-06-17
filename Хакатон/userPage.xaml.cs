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

namespace Хакатон
{
    /// <summary>
    /// Логика взаимодействия для userPage.xaml
    /// </summary>
    public partial class userPage : Window
    {
        ImageBrush pic = new ImageBrush();
        bool wOpen = false;
        Building building = new Building();
        public userPage()
        {
            InitializeComponent();
        }

        private void Build1_Click(object sender, RoutedEventArgs e)
        {
            hPage hp = new hPage();
            hp.Show();
            pic.ImageSource = new BitmapImage(new Uri("D:\\Влад\\ДОМАХА\\WPF\\Хакатон\\Хакатон\\Resources\\h1.png"));
            hp.PicBorder.Background = pic;

            hp.t1.Text = building.Name = "Дом1";
        }

        private void Build2_Click(object sender, RoutedEventArgs e)
        {
            hPage hp = new hPage();
            hp.Show();
            pic.ImageSource = new BitmapImage(new Uri("D:\\Влад\\ДОМАХА\\WPF\\Хакатон\\Хакатон\\Resources\\h2.png"));

            hp.PicBorder.Background = pic;
        }

        private void Build3_Click(object sender, RoutedEventArgs e)
        {
            hPage hp = new hPage();
            hp.Show();
            pic.ImageSource = new BitmapImage(new Uri("D:\\Влад\\ДОМАХА\\WPF\\Хакатон\\Хакатон\\Resources\\h3.png"));

            hp.PicBorder.Background = pic;
        }

        private void Build4_Click(object sender, RoutedEventArgs e)
        {
            hPage hp = new hPage();
            hp.Show();
            pic.ImageSource = new BitmapImage(new Uri("D:\\Влад\\ДОМАХА\\WPF\\Хакатон\\Хакатон\\Resources\\h4.png"));

            hp.PicBorder.Background = pic;
        }

        private void Build5_Click(object sender, RoutedEventArgs e)
        {
            hPage hp = new hPage();
            hp.Show();
            pic.ImageSource = new BitmapImage(new Uri("D:\\Влад\\ДОМАХА\\WPF\\Хакатон\\Хакатон\\Resources\\h5.png"));

            hp.PicBorder.Background = pic;
        }

        private void Build6_Click(object sender, RoutedEventArgs e)
        {
            hPage hp = new hPage();
            hp.Show();
            pic.ImageSource = new BitmapImage(new Uri("D:\\Влад\\ДОМАХА\\WPF\\Хакатон\\Хакатон\\Resources\\h6.png"));

            hp.PicBorder.Background = pic;
        }

        private void Build7_Click(object sender, RoutedEventArgs e)
        {
            hPage hp = new hPage();
            hp.Show();
            pic.ImageSource = new BitmapImage(new Uri("D:\\Влад\\ДОМАХА\\WPF\\Хакатон\\Хакатон\\Resources\\h7.png"));

            hp.PicBorder.Background = pic;
        }

        private void Build8_Click(object sender, RoutedEventArgs e)
        {
            hPage hp = new hPage();
            hp.Show();
            pic.ImageSource = new BitmapImage(new Uri("D:\\Влад\\ДОМАХА\\WPF\\Хакатон\\Хакатон\\Resources\\h8.png"));

            hp.PicBorder.Background = pic;
        }

        private void Build9_Click(object sender, RoutedEventArgs e)
        {
            hPage hp = new hPage();
            hp.Show();
            pic.ImageSource = new BitmapImage(new Uri("D:\\Влад\\ДОМАХА\\WPF\\Хакатон\\Хакатон\\Resources\\h9.png"));

            hp.PicBorder.Background = pic;
        }

        private void Build10_Click(object sender, RoutedEventArgs e)
        {
            hPage hp = new hPage();
            hp.Show();
            pic.ImageSource = new BitmapImage(new Uri("D:\\Влад\\ДОМАХА\\WPF\\Хакатон\\Хакатон\\Resources\\h10.png"));

            hp.PicBorder.Background = pic;
        }
    }
}
