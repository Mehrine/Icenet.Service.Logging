using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Icenet.Service.Logging.UI.Models
{
    public class LogInfoModel
    {
        public string TitleSummary { get; set; }
        public string id { get; set; }
        public string RaisedDateTime { get; set; }
        public string ProcessDateTime { get; set; }
        public string SourceMachine { get; set; }
        public string SourceProcess { get; set; }
        public string Context { get; set; }
        public string TransactionId { get; set; }
        public string Message { get; set; }
        public string MessageExtended { get; set; }
        public int EventId { get; set; }
        public int LogCategory { get; set; }
        public int ProcessId { get; set; }
        public int ThreadId { get; set; }
        public string ExceptionMessage { get; set; }
        public string StackTrace { get; set; }
        public string ServiceContract { get; set; }
        public string ServiceMethod { get; set; }
        public string Request { get; set; }
        public string Response { get; set; }
        public string CallDuration { get; set; }
        public string CreatedByUser { get; set; }
        public string CreatedDateTime { get; set; }
        public string UpdatedByUser { get; set; }
        public string UpdatedDateTime { get; set; }
        public string AccessControlList { get; set; }





        public string Title { get; set; }

        public string Detail { get; set; }

        public DateTime TimeStamp { get; set; }

        public string LogLevel { get; set; }

        public int Id { get; set; }

    }
}




