using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpWaferModuleInf
    {
        public string EqpId { get; set; }
        public string ModuleId { get; set; }
        public string MesModuleId { get; set; }
        public string ModuleDesc { get; set; }
        public DateTime? CrtTm { get; set; }
        public string CrtUserId { get; set; }
        public DateTime? ChgTm { get; set; }
        public string ChgUserId { get; set; }
    }
}
