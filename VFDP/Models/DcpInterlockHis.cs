using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpInterlockHis
    {
        public DateTime CrtTm { get; set; }
        public string EqpId { get; set; }
        public string InterlockNm { get; set; }
        public string EventTm { get; set; }
        public string InterlockCause { get; set; }
        public string ReqMsg { get; set; }
        public string RepMsg { get; set; }
        public string AppNm { get; set; }
        public string InterlockCd { get; set; }
    }
}
