using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpDcoldataInf
    {
        public decimal DcolDataId { get; set; }
        public string DcolId { get; set; }
        public string DcolVer { get; set; }
        public string MatlTyp { get; set; }
        public string MatlNm { get; set; }
        public string FacId { get; set; }
        public string ProdId { get; set; }
        public string ProdVer { get; set; }
        public string FlowId { get; set; }
        public string FlowVer { get; set; }
        public string OperId { get; set; }
        public string OperVer { get; set; }
        public string EqpId { get; set; }
        public string EqpRecipeId { get; set; }
        public DateTime? CrtTm { get; set; }
        public string CrtUserId { get; set; }
        public string CrtDesc { get; set; }
        public string BatchZoneCd { get; set; }
        public string SampLotId { get; set; }
        public string MainEqpId { get; set; }
        public string MainFlowId { get; set; }
        public string MainOperId { get; set; }
        public string MainEventTm { get; set; }
        public string OutTyp { get; set; }
        public string LotId { get; set; }
        public string MsgTid { get; set; }
        public string DcolTyp { get; set; }
        public string MesSendSkip { get; set; }
    }
}
