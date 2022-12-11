// Copyright Zbigniew Kuligowski. All Rights Reserved.

using PlcApp.Models;
using PlcApp.Properties;
using System;
using System.Text;

namespace PlcApp.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        // Fields
        private HomeDescriptionModel currentHomeDescription;

        // Properties
        public HomeDescriptionModel CurrentHomeDescription
        {
            get
            {
                return this.currentHomeDescription;
            }

            set
            {
                this.currentHomeDescription = value;
                this.OnPropertyChanged(nameof(this.CurrentHomeDescription));
            }
        }

        public HomeViewModel()
        {
            this.CurrentHomeDescription = new HomeDescriptionModel();

            this.LoadCurrentHomeInfo();
        }

        private void LoadCurrentHomeInfo()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"You are logged with {Settings.Default.Rights} Permissions.\n");

            if (Settings.Default.Rights.Equals("Admin"))
            {
                stringBuilder.AppendLine("You can connect to PLC, Read/Write Data and Register New Account.\n");
            }
            else if (Settings.Default.Rights.Equals("Read-Only"))
            {
                stringBuilder.AppendLine("You can connect to PLC and Read Data.\n");
                stringBuilder.AppendLine("To Write Data use Account with Write Permissions.\n");
                stringBuilder.AppendLine("Only Admin can Register New Account.\n");
            }
            else if (Settings.Default.Rights.Equals("Read-Write"))
            {
                stringBuilder.AppendLine("You can connect to PLC, Read/Write Data.\n");
                stringBuilder.AppendLine("Only Admin can Register New Account.\n");
            }

            this.CurrentHomeDescription.DisplayHomeInfo = stringBuilder.ToString();
        }
    }
}
