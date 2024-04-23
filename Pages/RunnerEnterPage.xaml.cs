﻿using System;
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

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для RunnerEnterPage.xaml
    /// </summary>
    public partial class RunnerEnterPage : Page
    {
        public RunnerEnterPage()
        {
            InitializeComponent();
        }
        private void RegRunnerBtn_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as MainWindow).MainFrame.Navigate(new Uri("Pages/NewRunnerRegistration.xaml", UriKind.Relative));
        }
    }
}
