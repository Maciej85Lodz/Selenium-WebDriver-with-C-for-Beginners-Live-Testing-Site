using System.Runtime.CompilerServices;
using AutoTestFramework.UIElements;
using OpenQA.Selenium.Chrome;

namespace AutoTestFramework
{
    public static class Actions
    {
        public static void InitDriver()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Navigate().GoToUrl(Config.BaseUrl);
            Driver.WaitForElementUpTo(Config.ElementsWaitingTimeout);
        }

        public static void FillLoginForm(string username, string password, string repeatPassword)
        {
            LoginScenarioPost loginScenario = new LoginScenarioPost();

            loginScenario.UsernameField.Clear();
            loginScenario.UsernameField.SendKeys(username);
            loginScenario.PasswordField.Clear();
            loginScenario.PasswordField.SendKeys(password);
            loginScenario.RepeatPasswordFiled.Clear();
            loginScenario.RepeatPasswordFiled.SendKeys(repeatPassword);
            loginScenario.LoginButton.Click();
        }
    }
}

