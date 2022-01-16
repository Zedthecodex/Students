using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Students
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        private ManageTeacher manageTeacher = new ManageTeacher();
        private ManageAttendance manageAttendance = new ManageAttendance();

        const string filename = "C:/Users/GOD/source/repos/Students/subjects.csv";
        public Dashboard()
        {
            InitializeComponent();

            DataContext = manageAttendance.LoadGrid();
        }

        private void Add_Subject_Click(object sender, RoutedEventArgs e)
        {
            manageAttendance.LoadData();

            //DateTime date = new DateTime();

            

            
        }

        private void DataGrid_Change(object sender, EventArgs e)
        {
            
            manageAttendance.SaveData();
        }
    }
}
