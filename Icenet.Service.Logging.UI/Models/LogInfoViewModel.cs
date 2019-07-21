using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Icenet.Service.Logging.UI.Models
{
    public class LogInfoViewModel : BaseViewModel
    {
        public LogInfoViewModel()
        {
            LogItems = new List<LogInfoModel>();
        }

        public List<LogInfoModel> LogItems { get; set; }
    }



}