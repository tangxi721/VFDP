using System;
using System.Collections.Generic;

namespace VFDP.Models
{
    public partial class DcpProcessMas
    {
        public string Fab { get; set; }
        public string ProcId { get; set; }
        public string Ip { get; set; }
        public string Port { get; set; }
        public string LogPath { get; set; }
        public string CrtUser { get; set; }
        public DateTime? CrtTm { get; set; }
        public string ChgUser { get; set; }
        public DateTime? ChgTm { get; set; }
        public string UserTyp { get; set; }
        public string SysVerp { get; set; }
    }
}
