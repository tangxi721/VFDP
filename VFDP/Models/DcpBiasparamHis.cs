using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpBiasparamHis
    {
        public string IcansLinkKey { get; set; }
        public string IcansLinkWfKey { get; set; }
        public string OvLinkKey { get; set; }
        public string OvLinkWfKey { get; set; }
        public string TestNo { get; set; }
        public string OvFieldx { get; set; }
        public string OvFieldy { get; set; }
        public string Fieldxpos { get; set; }
        public string Fieldypos { get; set; }
        public string TgtX { get; set; }
        public string TgtY { get; set; }
        public string Overlayx { get; set; }
        public string Overlayy { get; set; }
        public string TgtTestNo { get; set; }
        public string DefectId { get; set; }
        public string IcansFieldx { get; set; }
        public string IcansFieldy { get; set; }
        public string Fieldrelx { get; set; }
        public string Fieldrely { get; set; }
        public string X { get; set; }
        public string Y { get; set; }
        public string BiasXVal { get; set; }
        public string BiasYVal { get; set; }
        public DateTime? CrtDt { get; set; }
        public string KnnDesc { get; set; }
    }
}
