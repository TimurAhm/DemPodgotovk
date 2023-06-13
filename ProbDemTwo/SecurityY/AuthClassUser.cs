using ProbDemTwo.DbConnection.EntityES;
using ProbDemTwo.DbConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbDemTwo.SecurityY
{
    public class AuthClassUser
    {
        public static User user;
        public static bool Autent(string login, string password)
        {
            user = EfModel.Init().Users.FirstOrDefault(r => r.UserLogin== login && r.UserPassword == password);
            return user != null;
        }
    }
}
