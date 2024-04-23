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
using WpfApp1.Components.DB;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для RunnerSponsorshipRegistrationPage.xaml
    /// </summary>
    public partial class RunnerSponsorshipRegistrationPage : Page
    {
        public RunnerSponsorshipRegistrationPage()
        {
            InitializeComponent();
            List<Runner> runners = new List<Runner>();
            runners = App.db.Runner.ToList();
            runners.Select(x => x.FullName);
            this.DataContext = runners;
            RunnerCB.DisplayMemberPath = "FullName";
            RunnerCB.ItemsSource = runners.Select(x => x.FullName);
        }
    }
}
