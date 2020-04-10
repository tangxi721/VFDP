using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class MesWfMasMv
    {
        public string WfId { get; set; }
        public string ProduceTyp { get; set; }
        public string ProdId { get; set; }
        public string ProdVer { get; set; }
        public string ProdId2 { get; set; }
        public string ProdVer2 { get; set; }
        public string MatlLocCd { get; set; }
        public string LotBatchId { get; set; }
        public string TransGrpId { get; set; }
        public string ProdReqId { get; set; }
        public string OrgWfId { get; set; }
        public string SrcWfId { get; set; }
        public string GoalWfId { get; set; }
        public string LotId { get; set; }
        public string CarrierId { get; set; }
        public decimal? PositionVal { get; set; }
        public string ProdTyp { get; set; }
        public string SubProdTyp { get; set; }
        public decimal? SubProdUnitQty1 { get; set; }
        public decimal? SubProdUnitQty2 { get; set; }
        public decimal? CrtSubProdQty { get; set; }
        public decimal? CrtSubProdQty1 { get; set; }
        public decimal? CrtSubProdQty2 { get; set; }
        public decimal? SubProdQty { get; set; }
        public decimal? SubProdQty1 { get; set; }
        public decimal? SubProdQty2 { get; set; }
        public string ProdGradeCd { get; set; }
        public string SubProdGradeCd1 { get; set; }
        public string SubProdGradeCd2 { get; set; }
        public DateTime? DueTm { get; set; }
        public decimal? Priority { get; set; }
        public string FacId { get; set; }
        public string TgtFacId { get; set; }
        public string AreaId { get; set; }
        public string SerialNo { get; set; }
        public string ProdStatCd { get; set; }
        public string MesProcStatCd { get; set; }
        public string ProdHoldStatCd { get; set; }
        public string LastEventCd { get; set; }
        public string LastEventTimekey { get; set; }
        public DateTime? LastEventTm { get; set; }
        public string LastEventUserId { get; set; }
        public string LastEventDesc { get; set; }
        public string LastEventTyp { get; set; }
        public DateTime? CrtTm { get; set; }
        public string CrtUserId { get; set; }
        public DateTime? InProduceTm { get; set; }
        public string InProduceUserId { get; set; }
        public DateTime? LastPrcsTm { get; set; }
        public string LastPrcsUserId { get; set; }
        public DateTime? LastIdleTm { get; set; }
        public string LastIdleUserId { get; set; }
        public string ReasonCatgCd { get; set; }
        public string ReasonCd { get; set; }
        public string FlowId { get; set; }
        public string FlowVer { get; set; }
        public string OperId { get; set; }
        public string OperVer { get; set; }
        public string NodeStackVal { get; set; }
        public string EqpId { get; set; }
        public string EqpRecipeId { get; set; }
        public string RwkStatCd { get; set; }
        public decimal? RwkCnt { get; set; }
        public string RwkNodeId { get; set; }
        public string IngotId1 { get; set; }
        public string ObjId { get; set; }
        public string MonJobId { get; set; }
        public string MonOperId { get; set; }
        public string SrcLotId { get; set; }
        public string SrcCarrierId { get; set; }
        public string SrcSlotNo { get; set; }
        public decimal? MonRecycNumcnt { get; set; }
        public decimal? MonUseCnt { get; set; }
        public decimal? MonUseLimitVal { get; set; }
        public string MonStatTyp { get; set; }
        public string TransferTm { get; set; }
        public string MainLotId { get; set; }
        public string ResvFieldVal1 { get; set; }
        public string ResvFieldVal2 { get; set; }
        public string ResvFieldVal3 { get; set; }
        public string ResvFieldVal4 { get; set; }
        public string ResvFieldVal5 { get; set; }
        public decimal? NpwTotUseCnt { get; set; }
        public decimal? TotUseLastNpwVal { get; set; }
        public string SpecFlag { get; set; }
        public string ChgCondition { get; set; }
        public string ChkItemCd { get; set; }
        public string FrFabId { get; set; }
        public string SrcFlag { get; set; }
    }
}
