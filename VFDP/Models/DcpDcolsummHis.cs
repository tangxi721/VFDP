using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpDcolsummHis
    {
        public DateTime? CrtTm { get; set; }
        public decimal DcolDataId { get; set; }
        public string ServerIp { get; set; }
        public string ProcessNm { get; set; }
        public string EqpId { get; set; }
        public string DcolId { get; set; }
        public decimal? ErrCnt { get; set; }
        public decimal? TotProcTm { get; set; }
    }
}
