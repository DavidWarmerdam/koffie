using System;
using koffie.Pages;
using TechTalk.SpecFlow;


namespace koffie.StepDefinitions
{
    [Binding]
    public class HomePageItemsSteps : BaseStepDefinition
    {
        [Given(@"I open the homepage")]
        public void GivenIOpenTheHomepage()
        {
            HomePage.Go();
        }
        
        [Given(@"I have added the slider item to the cart")]
        public void GivenIHaveAddedTheSliderItemToTheCart()
        {
            HomePage.AddSliderItemToCart();
        }
        
        [When(@"I click on the cart icon")]
        public void WhenIClickOnTheCartIcon()
        {
            HomePage.ClickCart();
        }
        
        [Then(@"the koffiewarenhuislogo is present")]
        public void ThenTheKoffiewarenhuislogoIsPresent()
        {
            HomePage.LogoPresence();
        }
        
        [Then(@"the phone number of customer service is present")]
        public void ThenThePhoneNumberOfCustomerServiceIsPresent()
        {
            HomePage.PhoneNumberPresence();
        }
        
        [Then(@"I see the cart notification no items")]
        public void ThenISeeTheCartNotificationNoItems()
        {
            HomePage.AssertEmptyCart();
        }
        
        [Then(@"the slider product does contain stock")]
        public void ThenTheSliderProductDoesContainStock()
        {
            HomePage.AssertSliderStock();
        }
        
        [Then(@"the cart presents the added item")]
        public void ThenTheCartPresentsTheAddedItem()
        {
            HomePage.AssertFilledCart();
        }
    }
}
