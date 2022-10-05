using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Quiz_Selenium
{
    public class InvoiceAfterPurchaseOrder:CommonMethods
    {
        By product1 = By.XPath("//a[@data-product-id='1']");
        By product2 = By.XPath("//a[@data-product-id='2']");
        By product3 = By.XPath("//a[@data-product-id='3']");
        By product4 = By.XPath("//a[@data-product-id='4']");
        By continueShoppingButton = By.XPath("//button[text()='Continue Shopping']"); //button[text()='Continue Shopping']
        By cartButton = By.XPath("(//i[@class='fa fa-shopping-cart'])[1]");
        By checkOutButton = By.XPath("//a[text()='Proceed To Checkout']");
        By loginAsUserButton = By.XPath("//u[text()='Register / Login']");
        By fillForm = By.XPath("//textarea[@class='form-control']");
        By placingOrder = By.XPath("//a[text()='Place Order']");
        By nameOnCard = By.XPath("//input[@name='name_on_card']");
        By cardNum = By.XPath("//input[@name='card_number']");
        By cvcNum = By.XPath("//input[@name='cvc']");
        By expiryMonth = By.XPath("//input[@name='expiry_month']");
        By expiryYear = By.XPath("//input[@name='expiry_year']");
        By payButton = By.XPath("//button[@data-qa='pay-button']");
        By downLoadInvoce = By.XPath("//a[text()='Download Invoice']");
        By continueButton = By.XPath("//a[@data-qa='continue-button']");


        public void productsToCart()
        {
            ScrollToElement(product4);
            Click(product1);
            ExplicitWait(continueShoppingButton, 5);
            Click(continueShoppingButton);
            Click(product2);
            ExplicitWait(continueShoppingButton, 5);
            Click(continueShoppingButton);
            Click(product3);
            ExplicitWait(continueShoppingButton, 5);
            Click(continueShoppingButton);
            Click(product4);
            ExplicitWait(continueShoppingButton, 5);
            Click(continueShoppingButton);
            ScrollToElement(cartButton);
            Click(cartButton);
            Click(checkOutButton);
            Click(loginAsUserButton);
           
        }
        public void cartPage(string formFill, string cardName, string numberOfCard, string cvcN, string monthEx, string yearEx)
        {
            Click(cartButton);
            Click(checkOutButton);
            ScrollToElement(fillForm);
            Write(fillForm, formFill);
            Click(placingOrder);
            Write(nameOnCard, cardName);
            Write(cardNum, numberOfCard);
            Write(cvcNum, cvcN);
            Write(expiryMonth, monthEx);
            Write(expiryYear, yearEx);
            Click(payButton);
            Click(downLoadInvoce);
            Wait(30000);
            Click(continueButton);
        }

    }
}
