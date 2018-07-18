using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace mWSEI.Models
{
    public class Token
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string accessToken { get; set; }
        public string errorDescription { get; set; }
        public DateTime expireDate { get; set; }
        public int expiresIn { get; set; }

        public Token() { }
    }
}
