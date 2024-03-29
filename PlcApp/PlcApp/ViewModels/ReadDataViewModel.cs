﻿// Copyright Zbigniew Kuligowski. All Rights Reserved.

namespace PlcApp.ViewModels
{
    using System;
    using System.Text.Json;
    using System.Threading;
    using System.Windows.Input;
    using PlcApp.Models;
    using PlcApp.Properties;
    using PlcApp.Repositories;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

    public class ReadDataViewModel : ViewModelBase
    {
        // Fields
        private bool isConnected;
        private Db1Model db1model;
        private UserRepository userRepository;

        private IConnectionRepository connectionRepository;

        // Properties
        public Db1Model Db1Model
        {
            get
            {
                return this.db1model;
            }

            set
            {
                this.db1model = value;
                this.OnPropertyChanged(nameof(this.Db1Model));
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

        // -> Commands
        public ICommand ReadDataCommand { get; }

        // Constructor
        public ReadDataViewModel()
        {
            this.db1model = new Db1Model(
                Settings.Default.Bool,
                Settings.Default.Int,
                Settings.Default.Real,
                Settings.Default.DInt,
                Settings.Default.DWord,
                Settings.Default.Word);

            this.connectionRepository = new ConnectionRepository();

            this.ReadDataCommand = new ViewModelCommand(this.ExecuteReadDataCommand, this.CanExecuteReadDataCommand);

            this.userRepository = new UserRepository();
        }

        private bool CanExecuteReadDataCommand(object obj)
        {
            return Settings.Default.IsConnected;
        }

        private void ExecuteReadDataCommand(object obj)
        {
            this.connectionRepository.Connect(Settings.Default.IpAddress);
            this.Db1Model = this.connectionRepository.ReadSingleVariables();
            Settings.Default.Bool = this.db1model.Bool1;
            Settings.Default.Int = this.db1model.IntVariable;
            Settings.Default.Real = this.db1model.RealVariable;
            Settings.Default.DInt = this.db1model.DIntVariable;
            Settings.Default.DWord = this.db1model.DWordVariable;
            Settings.Default.Word = this.db1model.WordVariable;

            string jsonData = JsonSerializer.Serialize(this.db1model);
            this.userRepository.ArchiveUserActivity("Read Data", jsonData);
        }
    }
}
