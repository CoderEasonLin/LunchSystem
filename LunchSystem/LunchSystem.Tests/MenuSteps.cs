using System;
using TechTalk.SpecFlow;

namespace LunchSystem.Tests
{
    [Binding]
    public class MenuSteps
    {
        [Given(@"enter order page")]
        public void GivenEnterOrderPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"enter the meal ""(.*)""")]
        public void GivenEnterTheMeal(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"press order")]
        public void WhenPressOrder()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should ""(.*)"" in the ordered list")]
        public void ThenTheResultShouldInTheOrderedList(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
