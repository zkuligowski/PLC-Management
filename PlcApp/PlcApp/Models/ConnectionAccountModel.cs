// Copyright Zbigniew Kuligowski. All Rights Reserved.

namespace PlcApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ConnectionAccountModel
    {
        public string? IpAddress { get; set; }

        public bool? IsConnected { get; set; }

        public string? PlcType { get; set; }

        public int? Rack { get; set; }

        public int? Slot { get; set; }

        public string? DisplayConnectionStatus { get; set; }
    }
}
