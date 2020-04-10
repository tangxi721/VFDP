using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class MesNodeRelMv
    {
        public string FrNodeId { get; set; }
        public string ToNodeId { get; set; }
        public string RelTyp { get; set; }
        public string RelAttrVal { get; set; }
        public string FacId { get; set; }
        public string FlowId { get; set; }
        public string FlowVer { get; set; }
    }
}
