using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutoTestFramework.UIElements
{
    public class UsernameFieldPost
    {
        public UsernameFieldPost(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#post-74 > div > p > a")]
        public IWebElement LoginFromLink { get; set; }

    }
}
