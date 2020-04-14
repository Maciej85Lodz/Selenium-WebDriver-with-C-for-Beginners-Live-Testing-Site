using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumScreenShots
{
    class EntryPoint
    {
        static void Main()
        {
            IWebDriver chrome = new ChromeDriver();

            string screenshotsDirectory = Directory.GetCurrentDirectory() + @"\screenshots";

            chrome.Navigate().GoToUrl("http://google.com");

            Screenshot googleScreenshot = ((ITakesScreenshot)chrome).GetScreenshot();

            if (!Directory.Exists(screenshotsDirectory))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\screenshots");
            }
            googleScreenshot.SaveAsFile(Directory.GetCurrentDirectory() + @"\screenshots\googlescreenshot.png",ScreenshotImageFormat.Png);


            chrome.Quit();
        }
    }
}
