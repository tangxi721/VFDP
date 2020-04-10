using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpIcansmsgHis
    {
        public string LinkKey { get; set; }
        public string LinkWfKey { get; set; }
        public string Msg { get; set; }
        public DateTime? CrtDt { get; set; }
    }
}
