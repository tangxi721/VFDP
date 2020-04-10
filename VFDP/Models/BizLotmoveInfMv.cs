using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class BizLotmoveInfMv
    {
        public string LotId { get; set; }
        public string Timekey { get; set; }
        public DateTime? EventTm { get; set; }
        public string MoveTyp { get; set; }
        public string FacId { get; set; }
        public string ProduceTyp { get; set; }
        public string ProdId { get; set; }
        public string FlowId { get; set; }
        public string OperId { get; set; }
        public string MoveFacId { get; set; }
        public string MoveProdId { get; set; }
        public string MoveFlowId { get; set; }
        public string MoveOperId { get; set; }
        public string ObjId { get; set; }
        public decimal? WfQty { get; set; }
        public string HotTyp { get; set; }
        public string CarrierId { get; set; }
        public string CarrierObjId { get; set; }
        public string CarrierCatgCd { get; set; }
        public string OpratorUserId { get; set; }
        public string MoveOperatNm { get; set; }
        public DateTime? MoveEventTm { get; set; }
        public string EventDesc { get; set; }
        public string MoveEventDesc { get; set; }
        public string MoveStatCd { get; set; }
        public string ReturnYn { get; set; }
        public string ReturnFlowId { get; set; }
        public string ReturnOperId { get; set; }
        public string LastEventTimekey { get; set; }
        public string EqpGrpId { get; set; }
        public string EqpId { get; set; }
        public string BakLotYn { get; set; }
        public string DataSendYn { get; set; }
        public string LastEventFacId { get; set; }
        public string DiscardSlotNo { get; set; }
        public string CurrOperId { get; set; }
        public string CurrMesProcStatCd { get; set; }
        public string CurrEqpId { get; set; }
        public string CurrEqpRecipeId { get; set; }
        public string CurrRwkStatCd { get; set; }
        public string CurrWfQty { get; set; }
        public string SendRecipeId { get; set; }
        public string MultiBakTyp { get; set; }
        public string MultiReturnOperId { get; set; }
        public string ProdReqId { get; set; }
        public string MainEqpId { get; set; }
        public string MainFlowId { get; set; }
        public string MainOperId { get; set; }
        public string MainEventTm { get; set; }
        public string SendPlanId { get; set; }
        public string RecvOpratorUserId { get; set; }
        public string ParentLotId { get; set; }
        public string MergeId { get; set; }
        public string ChkOperId { get; set; }
        public string LotHoldDesc { get; set; }
        public string LotHoldStatCd { get; set; }
        public string RecycYn { get; set; }
        public string ChuckId { get; set; }
        public string DedicId { get; set; }
        public string SendMsgId { get; set; }
        public string RetnMsgId { get; set; }
        public DateTime? CrtTm { get; set; }
        public string LastReticleId { get; set; }
        public string ReticleVer { get; set; }
        public string ResvAttrVal1 { get; set; }
        public string ResvAttrVal2 { get; set; }
        public string ResvAttrVal3 { get; set; }
        public string ResvAttrVal4 { get; set; }
        public string ResvAttrVal5 { get; set; }
        public string RecipeDedicOperLval { get; set; }
        public string RecipeDedicEqpLval { get; set; }
        public string RecipeDedicRecipeLval { get; set; }
        public string RecipeDedicStepperLval { get; set; }
        public string ReturnProdId { get; set; }
        public string ReturnCarrierId { get; set; }
        public decimal? ReturnWfQty { get; set; }
        public string ReturnWfId { get; set; }
        public DateTime? ReturnEventTm { get; set; }
        public string ReturnOperatNm { get; set; }
        public string ReturnEventDesc { get; set; }
        public string NonProcLotYn { get; set; }
    }
}
