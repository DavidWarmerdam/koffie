using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentAutomation;

namespace koffie.Pages
{
    public class HomePage : BasePage<HomePage>
    {
        private const string Logo = "#logo";
        private const string Phone = "#phone_service";
        private const string CartButton = "#shopping_cart_icon";
        private const string EmptyCart = "#no_item";
        private const string FilledCart = ".product_head";
        private const string SliderProductStock = ".slide_stock";
        private const string AddSliderProductToCart = ".images .action_green";
        private const string VerderWinkelenKnop = ".continue_shopping";
        
        


        public HomePage(FluentTest test) : base(test)
        {
            Url = "https://www.koffiewarenhuis.nl/";
           // At = () => I.Assert.Visible(Element1);
        }

        public void LogoPresence()
        {
            I.Assert.Visible(Logo);
            
        }

        public void PhoneNumberPresence()
        {
            I.Assert.Visible(Phone);
        }
        public void ClickCart()
        {
            I.Click(CartButton);
        }

        public void AssertEmptyCart()
        {
            I.Assert.Visible(EmptyCart);
        }

        public void AssertFilledCart()
        {
            I.Assert.Exists(FilledCart);
        }

        public void AssertSliderStock()
        {
            I.Assert.Visible(SliderProductStock);
        }

        public void AddSliderItemToCart()
        {
            I.Click(AddSliderProductToCart);
        }

        public void ClickVerderWinkelen()
        {
            I.Click(VerderWinkelenKnop);
        }


    }
}