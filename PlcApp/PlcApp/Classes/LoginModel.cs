// Copyright Zbigniew Kuligowski. All Rights Reserved.

namespace PlcApp.Classes
{
    using System.ComponentModel;

    public class LoginModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private bool authenticated;

        private void OnpropertyChanged(bool b)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(b)));
        }

        public bool Authenticated
        {
            get
            {
                return this.authenticated;
            }

            set
            {
                this.authenticated = value;
                this.OnpropertyChanged(this.Authenticated);
            }
        }
    }
}
