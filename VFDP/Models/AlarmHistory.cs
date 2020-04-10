using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class AlarmHistory
    {
        public string TimeKey { get; set; }
        public string EquipmentId { get; set; }
        public string AlarmId { get; set; }
        public string AlarmCode { get; set; }
        public string AlarmDescription { get; set; }
        public string LotId { get; set; }
        public string LotCode { get; set; }
        public string RecipeId { get; set; }
        public string ProductId { get; set; }
        public string ProcessFlowId { get; set; }
        public string OperationId { get; set; }
        public DateTime CreateDatetime { get; set; }
        public string CreateUserId { get; set; }
    }
}
