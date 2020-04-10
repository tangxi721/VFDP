using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpDcolsiteInf
    {
        public string DcsiteId { get; set; }
        public string CtnDesc { get; set; }
        public string RelDcsiteNm { get; set; }
        public decimal? MaxDcsiteCnt { get; set; }
        public decimal? DcsiteCnt { get; set; }
        public decimal? DcsitePositionNo { get; set; }
        public decimal? DcsiteSeq { get; set; }
        public string DcsiteTyp { get; set; }
    }
}
