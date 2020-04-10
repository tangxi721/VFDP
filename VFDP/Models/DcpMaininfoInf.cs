using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpMaininfoInf
    {
        public string DcolId { get; set; }
        public string DcolVer { get; set; }
        public string DcolItemCd { get; set; }
        public string ApplyFlag { get; set; }
        public DateTime? CrtTm { get; set; }
        public string CrtUserId { get; set; }
        public DateTime? ChgTm { get; set; }
        public string ChgUserId { get; set; }
    }
}
