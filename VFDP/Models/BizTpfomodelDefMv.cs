using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class BizTpfomodelDefMv
    {
        public string FacId { get; set; }
        public string ProdId { get; set; }
        public string ProdVer { get; set; }
        public string FlowId { get; set; }
        public string FlowVer { get; set; }
        public string OperId { get; set; }
        public string OperVer { get; set; }
        public string CondId { get; set; }
        public string EnableTyp { get; set; }
        public string DcolId { get; set; }
        public string DcolVer { get; set; }
        public string FurnaceMonYn { get; set; }
        public string EqpGrpId { get; set; }
        public string NpwReturnFlowId { get; set; }
        public string NpwReturnOperId { get; set; }
        public string ObjBehaviorCd { get; set; }
        public string RwkFlowId { get; set; }
        public string RwkOperId { get; set; }
        public string RwkLimitCnt { get; set; }
        public string ReturnFlowId { get; set; }
        public string ReturnOperId { get; set; }
        public string CrtcalLayerYn { get; set; }
        public string OperatCrtcalLayerVal { get; set; }
        public string EqpRecipeId { get; set; }
        public string FlowDesc { get; set; }
        public string CapaCd { get; set; }
        public string DcolFormulaCtn { get; set; }
        public string DcolActCd { get; set; }
        public string AutoRenTyp { get; set; }
        public string AutoRenSuffNm { get; set; }
        public string AutoRenEqpId { get; set; }
        public string AutoRenObjTyp { get; set; }
        public string AutoRenObjNm { get; set; }
        public string FurnaceLoadTyp { get; set; }
        public string WetEtchR2rYn { get; set; }
        public string WfLevelR2rYn { get; set; }
        public decimal? IdleToleranceTime { get; set; }
        public DateTime? ChgTm { get; set; }
        public string ChgUserId { get; set; }
        public decimal? LotBatchSize { get; set; }
        public string PfoStkId { get; set; }
        public string FurnaceSortTyp { get; set; }
    }
}
