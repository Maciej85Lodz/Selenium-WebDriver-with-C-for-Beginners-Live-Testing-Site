using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ElementLocations
{
    class EntryPoint
    {
        static void Main()
        {
            IWebDriver driver = new ChromeDriver();
            string url = "http://testing.todvachev.com";

            driver.Navigate().GoToUrl(url);

            IWebElement image = driver.FindElement(By.CssSelector("#page-17 > div > p:nth-child(1) > a > img"));
            driver.Manage().Window.Maximize();

            Console.WriteLine(image.Location.X);
            Console.WriteLine(image.Location.Y);
            Console.WriteLine(image.Size.Width);
            Console.WriteLine(image.Size.Height);


        }
    }
}
