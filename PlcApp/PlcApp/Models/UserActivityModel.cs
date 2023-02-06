// Copyright Zbigniew Kuligowski. All Rights Reserved.

namespace PlcApp.Models
{
    public class UserActivityModel
    {
        public int? ID { get; set; }

        public string? UserName { get; set; }

        public string? UserAction { get; set; }

        public string? UserData { get; set; }
    }
}
