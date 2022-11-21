

namespace PlcApp.Views
{
    using System.Collections.Generic;
    using System.Windows;
    using System;
    using PlcApp.Classes;

    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            DataAccess db = new DataAccess();
            List<Person> users = new ();
            try
            {
                users = db.GetUserFromDB(this.usernameText.Text, this.passwordText.Password.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            if (users.Count == 1)
            {
                this.Close();
                ////var scadaWindow = new SCADA();
                ////scadaWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid username or password! Try Again!", "Error");
            }
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
