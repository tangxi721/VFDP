using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpSyslogHis
    {
        public string LogLevel { get; set; }
        public string HostIpAddr { get; set; }
        public string HostNm { get; set; }
        public DateTime CrtTm { get; set; }
        public string SvcNm { get; set; }
        public string ProcId { get; set; }
        public string ClassNm { get; set; }
        public string MethodNm { get; set; }
        public string EqpId { get; set; }
        public string LotId { get; set; }
        public string LogMsgCtn { get; set; }
        public string ExptCauseCtn { get; set; }
        public decimal? DcolDataId { get; set; }
        public string MsgTid { get; set; }
        public string Cmt { get; set; }
    }
}
