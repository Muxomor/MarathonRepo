using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Threading;
using WpfApp1.Pages;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static readonly DateTime MaraphoneDateTime = new DateTime(2024, 12, 31, 12, 0, 0);

        private DispatcherTimer timer;
        private TimeSpan timeBeforeMaraphone => MaraphoneDateTime - DateTime.Now;

        public MainWindow()
        {
            InitializeComponent();
            App.MainFrame = this.MainFrame;
            timer = new DispatcherTimer();
            timer.Tick += UpdateTimer;
            timer.Interval = TimeSpan.FromMinutes(1);
            timer.Start();
            UpdateTimer(null, null);
            MainFrame.Navigate(new Uri("Pages/HomePage.xaml", UriKind.Relative));
            var path = @"D:\Marathon\WpfApp1\WpfApp1\Assets\";
            foreach (var item in App.db.Charity.ToList())
            {
                var fullPath = path + item.CharityLogo;
                var imageByte = File.ReadAllBytes(fullPath);
                item.CharityLogoBit= imageByte; 
            }
            App.db.SaveChanges();
        }

        private void UpdateTimer(object sender, EventArgs e)
        {
            TimeCountdownTB.Text = $"{timeBeforeMaraphone.Days} дней. {timeBeforeMaraphone.Hours} часов. {timeBeforeMaraphone.Minutes} минут.";
        }
    }
}
