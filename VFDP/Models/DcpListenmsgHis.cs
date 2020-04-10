using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpListenmsgHis
    {
        public DateTime CrtTm { get; set; }
        public string EqpId { get; set; }
        public string AliasNm { get; set; }
        public string Tid { get; set; }
        public string Msg { get; set; }
        public decimal DcolDataId { get; set; }
        public string ServerIp { get; set; }
        public string ProcNm { get; set; }
    }
}
