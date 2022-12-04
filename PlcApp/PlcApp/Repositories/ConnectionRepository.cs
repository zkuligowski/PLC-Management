// Copyright Zbigniew Kuligowski. All Rights Reserved.

namespace PlcApp.Repositories
{
    using System;
    using S7.Net;
    using PlcApp.Models;
    using System.Net;

    public class ConnectionRepository : RepositoryBase, IConnectionRepository
    {
        private Plc? plc;

        public bool Connect(string ipAddress)
        {
            this.plc = new Plc(CpuType.S71200, ipAddress, 0, 1);
            this.plc.Open();

            if (this.plc.IsConnected)
            {
                return true;
            }

            return false;
        }

        public bool Disconnect(string ipAddress)
        {
            this.plc.Close();

            if (this.plc.IsConnected)
            {
                return true;
            }

            return false;
        }
    }
}
