using System.Collections.Generic;
using Icenet.Service.Logging.UI.Helpers;
using Icenet.Service.Logging.UI.Models;

namespace Icenet.Service.Logging.UI.Services
{
    public class LogService
    {
        public List<LogInfoModel> FindLogInfoModels()
        {
            List<LogInfoModel> endResult = RetrieverOfLogItems.LoadLogInfoModelFromJson();
            return endResult;
        }


        public List<LogItemModel> FindLogItemModels()
        {
            List<LogItemModel> result = RetrieverOfLogItems.LoadLogItemModelFromJson();
            return result;


            //public List<LogItemModel> FindLogItems()
            //{
            //    var instanceOfRetreiver = new RetrieverOfLogItems();
            //    var result = instanceOfRetreiver.GetLogItemInfoFromJsonFile();

            //    return result;



            //    return new List<LogItemModel>
            //    {
            //        new LogItemModel
            //        {
            //            Title = "Testing",
            //            Detail = "Quick check to ensure data prints to the table",
            //            LogLevel = "Warning",
            //          TimeStamp = new DateTime(2018, 2, 23, 11, 55, 22)
            //        },
            //        new LogItemModel()
            //        {
            //            Title = "Attempt2",
            //            Detail = "Checking to see if more than one data can be passed",
            //            LogLevel = "Info",
            //            TimeStamp  = new DateTime(2018, 2, 07)
            //        },
            //        new LogItemModel()
            //        {
            //            Title = "Scrollbar check",
            //            Detail = "Checking to see if the scrollbar works",
            //            LogLevel = "Info",
            //            TimeStamp  = new DateTime(2018, 2, 01)
            //        },
            //        new LogItemModel()
            //        {
            //            Title = "Practise check",
            //            Detail = "Practise check on telerik grid",
            //            LogLevel = "Info",
            //            TimeStamp  = new DateTime(2018, 2, 26)
            //        },
            //        new LogItemModel()
            //        {
            //            Title = "Attempt5",
            //            Detail = "Passing data",
            //            LogLevel = "Error",
            //            TimeStamp = new DateTime(2018, 2, 13)
            //}

        }
    }
}


//read up on Json and try to pass my LogItems through as Json
//use Json Editor Online

//use the package "Newtonsoft.Json", read up on it and the serialisation and de-serialisation