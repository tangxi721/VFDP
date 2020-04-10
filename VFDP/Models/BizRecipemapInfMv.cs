using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class BizRecipemapInfMv
    {
        public string PPRelId { get; set; }
        public string FacId { get; set; }
        public string ProdId { get; set; }
        public string ProdVer { get; set; }
        public string FlowId { get; set; }
        public string FlowVer { get; set; }
        public string OperId { get; set; }
        public string OperVer { get; set; }
        public string EqpId { get; set; }
        public string EqpModelCd { get; set; }
        public string RecipeId { get; set; }
        public string CtnDesc { get; set; }
        public string FurnaceMonYn { get; set; }
        public decimal? Priority { get; set; }
        public string PrimaryYn { get; set; }
        public string RawChambCondVal { get; set; }
        public string LogicalChambCondCtn { get; set; }
        public string StatCd { get; set; }
        public DateTime? CrtTm { get; set; }
        public string CrtUserId { get; set; }
        public DateTime? ChgTm { get; set; }
        public string ChgUserId { get; set; }
        public string MeasSlotNm { get; set; }
        public string ProcTm { get; set; }
        public string ProcTmIntval { get; set; }
        public string ProcIntvalAlarmId { get; set; }
        public string DepThk { get; set; }
        public string DepThkRsltVal { get; set; }
        public string SubTotCnt { get; set; }
        public string TotCnt { get; set; }
        public string TotThk { get; set; }
        public string ApplyLotIdPattnVal { get; set; }
        public decimal? RecipeIdleDcnt { get; set; }
        public decimal? LotCnt { get; set; }
        public decimal? UseLotCnt { get; set; }
        public decimal? Dcnt { get; set; }
        public DateTime? LastUseTm { get; set; }
        public string SopFirstRecipeYn { get; set; }
        public string SubRecipeIdUseYn { get; set; }
        public string SubRecipeId { get; set; }
        public string SlotRecipeIdUseYn { get; set; }
        public string ParaInvalidYn { get; set; }
        public string PhotoDedicRecipeYn { get; set; }
        public string PhotoDedicRecipeId { get; set; }
        public string EnablePortNo { get; set; }
        public decimal? SampSeq { get; set; }
        public string EqpTyp { get; set; }
        public string IncrTm { get; set; }
        public string TrblTyp { get; set; }
        public string ResvAttrVal1 { get; set; }
        public string ResvAttrVal2 { get; set; }
        public string ResvAttrVal3 { get; set; }
        public string ResvAttrVal4 { get; set; }
        public string ResvAttrVal5 { get; set; }
        public string ResvAttrVal6 { get; set; }
        public string ResvAttrVal7 { get; set; }
        public string ResvAttrVal8 { get; set; }
        public string ResvAttrVal9 { get; set; }
        public string ResvAttrVal10 { get; set; }
        public decimal? ChemicalUpperLimit { get; set; }
        public decimal? ChemicalLowerLimit { get; set; }
        public decimal? LifecountUpperLimit { get; set; }
        public decimal? LifecountLowerLimit { get; set; }
        public string PrimaryYnDelaylifecount { get; set; }
        public string PrimaryYnDelaychemical { get; set; }
        public string UpperBatchCnt { get; set; }
        public string LowerBatchCnt { get; set; }
        public decimal? QtimeUlVal { get; set; }
        public decimal? QtimeLlVla { get; set; }
        public string DelayQtimePrimaryYn { get; set; }
    }
}
