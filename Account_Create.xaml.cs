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
    /// Interaction logic for Account_Create.xaml
    /// </summary>
    public partial class Account_Create : Window
    {
        private ManageTeacher manageTeacher = new ManageTeacher();

        public Account_Create()
        {
            InitializeComponent();

            manageTeacher.LoadData();
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            //Todo do register new account

            string error = "";
            if (string.IsNullOrWhiteSpace(Text_Username.Text))
                error += "Username is required. \n";
            if (Text_Username.Text.Trim().Length < 3)
                error += "Username requires at least 3 Characters.\n";
            if (string.IsNullOrWhiteSpace(Text_Password.Password))
                error += "Password is required.\n";
            if (Text_Password.Password != Text_Confirm_Password.Password)
                error += "Password and Confirm password must be identical.";


            if (error.Length > 0)
                {
                    MessageBox.Show(error);
                    MessageBox.Show(Text_Password.Password);
                }
                else
                {
                manageTeacher.Teachers.Add(new Teacher

                {
                    Username = Text_Username.Text.Trim(),
                    Password  = Text_Password.Password.Trim(),
                    Phone = Text_Telephone.Text.Trim(),
                    QuestionNo = ComboBox_Security_Questions.SelectedIndex,
                    Answer = Text_Security_Answer.Text.Trim()
                });


                manageTeacher.SaveData();
                MessageBox.Show("Registration Successful");
                    Close();
                }



        }
    }
}
