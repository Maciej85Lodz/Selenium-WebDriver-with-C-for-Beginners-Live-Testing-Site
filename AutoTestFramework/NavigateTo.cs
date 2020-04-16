using System.Threading;
using AutoTestFramework.UIElements;
using OpenQA.Selenium;

namespace AutoTestFramework
{
    public static class NavigateTo
    {
        public static void LoginFormScenarioThroughTestCases(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            TestCasesPage tcPage = new TestCasesPage(driver);
            UsernameFieldPost ucPost = new UsernameFieldPost(driver);

            menu.TestCases.Click();
            tcPage.UsernameField.Click();
            ucPost.LoginFromLink.Click();
        }

        public static void LoginFormScenarioThroughMenu(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            TestScenariosPage tsPage = new TestScenariosPage(driver);

            menu.TestScenarios.Click();
            tsPage.LoginFormScenario.Click();
        }
    }
}
