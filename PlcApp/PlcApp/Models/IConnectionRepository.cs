// Copyright Zbigniew Kuligowski. All Rights Reserved.

namespace PlcApp.Models
{
    using PlcApp.Classes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IConnectionRepository
    {
        bool Connect(string ipAddress);

        bool Disconnect(string ipAddress);

        public Db1Model ReadSingleVariables();

        public void WriteSingleVariables(bool bool1, ushort intVariable, uint realVariable, int dIntVariable, uint dWordVariable, ushort wordVariable);
    }
}
