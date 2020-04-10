using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpTpfomodelDef
    {
        public string FacId { get; set; }
        public string ProdId { get; set; }
        public string ProdVer { get; set; }
        public string FlowId { get; set; }
        public string FlowVer { get; set; }
        public string OperId { get; set; }
        public string OperVer { get; set; }
        public string DcolId { get; set; }
        public string DcolVer { get; set; }
        public string MainOperId { get; set; }
        public string EqpGrpId { get; set; }
        public string EqpRecipeId { get; set; }
        public string WfLevelR2rYn { get; set; }
        public decimal? IdleToleranceTime { get; set; }
        public decimal? LotBatchSize { get; set; }
        public string LotCd { get; set; }
        public string ProduceTyp { get; set; }
        public string RwkFlowId { get; set; }
        public string RwkOperId { get; set; }
        public string RwkLimitCnt { get; set; }
        public DateTime? CrtTm { get; set; }
        public string CrtUserId { get; set; }
        public DateTime? ChgTm { get; set; }
        public string ChgUserId { get; set; }
    }
}
