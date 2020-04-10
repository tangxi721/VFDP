using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpWafertidHis
    {
        public string Tid { get; set; }
        public string TidLink { get; set; }
        public string WfId { get; set; }
        public DateTime CrtTm { get; set; }
        public decimal DcolDataId { get; set; }
    }
}
