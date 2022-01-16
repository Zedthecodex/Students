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

namespace Students
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            double controlsize = ((SystemParameters.PrimaryScreenWidth / 12) / 3 * 2) / 5 * 0.7;
            System.Windows.Application.Current.Resources.Remove("ControlFontSize");
            System.Windows.Application.Current.Resources.Add("ControlFontSize", controlsize);
        }
    }
}
