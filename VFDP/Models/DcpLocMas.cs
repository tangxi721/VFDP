using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpLocMas
    {
        public string Fab { get; set; }
        public string LotId { get; set; }
        public string CarrierId { get; set; }
        public string EqpId { get; set; }
        public string Oper { get; set; }
        public string Prod { get; set; }
        public string ProcFlow { get; set; }
        public string DcolId { get; set; }
        public DateTime? CrtTm { get; set; }
    }
}
