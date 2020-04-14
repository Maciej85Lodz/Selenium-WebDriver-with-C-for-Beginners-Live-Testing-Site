using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace _04.Drop_Down_Menu
{
    class EntryPoint
    {
        static IWebDriver driver = new ChromeDriver();
        static IWebElement dropDownMenu;
        private static IWebElement elemDropDownMenu;

        static void Main()
        {
            string url = "http://testing.todvachev.com/special-elements/drop-down-menu-test/";
            string dropDownMenuElements = "#post-6 > div > p:nth-child(6) > select > option:nth-child(3)";

            driver.Navigate().GoToUrl(url);

            dropDownMenu = driver.FindElement(By.Name("DropDownTest"));

            Console.WriteLine(dropDownMenu.GetAttribute("value"));

            elemDropDownMenu = driver.FindElement(By.CssSelector(dropDownMenuElements));
            Console.WriteLine("The third option from drop down menu is: " + elemDropDownMenu.GetAttribute("Value"));

            elemDropDownMenu.Click();

            Console.WriteLine("The selected option is: " + dropDownMenu.GetAttribute("value"));
            Thread.Sleep(2000);

            for (int i = 1; i <= 4; i++)
            {
                dropDownMenuElements = "#post-6 > div > p:nth-child(6) > select > option:nth-child("+ i +")";
                elemDropDownMenu = driver.FindElement(By.CssSelector(dropDownMenuElements));

                Console.WriteLine("The "+ i +" option from drop down menu is: " + elemDropDownMenu.GetAttribute("Value"));
            }

            Thread.Sleep(5000);

            driver.Quit();
        }

        
    }
}
