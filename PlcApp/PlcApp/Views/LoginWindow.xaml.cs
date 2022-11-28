// Copyright Zbigniew Kuligowski. All Rights Reserved.

namespace PlcApp.Views
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Windows;
    using PlcApp.Classes;

    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private ObservableCollection<LoginModel> loginModel2 = new ObservableCollection<LoginModel>();
        public bool auth { get; set; } = false;

        public LoginWindow()
        {
            this.InitializeComponent();

            this.DataContext = this;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
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
            }
            else
            {
                MessageBox.Show("Invalid username or password! Try Again!", "Error");
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            //LoginModel loginModel = new LoginModel();
            //loginModel.Authenticated = false;
            this.loginModel2.Add(new LoginModel() { Authenticated = false });

            //Auth = false;
            //var prop = new PropertyChangedEventArgs("Auth");
            //var test = prop.PropertyName;
            this.Close();
        }
    }
}
