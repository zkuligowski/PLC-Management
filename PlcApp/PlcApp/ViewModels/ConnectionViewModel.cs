// Copyright Zbigniew Kuligowski. All Rights Reserved.

namespace PlcApp.ViewModels
{
    using PlcApp.Models;
    using PlcApp.Repositories;
    using System.Windows.Input;
    using System;

    public class ConnectionViewModel : ViewModelBase
    {
        //Fields
        private ConnectionAccountModel currentConnectionAccount;
        private string ipAddress;
        private bool isConnected;
        private string connectionStatus;

        private IConnectionRepository connectionRepository;

        // Properties
        public ConnectionAccountModel CurrentConnectionAccount
        {
            get
            {
                return this.currentConnectionAccount;
            }

            set
            {
                this.currentConnectionAccount = value;
                this.OnPropertyChanged(nameof(this.CurrentConnectionAccount));
            }
        }

        public string IpAddress
        {
            get
            {
                return this.ipAddress;
            }

            set
            {
                this.ipAddress = value;
                this.OnPropertyChanged(nameof(this.IpAddress));
            }
        }

        public bool IsConnected
        {
            get
            {
                return this.isConnected;
            }

            set
            {
                this.isConnected = value;
                this.OnPropertyChanged(nameof(this.IsConnected));
            }
        }

        public string ConnectionStatus
        {
            get
            {
                return this.connectionStatus;
            }

            set
            {
                this.connectionStatus = value;
                this.OnPropertyChanged(nameof(this.ConnectionStatus));
            }
        }

        // -> Commands
        public ICommand ConnectionCommand { get; }

        public ICommand DisconnectionCommand { get; }

        // Constructor
        public ConnectionViewModel()
        {
            this.connectionRepository = new ConnectionRepository();

            this.CurrentConnectionAccount = new ConnectionAccountModel();

            this.ConnectionCommand = new ViewModelCommand(this.ExecuteConnectionCommand);

            this.DisconnectionCommand = new ViewModelCommand(this.ExecuteDisconnectionCommand);

            this.LoadCurrentConnectionData();
        }

        private void LoadCurrentConnectionData()
        {
            if (this.IsConnected)
            {
                this.ConnectionStatus = "Connected to: " + this.IpAddress;
            }
            else
            {
                this.ConnectionStatus = "Not Connected!";
            }
        }

        private void ExecuteDisconnectionCommand(object obj)
        {
            this.IsConnected = this.connectionRepository.Disconnect(this.IpAddress);
            this.LoadCurrentConnectionData();
        }

        private void ExecuteConnectionCommand(object obj)
        {
            this.IsConnected = this.connectionRepository.Connect(this.IpAddress);
            this.LoadCurrentConnectionData();
        }
    }
}
