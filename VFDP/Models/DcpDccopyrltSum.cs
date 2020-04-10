using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpDccopyrltSum
    {
        public string Timekey { get; set; }
        public string FacId { get; set; }
        public string LotCd { get; set; }
        public string ProdId { get; set; }
        public string FlowId { get; set; }
        public string OperId { get; set; }
        public string DcolId { get; set; }
        public string DcolVer { get; set; }
        public string CopyRslt { get; set; }
        public string SkipCnt { get; set; }
        public string OkCnt { get; set; }
        public string NgCnt { get; set; }
        public string RollbackCnt { get; set; }
    }
}
