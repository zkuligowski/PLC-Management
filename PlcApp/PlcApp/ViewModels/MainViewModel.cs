// Copyright Zbigniew Kuligowski. All Rights Reserved.

namespace PlcApp.ViewModels
{
    using System;
    using System.Threading;
    using System.Windows.Input;
    using FontAwesome.Sharp;
    using PlcApp.Models;
    using PlcApp.Properties;
    using PlcApp.Repositories;

    public class MainViewModel : ViewModelBase
    {
        //Fields
        private UserAccountModel currentUserAccount;
        private ViewModelBase currentChildView;
        private string caption;
        private IconChar icon;
        private bool writeDataEnabled;
        private bool registerAccountEnabled;

        private IUserRepository userRepository;

        // Properties
        public UserAccountModel CurrentUserAccount
        {
            get
            {
                return this.currentUserAccount;
            }

            set
            {
                this.currentUserAccount = value;
                this.OnPropertyChanged(nameof(this.CurrentUserAccount));
            }
        }

        public ViewModelBase CurrentChildView
        {
            get
             {
                return this.currentChildView;
             }

            set
            {
                this.currentChildView = value;
                this.OnPropertyChanged(nameof(this.CurrentChildView));
            }
        }

        public string Caption
        {
            get
            {
                return this.caption;
            }

            set
            {
                this.caption = value;
                this.OnPropertyChanged(nameof(this.Caption));
            }
        }

        public IconChar Icon
        {
            get
            {
                return this.icon;

            }

            set
            {
                this.icon = value;
                this.OnPropertyChanged(nameof(this.Icon));
            }
        }

        public bool WriteDataEnabled
        {
            get
            {
                return this.writeDataEnabled;

            }

            set
            {
                this.writeDataEnabled = value;
                this.OnPropertyChanged(nameof(this.WriteDataEnabled));
            }
        }

        public bool RegisterAccountEnabled
        {
            get
            {
                return this.registerAccountEnabled;
            }

            set
            {
                this.registerAccountEnabled = value;
                this.OnPropertyChanged(nameof(this.RegisterAccountEnabled));
            }
        }

        // --> Commands
        public ICommand ShowHomeViewCommand { get; }

        public ICommand ShowConnectionViewCommand { get; }

        public ICommand ShowReadDataViewCommand { get; }

        public ICommand ShowWriteDataViewCommand { get; }

        public ICommand ShowRegisterViewCommand { get; }

        public MainViewModel()
        {
            this.userRepository = new UserRepository();
            this.CurrentUserAccount = new UserAccountModel();

            // Initialize commands
            this.ShowHomeViewCommand = new ViewModelCommand(this.ExecuteShowHomeViewCommand);
            this.ShowConnectionViewCommand = new ViewModelCommand(this.ExecuteShowConnectionViewCommand);
            this.ShowReadDataViewCommand = new ViewModelCommand(this.ExecuteShowReadDataViewCommand);
            this.ShowWriteDataViewCommand = new ViewModelCommand(this.ExecuteShowWriteDataViewCommand);
            this.ShowRegisterViewCommand = new ViewModelCommand(this.ExecuteRegisterViewCommand);

            // Default View
            this.ExecuteShowHomeViewCommand(null);

            this.LoadCurrentUserData();
            this.LoadPriviliges();
        }

        private void ExecuteRegisterViewCommand(object obj)
        {
            this.CurrentChildView = new RegisterViewModel();
            this.Caption = "Register new account";
            this.Icon = IconChar.IdCard;
        }

        private void ExecuteShowWriteDataViewCommand(object obj)
        {
            this.CurrentChildView = new WriteDataViewModel();
            this.Caption = "Write Data";
            this.Icon = IconChar.Upload;
        }

        private void ExecuteShowReadDataViewCommand(object obj)
        {
            this.CurrentChildView = new ReadDataViewModel();
            this.Caption = "Read Data";
            this.Icon = IconChar.Download;
        }

        private void ExecuteShowConnectionViewCommand(object obj)
        {
            this.CurrentChildView = new ConnectionViewModel();
            this.Caption = "Connection";
            this.Icon = IconChar.Signal;
        }

        private void ExecuteShowHomeViewCommand(object obj)
        {
            this.CurrentChildView = new HomeViewModel();
            this.Caption = "Home";
            this.Icon = IconChar.Home;
        }

        private void LoadCurrentUserData()
        {
            var user = this.userRepository.GetByUsername(Thread.CurrentPrincipal.Identity.Name);

            if (user != null)
            {
                this.CurrentUserAccount.Username = user.UserName;
                this.CurrentUserAccount.DisplayName = $"Logged as: {user.UserName}";
                this.CurrentUserAccount.ProfilePicture = null;
            }
            else
            {
                this.CurrentUserAccount.DisplayName = "Invalid user, not logged in";
            }
        }

        private void LoadPriviliges()
        {
            if (Settings.Default.Rights.Equals("Admin"))
            {
                this.RegisterAccountEnabled = true;
                this.WriteDataEnabled = true;
            }
            else if (Settings.Default.Rights.Equals("Read-Write"))
            {
                this.WriteDataEnabled = true;
            }
        }
    }
}
