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
    /// Логика взаимодействия для AdminHPanel.xaml
    /// </summary>
    public partial class AdminHPanel : Window
    {
        ImageBrush pic = new ImageBrush();
        public AdminHPanel()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        //pic.ImageSource = new BitmapImage(new Uri("C:\\Users\\karin\\Source\\Repos\\HaKaToN\\Хакатон\\Resources\\h1.png"));
        //hp.PicBorder.Background = pic;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            string FW = openFile.FileName; 
            pic.ImageSource = new BitmapImage(new Uri(FW)); 
            AdminHPanel AHP = new AdminHPanel();
            AHP.PicBorder.Background = pic; 
        }
    }
}
