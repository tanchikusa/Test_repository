using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Navistar.Pages;

namespace Selenium.Pages
{
    public class HomePage : BasePage
    {
        IWebElement exploreButton => driver.FindElement(By.CssSelector(".heroContent a"));

        IWebElement leanMoreButton => driver.FindElement(By.CssSelector("div.field-link a[title='Learn More']"));

        IWebElement joinOurTeamButton => driver.FindElement(By.CssSelector("div.heroContent a[title='JOIN OUR TEAM']"));

        public HomePage(IWebDriver driver) : base(driver)
        { }

        public IWebElement GerExloreButton()
        {
            return exploreButton;
        }

        public VisionStrategyPage ClickExploreButton()
        {
            exploreButton.Click();
            Thread.Sleep(500);
            return new VisionStrategyPage(driver);
        }

        public VisionStrategyPage ClickLeanMoreButton()
        {
            leanMoreButton.Click();
            Thread.Sleep(500);
            return new VisionStrategyPage(driver);
        }

        public CareersPage ClickJoinOurTeamButton()
        {
            joinOurTeamButton.Click();
            Thread.Sleep(500);

            return new CareersPage(driver);
        }
    }
}
