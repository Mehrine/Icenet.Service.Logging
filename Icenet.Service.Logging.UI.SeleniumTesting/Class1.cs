using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace Icenet.Service.Logging.UI.SeleniumTesting
{
    [TestFixture]
    public class Class1
    {
        IWebDriver driver = new ChromeDriver();

        [Test]
        public void WhenINavigateToTheLogViewerPage_IShouldSeeTheTelerikGrid_ContainingTheLogItems()
        {
            var driver = new ChromeDriver(); //opens the ChromeDriver

           driver.Url = "http://localhost/TestSampleWebApp"; //Url of the ChromeDriver
           driver.Navigate(); //Url then navigates to the ChromeDriver

           

        }


        //[Test]
        //public void WhenINavigateToTheProductListPage_IShouldSeeFourProducts()
        //{
        //    var driver = new ChromeDriver(); //opens the ChromeDriver

        //    driver.Url = "http://localhost/TestSampleWebApp"; //Url of the ChromeDriver
        //    driver.Navigate(); //Url then navigates to the ChromeDriver

        //    var table = driver.FindElementById("products-table"); //"products-table", is found by using its Id

        //    var rows = table.FindElements(By.CssSelector("tr")); //finds the rows

        //    Assert.That(rows.Count, Is.EqualTo(5)); //Asserts that there are four rows

        //    //driver.Close(); //closes the driver 
        //}


    }
}


//selenium tests should test the datepicker, search box etc. it should navigate to the page do everything a user would and it should work...