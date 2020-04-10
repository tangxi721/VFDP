using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpPredcoldataitemInf
    {
        public decimal DcolDataId { get; set; }
        public string DcolItemCd { get; set; }
        public string TgtVal { get; set; }
        public string MinLimitVal { get; set; }
        public string MaxLimitVal { get; set; }
    }
}
