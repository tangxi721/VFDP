using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class BizLotscrapInfMv
    {
        public string LotId { get; set; }
        public string Timekey { get; set; }
        public DateTime? EventTm { get; set; }
        public string ProdId { get; set; }
        public string FlowId { get; set; }
        public string OperId { get; set; }
        public string FacId { get; set; }
        public string DiscardQty { get; set; }
        public string ReasonFlowId { get; set; }
        public string ReasonOperId { get; set; }
        public string ReasonEqpId { get; set; }
        public string EngrUserId { get; set; }
        public string OpratorUserId { get; set; }
        public string ObjId { get; set; }
        public string DiscardCd { get; set; }
        public string WfId { get; set; }
        public string PositionVal { get; set; }
        public string DiscardCarrierId { get; set; }
        public string EventDesc { get; set; }
        public string DelYn { get; set; }
        public string MainLotId { get; set; }
        public string ProduceTyp { get; set; }
        public string OwnerCd { get; set; }
        public string ChargeAreaId { get; set; }
        public string FrFabId { get; set; }
        public string TransDestCd { get; set; }
        public string ResrcFabId { get; set; }
    }
}
