using System;
using System.Collections;

namespace csharp
{
    public class DataClass
    {
        private string username;
        private string password;
        private int balance;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Balance { get => balance; set => balance = value; }
    }
}