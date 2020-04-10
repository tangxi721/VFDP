using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpDcoldatasampInf
    {
        public decimal DcolDataId { get; set; }
        public string SampMatlId { get; set; }
        public string SampMatlTyp { get; set; }
        public decimal? SampNo { get; set; }
        public DateTime? CrtTm { get; set; }
        public string CrtUserId { get; set; }
        public string CrtDesc { get; set; }
    }
}
