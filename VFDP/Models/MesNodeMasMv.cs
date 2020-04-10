using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class MesNodeMasMv
    {
        public string NodeId { get; set; }
        public string NodeTyp { get; set; }
        public string NodeAttrVal1 { get; set; }
        public string NodeAttrVal2 { get; set; }
        public decimal? XCoordVal { get; set; }
        public decimal? YCoordVal { get; set; }
        public string FacId { get; set; }
        public string FlowId { get; set; }
        public string FlowVer { get; set; }
        public decimal? OperSeq { get; set; }
    }
}
