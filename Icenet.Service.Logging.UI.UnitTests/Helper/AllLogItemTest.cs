using System;
using System.Collections.Generic;
using Icenet.Service.Logging.UI.Helpers;
using Icenet.Service.Logging.UI.Models;
using Icenet.Service.Logging.UI.Services;
using NUnit.Framework;

namespace Icenet.Service.Logging.UI.UnitTests.Helper
{
    [TestFixture]
    class AllLogItemTest
    {
        private readonly LogService _logService;
        private readonly FilterLog _filterLog;


        public AllLogItemTest()
        {
            _logService = new LogService();
            _filterLog = new FilterLog();
        }


        [TestCase("Info", null, 0, 2, 01, 3)]
        [TestCase("Info", null, 2018, 2, 07, 2)]
        [TestCase("Info", "Checking", 0, 2, 01, 2)]
        [TestCase("(Please select)", "Checking", 0, 2, 01, 2)] //for this test we want it to say if selected with "Please select", do not allow it to select any categories
        [TestCase("(Please select)", null, 0, 2, 01, 5)]
        [TestCase("Info0", "see", 0, 0, 0, 0)]
        public void GetSpecificLogItems_WhenAChosenTestCase_IsBeingTested (string LogCategory, string SearchText, int year,
        int month, int day, int ExpectedResult)
        {
            //Arrange
            List<LogItemModel> logItemModels = _logService.FindLogItemModels();

            DateTime? dateFrom = null;

            if (year != 0)
            {
                dateFrom = new DateTime(year, month, day);
            }


            var filterItems = new LogFilterModel
            {
                LogCategory = LogCategory,
                SearchText = SearchText,
                DateFrom = dateFrom
            };

            //Act
            var result =  _filterLog.GetLogFromLogItemModel(logItemModels, filterItems);
          
            //Assert
            Assert.That(result.Count, Is.EqualTo(ExpectedResult));
        }
    }
}

