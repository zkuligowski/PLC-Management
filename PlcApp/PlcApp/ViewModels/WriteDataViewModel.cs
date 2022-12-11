// Copyright Zbigniew Kuligowski. All Rights Reserved.

namespace PlcApp.ViewModels
{
    using PlcApp.Models;
    using PlcApp.Properties;
    using PlcApp.Repositories;
    using S7.Net;
    using System.Globalization;
    using System.Windows.Input;

    public class WriteDataViewModel : ViewModelBase
    {
        // Fields
        private bool isConnected;
        private Db1Model db1model;

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
        public ICommand WriteDataCommand { get; }

        // Constructor
        public WriteDataViewModel()
        {
            this.db1model = new Db1Model(
                Settings.Default.Bool,
                Settings.Default.Int,
                Settings.Default.Real,
                Settings.Default.DInt,
                Settings.Default.DWord,
                Settings.Default.Word);

            this.connectionRepository = new ConnectionRepository();

            this.WriteDataCommand = new ViewModelCommand(this.ExecuteWriteDataCommand);
        }

        private void ExecuteWriteDataCommand(object obj)
        {
            this.connectionRepository.Connect(Settings.Default.IpAddress);

            this.connectionRepository.WriteSingleVariables(
                this.Db1Model.Bool1,
                (ushort)this.Db1Model.IntVariable,
                float.Parse(this.Db1Model.RealVariable.ToString(), CultureInfo.InvariantCulture.NumberFormat).ConvertToUInt(),
                this.Db1Model.DIntVariable,
                (uint)this.Db1Model.DWordVariable,
                this.Db1Model.WordVariable);

            Settings.Default.Bool = this.db1model.Bool1;
            Settings.Default.Int = this.db1model.IntVariable;
            Settings.Default.Real = this.db1model.RealVariable;
            Settings.Default.DInt = this.db1model.DIntVariable;
            Settings.Default.DWord = this.db1model.DWordVariable;
            Settings.Default.Word = this.db1model.WordVariable;
        }
    }
}
