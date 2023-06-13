using System;
using System.Collections.Generic;

namespace ProbDemTwo.DbConnection.EntityES
{
    public partial class Poseschenie
    {
        public int PoseschenieId { get; set; }
        public string PosescheniePacient { get; set; } = null!;
        public string PoseschenieVrachFam { get; set; } = null!;
        public string PoseschenieVrachName { get; set; } = null!;
        public string PoseschenieVrachOtch { get; set; } = null!;
        public DateOnly? PoseschenieDataZapis { get; set; }
        public DateOnly PoseschenieDataPos { get; set; }
        public TimeOnly PoseschenieTimePos { get; set; }
        public string PoseschenieTipPos { get; set; } = null!;
        public string? PoseschenieKritetiyPos { get; set; }
    }
}
