using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentAutomation;
using koffie.Pages;
using TechTalk.SpecFlow;




namespace koffie.StepDefinitions
{
    [Binding]
    public class BaseStepDefinition : FluentTest
    {
        public BaseStepDefinition()
        {
            HomePage = new HomePage(this);

            ConfigureWbTstr();
        }

        public HomePage HomePage { get; private set; }

        private void ConfigureWbTstr()
        {
            WbTstr.Configure()
                  .UseWebDriver(SeleniumWebDriver.Browser.PhantomJs)
                  .BootstrapInstance();
        }
    }
}
