using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;
using System.Threading.Tasks;

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

            driver.Manage().Window.Maximize();

            string actualTitle = driver.Title;
            string expectedTitle = "Test automation - Wikipedia";
            if (actualTitle == expectedTitle)
            {
                Console.WriteLine("The page title is correct: " + actualTitle);
            }
            else
            {
                Console.WriteLine("The page title is incorrect. Expected: " + expectedTitle + " but was: " + actualTitle);
            }

            {
                string expectedText = "Test automation can automate some repetitive but necessary tasks in a formalized testing process.";
                if (driver.PageSource.Contains(expectedText))
                {
                    Console.WriteLine("The expected text is present on the page.");
                }
                else
                {
                    Console.WriteLine("The expected text is not present on the page.");

                    


                }
            }

        }
    }
}











            
  