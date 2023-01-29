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
            //Navigate to Chrome Browser
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.wikipedia.org/");

            //Input search Text - Automation Testing
            IWebElement searchBox = driver.FindElement(By.Id("searchInput"));
            searchBox.SendKeys("Automation Testing");

            //Click on search button and takes you to Test automation page
            IWebElement searchButton = driver.FindElement(By.XPath("//button[@type='submit']"));
            searchButton.Click();

            //This code verifies search results page contains the correct page title "Test automation - Wikipedia"
            //This code verifies search result contains the text "Test automation can automate some repetitive
            //but necessary tasks in a formalized testing process"

        }

    }
}











            
  