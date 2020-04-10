using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpTableActionHis
    {
        public DateTime? CrtTm { get; set; }
        public string ProgId { get; set; }
        public string TableNm { get; set; }
        public string ColumnNm { get; set; }
        public string BeforeVal { get; set; }
        public string AfterVal { get; set; }
        public string ActionComment { get; set; }
        public string TranTyp { get; set; }
        public string KeyVal { get; set; }
        public string CrtUserId { get; set; }
    }
}
