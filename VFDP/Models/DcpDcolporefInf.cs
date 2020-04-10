using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpDcolporefInf
    {
        public string FacId { get; set; }
        public string ProdId { get; set; }
        public string FlowId { get; set; }
        public string OperId { get; set; }
        public string PrePostItemNm { get; set; }
        public string PostItemNm { get; set; }
        public string CalcFmtTyp { get; set; }
        public string FirstCaloperLocTyp { get; set; }
        public string PreProdId { get; set; }
        public string PreFlowId { get; set; }
        public string PreOperId { get; set; }
        public string PreItemNm { get; set; }
        public DateTime? CrtTm { get; set; }
        public string CrtUserId { get; set; }
        public DateTime? ChgTm { get; set; }
        public string ChgUserId { get; set; }
        public string DcsiteId { get; set; }
        public string PfoMstTyp { get; set; }
        public string CalcFmtTyp2nd { get; set; }
    }
}
