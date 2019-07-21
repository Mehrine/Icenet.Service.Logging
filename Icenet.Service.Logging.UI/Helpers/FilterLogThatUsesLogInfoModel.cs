using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Icenet.Service.Logging.UI.Models;

namespace Icenet.Service.Logging.UI.Helpers
{
    public class FilterLogThatUsesLogInfoModel
    {
 
        public List<string> LogCategories = new List<string>()
        {
            "(Please select)",
            "Info",
            "Warning",
            "Error",
            "Trace",
        };


        enum LogCategoryEnum
        {
            None = 0,
            Info = 1,
            Warning = 2,
            Error = 3,
            Trace = 4
            //"(Please select)",  "Info", "Warning", "Error",  "Trace"
        };


        public List<LogInfoModel> GetLogFromLogInfoModel (List<LogInfoModel> logItem, LogFilterModel filter)
        {
            var filteredLogItems = logItem.Where(logItems =>
                MatchesLogLevel(logItems, filter.LogCategory) &&
                MatchesSearchTextReturnsYesWhenNull(logItems, filter.SearchText) &&
                MatchesTimeStamp(logItems, filter.DateFrom)
            ).ToList();

            return filteredLogItems;
        }
        

        private bool MatchesLogLevel(LogInfoModel logItem, string logLevel)
        {
            if (logLevel == null || logLevel == LogCategoryEnum.None.ToString())
            {
                return true;
            }
            return logItem.LogLevel == logLevel;
        }


        private bool MatchesSearchTextReturnsYesWhenNull(LogInfoModel logItem, string searchText)
        {
            if (string.IsNullOrEmpty(searchText))
            {
                return true;
            }
            return logItem.Title.Contains(searchText) || logItem.Detail.Contains(searchText);
        }



        private bool MatchesTimeStamp(LogInfoModel logItem, DateTime? timeStamp)
        {
            if (!timeStamp.HasValue)
            {
                return true;
            }
            return logItem.TimeStamp >= timeStamp;
        }
    }
}