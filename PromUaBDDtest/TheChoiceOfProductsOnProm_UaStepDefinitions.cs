using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using PromUaBDDtest.FeatureFiles;
using Xunit;


namespace PromUaBDDtest
{
    [Binding]
    public class TheChoiceOfProductsOnProm_UaStepDefinitions
    {
        [Given(@"open a browser window and maximize")]
        public void GivenOpenABrowserWindowAndMaximize()
        {
            HotDriver.driver = new ChromeDriver();
            HotDriver.driver.Manage().Window.Maximize();

        }

        [When(@"the shopper is on the product page")]
        public void WhenTheShopperIsOnTheProductPage()
        {
            HotDriver.driver.Navigate().GoToUrl("https://prom.ua/p1566180056-acer-nitro-an515.html?&primelead=NA");
        }

        [When(@"the shopper clicks on All Description")]
        public void WhenTheShopperClicksOnAllDescription()
        {
            Thread.Sleep(3000);
            IWebElement element = (IWebElement)HotDriver.driver.FindElement(By.XPath("//div[2]/div[2]/div[2]/button"));
            element.Click();
        }

        [Then(@"the buyer should see the full characteristics of the product")]
        public void ThenTheBuyerShouldSeeTheFullCharacteristicsOfTheProduct()
        {
            Thread.Sleep(3000);
            IWebElement element = (IWebElement)HotDriver.driver.FindElement(By.CssSelector("tr:nth-child(16) span"));
            string actual = element.Text;
            Assert.Equal("Intel Core i5-10300H", actual);
            HotDriver.driver.Quit();
        }

        [When(@"customer is on the product info page")]
        public void WhenCustomerIsOnTheProductInfoPage()
        {
            HotDriver.driver.Navigate().GoToUrl("https://prom.ua/p1566180056-acer-nitro-an515.html?&primelead=NA");
        }

        [When(@"the customer clicks on the Seller UsaSklad button")]
        public void WhenTheCustomerClicksOnTheSellerUsaSkladButton()
        {
            Thread.Sleep(3000);
            IWebElement element1 = (IWebElement)HotDriver.driver.FindElement(By.CssSelector(".smSpd"));
            element1.Click();

        }

        [When(@"the customer clicks on the Contact  button")]
        public void WhenTheCustomerClicksOnTheContactButton()
        {
            Thread.Sleep(3000);
            IWebElement element1 = (IWebElement)HotDriver.driver.FindElement(By.CssSelector(".w2KJ2:nth-child(3) > .we0Q9"));
            element1.Click();

        }

        [Then(@"customer should then see the seller's phone number")]
        public void ThenCustomerShouldThenSeeTheSellersPhoneNumber()
        {
            Thread.Sleep(3000);
            IWebElement element = (IWebElement)HotDriver.driver.FindElement(By.CssSelector("#react-portal > div:nth-child(60) > div > div.F6DST.QFnqI > div > div.tC3ok.KJkv7 > div > ul > li:nth-child(5) > div > ul > li:nth-child(1) > div > div.kf2kF.BQjDj > ul > li:nth-child(1) > a"));
            string actual = element.Text;
            Assert.Equal("+380 (95) 166-37-99", actual);
            HotDriver.driver.Quit();

        }

        [When(@"the shopper is on the product information page")]
        public void WhenTheShopperIsOnTheProductInformationPage()
        {
            HotDriver.driver.Navigate().GoToUrl("https://prom.ua/p1566180056-acer-nitro-an515.html?&primelead=NA");
        }

        [When(@"the customer clicks on the Return Policy link")]
        public void WhenTheCustomerClicksOnTheReturnPolicyLink()
        {
            Thread.Sleep(3000);
            IWebElement element = (IWebElement)HotDriver.driver.FindElement(By.XPath("//div[4]/div[2]/div[3]/div/button"));
            element.Click();

        }

        [Then(@"customer should then see the possible return date")]
        public void ThenCustomerShouldThenSeeThePossibleReturnDate()
        {
            Thread.Sleep(3000);
            IWebElement element = (IWebElement)HotDriver.driver.FindElement(By.CssSelector(".kf2kF:nth-child(1) > .H__zz"));
            string actual = element.Text;
            Assert.Equal("14", actual);
            HotDriver.driver.Quit();

        }

        [When(@"shopper is on the product information page")]
        public void WhenShopperIsOnTheProductInformationPage()
        {
            HotDriver.driver.Navigate().GoToUrl("https://prom.ua/p1566180056-acer-nitro-an515.html?&primelead=NA");
        }

        [When(@"the customer clicks on the Acer link")]
        public void WhenTheCustomerClicksOnTheAcerLink()
        {
            Thread.Sleep(3000);
            IWebElement element1 = (IWebElement)HotDriver.driver.FindElement(By.CssSelector(".C5rQ2 > .uvIdx"));
            element1.Click();

        }

        [Then(@"customer should then see products from that manufacturer in different categories")]
        public void ThenCustomerShouldThenSeeProductsFromThatManufacturerInDifferentCategories()
        {
            Thread.Sleep(3000);
            IWebElement element = (IWebElement)HotDriver.driver.FindElement(By.CssSelector(".tg78x > .uvIdx"));
            string actual = element.Text;
            Assert.Equal("Acer", actual);
            HotDriver.driver.Quit();

        }
    }
}
