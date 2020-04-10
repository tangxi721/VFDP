using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpIcanswfHis
    {
        public string LinkKey { get; set; }
        public string LinkWfKey { get; set; }
        public string WfId { get; set; }
        public string ChambId { get; set; }
        public DateTime? CrtDt { get; set; }
    }
}
