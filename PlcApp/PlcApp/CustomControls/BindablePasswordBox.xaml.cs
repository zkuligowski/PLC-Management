// Copyright Zbigniew Kuligowski. All Rights Reserved.

namespace PlcApp.CustomControls
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Navigation;
    using System.Windows.Shapes;

    /// <summary>
    /// Interaction logic for BindablePasswordBox.xaml
    /// </summary>
    public partial class BindablePasswordBox : UserControl
    {
        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register("Password", typeof(SecureString), typeof(BindablePasswordBox));

        public SecureString Password
        {
            get { return (SecureString)this.GetValue(PasswordProperty); }
            set { this.SetValue(PasswordProperty, value); }
        }

        public BindablePasswordBox()
        {
            this.InitializeComponent();
            this.txtPassword.PasswordChanged += this.OnPasswordChanged;
        }

        private void OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            this.Password = this.txtPassword.SecurePassword;
        }
    }
}
