using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class EventHistory
    {
        public string TimeKey { get; set; }
        public string EquipmentId { get; set; }
        public string EventId { get; set; }
        public string AliasName { get; set; }
        public string ChamberId { get; set; }
        public string LotId { get; set; }
        public string WaferId { get; set; }
        public string LotCode { get; set; }
        public string CarrierId { get; set; }
        public string ProductId { get; set; }
        public string ProcessFlowId { get; set; }
        public string OperationId { get; set; }
        public string RecipeId { get; set; }
        public string ChamberRecipeId { get; set; }
        public int? SlotId { get; set; }
        public int? PortId { get; set; }
        public string ControlJobId { get; set; }
        public string ProcessJobId { get; set; }
        public DateTime CreateDatetime { get; set; }
        public string CreateUserId { get; set; }
    }
}
