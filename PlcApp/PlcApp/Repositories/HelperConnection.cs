// Copyright Zbigniew Kuligowski. All Rights Reserved.

namespace PlcApp.Classes
{
    using System.Configuration;

    public static class HelperConnection
    {
        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
