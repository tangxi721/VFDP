using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpWfinterlockHis
    {
        public decimal Rawid { get; set; }
        public string EqpId { get; set; }
        public string LotId { get; set; }
        public string EventNm { get; set; }
        public decimal? InWfCnt { get; set; }
        public string IntlockStatVal { get; set; }
        public DateTime? CrtTm { get; set; }
        public decimal? HoldCnt { get; set; }
        public decimal? ReleaseCnt { get; set; }
        public decimal? MaxCnt { get; set; }
    }
}
