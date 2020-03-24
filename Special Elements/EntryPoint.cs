using System;
using System.Runtime.Remoting.Channels;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement textBox;

    static void Main()
    {
        string url = "http://testing.todvachev.com/special-elements/text-input-field/";
        
        driver.Navigate().GoToUrl(url);

        textBox = driver.FindElement(By.Name("username"));

        textBox.SendKeys("Test Text");

        Thread.Sleep(3000);

        Console.WriteLine(textBox.GetAttribute("value"));
        Console.WriteLine(textBox.GetAttribute("maxlenght"));

        Thread.Sleep(3000);

        driver.Quit();
    }

}