using System;
using System.Collections.Generic;

namespace ProbDemTwo.DbConnection.EntityES
{
    public partial class User
    {
        public int UserId { get; set; }
        public string UserFam { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string UserOtch { get; set; } = null!;
        public string UserDoljnost { get; set; } = null!;
        public string UserLogin { get; set; } = null!;
        public string UserPassword { get; set; } = null!;
    }
}
