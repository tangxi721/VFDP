using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class MesFlowMasMv
    {
        public string FacId { get; set; }
        public string FlowId { get; set; }
        public string FlowVer { get; set; }
        public string CtnDesc { get; set; }
        public string ChkStatCd { get; set; }
        public string ActiveStatCd { get; set; }
        public DateTime? CrtTm { get; set; }
        public string CrtUserId { get; set; }
        public DateTime? ChkoutTm { get; set; }
        public string ChkoutUserId { get; set; }
        public string FlowTyp { get; set; }
        public string FlowCatgCd { get; set; }
        public string NpwTyp { get; set; }
        public DateTime? ChgTm { get; set; }
        public string ChgUserId { get; set; }
        public string MainLotCd { get; set; }
        public string MainProdId { get; set; }
        public string ReturnFlowId { get; set; }
        public string ReturnOperId { get; set; }
        public string DervProdId { get; set; }
        public string ProdGrpNm { get; set; }
        public string BasePlanId { get; set; }
        public string PlanOwnerId { get; set; }
        public string BasePlanYn { get; set; }
        public string EmcEqpId { get; set; }
        public string NpwReturnOperId { get; set; }
        public string CuBasePlanYn { get; set; }
        public string CuLotYn { get; set; }
        public string MtjBasePlanYn { get; set; }
        public string MtjLotYn { get; set; }
        public string PlanId { get; set; }
        public string PlanCrtYn { get; set; }
        public string RefFlowId { get; set; }
        public string SubActiveStatCd { get; set; }
        public string EventUseTyp { get; set; }
        public string EqpGrpAbbrNm { get; set; }
        public string BuildingId { get; set; }
        public string MetalTyp { get; set; }
        public string RecipeId { get; set; }
        public string MetrTyp { get; set; }
        public string RwkTyp { get; set; }
        public string RwkAreaId { get; set; }
        public string SubOperId { get; set; }
        public string MainOperId { get; set; }
        public string TechNm { get; set; }
        public string WorkTyp { get; set; }
    }
}
