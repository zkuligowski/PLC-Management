﻿// Copyright Zbigniew Kuligowski. All Rights Reserved.

namespace PlcApp.Classes
{
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using Dapper;

    public class DataAccess
    {
        public void AddNewUser(string firstName, string surname, string email, string birthDate, string mobileNumber, string username, string password, string rightslevel)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("UsersDB")))
            {
                Person newUser = new Person
                {
                    FirstName = firstName,
                    Surname = surname,
                    Email = email,
                    BirthDate = birthDate,
                    MobileNumber = mobileNumber,
                    UserName = username,
                    Password = password,
                    RightsLevel = rightslevel,
                };
                List<Person> users = new List<Person>();
                users.Add(newUser);

                connection.Execute("dbo.insertUser @FirstName, @Surname, @Email, @BirthDate, @MobileNumber, @Username, @Password, @RightsLevel", users);
            }
        }

        public List<Person> GetUserFromDB(string username, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("UsersDB")))
            {
                var output = connection.Query<Person>(
                    "dbo.GetByUsernameAndPassword @UserName, @Email, @Password",
                    new { Username = username, Email = username, Password = password }).ToList();
                return output;
            }
        }
    }
}
