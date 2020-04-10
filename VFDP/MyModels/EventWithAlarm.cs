using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VFDP.Models;

namespace VFDP.MyModels
{
    public class EventWithAlarm
    {
        public IEnumerable<EventHistory> EventHis { get; set; }
        public IEnumerable<AlarmHistory> AlarmHis { get; set; }

        public EventWithAlarm(HumDevContext context)
        {
            this.EventHis = context.EventHistory.ToList();
            this.AlarmHis = context.AlarmHistory.ToList();
        }
    }
}
