using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navistar.Pages
{
    public class BasePage
    {
        protected readonly IWebDriver driver;
        
        IReadOnlyList<IWebElement> closeCookiesButtons => driver.FindElements(By.CssSelector("div.privacy-warning a"));

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Window.Maximize();
            if (closeCookiesButtons.Count > 0)
            {
                closeCookiesButtons[0].Click();
            }
        }

        public MainMenu GetMainMenu()
        {
            return new MainMenu(driver);
        }

        public string GetTitle()
        {
            return driver.Title;
        }
    }
}
