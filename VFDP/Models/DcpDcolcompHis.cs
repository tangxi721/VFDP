using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpDcolcompHis
    {
        public DateTime DcpDcolCrtTm { get; set; }
        public decimal DcpDcolDataId { get; set; }
        public decimal EdbDcolDataId { get; set; }
        public decimal EdbRsltCnt { get; set; }
        public decimal DcpRsltCnt { get; set; }
        public decimal OkCnt { get; set; }
        public decimal NgNovalCnt { get; set; }
        public decimal NgNotmatchCnt { get; set; }
        public string DcolId { get; set; }
        public string LotCd { get; set; }
        public string FacId { get; set; }
        public string ProdId { get; set; }
        public string FlowId { get; set; }
        public string OperId { get; set; }
        public string EqpId { get; set; }
        public string LotId { get; set; }
        public string SampMatlId { get; set; }
        public string EdbSampMatlId { get; set; }
        public string EdbFacId { get; set; }
        public string EdbProdId { get; set; }
        public DateTime? CrtTm { get; set; }
        public string CrtUserId { get; set; }
    }
}
