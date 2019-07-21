using System;
using Icenet.Service.Logging.UI.Helpers;
using Icenet.Service.Logging.UI.Models;
using Icenet.Service.Logging.UI.Services;
using NUnit.Framework;

namespace Icenet.Service.Logging.UI.UnitTests.Helper
{
    [TestFixture]
    class FilterLogTest
    {
        private readonly LogService _logService;
        private readonly FilterLog _filterLog;

        public FilterLogTest()
        {
            _logService = new LogService();
            _filterLog = new FilterLog();
        }

        [Test]
        public void TestShouldReturn_TwoDatesWhenTheInfoCategory_HasADateOfTheSeventhOfFebruary()
        {
            //Arrange
            var logItem = _logService.FindLogItemModels();

            var filterItems = new LogFilterModel
            {
                LogCategory = "Info",
                SearchText = null,
                DateFrom = new DateTime(2018, 2, 7)
            };

            //Act
            var result = _filterLog.GetLogFromLogItemModel(logItem, filterItems);

            //Assert
            Assert.That(result.Count, Is.EqualTo(2));
        }
    }
}
