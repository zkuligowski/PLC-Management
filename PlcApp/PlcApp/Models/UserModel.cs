// Copyright Zbigniew Kuligowski. All Rights Reserved.

namespace PlcApp.Models
{
    public class UserModel
    {
        public int? ID { get; set; }

        public string? FirstName { get; set; }

        public string? Surname { get; set; }

        public string? Email { get; set; }

        public string? BirthDate { get; set; }

        public string? MobileNumber { get; set; }

        public string? UserName { get; set; }

        public string? Password { get; set; }

        public string? RightsLevel { get; set; }

        public string? UpdatedOn { get; set; }

        public UserModel(string? firstName, string? surname, string? email, string? birthDate, string? mobileNumber, string? userName, string? password, string? rightsLevel)
        {
            this.FirstName = firstName;
            Surname = surname;
            Email = email;
            BirthDate = birthDate;
            MobileNumber = mobileNumber;
            UserName = userName;
            Password = password;
            RightsLevel = rightsLevel;
        }

        public UserModel()
        {
        }
    }
}
