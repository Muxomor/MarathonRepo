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
    /// Логика взаимодействия для NewRunnerRegistration.xaml
    /// </summary>
    public partial class NewRunnerRegistration : Page
    {
        public NewRunnerRegistration()
        {
            InitializeComponent();
            Runner newRunner = new Runner();
            this.DataContext = newRunner;
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            App.MainFrame.GoBack();
            App.MainFrame.RemoveBackEntry();
        }
    }
}
