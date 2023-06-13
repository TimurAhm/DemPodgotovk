using ProbDemTwo.DbConnection;
using ProbDemTwo.DbConnection.EntityES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbDemTwo.SecurityY
{
    public class AuthClassPacient
    {
        public static Pacient pacient;
        public static bool Autent(string login, string password)
        {
            pacient = EfModel.Init().Pacients.FirstOrDefault(r => r.PacientFam == login && Convert.ToString(r.PacientPolis) == password);
            return pacient != null;
        }
    }
}
