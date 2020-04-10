using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpLoggerMas
    {
        public string FabId { get; set; }
        public string ProcId { get; set; }
        public string LogPath { get; set; }
        public decimal DataKeepDur { get; set; }
    }
}
