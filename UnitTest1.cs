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

            string currentTabHandle = driver.CurrentWindowHandle;

        
            ((IJavaScriptExecutor)driver).ExecuteScript("window.open;");

            
            foreach (string tabHandle in driver.WindowHandles)
            {
                if (tabHandle != currentTabHandle)
                {
                    driver.SwitchTo().Window(tabHandle);

                }

            }
            var body = driver.FindElement(By.TagName("body"));

            Console.WriteLine("body");

            Console.WriteLine(body);

            // if (body.("Test automation can automate some repetitive but necessary tasks in a formalized testing process")) ;


            ((IJavaScriptExecutor)driver).ExecuteScript(
                "arguments[0].innerHTML = arguments[0].innerHTML.replace('Test automation can automate some repetitive but necessary tasks in a formalized testing process', '<span style=\"background-color: yellow;\">Test automation can automate some repetitive but necessary tasks in a formalized testing process</span>');",
                body);


        }

    }
}











            
  