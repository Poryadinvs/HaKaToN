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
        Building building = new Building();
        public userPage()
        {
            InitializeComponent();
        }

        private void Build1_Click(object sender, RoutedEventArgs e)
        {
            hPage hp = new hPage();
            hp.Show();
            pic.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/h1.png"));
            hp.PicBorder.Background = pic;
            Random random = new Random();
            int y = random.Next(1900, 2023);
            y = building.BuidYear;
            int f = random.Next(1, 10);
            f = building.Floors;
            int fl = random.Next(1, 50);
            fl = building.Flats;
            int cn = random.Next(100000000, 999999999);
            cn = building.CudNum;
            int s = random.Next(100, 500);
            s = building.Square;
            int p = random.Next(1, 100);
            p = building.PepleCount;
            hp.t1.Text = building.Name = "Дом1";
            hp.t2.Text = building.Adres = "Случайный адрес " + random.Next(1, 1000);
            hp.t3.Text = y.ToString();
            hp.t4.Text = building.State = "Отличное";
            hp.t5.Text = f.ToString();
            hp.t6.Text = fl.ToString();
            hp.t7.Text = building.Material = "Кирпич";
            hp.t8.Text = cn.ToString();
            hp.t9.Text = cn.ToString();
            hp.t10.Text = p.ToString();

        }

        private void Build2_Click(object sender, RoutedEventArgs e)
        {
            hPage hp = new hPage();
            hp.Show();
            pic.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/h2.png"));

            hp.PicBorder.Background = pic;

            Random random = new Random();
            int y = random.Next(1900, 2023);
            y = building.BuidYear;
            int f = random.Next(1, 10);
            f = building.Floors;
            int fl = random.Next(1, 50);
            fl = building.Flats;
            int cn = random.Next(100000000, 999999999);
            cn = building.CudNum;
            int s = random.Next(100, 500);
            s = building.Square;
            int p = random.Next(1, 100);
            p = building.PepleCount;
            hp.t1.Text = building.Name = "Дом2";
            hp.t2.Text = building.Adres = "" + random.Next(1, 1000);
            hp.t3.Text = y.ToString();
            hp.t4.Text = building.State = "Нормальное";
            hp.t5.Text = f.ToString();
            hp.t6.Text = fl.ToString();
            hp.t7.Text = building.Material = "Дуб";
            hp.t8.Text = cn.ToString();
            hp.t9.Text = cn.ToString();
            hp.t10.Text = p.ToString();
        }

        private void Build3_Click(object sender, RoutedEventArgs e)
        {
            hPage hp = new hPage();
            hp.Show();
            pic.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/h3.png"));

            hp.PicBorder.Background = pic;

            Random random = new Random();
            int y = random.Next(1900, 2023);
            y = building.BuidYear;
            int f = random.Next(1, 10);
            f = building.Floors;
            int fl = random.Next(1, 50);
            fl = building.Flats;
            int cn = random.Next(100000000, 999999999);
            cn = building.CudNum;
            int s = random.Next(100, 500);
            s = building.Square;
            int p = random.Next(1, 100);
            p = building.PepleCount;
            hp.t1.Text = building.Name = "Дом3";
            hp.t2.Text = building.Adres = "" + random.Next(1, 1000);
            hp.t3.Text = y.ToString();
            hp.t4.Text = building.State = "Ававрийное";
            hp.t5.Text = f.ToString();
            hp.t6.Text = fl.ToString();
            hp.t7.Text = building.Material = "Кирпич";
            hp.t8.Text = cn.ToString();
            hp.t9.Text = cn.ToString();
            hp.t10.Text = p.ToString();
        }

        private void Build4_Click(object sender, RoutedEventArgs e)
        {
            hPage hp = new hPage();
            hp.Show();
            pic.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/h4.png"));

            hp.PicBorder.Background = pic;

            Random random = new Random();
            int y = random.Next(1900, 2023);
            y = building.BuidYear;
            int f = random.Next(1, 10);
            f = building.Floors;
            int fl = random.Next(1, 50);
            fl = building.Flats;
            int cn = random.Next(100000000, 999999999);
            cn = building.CudNum;
            int s = random.Next(100, 500);
            s = building.Square;
            int p = random.Next(1, 100);
            p = building.PepleCount;
            hp.t1.Text = building.Name = "Дом4";
            hp.t2.Text = building.Adres = "" + random.Next(1, 1000);
            hp.t3.Text = y.ToString();
            hp.t4.Text = building.State = "Отличное";
            hp.t5.Text = f.ToString();
            hp.t6.Text = fl.ToString();
            hp.t7.Text = building.Material = "Гранит";
            hp.t8.Text = cn.ToString();
            hp.t9.Text = cn.ToString();
            hp.t10.Text = p.ToString();
        }

        private void Build5_Click(object sender, RoutedEventArgs e)
        {
            hPage hp = new hPage();
            hp.Show();
            pic.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/h5.png"));

            hp.PicBorder.Background = pic;

            Random random = new Random();
            int y = random.Next(1900, 2023);
            y = building.BuidYear;
            int f = random.Next(1, 10);
            f = building.Floors;
            int fl = random.Next(1, 50);
            fl = building.Flats;
            int cn = random.Next(100000000, 999999999);
            cn = building.CudNum;
            int s = random.Next(100, 500);
            s = building.Square;
            int p = random.Next(1, 100);
            p = building.PepleCount;
            hp.t1.Text = building.Name = "Дом5";
            hp.t2.Text = building.Adres = "" + random.Next(1, 1000);
            hp.t3.Text = y.ToString();
            hp.t4.Text = building.State = "Отличное";
            hp.t5.Text = f.ToString();
            hp.t6.Text = fl.ToString();
            hp.t7.Text = building.Material = "Картон";
            hp.t8.Text = cn.ToString();
            hp.t9.Text = cn.ToString();
            hp.t10.Text = p.ToString();
        }

        private void Build6_Click(object sender, RoutedEventArgs e)
        {
            hPage hp = new hPage();
            hp.Show();
            pic.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/h6.png"));

            hp.PicBorder.Background = pic;

            Random random = new Random();
            int y = random.Next(1900, 2023);
            y = building.BuidYear;
            int f = random.Next(1, 10);
            f = building.Floors;
            int fl = random.Next(1, 50);
            fl = building.Flats;
            int cn = random.Next(100000000, 999999999);
            cn = building.CudNum;
            int s = random.Next(100, 500);
            s = building.Square;
            int p = random.Next(1, 100);
            p = building.PepleCount;
            hp.t1.Text = building.Name = "Дом6";
            hp.t2.Text = building.Adres = "Случайный адрес " + random.Next(1, 1000);
            hp.t3.Text = y.ToString();
            hp.t4.Text = building.State = "Отличное";
            hp.t5.Text = f.ToString();
            hp.t6.Text = fl.ToString();
            hp.t7.Text = building.Material = "Кирпич";
            hp.t8.Text = cn.ToString();
            hp.t9.Text = cn.ToString();
            hp.t10.Text = p.ToString();
        }

        private void Build7_Click(object sender, RoutedEventArgs e)
        {
            hPage hp = new hPage();
            hp.Show();
            pic.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/h7.png"));

            hp.PicBorder.Background = pic;

            Random random = new Random();
            int y = random.Next(1900, 2023);
            y = building.BuidYear;
            int f = random.Next(1, 10);
            f = building.Floors;
            int fl = random.Next(1, 50);
            fl = building.Flats;
            int cn = random.Next(100000000, 999999999);
            cn = building.CudNum;
            int s = random.Next(100, 500);
            s = building.Square;
            int p = random.Next(1, 100);
            p = building.PepleCount;
            hp.t1.Text = building.Name = "Дом7";
            hp.t2.Text = building.Adres = "" + random.Next(1, 1000);
            hp.t3.Text = y.ToString();
            hp.t4.Text = building.State = "Нормальное";
            hp.t5.Text = f.ToString();
            hp.t6.Text = fl.ToString();
            hp.t7.Text = building.Material = "Пенопласт";
            hp.t8.Text = cn.ToString();
            hp.t9.Text = cn.ToString();
            hp.t10.Text = p.ToString();
        }

        private void Build8_Click(object sender, RoutedEventArgs e)
        {
            hPage hp = new hPage();
            hp.Show();
            pic.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/h8.png"));

            hp.PicBorder.Background = pic;
            Random random = new Random();
            int y = random.Next(1900, 2023);
            y = building.BuidYear;
            int f = random.Next(1, 10);
            f = building.Floors;
            int fl = random.Next(1, 50);
            fl = building.Flats;
            int cn = random.Next(100000000, 999999999);
            cn = building.CudNum;
            int s = random.Next(100, 500);
            s = building.Square;
            int p = random.Next(1, 100);
            p = building.PepleCount;
            hp.t1.Text = building.Name = "Дом8";
            hp.t2.Text = building.Adres = "" + random.Next(1, 1000);
            hp.t3.Text = y.ToString();
            hp.t4.Text = building.State = "Шакарное";
            hp.t5.Text = f.ToString();
            hp.t6.Text = fl.ToString();
            hp.t7.Text = building.Material = "Камень";
            hp.t8.Text = cn.ToString();
            hp.t9.Text = cn.ToString();
            hp.t10.Text = p.ToString();
        }

        private void Build9_Click(object sender, RoutedEventArgs e)
        {
            hPage hp = new hPage();
            hp.Show();
            pic.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/h9.png"));

            hp.PicBorder.Background = pic;

            Random random = new Random();
            int y = random.Next(1900, 2023);
            y = building.BuidYear;
            int f = random.Next(1, 10);
            f = building.Floors;
            int fl = random.Next(1, 50);
            fl = building.Flats;
            int cn = random.Next(100000000, 999999999);
            cn = building.CudNum;
            int s = random.Next(100, 500);
            s = building.Square;
            int p = random.Next(1, 100);
            p = building.PepleCount;
            hp.t1.Text = building.Name = "Дом9";
            hp.t2.Text = building.Adres = "" + random.Next(1, 1000);
            hp.t3.Text = y.ToString();
            hp.t4.Text = building.State = "Аварийное";
            hp.t5.Text = f.ToString();
            hp.t6.Text = fl.ToString();
            hp.t7.Text = building.Material = "Стекло";
            hp.t8.Text = cn.ToString();
            hp.t9.Text = cn.ToString();
            hp.t10.Text = p.ToString();
        }

        private void Build10_Click(object sender, RoutedEventArgs e)
        {
            hPage hp = new hPage();
            hp.Show();
            pic.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/h10.png"));

            hp.PicBorder.Background = pic;

            Random random = new Random();
            int y = random.Next(1900, 2023);
            y = building.BuidYear;
            int f = random.Next(1, 10);
            f = building.Floors;
            int fl = random.Next(1, 50);
            fl = building.Flats;
            int cn = random.Next(100000000, 999999999);
            cn = building.CudNum;
            int s = random.Next(100, 500);
            s = building.Square;
            int p = random.Next(1, 100);
            p = building.PepleCount;
            hp.t1.Text = building.Name = "Дом10";
            hp.t2.Text = building.Adres = "" + random.Next(1, 1000);
            hp.t3.Text = y.ToString();
            hp.t4.Text = building.State = "Отличное";
            hp.t5.Text = f.ToString();
            hp.t6.Text = fl.ToString();
            hp.t7.Text = building.Material = "Метал";
            hp.t8.Text = cn.ToString();
            hp.t9.Text = cn.ToString();
            hp.t10.Text = p.ToString();
        }
    }
}
