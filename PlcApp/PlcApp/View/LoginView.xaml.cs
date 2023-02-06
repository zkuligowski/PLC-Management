// Copyright Zbigniew Kuligowski. All Rights Reserved.

namespace PlcApp.View
{
    using System.Windows;
    using System.Windows.Input;

    /// <summary>
    /// Interaction logic for LoginView.xaml.
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            this.InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void BtnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
