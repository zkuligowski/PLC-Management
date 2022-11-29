﻿// Copyright Zbigniew Kuligowski. All Rights Reserved.

namespace PlcApp.Repositories
{
    using System.Data.SqlClient;
    using PlcApp.Classes;

    public abstract class RepositoryBase
    {
        private readonly string connectionString;
        public RepositoryBase()
        {
            this.connectionString = Helper.CnnVal("UsersDB");
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(this.connectionString);
        }
    }
}
