using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpInterfaceHis
    {
        public DateTime CrtTm { get; set; }
        public string LotId { get; set; }
        public string EqpId { get; set; }
        public string AliasNm { get; set; }
        public string SendMsg { get; set; }
        public string SendYn { get; set; }
        public decimal DcolDataId { get; set; }
        public string ServerIp { get; set; }
        public string ProcNm { get; set; }
        public string SendTyp { get; set; }
        public string CrtUserId { get; set; }
    }
}
