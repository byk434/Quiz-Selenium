using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Quiz_Selenium
{
    internal class AddProductsToCart : CommonMethods
    {
        By product1 = By.XPath("//a[@data-product-id='1']");
        By product2 = By.XPath("//a[@data-product-id='2']");
        By product4 = By.XPath("//a[@data-product-id='4']");
        By continueShoppingButton = By.XPath("//button[text()='Continue Shopping']");
        By cartButton = By.XPath("//u[text()='View Cart']");
        public void productsToCart()
        {
            ScrollToElement(product4);
            Click(product1);
            ExplicitWait(continueShoppingButton, 5);
            Click(continueShoppingButton);
            Click(product2);
            ExplicitWait(continueShoppingButton, 5);
            Click(continueShoppingButton);
            Hover(cartButton);

        }
    }
}
