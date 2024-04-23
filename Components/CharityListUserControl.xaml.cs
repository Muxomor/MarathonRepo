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

namespace WpfApp1.Components
{
    /// <summary>
    /// Логика взаимодействия для CharityListUserControl.xaml
    /// </summary>
    public partial class CharityListUserControl : UserControl
    {
        public CharityListUserControl(Charity charity)
        {
            InitializeComponent();
            
            charity.CharityLogo="/Assets/"+charity.CharityLogo;
            
            //logoImage.Source = charity.CharityLogo;
            this.DataContext = charity;
        }
    }
}
