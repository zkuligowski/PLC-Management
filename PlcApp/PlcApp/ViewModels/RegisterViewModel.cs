using PlcApp.Models;
using PlcApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PlcApp.ViewModels
{
    public class RegisterViewModel : ViewModelBase
    {
        // Fields
        private string userName;
        private SecureString password;
        private string email;
        private string birthDate;
        private string mobileNumber;
        private SecureString rePassword;
        private string rightsLevel;
        private string firstName;
        private string surname;

        private IUserRepository userRepository;
        private UserModel userModel;

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

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                this.firstName = value;
                this.OnPropertyChanged(nameof(this.FirstName));
            }
        }

        public string Surname
        {
            get
            {
                return this.surname;
            }

            set
            {
                this.surname = value;
                this.OnPropertyChanged(nameof(this.Surname));
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                this.email = value;
                this.OnPropertyChanged(nameof(this.Email));
            }
        }

        public string BirthDate
        {
            get
            {
                return this.birthDate;
            }

            set
            {
                this.birthDate = value;
                this.OnPropertyChanged(nameof(this.BirthDate));
            }
        }

        public SecureString RePassword
        {
            get
            {
                return this.rePassword;
            }

            set
            {
                this.rePassword = value;
                this.OnPropertyChanged(nameof(this.RePassword));
            }
        }

        public string RightsLevel
        {
            get
            {
                return this.rightsLevel;
            }

            set
            {
                this.rightsLevel = value;
                this.OnPropertyChanged(nameof(this.RightsLevel));
            }
        }

        public string MobileNumber
        {
            get
            {
                return this.mobileNumber;
            }

            set
            {
                this.mobileNumber = value;
                this.OnPropertyChanged(nameof(this.MobileNumber));
            }
        }

        // Commands
        public ICommand RegisterCommand { get; }

        public RegisterViewModel()
        {
            this.userRepository = new UserRepository();
            this.RegisterCommand = new ViewModelCommand(this.ExecuteRegisterCommand, this.CanExecuteRegisterCommand);
        }

        private bool CanExecuteRegisterCommand(object obj)
        {
            return true;
        }

        private void ExecuteRegisterCommand(object obj)
        {
            NetworkCredential networkCredential = new NetworkCredential(this.UserName, this.Password);

            this.userModel = new UserModel(
                this.FirstName,
                this.Surname,
                this.Email,
                this.BirthDate,
                this.MobileNumber,
                networkCredential.UserName,
                networkCredential.Password,
                this.RightsLevel);

            this.userRepository.Add(this.userModel);
        }
    }
}
