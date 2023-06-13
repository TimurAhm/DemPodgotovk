using System;
using System.Collections.Generic;
using System.Linq;

namespace ProbDemTwo.DbConnection.EntityES
{
    public partial class Vrachi
    {
        public int VrachiId { get; set; }
        public string VrachiFam { get; set; } = null!;
        public string VrachiName { get; set; } = null!;
        public string VrachiOtch { get; set; } = null!;
        public string VrachiDoljnost { get; set; } = null!;
        public string? VrachiSmena { get; set; }
        public string? VrachiVremya { get; set; }
        public string VrachiTipPos { get; set; } = null!;
        public string VrachiStatus { get; set; } = null!;
        public byte[]? VrachiPhoto { get; set; }

        public string NameFFFFFF
        {
            get 
            {
                string asfg = VrachiName.First() + ". " + VrachiOtch.First() + ".";
                return asfg;
            }
        }
    }
}
