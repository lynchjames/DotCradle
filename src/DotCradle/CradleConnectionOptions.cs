using System;

namespace DotCradle
{
    public class CradleConnectionOptions
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public bool Secure { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public static CradleConnectionOptions Localhost { get { return new CradleConnectionOptions {Host = "127.0.0.1", Port = 5984, Secure = false}; } }
    }
}