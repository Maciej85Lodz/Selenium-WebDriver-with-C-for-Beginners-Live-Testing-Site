using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutoTestFramework

{
    class EntryPoint
    {
        IAlert alert;

        public static void Main()
        {
        }

        [SetUp]
        public void Initialize()
        {
            Actions.InitDriver();
        }

        [Test]
        public void ValidLogin()
        {
            NavigateTo.LoginFormScenarioThroughMenu();
            Actions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepearPassword);
            
            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertsMessages.SuccessfulLogin,alert.Text);
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
