

namespace PlcApp.Views
{
    using System;
    using System.Windows;
    using PlcApp.Classes;

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
            try
            {
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
