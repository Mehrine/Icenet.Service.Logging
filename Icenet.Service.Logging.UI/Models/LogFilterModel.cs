using System;

namespace Icenet.Service.Logging.UI.Models
{
    public class LogFilterModel
    {
        public string LogCategory { get; set; }
        public string SearchText { get; set; }
        public DateTime? DateFrom { get; set; }

    }
}