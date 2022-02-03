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
    public class UsingBiotusStepDefinitions
    {
        [Given(@"user opening a browser window and maximize")]
        public void GivenUserOpeningABrowserWindowAndMaximize()
        {
            //HotDriver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);(сайт не пускает с такой паузой)
            Thread.Sleep(40000);
            HotDriver.driver = new ChromeDriver();
            HotDriver.driver.Manage().Window.Maximize();

        }

        [Given(@"user in on the home page")]
        public void GivenUserInOnTheHomePage()
        {
            HotDriver.driver.Navigate().GoToUrl("https://biotus.ua/");
        }

        [When(@"customer clicks on the Vitamins link")]
        public void WhenCustomerClicksOnTheVitaminsLink()
        {
            Thread.Sleep(3000);
            IWebElement element = (IWebElement)HotDriver.driver.FindElement(By.XPath("//div[2]/ul/li[2]/a/span"));
            element.Click();

        }

        [When(@"customer clicks on the Vitamin C link\.")]
        public void WhenCustomerClicksOnTheVitaminCLink_()
        {
            Thread.Sleep(3000);
            IWebElement element = (IWebElement)HotDriver.driver.FindElement(By.XPath("//li[2]/div/a/span[2]"));
            element.Click();

        }

        [When(@"customer clicks on the Ester-C link")]
        public void WhenCustomerClicksOnTheEster_CLink()
        {
            Thread.Sleep(3000);
            IWebElement element = (IWebElement)HotDriver.driver.FindElement(By.XPath("//li[2]/div/a/span[2]"));
            element.Click();

        }

        [When(@"shopper clicks on the link Ester-C Plus Vitamin C")]
        public void WhenShopperClicksOnTheLinkEster_CPlusVitaminC()
        {
            Thread.Sleep(3000);
            IWebElement element = (IWebElement)HotDriver.driver.FindElement(By.CssSelector(".item:nth-child(1) .product-image-photo"));
            element.Click();

        }

        [Then(@"customer must see a info of the product")]
        public void ThenCustomerMustSeeAInfoOfTheProduct()
        {
            Thread.Sleep(3000);
            IWebElement element = (IWebElement)HotDriver.driver.FindElement(By.XPath("//div[2]/div/div[2]/div/div/div/span/span"));
            string actual = element.Text;
            Assert.Equal("19343", actual);
            HotDriver.driver.Quit();

        }

        [When(@"customer enters '([^']*)' in the search box")]
        public void WhenCustomerEntersInTheSearchBox(string p0)
        {
            Thread.Sleep(3000);
            IWebElement element = (IWebElement)HotDriver.driver.FindElement(By.CssSelector("#search"));
            element.Click();
            element.SendKeys(p0);
            element.SendKeys(Keys.Enter);

        }

        [When(@"customer clicks on the link Omega, Now Foods")]
        public void WhenCustomerClicksOnTheLinkOmegaNowFoods()
        {
            Thread.Sleep(3000);
            IWebElement element = (IWebElement)HotDriver.driver.FindElement(By.XPath("//img[@alt='Супер омега 3, Omega-3, Now Foods, 500 EPA/250 DHA, 90 капсул (Default)']"));
            element.Click();

        }

        [Then(@"customer should have a window with a description of that product")]
        public void ThenCustomerShouldHaveAWindowWithADescriptionOfThatProduct()
        {
            Thread.Sleep(3000);
            IWebElement element = (IWebElement)HotDriver.driver.FindElement(By.XPath("//div[2]/div/div[2]/div/div/div/span[2]/span"));
            string actual = element.Text;
            Assert.Equal("733739016614", actual);
            HotDriver.driver.Quit();

        }

        [When(@"customer clicks on the For Sports link")]
        public void WhenCustomerClicksOnTheForSportsLink()
        {
            Thread.Sleep(3000);
            IWebElement element = (IWebElement)HotDriver.driver.FindElement(By.XPath("//div[5]/div/ul/li[3]/a/span"));
            element.Click();

        }

        [When(@"shopper clicks on the Sports Amino Acids link")]
        public void WhenShopperClicksOnTheSportsAminoAcidsLink()
        {
            Thread.Sleep(3000);
            IWebElement element = (IWebElement)HotDriver.driver.FindElement(By.XPath("//li[4]/div/a/span[2]"));
            element.Click();

        }

        [When(@"shopper clicks on the Arginine link")]
        public void WhenShopperClicksOnTheArginineLink()
        {
            Thread.Sleep(3000);
            IWebElement element = (IWebElement)HotDriver.driver.FindElement(By.XPath("//img[@alt=' L-аргинин, Thorne Research, 120 кап. (Default)']"));
            element.Click();

        }

        [Then(@"customer must see a description of the product")]
        public void ThenCustomerMustSeeADescriptionOfTheProduct()
        {
            Thread.Sleep(3000);
            IWebElement element = (IWebElement)HotDriver.driver.FindElement(By.XPath("//div[2]/div/div[2]/div/div/div/span[2]/span"));
            string actual = element.Text;
            Assert.Equal("693749525028", actual);
            HotDriver.driver.Quit();

        }

        [When(@"shopper clicks on the Minerals link")]
        public void WhenShopperClicksOnTheMineralsLink()
        {
            Thread.Sleep(3000);
            IWebElement element = (IWebElement)HotDriver.driver.FindElement(By.XPath("//div[2]/ul/li[3]/a/span"));
            element.Click();

        }

        [When(@"shopper clicks on the Vitamins link with Selenium")]
        public void WhenShopperClicksOnTheVitaminsLinkWithSelenium()
        {
            Thread.Sleep(3000);
            IWebElement element = (IWebElement)HotDriver.driver.FindElement(By.XPath("//span[2]"));
            element.Click();

        }

        [When(@"buyer clicks on the Selenium for eye checkbox")]
        public void WhenBuyerClicksOnTheSeleniumForEyeCheckbox()
        {
            Thread.Sleep(3000);
            IWebElement element = (IWebElement)HotDriver.driver.FindElement(By.XPath("//form/ul/li[4]/a/span"));
            element.Click();

        }

        [When(@"buyer clicks on the Selenium, Puritan's Pride link")]
        public void WhenBuyerClicksOnTheSeleniumPuritansPrideLink()
        {
            Thread.Sleep(3000);
            IWebElement element = (IWebElement)HotDriver.driver.FindElement(By.XPath("//div[@id='amasty-shopby-product-list']/div[2]/div/div[2]/div[2]/a/span/span/img"));
            element.Click();

        }

        [Then(@"buyer should see a description of the product")]
        public void ThenBuyerShouldSeeADescriptionOfTheProduct()
        {
            Thread.Sleep(3000);
            IWebElement element = (IWebElement)HotDriver.driver.FindElement(By.XPath("//div[2]/div/div[2]/div/div/div/span/span"));
            string actual = element.Text;
            Assert.Equal("31998", actual);
            HotDriver.driver.Quit();

        }
    }
}
