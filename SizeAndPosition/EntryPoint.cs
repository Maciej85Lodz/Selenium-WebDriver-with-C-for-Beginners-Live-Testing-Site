using System.Drawing;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SizeAndPosition
{
    class EntryPoint
    {
        static void Main()
        {
            Size size = new Size();
            size.Width = 600;
            size.Height = 600;

            Point position = new Point();
            position.X = 0;
            position.Y = 0;


            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://testing.todvachev.com/");
            driver.Manage().Window.Size = size;
            driver.Manage().Window.Position = position;


        }
    }
}
