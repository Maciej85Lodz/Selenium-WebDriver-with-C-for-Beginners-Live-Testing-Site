using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

namespace UserlikeActions
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            string url = "http://testing.todvachev.com/draganddrop/draganddrop.html";

            string lightGreen = "rgba(144, 238, 144, 1)";

            driver.Navigate().GoToUrl(url);

            string[] elementIds =
            {
                "Drag1",
                "Drag2",
                "Drag3",
                "Drag4",
                "Drag5"
            };

            IWebElement[] elements =
            {
                driver.FindElement(By.Id(elementIds[0])),
                driver.FindElement(By.Id(elementIds[1])),
                driver.FindElement(By.Id(elementIds[2])),
                driver.FindElement(By.Id(elementIds[3])),
                driver.FindElement(By.Id(elementIds[4]))
            };

            Actions actions = new Actions(driver);

            actions.MoveToElement(elements[0]).Build().Perform();

            Console.WriteLine(elements[0].GetCssValue("background-color") == lightGreen);
            Console.WriteLine(elements[1].GetCssValue("background-color") == lightGreen);

            Thread.Sleep(5000);

            MoveElement(new Actions(driver), elements[0],elements[1], 0, 10);
            Thread.Sleep(1000);
            MoveElement(new Actions(driver), elements[0], elements[2], 0, 10);
            Thread.Sleep(1000);
            MoveElement(new Actions(driver), elements[0], elements[1], 0, 10);
            Thread.Sleep(1000);

            Console.WriteLine("The element "+elements[0].Text+ " has been moved to " + elements[1].Text);
            
            Thread.Sleep(5000);

            driver.Quit();
        }

        static void MoveElement(Actions actions, IWebElement from, IWebElement to, int x = 0, int y = 0)
        {
            actions.ClickAndHold(from)
                .MoveToElement(to)
                .MoveByOffset(0, 10)
                .Release()
                .Build()
                .Perform();
        }
    }
}
