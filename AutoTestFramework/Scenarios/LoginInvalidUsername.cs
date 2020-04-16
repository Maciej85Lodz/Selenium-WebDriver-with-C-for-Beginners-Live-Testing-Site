﻿
namespace AutoTestFramework
{
    using OpenQA.Selenium;
    using NUnit.Framework;

    public class LoginInvalidUsername
    {
        IAlert alert;
        public IWebDriver Driver { get; set; }

        public LoginInvalidUsername()
        {     
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Driver = Actions.InitDriver();
            NavigateTo.LoginFormScenarioThroughTestCases(Driver);
        }

        [TestCase]
        public void LessThan5Chars()
        {
            NavigateTo.LoginFormScenarioThroughMenu(Driver);
            Actions.FillLoginForm(Config.Credentials.Invalid.Username.FourCharacters, Config.Credentials.Valid.Password, Config.Credentials.Valid.Password,Driver);

            alert = Driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertsMessages.UsernameLengthOutOfRange, alert.Text);
            alert.Accept();            
        }

        [TestCase]
        public void MoreThan12Chars()
        {
            Actions.FillLoginForm(Config.Credentials.Invalid.Username.ThirteenCharacters,
                Config.Credentials.Valid.Password, Config.Credentials.Valid.Password, Driver);

            alert = Driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertsMessages.UsernameLengthOutOfRange, alert.Text);
            alert.Accept();
        }
       
        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.Quit();
        }
    }
}