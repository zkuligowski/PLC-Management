// Copyright Zbigniew Kuligowski. All Rights Reserved.

namespace PlcApp.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Net;
    using System.Security;
    using System.Threading;
    using Dapper;
    using Microsoft.VisualBasic.ApplicationServices;
    using PlcApp.Classes;
    using PlcApp.Models;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

    public class UserRepository : RepositoryBase, IUserRepository
    {
        public void Add(UserModel user)
        {
            using IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("UsersDB"));

            connection.Execute("dbo.insertUser @FirstName, @Surname, @Email, @BirthDate, @MobileNumber, @Username, @Password, @RightsLevel", user);
        }

        public bool AuthenticateUser(NetworkCredential credential)
        {
            using IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("UsersDB"));
            var output = connection.Query<UserModel>(
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
                    Password = null,
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

        public void ArchiveUserActivity(string userAction, string userData)
        {
            var userName = Thread.CurrentPrincipal.Identity.Name;

            using IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("UsersDB"));

            connection.Query<UserAccountModel>(
                    "dbo.InsertActivityEvent @UserName, @UserAction, @UserData",
                    new { Username = userName, UserAction = userAction, UserData = userData });
        }
    }
}
