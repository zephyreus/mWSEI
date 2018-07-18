using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace mWSEI.Models
{
    public class User
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public User() { }
        public User(string Login, string Password)
        {
            this.Login = Login;
            this.Password = Password;
        }

        public bool VerifyCredentials()
        {
            if (string.IsNullOrWhiteSpace(Login) || string.IsNullOrWhiteSpace(Password))
                return false;
            else
                return true;
        }
    }
}
