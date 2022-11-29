// Copyright Zbigniew Kuligowski. All Rights Reserved.

namespace PlcApp.Repositories
{
    using Dapper;
    using PlcApp.Classes;
    using PlcApp.Models;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Threading.Tasks;

    public class UserRepository : RepositoryBase, IUserRepository
    {
        public void Add(UserModel user)
        {
            throw new NotImplementedException();
        }

        public bool AuthenticateUser(NetworkCredential credential)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("UsersDB")))
            {
                var output = connection.Query<Person>(
                    "dbo.GetByUsernameAndPassword @UserName, @Email, @Password",
                    new { Username = credential.UserName, Email = "testemail", Password = credential.Password }).ToList();

                return output.Count == 1;
            }
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
            throw new NotImplementedException();
        }

        public void Remove(UserModel user)
        {
            throw new NotImplementedException();
        }
    }
}
