using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpBiasavgparamHis
    {
        public string LinkKey { get; set; }
        public string LinkWfKey { get; set; }
        public string TestNo { get; set; }
        public string Fieldx { get; set; }
        public string Fieldy { get; set; }
        public string BiasXVal { get; set; }
        public string BiasYVal { get; set; }
        public DateTime? CrtDt { get; set; }
    }
}
