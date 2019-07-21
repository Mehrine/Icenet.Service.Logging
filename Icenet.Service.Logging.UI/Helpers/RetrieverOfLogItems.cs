using System.Collections.Generic;
using System.IO;
using System.Net;
using Icenet.Service.Logging.UI.Models;
using Newtonsoft.Json;

namespace Icenet.Service.Logging.UI.Helpers
{
    public class RetrieverOfLogItems
    {
        public static List<LogItemModel> LoadLogItemModelFromJson()
        {
            var result = Result();
            var endResult = JsonConvert.DeserializeObject<List<LogItemModel>>(result);
            return endResult;
        }

        
        public static List<LogInfoModel> LoadLogInfoModelFromJson()
        {
           var result = Result();

           var logInfo = JsonConvert.DeserializeObject<List<LogInfoModel>>(result);
           return logInfo;


            
            //public List<LogItemModel> GetLogItemInfoFromJsonFile()
            //{
            //    // var filePath = @"C:\Temp\LogInfo.json";
            //    //var filePath = @"C:\Temp\JsonExample.json";

            //    var filePath = @"C:\Temp\egbertFile.json";

            //    if (!File.Exists(filePath))
            //    {
            //        throw new FileNotFoundException("Unable to find sample file at path '{0}'".FormatWith(filePath));
            //    }

            //    List<LogItemModel> result = null;
            //    using (var reader = new StreamReader(filePath))
            //    {
            //        try
            //        {
            //            var json = reader.ReadToEnd();
            //            result = JsonConvert.DeserializeObject<List<LogItemModel>>(json);

            //            var logmessage = $"Loaded logItems at path '{filePath}'";
            //        }
            //        catch (Exception exception) { throw new Exception(exception.Message); }
            //    }
            //    return result;

        }

        
        private static string Result()
        {
            var logServiceUrl = Settings.LogServiceUrl();
            var getRequest = (HttpWebRequest) WebRequest.Create(logServiceUrl + "/returnlogitems");
            getRequest.Method = "GET";
           
            var response = (HttpWebResponse) getRequest.GetResponse();
            var responseStream = response.GetResponseStream();
            var streamReader = new StreamReader(responseStream);
            var result = streamReader.ReadToEnd();
            return result;
        }
    }
}

//tidy the code up, rename things
//get url from app settings in the config file

//get the date format into c# .net date format