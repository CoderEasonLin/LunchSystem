using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace LunchSystem.Tests.Steps
{
    [Binding]
    public class MenuSteps
    {
        static ChromeDriver driver = new ChromeDriver();

        [Given(@"enter order page")]
        public void GivenEnterOrderPage()
        {
            driver.Navigate().GoToUrl("http://localhost:50621/");
        }
        
        [Given(@"enter the meal ""(.*)""")]
        public void GivenEnterTheMeal(string meal)
        {
            driver.FindElementById("meal").SendKeys(meal);
        }
        
        [When(@"press order")]
        public void WhenPressOrder()
        {
            driver.FindElementById("order").Click();
        }
        
        [Then(@"the result should ""(.*)"" in the ordered list")]
        public void ThenTheResultShouldInTheOrderedList(string expectedMeal)
        {
            Assert.AreEqual(expectedMeal, driver.FindElementById("ordered").Text);
        }

        [Then(@"can see the menu image")]
        public void ThenCanSeeTheMenuImage()
        {
            Assert.AreEqual("img", driver.FindElementById("menu").TagName);
            Assert.IsNotNull(driver.FindElementById("menu").GetAttribute("src"));
        }

        [Then(@"can see the system logo")]
        public void ThenCanSeeTheSystemLogo()
        {
            Assert.IsTrue(driver.FindElementById("logo").Displayed);
        }


        [AfterFeature]
        public static void TearDown()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
