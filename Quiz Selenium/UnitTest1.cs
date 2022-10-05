using System;
using System.ComponentModel.Design;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Quiz_Selenium
{
    [TestClass]
    public class UnitTest1 : CommonMethods
    {
        [TestMethod]
        public void UserRegistrationWithValidData()
        {

            CommonMethods.BrowserImplemented("edge");
            CommonMethods.OpenUrl("https://www.automationexercise.com/");
            CommonMethods obj = new CommonMethods();
            obj.IsPageReady(driver);
            SignUpUser userRegistration = new SignUpUser();
            userRegistration.RegisterUser("Babar Khan", "2iwewe456455@outlook.com", "Babar12345", "Babar", "Khan", "Contour Software", "Gulberg", "Lahore", "New York", "New York", "54000", "+923054047320");
            userRegistration.continueB();
        }
        [TestMethod]
        public void LogUserInWithValidData()
        {
            CommonMethods.BrowserImplemented("edge");
            CommonMethods.OpenUrl("https://www.automationexercise.com/");
            CommonMethods obj = new CommonMethods();
            obj.IsPageReady(driver);
            SignInUser signUserIn = new SignInUser();
            signUserIn.userLogIn("byk.isr@gmail.com", "Babar12345");
        }
        [TestMethod]
        public void LogUserOut()
        {
            
            CommonMethods.BrowserImplemented("edge");
            CommonMethods.OpenUrl("https://www.automationexercise.com/");
            CommonMethods obj = new CommonMethods();
            obj.IsPageReady(driver);
            LogOutUser signUserOut = new LogOutUser();
            signUserOut.userLogOut("byk.isr@gmail.com", "Babar12345");
            signUserOut.logoutP();
            
        }
        [TestMethod]
        public void SearchFunctionality()
        {
            By assertText1 = By.XPath("//h2[@class='title text-center']");
            By searchedProducts = By.XPath("class='title text-center'");
            CommonMethods.BrowserImplemented("edge");
            CommonMethods.OpenUrl("https://www.automationexercise.com/");
            CommonMethods obj = new CommonMethods();
            obj.IsPageReady(driver);
            SearchClass productSearch = new SearchClass();
            productSearch.productButtton();
            string expectedText = "ALL PRODUCTS";
            string actualText = productSearch.getText(assertText1);
            Assert.AreEqual(expectedText, actualText);
            productSearch.searchingInput();
            string expectedSearchText = "SEARCHED PRODUCTS";
            string actualsearchText = productSearch.getText(searchedProducts);
            Assert.AreEqual(expectedSearchText, actualsearchText);
            productSearch.clickingSearchIcon();
        }
        [TestMethod]
        public void DownloadInvoice()
        {
            CommonMethods.BrowserImplemented("edge");
            CommonMethods.OpenUrl("https://www.automationexercise.com/");
            CommonMethods obj = new CommonMethods();
            obj.IsPageReady(driver);
            InvoiceAfterPurchaseOrder invoiceDownload = new InvoiceAfterPurchaseOrder();
            invoiceDownload.productsToCart();
            SignUpUser userSignUp = new SignUpUser();
            userSignUp.RegisterUser("Babar Khan", "255g54562211212112455@outlook.com", "Babar12345", "Babar", "Khan", "Contour Software", "Gulberg", "Lahore", "New York", "New York", "54000", "+923054047320");
            invoiceDownload.cartPage("I like buying stuff", "bobor", "4545454", "332", "10", "2024");
        }
        [TestMethod]
        public void AddToCart()
        {
            CommonMethods.BrowserImplemented("edge");
            CommonMethods.OpenUrl("https://www.automationexercise.com/");
            CommonMethods obj = new CommonMethods();
            obj.IsPageReady(driver);
            AddProductsToCart productsAddedToCart = new AddProductsToCart();
            productsAddedToCart.productsToCart();
        }
        [TestMethod]
        public void PlaceOrderAndRegisterWhileCheckout()
        {
            By congoMsg = By.XPath("//p[text()='Congratulations! Your order has been confirmed!']");
            CommonMethods.BrowserImplemented("edge");
            CommonMethods.OpenUrl("https://www.automationexercise.com/");
            CommonMethods obj = new CommonMethods();
            obj.IsPageReady(driver);
            PlaceOrderRegisterwhileCheckout PlacingOrderAndRegistering = new PlaceOrderRegisterwhileCheckout();
            PlacingOrderAndRegistering.placingOrderNow();
            SignUpUser userSign = new SignUpUser();
            userSign.RegisterUser("Babar Khan", "255gtyuytuiywuiyui12112455@outlook.com", "Babar12345", "Babar", "Khan", "Contour Software", "Gulberg", "Lahore", "New York", "New York", "54000", "+923054047320");
            PlacingOrderAndRegistering.cartPage("I like buying stuff", "bobor", "4545454", "332", "10", "2024");
            string expectedMsg = "Congratulations! Your order has been confirmed!";
            string actualMsg = PlacingOrderAndRegistering.getText(congoMsg);
            Assert.AreEqual(expectedMsg, actualMsg);
        }
        [TestMethod]
        public void ViewProductDetails()
        {
            By productName = By.XPath("//h2[text()='Blue Top']");
            By productCategory = By.XPath("//p[text()='Category: Women > Tops']");
            CommonMethods.BrowserImplemented("edge");
            CommonMethods.OpenUrl("https://www.automationexercise.com/");
            CommonMethods obj = new CommonMethods();
            obj.IsPageReady(driver);
            VerifyAllProducts detailsOfProducts = new VerifyAllProducts();
            detailsOfProducts.productDetails();
            string expectedName = "Blue Top";
            string actualName = detailsOfProducts.getText(productName);
            Assert.AreEqual(expectedName, actualName);
        }
    }
}
