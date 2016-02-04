using OlympicMarathon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OlympicMarathon.Infrastructure
{
    public static class RunnerLogDb
    {
        private static List<LogModel> db;
        
        static RunnerLogDb()
        {
            db = new List<LogModel>();

            var log0 = new LogModel();
            log0.Id = 0;
            log0.RunDate = new DateTime(2015, 12, 31, 09, 00, 00);
            log0.Distance = 26;

            var log1 = new LogModel();
            log1.Id = 1;
            log1.RunDate = new DateTime(2016, 1, 3, 09, 30, 00);
            log0.Distance = 12;

            db.Add(log0);
            db.Add(log1);
        }
        public static void InsertLog(LogModel log)
        {
            if (db.Any(l => l.Id == log.Id))
            {
                throw new Exception("Attempt to insert duplicate item in db!");
            }
            db.Add(log);
        }

        internal static void DeleteLog(int id)
        {
            db.RemoveAll(log => log.Id == id);
        }

        internal static LogModel GetRunnerLog(Int32 id)
        {
            return db.Where(log => log.Id == id).Single();
        }

        internal static List<LogModel> GetLogsFromDataabse()
        {
            return db.ToList();
        }
    }
}