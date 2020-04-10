using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpErrlogHis
    {
        public DateTime CrtTm { get; set; }
        public string LogLevel { get; set; }
        public string Ip { get; set; }
        public string HostNm { get; set; }
        public string ServiceNm { get; set; }
        public string ProcId { get; set; }
        public string ClassNm { get; set; }
        public string MethodNm { get; set; }
        public string EqpId { get; set; }
        public string LotId { get; set; }
        public string LogMsg { get; set; }
        public string LogCause { get; set; }
        public decimal? DcolDataId { get; set; }
        public string MsgTid { get; set; }
        public string Desc { get; set; }
    }
}
