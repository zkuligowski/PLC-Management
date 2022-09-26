using PlcApp.Classes;
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

namespace PlcApp.Views
{
    /// <summary>
    /// Interaction logic for RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            DataAccess db = new DataAccess();
            db.AddNewUser(
                this.firstNameText.Text,
                this.surnameText.Text,
                this.emailText.Text,
                this.birthDateDatePicker.Text,
                this.mobileNumberText.Text,
                this.usernameText.Text,
                this.passwordText.Password.ToString(),
                this.rightsLevelComboBox.Text);
        }
    }
}
