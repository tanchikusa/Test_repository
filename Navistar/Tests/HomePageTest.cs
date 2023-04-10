using Selenium.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Navistar.Tests
{
  
    [TestFixture]
    public class HomePageTest : BaseTest
    {
        private HomePage homePage;

        [SetUp]
        public void Setup()
        {
            // Initialize ...
            driver.Navigate().GoToUrl("https://navistar.com/");
            homePage = new HomePage(driver);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }

        [Test]
        public void TestVisionStrategyButton()
        {
            Assert.That(homePage.GetTitle, Is.EqualTo("Home | Navistar®"));
            var visionStrategyPage = homePage.ClickExploreButton();
            Assert.That(visionStrategyPage.getVisionAndStrategyMessage().Text, Is.EqualTo("VISION AND STRATEGY"));
        }

        [Test]
        public void TestLearnMoreButton()
        {
            Assert.That(homePage.GetTitle, Is.EqualTo("Home | Navistar®"));
            var visionStrategyPage = homePage.ClickLeanMoreButton();
            Assert.That(visionStrategyPage.getVisionAndStrategyMessage().Text, Is.EqualTo("VISION AND STRATEGY"));
        }

        [Test]
        public void TestJoinOurTeamButton()
        {
            Assert.That(homePage.GetTitle, Is.EqualTo("Home | Navistar®"));
            var careersPage = homePage.ClickJoinOurTeamButton();
            Assert.That(careersPage.getFindJobsButton().Text, Is.EqualTo("FIND JOBS"));
        }


        [Test]
        public void TestVisionStrategyMainMenu()
        {
            var visionStrategyPage = homePage.GetMainMenu().ClickVisionAndStrategyLink();
            Assert.That(visionStrategyPage.getVisionAndStrategyMessage().Text, Is.EqualTo("VISION AND STRATEGY"));
        }

        [Test]
        public void TestWindowCareerMenu()
        {
            var careersPage = homePage.GetMainMenu().ClickCareersLink();
            Assert.That(careersPage.getFindJobsButton().Text, Is.EqualTo("FIND JOBS"));
        }
    }
}
