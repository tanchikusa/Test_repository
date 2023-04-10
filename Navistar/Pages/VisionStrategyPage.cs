using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navistar.Pages
{
    public class VisionStrategyPage : BasePage
    {
        IWebElement visionAndStrategyMessage => driver.FindElement(By.CssSelector("h1"));

        public VisionStrategyPage(IWebDriver driver) : base(driver)
        { }

        public IWebElement getVisionAndStrategyMessage()
        {
            return visionAndStrategyMessage;
        }
    }
}
