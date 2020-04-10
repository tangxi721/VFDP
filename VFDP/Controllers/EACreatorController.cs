using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VFDP.Models;
using VFDP.MyModels;

namespace VFDP.Controllers
{
    public class EACreatorController : Controller
    {
        private readonly HumDevContext _context;
        
        public EACreatorController(HumDevContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            EventWithAlarm eventWithAlarm = new EventWithAlarm(_context)
            {
                EventHis = _context.EventHistory.ToList(),
                AlarmHis = _context.AlarmHistory.ToList()
            };        
            return View(eventWithAlarm);
        }

        public IActionResult Index(Reqmessage reqmessage) {
            string type = reqmessage.Type;

            string alarmID = reqmessage.AlarmID;

            EventWithAlarm eventWithAlarm = new EventWithAlarm(_context)
            {
                EventHis = _context.EventHistory.ToList(),
                AlarmHis = _context.AlarmHistory.ToList()
            };
            return View(eventWithAlarm);
        }



        public async Task<JsonResult> GetAlarmCodes()
        {
            var alarmCodeList = await (from t in _context.SystemCode select t.Code).Distinct().ToListAsync();
            return Json(alarmCodeList);
        }

        public async Task<JsonResult> GetAlarmID(string AlarmCode)
        {
            var alarmIdList = await (from t in _context.SystemCode where t.Code == AlarmCode select t.DisplayName).ToListAsync();
            return Json(alarmIdList);
        }

        public async Task<JsonResult> GetAlarmDes(string AlarmCode, string AlarmID)
        {
            var alarmDes = await (from t in _context.SystemCode where t.Code == AlarmCode && t.DisplayName == AlarmID select t.Description).ToListAsync();
            return Json(alarmDes);
        }

    }
}