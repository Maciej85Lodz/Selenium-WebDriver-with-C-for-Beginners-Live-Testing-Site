using System;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace _03.Radio_Buttons
{
    class EntryPoint
    {
        static IWebDriver driver = new ChromeDriver();
        static IWebElement radioButton;

        static void Main()
        {
            string url = "http://testing.todvachev.com/special-elements/radio-button-test/";
            string[] option ={ "1","3","5"};

            driver.Navigate().GoToUrl(url);

            
            for (int i = 0; i < option.Length; i++)
            {
                radioButton =
                    driver.FindElement(By.CssSelector("#post-10 > div > form > p:nth-child(6) > input[type=\"radio\"]:nth-child(" + option[i] + ")"));

                if (radioButton.GetAttribute("checked") == "true")
                {
                    Console.WriteLine("The "+ (i+1) +" radio button is checked");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("This is the one of uchecked radion buttons!");
                    Console.ReadKey();
                }
            }
            
            driver.Quit();
        }
    }
}
