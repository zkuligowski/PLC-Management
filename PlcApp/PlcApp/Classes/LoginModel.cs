// Copyright Zbigniew Kuligowski. All Rights Reserved.

using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PlcApp.Classes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

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
