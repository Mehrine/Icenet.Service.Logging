using System;
using System.Linq;
using System.Web.Mvc;
using Icenet.Service.Logging.UI.Helpers;
using Icenet.Service.Logging.UI.Models;
using Icenet.Service.Logging.UI.Services;
using NLog;

namespace Icenet.Service.Logging.UI.Controllers
{
    public class HomeController : Controller
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly LogService _logService;
        private readonly FilterLog _filterLog;

        public HomeController()
        {
            _logService = new LogService();
            _filterLog = new FilterLog();
        }

        [HttpGet]
        public ActionResult Index(LogViewModel model)
        {
            //foreach (int value in Enum.GetValues(typeof(DaysOfWeek)))
            //{
            //    Console.WriteLine(((DaysOfWeek)value).ToString());
            //}

            //var values = Enum.GetValues(typeof(LogCategoryEnum));

            //iterate through logcategoryenums to produce a list of strings
            model = new LogViewModel
            {
                LogCategories = _filterLog.LogCategories

            };

            return View(model);
        }

        private ActionResult LoadAndFilterLogItems(LogViewModel model)
        {
            try
            {
                model.LogCategories = _filterLog.LogCategories;
                var logItem = _logService.FindLogItemModels();
                var filterItems = model.Filter;

                model.LogItems = _filterLog.GetLogFromLogItemModel(logItem, filterItems);

                return View("LogItemGrid", model);
            }
            catch (Exception exception)
            {
                logger.Error(exception,
                    "there was an error when attempting to retrieve the preferred string using searchString "
                );
                model.ErrorMessage = exception.Message;

                return View("LogItemGrid", model);
            }
        }

        [HttpGet]
        public ActionResult GetAllLogItems(LogViewModel model)
        {
            return LoadAndFilterLogItems(model);
        }

        [HttpPost]
        public ActionResult GetFilteredLogItems(LogViewModel model)
        {
            return LoadAndFilterLogItems(model);
        }

        [HttpGet]
        public ActionResult LogDetail(int logId)
        {
            var logItems = _logService.FindLogItemModels();

            var logItem = logItems.FirstOrDefault(x => x.Id == logId);

            return View(logItem);
        }
    }
}


//get the code from the console application & put it inside the retreiever of log items
//copy the code, comment the  retreiever of log items code and test it to see if it works






