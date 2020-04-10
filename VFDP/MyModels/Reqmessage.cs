using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VFDP.MyModels
{
    public class Reqmessage
    {
        public string Type { get; set; }
        public string TimeKey { get; set; }
        public string EquipmentName { get; set; }
        public string EquipmentCount { get; set; }
        public string ChamberCount { get; set; }
        public string Port { get; set; }
        public string Slot { get; set; }
        public string LotName { get; set; }
        public string LotCount { get; set; }
        public string IntervalHour { get; set; }
        public string IntervalMinute { get; set; }
        public string IntervalSecond { get; set; }
        public string Product { get; set; }
        public string ProcessFlow { get; set; }
        public string Operation { get; set; }
        public string AlarmCode { get; set; }
        public string AlarmID { get; set; }
        public string AlarmDescription { get; set; }
        public string AlarmModel { get; set; }
    }
}
