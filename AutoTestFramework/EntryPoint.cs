using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutoTestFramework

{
    class EntryPoint
    {
        IAlert alert;
        public IWebDriver Driver { get; set; }
        public static void Main()
        {
        }

        [SetUp]
        public void Initialize()
        {
            Driver = Actions.InitDriver();
        }

        [Test]
        public void ValidLogin()
        {
            NavigateTo.LoginFormScenarioThroughMenu(Driver);
            Actions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Valid.Password, 
                Config.Credentials.Valid.RepearPassword, Driver);
            
            alert = Driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertsMessages.SuccessfulLogin,alert.Text);
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.Quit();
            Driver.Quit();
        }
    }
}
