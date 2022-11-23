// Copyright Zbigniew Kuligowski. All Rights Reserved.

namespace PlcApp
{
    using System.Windows;
    using PlcApp.Views;

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            var loginWindow = new LoginWindow();
            this.Dispatcher.Invoke(loginWindow.ShowDialog);
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            var registrationWindow = new RegistrationWindow();
            this.Dispatcher.Invoke(registrationWindow.ShowDialog);
        }

        private void RunApp_Click(object sender, RoutedEventArgs e)
        {
            var scadaWindow = new SCADA();
            scadaWindow.ShowDialog();
        }

        private void CloseMainWindow_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
