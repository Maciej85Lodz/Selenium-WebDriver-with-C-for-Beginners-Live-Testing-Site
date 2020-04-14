using System.Threading;
using AutoTestFramework.UIElements;

namespace AutoTestFramework
{
    public static class NavigateTo
    {
        public static void LoginFormScenarioThroughTestCases()
        {
            Menu menu = new Menu();
            TestCasesPage tcPage = new TestCasesPage();
            UsernameFieldPost ucPost = new UsernameFieldPost();

            menu.TestCases.Click();
            tcPage.UsernameField.Click();
            ucPost.LoginFromLink.Click();
        }

        public static void LoginFormScenarioThroughMenu()
        {
            Menu menu = new Menu();
            TestScenariosPage tsPage = new TestScenariosPage();

            menu.TestScenarios.Click();
            tsPage.LoginFormScenario.Click();
        }
    }
}
