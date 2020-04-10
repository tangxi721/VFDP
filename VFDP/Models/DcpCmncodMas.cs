using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpCmncodMas
    {
        public string CdGrp { get; set; }
        public string CdNm { get; set; }
        public string CdVal { get; set; }
        public decimal? DispOrder { get; set; }
        public string UseYn { get; set; }
        public string CtnDesc { get; set; }
        public string CrtUserId { get; set; }
        public DateTime? CrtTm { get; set; }
        public string ChgUserId { get; set; }
        public DateTime? ChgTm { get; set; }
    }
}
