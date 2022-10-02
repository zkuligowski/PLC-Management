﻿// Copyright (c) Zbigniew Kuligowski. All rights reserved.

namespace PlcApp
{
    using System;
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
            throw new NotSupportedException();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            var registrationWindow = new RegistrationWindow();
            this.Dispatcher.Invoke(registrationWindow.ShowDialog);
        }
    }
}
