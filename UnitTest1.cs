using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWikipediaDemo
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
      
        }

        [Test]
        public void Test()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.wikipedia.org/");

            IWebElement searchBox = driver.FindElement(By.Id("searchInput"));
            searchBox.SendKeys("Automation Testing");

            IWebElement searchButton = driver.FindElement(By.XPath("//button[@type='submit']"));
            searchButton.Click();















            //Open Browser
            //*IWebDriver webDriver = new ChromeDriver();
            /*Navigate to site
            webDriver.Navigate().GoToUrl("https://en.wikipedia.org/wiki/Main_Page");

           IWebDriver  search = driver.FindElement(By.Id("searchInput"));
           searchBox.SendKeys("Automation testing");*/

           // IWebElement searchButton = driver.FindElement(By.ClassName("Search"));
           // searchButton.Click();

          //  ElementClickInterceptedException 

           // IWebDriver driver.FindElement(By.Id("searchButton")).Click();

            //IWebElement searchButton = driver.FindElement(By.XPath("//button[@id='searchform']"));
            //searchButton.Click();

            //Using click method to submit search
            // searchButton.SendKeys





            //Wait for the page to load
            System.Threading.Thread.Sleep(5000);

            // Get the title of the page and print it
            Console.WriteLine(driver.Title);

            // Close the browser
            driver.Quit();

        }
    }
}