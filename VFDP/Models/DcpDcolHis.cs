using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpDcolHis
    {
        public string DcolId { get; set; }
        public string DcolVer { get; set; }
        public string Timekey { get; set; }
        public DateTime? EventTm { get; set; }
        public string EventCd { get; set; }
        public string MatlTyp { get; set; }
        public string SampMatlTyp { get; set; }
        public decimal? SampCnt { get; set; }
        public string EventUserId { get; set; }
        public string EventDesc { get; set; }
        public string DcolTyp { get; set; }
        public string AutoChgYn { get; set; }
        public string AutoParaChgYn { get; set; }
    }
}
