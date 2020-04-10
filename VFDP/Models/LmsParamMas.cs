using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class LmsParamMas
    {
        public decimal ParaId { get; set; }
        public decimal LogsheetId { get; set; }
        public string DataCatg { get; set; }
        public string Nm1st { get; set; }
        public string Nm2nd { get; set; }
        public string Nm3rd { get; set; }
        public string ParaNm { get; set; }
        public string DataFormat { get; set; }
        public decimal? ColumnOrder { get; set; }
        public DateTime CrtTm { get; set; }
        public string MeasureCheck1 { get; set; }
        public string MeasureCheck2 { get; set; }
        public string MeasureCheck3 { get; set; }
        public string DecimalPoint { get; set; }
    }
}
