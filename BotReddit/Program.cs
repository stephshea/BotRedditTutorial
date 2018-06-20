using System;
using System.Net;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BotReddit
{
    class MainClass
    {
        public static void Main(string[] args)
        {
             var options = new ChromeOptions();
             options.AddArguments("--disable-gpu");

            var chromeDriver = new ChromeDriver();
            chromeDriver.Navigate().GoToUrl("https://old.reddit.com/");
            //chromeDriver.FindElementByXPath("//input[@id='login']").Click();
            //chromeDriver.FindElementByXPath("//input[@id='search']").Click();


             chromeDriver.FindElementByXPath("//input*[@id='search']").Click();
             chromeDriver.Keyboard.SendKeys("test");
             chromeDriver.Keyboard.SendKeys(Keys.Enter);

                Console.WriteLine("Hello Reddit!");

        }
    }
}
//*[@id="search"]

//*[@id="search"]/input[1]