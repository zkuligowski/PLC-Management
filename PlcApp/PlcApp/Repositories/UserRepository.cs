// Copyright Zbigniew Kuligowski. All Rights Reserved.

namespace PlcApp.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Net;
    using Dapper;
    using PlcApp.Classes;
    using PlcApp.Models;

    public class UserRepository : RepositoryBase, IUserRepository
    {
        public void Add(UserModel user)
        {
            throw new NotImplementedException();
        }

        public bool AuthenticateUser(NetworkCredential credential)
        {
            using IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("UsersDB"));
            var output = connection.Query<Person>(
                "dbo.GetByUsernameAndPassword @UserName, @Email, @Password",
                new { Username = credential.UserName, Email = credential.UserName, Password = credential.Password }).ToList();

            return output.Count == 1;
        }

        public void Edit(UserModel user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserModel> GetByAll()
        {
            throw new NotImplementedException();
        }

        public UserModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public UserModel GetByUsername(string username)
        {
            UserModel? user = null;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("UsersDB")))
            {
                var output = connection.Query<Person>(
                    "dbo.GetByUsername @UserName",
                    new { Username = username });

                user = new UserModel()
                {
                    ID = 0,
                    FirstName = output.First().FirstName,
                    Surname = output.First().Surname,
                    Email = output.First().Email,
                    BirthDate = output.First().BirthDate,
                    MobileNumber = output.First().MobileNumber,
                    UserName = output.First().FirstName,
                    Password = string.Empty,
                    RightsLevel = output.First().RightsLevel,
                    UpdatedOn = string.Empty,
                };
            }

            return user;
        }

        public void Remove(UserModel user)
        {
            throw new NotImplementedException();
        }
    }
}
