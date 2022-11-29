// Copyright Zbigniew Kuligowski. All Rights Reserved.

namespace PlcApp
{
    using PlcApp.View;
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows;

    /// <summary>
    /// Interaction logic for App.xaml.
    /// </summary>
    public partial class App : Application
    {
        protected void ApplicationStart(object sender, StartupEventArgs e)
        {
            var LoginView = new LoginView();
            LoginView.Show();
        }
    }
}
