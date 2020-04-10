using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class LmsEqpMas
    {
        public decimal? LogsheetId { get; set; }
        public string EqpId { get; set; }
        public string LastJobEndTm { get; set; }
        public string MeasPeriod { get; set; }
    }
}
