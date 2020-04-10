using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpCommonSpecMas
    {
        public string OperId { get; set; }
        public string CtnDesc { get; set; }
        public string DcolId { get; set; }
        public DateTime? CrtTm { get; set; }
        public string CrtUserId { get; set; }
        public DateTime? ChgTm { get; set; }
        public string ChgUserId { get; set; }
    }
}
