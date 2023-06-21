using Microsoft.Win32;
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

namespace Хакатон
{
    /// <summary>
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Window
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        ImageBrush pic = new ImageBrush();
        OpenFileDialog openFile = new OpenFileDialog();
        string fw;



        private void Build1_Click(object sender, RoutedEventArgs e)
        {
            AdminHPanel AHP = new AdminHPanel();
            AHP.Show();
            openFile.Filter = "Picture documents (.png)|*.png";

            bool? result = openFile.ShowDialog();
            if (result == true)
            {
                fw = openFile.FileName;
                AHP.AhPic.ImageSource = new BitmapImage(new Uri(fw));
                AHP.PicBorder.Background = AHP.AhPic; 
                hPicButton1.ImageSource = new BitmapImage(new Uri(fw));
            }

        }

        private void Build2_Click(object sender, RoutedEventArgs e)
        {
            AdminHPanel AHP = new AdminHPanel();
            AHP.Show();

            openFile.Filter = "Picture documents (.png)|*.png";

            bool? result = openFile.ShowDialog();
            if (result == true)
            {
                fw = openFile.FileName;
                AHP.AhPic.ImageSource = new BitmapImage(new Uri(fw));
                AHP.PicBorder.Background = AHP.AhPic;
                hPicButton2.ImageSource = new BitmapImage(new Uri(fw));
            }
        }

        private void Build3_Click(object sender, RoutedEventArgs e)
        {
            AdminHPanel AHP = new AdminHPanel();
            AHP.Show();

            openFile.Filter = "Picture documents (.png)|*.png";

            bool? result = openFile.ShowDialog();
            if (result == true)
            {
                fw = openFile.FileName;
                AHP.AhPic.ImageSource = new BitmapImage(new Uri(fw));
                AHP.PicBorder.Background = AHP.AhPic;
                hPicButton3.ImageSource = new BitmapImage(new Uri(fw));
            }
        }

        private void Build4_Click(object sender, RoutedEventArgs e)
        {
            AdminHPanel AHP = new AdminHPanel();
            AHP.Show();

            openFile.Filter = "Picture documents (.png)|*.png";

            bool? result = openFile.ShowDialog();
            if (result == true)
            {
                fw = openFile.FileName;
                AHP.AhPic.ImageSource = new BitmapImage(new Uri(fw));
                AHP.PicBorder.Background = AHP.AhPic;
                hPicButton4.ImageSource = new BitmapImage(new Uri(fw));
            }
        }

        private void Build5_Click(object sender, RoutedEventArgs e)
        {
            AdminHPanel AHP = new AdminHPanel();
            AHP.Show();

            openFile.Filter = "Picture documents (.png)|*.png";

            bool? result = openFile.ShowDialog();
            if (result == true)
            {
                fw = openFile.FileName;
                AHP.AhPic.ImageSource = new BitmapImage(new Uri(fw));
                AHP.PicBorder.Background = AHP.AhPic;
                hPicButton5.ImageSource = new BitmapImage(new Uri(fw));
            }
        }

        private void Build6_Click(object sender, RoutedEventArgs e)
        {
            AdminHPanel AHP = new AdminHPanel();
            AHP.Show();

            openFile.Filter = "Picture documents (.png)|*.png";

            bool? result = openFile.ShowDialog();
            if (result == true)
            {
                fw = openFile.FileName;
                AHP.AhPic.ImageSource = new BitmapImage(new Uri(fw));
                AHP.PicBorder.Background = AHP.AhPic;
                hPicButton6.ImageSource = new BitmapImage(new Uri(fw));
            }
        }

        private void Build7_Click(object sender, RoutedEventArgs e)
        {
            AdminHPanel AHP = new AdminHPanel();
            AHP.Show();

            openFile.Filter = "Picture documents (.png)|*.png";

            bool? result = openFile.ShowDialog();
            if (result == true)
            {
                fw = openFile.FileName;
                AHP.AhPic.ImageSource = new BitmapImage(new Uri(fw));
                AHP.PicBorder.Background = AHP.AhPic;
                hPicButton7.ImageSource = new BitmapImage(new Uri(fw));
            }
        }

        private void Build8_Click(object sender, RoutedEventArgs e)
        {
            AdminHPanel AHP = new AdminHPanel();
            AHP.Show();

            openFile.Filter = "Picture documents (.png)|*.png";

            bool? result = openFile.ShowDialog();
            if (result == true)
            {
                fw = openFile.FileName;
                AHP.AhPic.ImageSource = new BitmapImage(new Uri(fw));
                AHP.PicBorder.Background = AHP.AhPic;
                hPicButton8.ImageSource = new BitmapImage(new Uri(fw));
            }
        }

        private void Build9_Click(object sender, RoutedEventArgs e)
        {
            AdminHPanel AHP = new AdminHPanel();
            AHP.Show();

            openFile.Filter = "Picture documents (.png)|*.png";

            bool? result = openFile.ShowDialog();
            if (result == true)
            {
                fw = openFile.FileName;
                AHP.AhPic.ImageSource = new BitmapImage(new Uri(fw));
                AHP.PicBorder.Background = AHP.AhPic;
                hPicButton9.ImageSource = new BitmapImage(new Uri(fw));
            }
        }

        private void Build10_Click(object sender, RoutedEventArgs e)
        {
            AdminHPanel AHP = new AdminHPanel();
            AHP.Show();

            openFile.Filter = "Picture documents (.png)|*.png";

            bool? result = openFile.ShowDialog();
            if (result == true)
            {
                fw = openFile.FileName;
                AHP.AhPic.ImageSource = new BitmapImage(new Uri(fw));
                AHP.PicBorder.Background = AHP.AhPic;
                hPicButton10.ImageSource = new BitmapImage(new Uri(fw));
            }
        }
    }
}
