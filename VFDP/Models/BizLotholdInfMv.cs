using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class BizLotholdInfMv
    {
        public string LotId { get; set; }
        public string Timekey { get; set; }
        public string ProdId { get; set; }
        public string FlowId { get; set; }
        public string OperId { get; set; }
        public string HoldCd { get; set; }
        public string HoldEngrUserId { get; set; }
        public string FacId { get; set; }
        public DateTime? HoldTm { get; set; }
        public string HoldOpratorUserId { get; set; }
        public string FindFlowId { get; set; }
        public string FindOperId { get; set; }
        public string MainEqpId { get; set; }
        public string HoldDesc { get; set; }
        public string ReleaseYn { get; set; }
        public DateTime? ReleaseTm { get; set; }
        public string ReleaseCd { get; set; }
        public string ReleaseOpratorUserId { get; set; }
        public string ReleaseEngrUserId { get; set; }
        public string ReasonFlowId { get; set; }
        public string ReasonOperId { get; set; }
        public string ReasonEqpId { get; set; }
        public string ReleaseDesc1 { get; set; }
        public string ReleaseDesc2 { get; set; }
        public string ReleaseDesc3 { get; set; }
        public decimal? InfoDiscardQty { get; set; }
        public string InfoDiscardWfId { get; set; }
        public decimal? InfoRwkQty { get; set; }
        public string InfoRwkWfId { get; set; }
        public string InfoRsltVal { get; set; }
        public string InfoGradeCd { get; set; }
        public string TrblAlarmYn { get; set; }
        public string MoveOutTyp { get; set; }
        public string CarrierId { get; set; }
        public string ObjId { get; set; }
        public string DelYn { get; set; }
        public string ProduceTyp { get; set; }
        public string OwnerCd { get; set; }
        public decimal? WfQty { get; set; }
        public string FrFabId { get; set; }
        public string ReasonAreaId { get; set; }
        public string FindAreaId { get; set; }
    }
}
