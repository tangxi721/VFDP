using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class TestProcessMas
    {
        public string Fab { get; set; }
        public string SysId { get; set; }
        public string ProcessId { get; set; }
        public string Ip { get; set; }
        public string Port { get; set; }
        public string LogPath { get; set; }
        public string CrtUser { get; set; }
        public DateTime? CrtTm { get; set; }
        public string ChgUser { get; set; }
        public DateTime? ChgTm { get; set; }
        public string UseTyp { get; set; }
        public string SysVerp { get; set; }
        public string UiPort { get; set; }
    }
}
