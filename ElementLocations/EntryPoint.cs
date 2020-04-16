using System;
using System.Drawing;
using System.Threading;
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
            //driver.Manage().Window.Maximize();

            //Console.WriteLine(image.Location.X);
            //Console.WriteLine(image.Location.Y);
            //Console.WriteLine(image.Size.Width);
            //Console.WriteLine(image.Size.Height);

            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;

            string script = "arguments[0].style[\"display\"]=\"none\"";

            jsExecutor.ExecuteScript(script, image);

            IWebElement textColor = driver.FindElement(By.CssSelector("#page-17 > div "));

            script = "arguments[0].style[\"color\"]=\"red\"";
            jsExecutor.ExecuteScript(script, textColor);

            string script2 = "arguments[0].style[\"border\"]=\"5px solid red\"";

            jsExecutor.ExecuteScript(script2, textColor);


            Thread.Sleep(2000);

            IWebElement content = driver.FindElement(By.CssSelector("#page-17 > div "));

            SetStyle(driver, content, "color","green");

            Thread.Sleep(3000);

            driver.Quit();

        }

        static void SetStyle(IWebDriver driver, IWebElement element, string style, string styleValue)
        {
            string script = String.Format("arguments[0].style[\"{0}\"] = \"{1}\"", style,styleValue);

            IJavaScriptExecutor  jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript(script, element);
        }
    }
}
