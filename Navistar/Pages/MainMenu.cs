using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navistar.Pages
{
    public class MainMenu
    {
        protected readonly IWebDriver driver;

        IReadOnlyList<IWebElement> aboutUsLinks => driver.FindElements(By.CssSelector("header nav ul>li.submenu.level1>a"));
      
        IWebElement visionAndStrategyLink => driver.FindElement(By.CssSelector("li a[title = 'Vision and Strategy']"));
        IWebElement careersLink => driver.FindElement(By.CssSelector("li a[title = 'Careers']"));
        public MainMenu(IWebDriver driver)
        {
            this.driver = driver;
        
        }

        public VisionStrategyPage ClickVisionAndStrategyLink()
        {
            Actions builder = new Actions(driver);
            builder.MoveToElement(aboutUsLinks[0]).Click().Build().Perform();
      
            visionAndStrategyLink.Click();
            Thread.Sleep(500);
            return new VisionStrategyPage(driver);
        }

        public CareersPage ClickCareersLink()
        {
            //Store the ID of the original window
            string originalWindow = driver.CurrentWindowHandle;

            //Check we don't have other windows open already
            Assert.AreEqual(driver.WindowHandles.Count, 1);

            Actions builder = new Actions(driver);
            builder.MoveToElement(aboutUsLinks[2]).Click().Build().Perform();
      
            careersLink.Click();

     
            Thread.Sleep(500);

            foreach (string window in driver.WindowHandles)
            {
                if (originalWindow != window)
                {
                    driver.SwitchTo().Window(window);
                    break;
                }
            }
            Thread.Sleep(500);
            
            return new CareersPage(driver);
        }

    }
}
