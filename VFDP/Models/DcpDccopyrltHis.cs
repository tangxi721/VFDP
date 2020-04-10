using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpDccopyrltHis
    {
        public string Timekey { get; set; }
        public string SrcFacId { get; set; }
        public string SrcLotCd { get; set; }
        public string SrcProdId { get; set; }
        public string SrcFlowId { get; set; }
        public string SrcOperId { get; set; }
        public string SrcDcolId { get; set; }
        public string SrcDcolVer { get; set; }
        public string FacId { get; set; }
        public string LotCd { get; set; }
        public string ProdId { get; set; }
        public string FlowId { get; set; }
        public string OperId { get; set; }
        public string DcolId { get; set; }
        public string DcolVer { get; set; }
        public string TableNm { get; set; }
        public string ProcTyp { get; set; }
        public string CopyRslt { get; set; }
        public string RsltDesc { get; set; }
        public string ApplyInf { get; set; }
        public string TranTyp { get; set; }
        public string CrtUserId { get; set; }
        public DateTime? CrtTm { get; set; }
        public string SrcTableNm { get; set; }
    }
}
