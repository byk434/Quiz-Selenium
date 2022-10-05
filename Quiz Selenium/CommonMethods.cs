using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Quiz_Selenium
{
    public class CommonMethods
    {
        public static IWebDriver driver;


        public static IWebDriver BrowserImplemented(string browser)

        {

            if (browser == "chrome")
            {
                ChromeOptions chromeOption = new ChromeOptions();
                chromeOption.AddArguments("start-maximized");
                chromeOption.AddArguments("incognito");
                chromeOption.AddArguments("disable-popup-blocking");
                //chromeOption.AddArguments("headless");
                driver = new ChromeDriver(chromeOption);


                //driver = new ChromeDriver(chromeOption);
            }
            else if (browser == "edge")
            {
                EdgeOptions edgeOption = new EdgeOptions();
                edgeOption.AddArguments("start-maximized");
                edgeOption.AddArguments("-inprivate");
                edgeOption.AddArguments("disable-popup-blocking");
                //edgeOption.AddArguments("headless");
                driver = new EdgeDriver(edgeOption);
            }
            else if (browser == "firefox")
            {
                FirefoxOptions firefoxOption = new FirefoxOptions();
                firefoxOption.AddArguments("start-maximized");
                firefoxOption.AddArguments("newprivate");
                //firefoxOption.AddArguments("disable-popup-blocking");
                driver = new FirefoxDriver(firefoxOption);
            }
            return driver;
        }
        public void Write(By by, string value)
        {
            driver.FindElement(by).SendKeys(value);
        }
        public static void Click(By by)
        {
            driver.FindElement(by).Click();
        }
        public static void OpenUrl(string url)
        {
            driver.Url = url;
        }
        public static void Hover(By by)

        {
            Actions actions = new Actions(driver);

            actions.MoveToElement(driver.FindElement(by)).Perform();
        }
        public static void HoverClick(By by)

        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(driver.FindElement(by)).Click().Perform();

        }
        public static void Maximize()
        {
            driver.Manage().Window.Maximize();
        }
        public static void ImplicitWait(int value)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(value);
        }
        public IWebElement ExplicitWait(By by, int value)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(value));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by));
        }
        public void Wait(int milliSecs)
        {
            Thread.Sleep(milliSecs);
        }
        public static void ScrollToElement(By by)
        {
            var scrollToElement = driver.FindElement(by);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", scrollToElement);
        }
        public void WindowHandle(int value)
        {
            driver.SwitchTo().Window(driver.WindowHandles[value]);
        }
        public void closeBrowser()
        {
            driver.Close();
        }
        public bool IsPageReady(IWebDriver driver)
        {
            return ((IJavaScriptExecutor)driver)
             .ExecuteScript("return document.readyState")
             .Equals("complete");
        }
        public string getText(By by)
        {

            IWebElement element = driver.FindElement(by);
            string str = element.GetAttribute("innerHTML");
            return str;
        }
        public void ReFreshPage()
        {
            driver.Navigate().Refresh();
        }
        public void Asserting(By by)
        {

            IWebElement element = driver.FindElement(by);
            bool status = element.Displayed;
            Assert.AreEqual(status, true);
        }
    }
}
