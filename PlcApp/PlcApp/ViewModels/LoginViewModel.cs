// Copyright Zbigniew Kuligowski. All Rights Reserved.

namespace PlcApp.ViewModels
{
    using System;
    using System.Net;
    using System.Security;
    using System.Security.Principal;
    using System.Threading;
    using System.Windows.Input;
    using PlcApp.Models;
    using PlcApp.Properties;
    using PlcApp.Repositories;

    public class LoginViewModel : ViewModelBase
    {
        // Fields
        private string userName;
        private SecureString password;
        private string errorMessage;
        private bool isViewVisible = true;
        private UserModel userModel;

        private IUserRepository userRepository;

        // Properties
        public string UserName
        {
            get
            {
                return this.userName;
            }

            set
            {
                this.userName = value;
                this.OnPropertyChanged(nameof(this.UserName));
            }
        }

        public SecureString Password
        {
            get
            {
                return this.password;
            }

            set
            {
                this.password = value;
                this.OnPropertyChanged(nameof(this.Password));
            }
        }

        public string ErrorMessage
        {
            get
            {
                return this.errorMessage;
            }

            set
            {
                this.errorMessage = value;
                this.OnPropertyChanged(nameof(this.ErrorMessage));
            }
        }

        public bool IsViewVisible
        {
            get
            {
                return this.isViewVisible;
            }

            set
            {
                this.isViewVisible = value;
                this.OnPropertyChanged(nameof(this.IsViewVisible));
            }
        }

        // -> Commands
        public ICommand LoginCommand { get; }

        public ICommand RecoverPasswordCommand { get; }

        public ICommand ShowPasswordCommand { get; }

        public ICommand RememberPasswordCommand { get; }

        public ICommand RegisterAccountCommand { get; }

        // Constructor
        public LoginViewModel()
        {
            this.userRepository = new UserRepository();
            this.userModel = new UserModel();
            this.LoginCommand = new ViewModelCommand(this.ExecuteloginCommand, this.CanExecuteLoginCommand);

            // this.RecoverPasswordCommand = new ViewModelCommand(p => this.ExecuteRecoverPassCommand(string.Empty, string.Empty));
        }

        private bool CanExecuteLoginCommand(object obj)
        {
            bool validData;
            if (string.IsNullOrWhiteSpace(this.UserName) || this.UserName.Length < 3 ||
                this.Password == null || this.Password.Length < 3)
            {
                validData = false;
            }
            else
            {
                validData = true;
            }

            return validData;
        }

        private void ExecuteloginCommand(object obj)
        {
            var isValidUser = this.userRepository.AuthenticateUser(
                new NetworkCredential(
                    this.UserName, this.Password));
            if (isValidUser)
            {
                this.userModel = this.userRepository.GetByUsername(this.UserName);
                Settings.Default.Rights = this.userModel.RightsLevel;

                Thread.CurrentPrincipal = new GenericPrincipal(
                    new GenericIdentity(this.UserName), null);
                this.IsViewVisible = false;

                this.userRepository.ArchiveUserActivity("Login", string.Empty);
            }
            else
            {
                this.ErrorMessage = "* Invalid username or password";
            }
        }

        private void ExecuteRecoverPassCommand(string username, string email)
        {
            throw new NotImplementedException();
        }
    }
}
