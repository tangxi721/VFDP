using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpSysqueryMas
    {
        public string FacId { get; set; }
        public string SysId { get; set; }
        public string QueryId { get; set; }
        public string QuerySql { get; set; }
    }
}
