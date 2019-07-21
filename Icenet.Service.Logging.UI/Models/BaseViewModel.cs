using System.Collections.Generic;

namespace Icenet.Service.Logging.UI.Models
{
    public class BaseViewModel
    {
            public List<string> LogCategories { get; set; }

            public LogFilterModel Filter { get; set; }
            protected BaseViewModel()
            {
                Filter = new LogFilterModel();
            }

            //[Required(ErrorMessage = "This isn't working")]
            public string ErrorMessage { get; set; }
        
    }
}