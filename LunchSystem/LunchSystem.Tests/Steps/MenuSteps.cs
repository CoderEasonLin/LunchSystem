using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace LunchSystem.Tests.Steps
{
    [Binding]
    public class MenuSteps
    {
        private static ChromeDriver _driver = new ChromeDriver();

        private string _name = String.Empty;
        private string _meal = String.Empty;
        private int _price = 0;

        [Given(@"enter order page")]
        public void GivenEnterOrderPage()
        {
            _driver.Navigate().GoToUrl("http://localhost:50621/");
        }

        [Given(@"enter the order ""(.*)"", ""(.*)"", ""(.*)""")]
        public void GivenEnterTheOrder(string name, string meal, int price)
        {
            _meal = meal;
            _driver.FindElementById("meal").SendKeys(meal);

            _name = name;
            _driver.FindElementById("name").SendKeys(name);

            _price = price;
            _driver.FindElementById("price").SendKeys(price.ToString());
        }

        [When(@"press order")]
        public void WhenPressOrder()
        {
            _driver.FindElementById("order").Click();
        }

        [Then(@"the order should show in the ordered list")]
        public void ThenTheOrderShouldShowInTheOrderedList()
        {
            Assert.AreEqual(_name, _driver.FindElementById("whoOrder").Text);
            Assert.AreEqual(_meal, _driver.FindElementById("whatOrder").Text);
            Assert.AreEqual(_price, Convert.ToInt32(_driver.FindElementById("howMuchOrder").Text));
        }


        [Then(@"can see the menu image")]
        public void ThenCanSeeTheMenuImage()
        {
            Assert.AreEqual("img", _driver.FindElementById("menu").TagName);
            Assert.IsNotNull(_driver.FindElementById("menu").GetAttribute("src"));
        }


        [Then(@"can see the system logo")]
        public void ThenCanSeeTheSystemLogo()
        {
            Assert.IsTrue(_driver.FindElementById("logo").Displayed);
        }

        [AfterFeature]
        public static void TearDown()
        {
            _driver.Close();
            _driver.Quit();
        }
    }
}
