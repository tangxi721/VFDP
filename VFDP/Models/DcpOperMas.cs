using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpOperMas
    {
        public string FabId { get; set; }
        public string OperId { get; set; }
        public string CtnDesc { get; set; }
        public string ChkStatCd { get; set; }
        public string ActiveStatCd { get; set; }
        public string MidOperTyp { get; set; }
        public string DetOperTyp { get; set; }
    }
}
