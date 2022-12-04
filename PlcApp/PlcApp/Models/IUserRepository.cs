// Copyright Zbigniew Kuligowski. All Rights Reserved.

namespace PlcApp.Models
{
    using System.Collections.Generic;
    using System.Net;

    public interface IUserRepository
    {
        bool AuthenticateUser(NetworkCredential credential);

        void Add(UserModel user);

        void Edit(UserModel user);

        void Remove(UserModel user);

        UserModel GetById(int id);

        UserModel GetByUsername(string username);

        IEnumerable<UserModel> GetByAll();
    }
}
