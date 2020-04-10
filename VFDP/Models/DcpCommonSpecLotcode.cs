using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpCommonSpecLotcode
    {
        public string OperId { get; set; }
        public string LotCd { get; set; }
        public string CtnDesc { get; set; }
        public string DcolId { get; set; }
        public DateTime? CrtTm { get; set; }
        public string CrtUserId { get; set; }
    }
}
