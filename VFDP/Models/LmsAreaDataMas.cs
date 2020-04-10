using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class LmsAreaDataMas
    {
        public string Area { get; set; }
        public string ColumnNm { get; set; }
        public string ColumnTitle1 { get; set; }
        public string ColumnTitle2 { get; set; }
        public string ColumnTitle3 { get; set; }
        public decimal? ColumnOrder { get; set; }
        public string BeforeMeas { get; set; }
        public string Width { get; set; }
        public string IsRowSpanYn { get; set; }
        public string IsVisibleYn { get; set; }
    }
}
