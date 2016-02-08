using OlympicMarathon.Infrastructure;
using OlympicMarathon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OlympicMarathon.Controllers
{
    public class RunLogController : Controller
    {
        public ActionResult GetLog()
        {
            List<LogModel> log = RunnerLogDb.GetLogsFromDataabse();
            return View(log);
        }

        public ActionResult InsertLog()
        {
            LogModel log = new LogModel();
            log.RunDate = DateTime.Now;
            return View(log);
        }

        [HttpPost]
        public ActionResult InsertLog(LogModel log)
        {
            RunnerLogDb.InsertLog(log);
            return RedirectToAction("GetLog");
        }

        public ActionResult DeleteLog(int id)
        {
            RunnerLogDb.DeleteLog(id);
            return RedirectToAction("GetLog");
        }

        public ActionResult EditLog(int id)
        {
            LogModel log = RunnerLogDb.GetRunnerLog(id);
            return View(log);
        }
    }
}