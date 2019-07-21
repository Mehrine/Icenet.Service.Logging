using System.Collections.Generic;


namespace Icenet.Service.Logging.UI.Models
{
    public class LogViewModel : BaseViewModel
    {
        public LogViewModel()
        {
            LogItems = new List<LogItemModel>();
        }

        public List<LogItemModel> LogItems { get; set; }
       
    }
}