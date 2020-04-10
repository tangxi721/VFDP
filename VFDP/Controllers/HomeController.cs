using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using VFDP.Models;

namespace VFDP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HumDevContext _context;

        public HomeController(ILogger<HomeController> logger, HumDevContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
           
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
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
            var alarmDes = await (from t in _context.SystemCode where t.Code == AlarmCode && t.DisplayName==AlarmID select t.Description).ToListAsync();
            return Json(alarmDes);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
