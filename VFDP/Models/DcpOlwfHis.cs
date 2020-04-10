using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpOlwfHis
    {
        public string LinkKey { get; set; }
        public string LinkWfKey { get; set; }
        public string SlotId { get; set; }
        public string WfId { get; set; }
        public DateTime? CrtDt { get; set; }
        public string ChuckId { get; set; }
        public string OrgWfId { get; set; }
    }
}
