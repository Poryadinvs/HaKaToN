using Microsoft.Win32;
using System;
using System.IO;
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

namespace Хакатон
{
    /// <summary>
    /// Логика взаимодействия для AdminHPanel.xaml
    /// </summary>
    public partial class AdminHPanel : Window
    {
        public AdminHPanel()
        {
            InitializeComponent();
        }

        private void SaveButoon_Click(object sender, RoutedEventArgs e)
        {
            int date = Int32.Parse(At3.Text);
            DateTime dtB = new DateTime(date);
            int dateJ = Int32.Parse(At11.Text);
            DateTime dtJ = new DateTime(dateJ);
            int dtWJ = Int32.Parse(At14.Text);
            DateTime dateWJ = new DateTime(dtWJ);
            int dateDL = Int32.Parse(At16.Text);
            DateTime dtDL = new DateTime(dateDL); 
            int dateJA = Int32.Parse(At21.Text);
            DateTime dtJA = new DateTime(dateJA);
            int FloCount = Int32.Parse(At5.Text);
            int FlaCount = Int32.Parse(At6.Text);
            int CD = Int32.Parse(At8.Text);
            int sq = Int32.Parse(At9.Text);
            int pc = Int32.Parse(At10.Text);

            AdminPage AP = new AdminPage();
            byte[] imageBytes = File.ReadAllBytes(AP.openFile.FileName);

            try
            {
                ABuilding aBuilding = new ABuilding()
                {
                    BuildinName = At1.Text,
                    Adres = At2.Text,
                    yearBuld = dtB,
                    State = At4.Text,
                    FloorsCount = FloCount,
                    FlatsCount = FlaCount,
                    Material = At7.Text,
                    CudNum = CD,
                    Square = sq,
                    PeopleCount = pc 
                };
                AppConnect.model1db.ABuilding.Add(aBuilding);

                AJournal aJournal = new AJournal()
                {
                    ADate = dtJ,
                    Comment = At12.Text,
                    FIOEmpl = At13.Text,
                };
                AppConnect.model1db.AJournal.Add(aJournal);

                AWorkJournal aWorkJournal = new AWorkJournal()
                {
                    ADate = dateWJ,
                    Task = At15.Text,
                    Dedlines = dtDL,
                    Status = At17.Text,
                    Comment = At18.Text,
                    Quality = At19.Text,
                };
                AppConnect.model1db.AWorkJournal.Add(aWorkJournal);

                ABuidingInfo aBuidingInfo = new ABuidingInfo()
                {
                    BuildingPic = imageBytes, 
                    BuildingInfo = At20.Text,
                };
                AppConnect.model1db.ABuidingInfo.Add(aBuidingInfo);

                AJournalViolations aJournalViolations = new AJournalViolations()
                {
                    ADate = dtJA,
                    Task = At22.Text,
                    Resons = At23.Text,
                };
                AppConnect.model1db.AJournalViolations.Add(aJournalViolations);

                AUser aUser = new AUser()
                {
                    FIOUser = At24.Text,
                    JobTitel = At25.Text
                };

                AppConnect.model1db.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении" + ex, "Уведомление", MessageBoxButton.OK,
                 MessageBoxImage.Error);
            }
        }
    }
}
