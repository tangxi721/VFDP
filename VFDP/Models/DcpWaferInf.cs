using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpWaferInf
    {
        public string WfId { get; set; }
        public string EqpId { get; set; }
        public string ModuleId { get; set; }
        public string LotId { get; set; }
        public string Prod { get; set; }
        public string ProcFlow { get; set; }
        public string OperId { get; set; }
        public string RecipeId { get; set; }
        public string CassetteId { get; set; }
        public string CassetteSlot { get; set; }
        public string OnlineMode { get; set; }
        public DateTime? CrtTm { get; set; }
        public string CrtUserId { get; set; }
        public DateTime? ChgTm { get; set; }
        public string ChgUserId { get; set; }
    }
}
