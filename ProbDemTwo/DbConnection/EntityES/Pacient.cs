using System;
using System.Collections.Generic;

namespace ProbDemTwo.DbConnection.EntityES
{
    public partial class Pacient
    {
        public int PacientId { get; set; }
        public string PacientFio { get; set; } = null!;
        public string PacientFam { get; set; } = null!;
        public string PacientName { get; set; } = null!;
        public string PacientOtch { get; set; } = null!;
        public long PacientPhone { get; set; }
        public long PacientPolis { get; set; }
        public DateOnly PacientDateRojd { get; set; }
        public string PacientMaiil { get; set; } = null!;
    }
}
