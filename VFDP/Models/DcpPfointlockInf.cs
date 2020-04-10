using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpPfointlockInf
    {
        public string IntlockId { get; set; }
        public string FacId { get; set; }
        public string ProdId { get; set; }
        public string ProdVer { get; set; }
        public string FlowId { get; set; }
        public string FlowVer { get; set; }
        public string OperId { get; set; }
        public string OperVer { get; set; }
        public string IntlockTyp { get; set; }
        public string ChkProdId { get; set; }
        public string ChkFlowId { get; set; }
        public string ChkOperId { get; set; }
        public string LotWfGbnCd { get; set; }
        public string ItemNm { get; set; }
        public string UlVal { get; set; }
        public string LlVal { get; set; }
        public string AndOrTyp { get; set; }
        public string InOutTyp { get; set; }
        public string HoldCd { get; set; }
        public string HoldNm { get; set; }
        public string HoldCtn { get; set; }
        public string CrtUserId { get; set; }
        public DateTime? CrtTm { get; set; }
        public string ChgUserId { get; set; }
        public DateTime? ChgTm { get; set; }
    }
}
