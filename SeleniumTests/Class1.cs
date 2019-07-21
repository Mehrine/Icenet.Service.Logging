using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    public class Class1
    {
        IWebDriver driver = new ChromeDriver();

        [Test]
        public void WhenINavigateToTheLogViewerPage_IShouldSeeTheTelerikGrid_Has5LogItems()
        {
            var driver = new ChromeDriver(); //opens the ChromeDriver
            driver.Url = "http://localhost/LogViewer/Home/Index";

            driver.Navigate(); //Url then navigates to the ChromeDriver

            var table = driver.FindElementById("MyGrid");

            var rows = table.FindElements(By.CssSelector("tr")); //finds the rows
            Assert.That(rows.Count, Is.EqualTo(6)); 
        }

        [Test]
        public void TheLogCategoryShouldSelectACategory_AndHitTheFilterButton()
        {
            var driver = new ChromeDriver(); //opens the ChromeDriver
            driver.Url = "http://localhost/LogViewer/Home/Index";

            //SelectElement selector = new SelectElement(element);
            //selector.SelectByIndex(1);

            new SelectElement(driver.FindElement(By.Id("{put your tag information here}"))).SelectByText("{State here}");


            driver.Navigate(); //Url then navigates to the ChromeDriver
            




        }  
    }
}




//the selenium tests must test the search text, the datepicker etc. it should do everything a user would do but automically without
//clicking on it...