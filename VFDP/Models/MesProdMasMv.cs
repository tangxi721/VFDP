using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class MesProdMasMv
    {
        public string FacId { get; set; }
        public string ProdId { get; set; }
        public string ProdVer { get; set; }
        public string CtnDesc { get; set; }
        public string ChkStatCd { get; set; }
        public string ActiveStatCd { get; set; }
        public DateTime? CrtTm { get; set; }
        public string CrtUserId { get; set; }
        public DateTime? ChkoutTm { get; set; }
        public string ChkoutUserId { get; set; }
        public string ProduceTyp { get; set; }
        public string ProdTyp { get; set; }
        public decimal? WfQty { get; set; }
        public string SubProdTyp { get; set; }
        public decimal? SubProdUnitQty1 { get; set; }
        public decimal? SubProdUnitQty2 { get; set; }
        public string FlowId { get; set; }
        public string FlowVer { get; set; }
        public double? EstCycleTime { get; set; }
        public string MultiProdTyp { get; set; }
        public string ProdId2 { get; set; }
        public string ProdVer2 { get; set; }
        public string ObjId { get; set; }
        public string FamilyCd { get; set; }
        public string TechNm { get; set; }
        public string DenTyp { get; set; }
        public string Typ1 { get; set; }
        public string Typ2 { get; set; }
        public string GenTyp { get; set; }
        public string OrganizVal { get; set; }
        public string MainCd { get; set; }
        public decimal? TotOperCnt { get; set; }
        public decimal? MainOperId { get; set; }
        public decimal? ReticleOperCnt { get; set; }
        public string LotCd { get; set; }
        public string RecycFlowId { get; set; }
        public double? RecycTimeLimitVal { get; set; }
        public DateTime? ChgTm { get; set; }
        public string ChgUserId { get; set; }
        public decimal? MonUseLimitVal { get; set; }
        public string ShipYn { get; set; }
        public string ResvFieldVal1 { get; set; }
        public string ResvFieldVal2 { get; set; }
        public string ResvFieldVal3 { get; set; }
        public string ResvFieldVal4 { get; set; }
        public string ResvFieldVal5 { get; set; }
        public string ReturnProdId { get; set; }
        public string ReturnFlowId { get; set; }
        public string ReturnOperId { get; set; }
        public string CrtProdYn { get; set; }
        public string OperOptTyp { get; set; }
        public string SdTyp { get; set; }
        public string FdTyp { get; set; }
        public string FrFabId { get; set; }
        public string PrbTyp { get; set; }
        public string ProdStatCd { get; set; }
        public string GradeTyp { get; set; }
        public string ToFabId { get; set; }
        public string MainProdId { get; set; }
        public string BasePlanId { get; set; }
        public string PlanYn { get; set; }
        public string MoveProdId { get; set; }
        public decimal? WipCnt { get; set; }
        public string DeptNm { get; set; }
        public string PlanCatgTyp { get; set; }
        public string ProjectNm { get; set; }
        public string EqpGrpAbbrNm { get; set; }
        public string NpwTyp { get; set; }
        public string WorkTyp { get; set; }
    }
}
