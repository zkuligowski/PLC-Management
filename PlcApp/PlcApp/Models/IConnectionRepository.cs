// Copyright Zbigniew Kuligowski. All Rights Reserved.

namespace PlcApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IConnectionRepository
    {
        bool Connect(string ipAddress);

        bool Disconnect(string ipAddress);
    }
}
