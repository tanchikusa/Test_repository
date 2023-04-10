using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navistar.Pages
{
    public class CareersPage : BasePage
    {

        IWebElement findJobsButton => driver.FindElement(By.CssSelector("button.search-button"));


        public CareersPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement getFindJobsButton()
        {
            return findJobsButton;
        }
    }
}
